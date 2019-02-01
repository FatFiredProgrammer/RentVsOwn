using System;
using System.Collections.Generic;
using System.Text;

namespace RentVsOwn
{
    public sealed class Landlord : IPerson
    {
        /// <summary>
        /// A class to help with monthly calculations.
        /// </summary>
        private sealed class Monthly
        {
            public decimal Rent { get; set; }

            public decimal Expenses { get; set; }

            public decimal Principal { get; set; }

            public decimal NetIncome { get; set; }

            public decimal Interest { get; set; }

            /// <summary>
            ///     This represents a personal loan we either had to take out this
            ///     month to make cash flow or an amount we paid back to against a previous personal loan
            /// </summary>
            public decimal PersonalLoan { get; set; }
        }

        /// <inheritdoc />
        public string Name => nameof(Landlord);

        /// <inheritdoc />
        public decimal NetWorth { get; private set; }

        private decimal _initialInvestment;

        private decimal _cash;

        private decimal _totalRent;

        private decimal _averageRent;

        private decimal _totalExpenses;

        private decimal _averageExpenses;

        private decimal _carryOverDepreciation;

        private decimal _totalUsedDepreciation;

        /// <summary>
        ///     This represents a personal loan we either had to take out this
        ///     month to make cash flow or an amount we paid back to against a previous personal loan
        /// </summary>
        private decimal _personalLoan;

        /// <summary>
        /// </summary>
        private decimal _currentYearTaxableIncome;

        private decimal? _npv;

        private List<decimal> _cashFlows = new List<decimal>();

        private void CalculateExpenses(Monthly monthly, Simulation simulation, IOutput output)
        {
            var expenses = 0m;
            var managementFee = simulation.Rent * simulation.LandlordManagementFeePercentage;
            output.WriteLine($"Management fee of {managementFee:C0}");
            expenses += managementFee;

            var loanPayment = simulation.LandlordMonthlyPayment;
            var interest = (simulation.LandlordLoanBalance * simulation.LandlordInterestRate / 12).ToDollars();
            monthly.Principal = (loanPayment - interest).ToDollars();
            output.WriteLine($"Loan payment of {loanPayment:C0} ({monthly.Principal:C0} principal / {interest:C0} interest)");
            expenses += monthly.Interest;

            simulation.LandlordLoanBalance -= monthly.Principal;
            output.WriteLine($"New loan balance of {simulation.LandlordLoanBalance:C0}");

            var propertyTax = (simulation.LandlordHomeValue * simulation.PropertyTaxPercentage / 12).ToDollars();
            expenses += propertyTax;
            output.WriteLine($"Spent {propertyTax:C0} on property tax");
            if (simulation.InsurancePerMonth > 0)
            {
                expenses += simulation.InsurancePerMonth;
                output.WriteLine($"Spent {simulation.InsurancePerMonth:C0} on insurance");
            }

            if (simulation.HoaPerMonth > 0)
            {
                expenses += simulation.HoaPerMonth;
                output.WriteLine($"Spent {simulation.HoaPerMonth:C0} on HOA");
            }

            var homeMaintenance = (simulation.LandlordHomeValue * simulation.HomeMaintenancePercentagePerYear / 12).ToDollars();
            expenses += homeMaintenance;
            output.WriteLine($"Spent {homeMaintenance:C0} on home maintenance");

            // We pay the previous years taxes at the start of each new year.
            if (simulation.IsNewYear)
            {
                var taxes = (_currentYearTaxableIncome * simulation.MarginalTaxRate).ToDollarCents();
                if (taxes > 0)
                {
                    output.WriteLine($"Paid last year's taxes of {taxes:C0}");
                    expenses += taxes;
                }

                _currentYearTaxableIncome = 0;
            }

            output.WriteLine($"Total monthly expenses of {expenses:C0}");
            _totalExpenses += expenses;
        }

        private void CalculateTaxableIncome(Monthly monthly, Simulation simulation, IOutput output)
        {
            // My net income includes amount I have paid in principle.
            output.WriteLine($"Net income of {monthly.NetIncome:C0}");

            // We now have a net income for the month.
            // Let's see what we can do about using depreciation
            var depreciation = (simulation.HomeValue * simulation.DepreciablePercentage / (simulation.DepreciationYears * 12)).ToDollarCents();
            output.WriteLine($"Allowed monthly depreciation of {depreciation:C0} + carry-over of {_carryOverDepreciation:C0}");
            var allowableDepreciation = depreciation + _carryOverDepreciation;
            if (monthly.NetIncome > 0)
            {
                var usedDepreciation = Math.Min(monthly.NetIncome, _carryOverDepreciation).ToDollarCents();
                var taxableIncome = monthly.NetIncome - usedDepreciation;
                _currentYearTaxableIncome += taxableIncome;
                output.WriteLine($"Taxable income of {taxableIncome:C0} ({_currentYearTaxableIncome:C0} YTD)");
                allowableDepreciation -= usedDepreciation;
                _totalUsedDepreciation += usedDepreciation;
            }

            _carryOverDepreciation = Math.Max(0m, allowableDepreciation).ToDollarCents();
            output.WriteLine($"{_carryOverDepreciation:C0} of depreciation carried over");
        }

        private void CloseOutPersonalLoan(ref decimal proceeds, Simulation simulation, IOutput output)
        {
            if (_personalLoan != 0)
            {
                output.WriteLine($"Closed out personal loan of {_personalLoan:C0}");
                proceeds -= _personalLoan;
                _personalLoan = 0;
            }
        }

        private void DisposeOfTheProfits(Monthly monthly, Simulation simulation, IOutput output)
        {
            // My net income includes amount I have paid in principle.
            // If we have any income left, use it to pay down the mortgage balance.
            if (monthly.NetIncome > 0)
            {
                if (simulation.LandlordLoanBalance > 0)
                {
                    var additionalPrincipal = Math.Min(simulation.LandlordLoanBalance, monthly.NetIncome);
                    simulation.LandlordLoanBalance -= additionalPrincipal;
                    output.WriteLine($"Paid additional principal of {additionalPrincipal:C0} leaving balance of {simulation.LandlordLoanBalance:C0}");
                    monthly.NetIncome -= additionalPrincipal;
                }
            }

            // Anything left, just subtract from personal loan.
            if (monthly.NetIncome > 0)
            {
                _personalLoan -= monthly.NetIncome;
                output.WriteLine($"Added net income of {monthly.NetIncome:C0} to personal leaving balance of {_personalLoan:C0}");
            }
        }

        private void Finalize(Simulation simulation, IOutput output)
        {
            var proceeds = 0m;
            SellHome(ref proceeds, simulation, output);
            PayTaxesOnHomeSale(ref proceeds, simulation, output);
            PayRemainingIncomeTax(ref proceeds, simulation, output);
            CloseOutPersonalLoan(ref proceeds, simulation, output);
            output.WriteLine($"Net home sale proceeds of {proceeds:C0}");

            // Put proceeds into cash account
            _cash += proceeds;
            _cash = _cash.ToDollars();
            output.WriteLine($"Total cash on hand of {_cash:C0}");

            // Add in this very last cash flow
            _cashFlows[_cashFlows.Count - 1] += proceeds;
            _npv = Npv.Calculate(_initialInvestment, _cashFlows, simulation.DiscountRate);
            output.WriteLine($"Net present value of {_npv:C0}");
        }

        private void Initialize(Simulation simulation, IOutput output)
        {
            _initialInvestment = 0;
            _cash = 0;
            _totalRent = 0;
            _averageRent = 0;
            _totalExpenses = 0;
            _averageExpenses = 0;
            _carryOverDepreciation = 0;
            _totalUsedDepreciation = 0;
            _personalLoan = 0;
            _currentYearTaxableIncome = 0;
            _cashFlows = new List<decimal>();
            _npv = null;

            output.WriteLine($"Down payment of {simulation.LandlordDownPayment:C0}");
            _initialInvestment += simulation.LandlordDownPayment;
            output.WriteLine($"Fixed closing costs of {simulation.ClosingFixedCosts:C0}");
            _initialInvestment += simulation.ClosingFixedCosts;
            var variableClosingCosts = simulation.LandlordLoanAmount * simulation.ClosingVariableCostsPercentage;
            output.WriteLine($"Variable closing costs of {variableClosingCosts:C0}");
            _initialInvestment += variableClosingCosts;
            output.WriteLine($"Total initial investment of {_initialInvestment:C0}");
            output.WriteLine($"Initial loan balance of {simulation.LandlordLoanBalance:C0}");
        }

        private Monthly InitializeMonthly(Simulation simulation, IOutput output)
        {
            output.WriteLine($"Received rent of {simulation.Rent:C0}");

            var loanPayment = simulation.LandlordMonthlyPayment;
            var interest = (simulation.LandlordLoanBalance * simulation.LandlordInterestRate / 12).ToDollars();
            var principal = (loanPayment - interest).ToDollars();
            output.WriteLine($"Loan payment of {loanPayment:C0} ({principal:C0} principal / {interest:C0} interest)");

            // Assume we will always pay principal
            simulation.LandlordLoanBalance -= principal;
            output.WriteLine($"New loan balance of {simulation.LandlordLoanBalance:C0}");

            // Set up our monthly ledger
            var monthly = new Monthly
            {
                Rent = simulation.Rent,
                Interest = interest,
                Principal = principal,
                Expenses = interest,
                NetIncome = simulation.Rent - interest,
            };
            _totalRent += monthly.Rent;
            return monthly;
        }

        private void PayRemainingIncomeTax(ref decimal proceeds, Simulation simulation, IOutput output)
        {
            var taxes = (_currentYearTaxableIncome * simulation.MarginalTaxRate).ToDollarCents();
            if (taxes > 0)
            {
                output.WriteLine($"Paid remaining yearly taxes of {taxes:C0}");
                proceeds -= taxes;
                _totalExpenses += taxes;
                _currentYearTaxableIncome = 0;
            }
        }

        private void PayTaxesOnHomeSale(ref decimal proceeds, Simulation simulation, IOutput output)
        {
            var capitalGains = proceeds;
            if (capitalGains > 0)
            {
                if (_totalUsedDepreciation > 0)
                {
                    var reclaimedDepreciation = Math.Min(capitalGains, _totalUsedDepreciation).ToDollarCents();
                    var reclaimedDepreciationTaxes = (reclaimedDepreciation * simulation.MarginalTaxRate).ToDollarCents();
                    if (reclaimedDepreciationTaxes > 0)
                    {
                        output.WriteLine($"Paid depreciation recapture taxes of {reclaimedDepreciationTaxes:C0}");
                        proceeds -= reclaimedDepreciationTaxes;
                        capitalGains -= reclaimedDepreciation;
                        _totalExpenses += reclaimedDepreciationTaxes;
                    }
                }

                if (capitalGains > 0)
                {
                    var capitalGainsTaxes = (capitalGains * simulation.CapitalGainsRate).ToDollarCents();
                    output.WriteLine($"Paid capital gains taxes of {capitalGainsTaxes:C0}");
                    proceeds -= capitalGainsTaxes;
                    _totalExpenses += capitalGainsTaxes;
                }
            }
        }

        private void PayTheBills(Monthly monthly, Simulation simulation, IOutput output)
        {
            // We must pay our expenses and the principal on the loan
            var cashNeeded = monthly.Expenses + monthly.Principal;

            // Deal with a personal loan if we need one.
            if (monthly.Rent < monthly.Expenses + monthly.Principal)
            {
                var personalLoanAmount = Math.Abs((monthly.Expenses + monthly.Principal) - monthly.Rent);
                _personalLoan += personalLoanAmount;
                output.WriteLine($"Required personal loan of {personalLoanAmount:C0} creating a balance of {_personalLoan:C0}");
            }

            // Our net income is our rent my our expenses.
            // Note that the net income includes our principal payment
            // ?return rent - monthly.Expenses;
        }

        private void Process(Simulation simulation, IOutput output)
        {
            Monthly monthly = InitializeMonthly(simulation, output);
            CalculateExpenses(monthly, simulation, output);
            PayTheBills(monthly, simulation, output);
            RepayPersonalLoan(monthly, simulation, output);
            CalculateTaxableIncome(monthly, simulation, output);
            DisposeOfTheProfits(monthly, simulation, output);
            RecordCashFlow(monthly, simulation, output);
        }

        private void RecordCashFlow(Monthly monthly, Simulation simulation, IOutput output)
        {
            // At the end of the year, we have to pay taxes.

            // Cash flow used for NPV
            var cashFlow = monthly.NetIncome + monthly.PersonalLoan;

            _cashFlows.Add(cashFlow);

            // PersonalLoan
        }

        private void RepayPersonalLoan(Monthly monthly, Simulation simulation, IOutput output)
        {
            if (monthly.NetIncome > 0 && _personalLoan > 0)
            {
                var personalLoanPayment = Math.Min(_personalLoan, monthly.NetIncome);
                _personalLoan -= personalLoanPayment;
                output.WriteLine($"Paid back {personalLoanPayment:C0} of personal loan leaving a balance of {_personalLoan:C0}");
                monthly.NetIncome -= personalLoanPayment;
            }
        }

        private void SellHome(ref decimal proceeds, Simulation simulation, IOutput output)
        {
            var homeValue = simulation.LandlordHomeValue;
            output.WriteLine($"Sold home for {homeValue:C0}");
            var salesFixedCosts = simulation.SalesFixedCosts;
            var salesCommission = simulation.SalesCommissionPercentage * homeValue;
            output.WriteLine($"Fixed sales costs of {salesFixedCosts:C0} and commission of {salesCommission:C0}");
            proceeds = homeValue - (salesFixedCosts + salesCommission);
            _totalExpenses += salesFixedCosts + salesCommission;
            output.WriteLine($"Paid of loan balance of {simulation.LandlordLoanBalance:C0}");
            proceeds -= simulation.LandlordLoanBalance;
            simulation.LandlordLoanBalance = 0;
            simulation.LandlordHomeValue = 0;
        }

        /// <inheritdoc />
        public void Simulate(Simulation simulation, IOutput output)
        {
            if (simulation == null)
                throw new ArgumentNullException(nameof(simulation));
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            output.WriteLine($"{Name} in month # {simulation.Month}");

            if (simulation.IsInitial)
                Initialize(simulation, output);
            Process(simulation, output);
            if (simulation.IsFinal)
                Finalize(simulation, output);
            _averageRent = (_totalRent / simulation.Months).ToDollars();
            _averageExpenses = (_totalExpenses / simulation.Months).ToDollars();
            NetWorth = _cash + simulation.LandlordHomeValue - simulation.LandlordLoanBalance;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(
                $"{Name} has total rent of {_totalRent:C0} (average of {_averageRent:C0} / month), total expenses of {_totalExpenses:C0} (average of {_averageExpenses:C0} / month), and has a net worth of {NetWorth:C0} on an initial investment of {_initialInvestment:C0}");
            if (_npv.HasValue)
            {
                text.AppendLine(
                    $"Net present value of {_npv:C0}");
            }

            return text.ToString().TrimEnd();
        }
    }
}
