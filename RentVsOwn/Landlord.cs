using System;
using System.Collections.Generic;
using System.Text;

namespace RentVsOwn
{
    public sealed class Landlord : IPerson
    {
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

        private decimal _personalLoan;

        private decimal _yearTaxableIncome;
        private decimal _npv;

        private List<decimal> _cashFlows = new List<decimal>();

        private void Finalize(Simulation simulation, IOutput output)
        {
            var homeValue = simulation.LandlordHomeValue;
            output.WriteLine($"Sold home for {homeValue:C0}");
            var salesFixedCosts = simulation.SalesFixedCosts;
            var salesCommission = simulation.SalesCommissionPercentage * homeValue;
            output.WriteLine($"Fixed sales costs of {salesFixedCosts:C0} and commission of {salesCommission:C0}");
            var proceeds = homeValue - (salesFixedCosts + salesCommission);
            _totalExpenses += salesFixedCosts + salesCommission;
            output.WriteLine($"Paid of loan balance of {simulation.LandlordLoanBalance:C0}");
            proceeds -= simulation.LandlordLoanBalance;
            simulation.LandlordLoanBalance = 0;
            simulation.LandlordHomeValue = 0;

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

            // Pay any remaining taxes.
            var taxes = (_yearTaxableIncome * simulation.MarginalTaxRate).ToDollarCents();
            if (taxes > 0)
            {
                output.WriteLine($"Paid remaining yearly taxes of {taxes:C0}");
                proceeds -= taxes;
                _totalExpenses += taxes;
                _yearTaxableIncome = 0;
            }

            // Repay or reclaim any personal loan
            if (_personalLoan != 0)
            {
                output.WriteLine($"Repaid personal loan of {_personalLoan:C0}");
                proceeds -= _personalLoan;
                _personalLoan = 0;
            }

            // Put proceeds into cash account
            output.WriteLine($"Net home sale proceeds of {proceeds:C0}");
            _cash += proceeds;
            _cash = _cash.ToDollars();

            // Add in this very last cash flow
            _cashFlows[_cashFlows.Count - 1] += proceeds;
            _npv = Npv.Calculate(_initialInvestment, _cashFlows, simulation.DiscountRate);
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
            _yearTaxableIncome = 0;
            _cashFlows = new List<decimal>();
            _npv = 0;

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

        private void Process(Simulation simulation, IOutput output)
        {
            var rent = simulation.Rent;
            _totalRent += rent;
            output.WriteLine($"Received rent of {rent:C0}");

            var expenses = 0m;
            var managementFee = rent * simulation.LandlordManagementFeePercentage;
            output.WriteLine($"Management fee of {managementFee:C0}");
            expenses += managementFee;

            var loanPayment = simulation.LandlordMonthlyPayment;
            var interest = (simulation.LandlordLoanBalance * simulation.LandlordInterestRate / 12).ToDollars();
            var principal = (loanPayment - interest).ToDollars();
            output.WriteLine($"Loan payment of {loanPayment:C0} ({principal:C0} principal / {interest:C0} interest)");
            expenses += interest;

            simulation.LandlordLoanBalance -= principal;
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
                var taxes = (_yearTaxableIncome * simulation.MarginalTaxRate).ToDollarCents();
                if (taxes > 0)
                {

                    output.WriteLine($"Paid last year's taxes of {taxes:C0}");
                    expenses += taxes;
                }

                _yearTaxableIncome = 0;
            }

            output.WriteLine($"Total monthly expenses of {expenses:C0}");
            _totalExpenses += expenses;
#if false
            // We must pay our expenses and 
            var cashNeeded = expenses + principal;

            // Deal with a personal loan if I have one.
            if (cashFlow > 0)
            {
                if (_personalLoan > 0)
                {
                    var personalLoanPayment = Math.Min(_personalLoan, netIncome);
                    _personalLoan -= personalLoanPayment;
                    output.WriteLine($"Paid back {personalLoanPayment:C0} of personal loan leaving a balance of {_personalLoan:C0}");
                    netIncome -= personalLoanPayment;
                }
            }

            if (netIncome < 0)
            {
                var personalLoanAmount = Math.Abs(netIncome);
                _personalLoan += personalLoanAmount;
                output.WriteLine($"Required personal loan of {personalLoanAmount:C0} creating a balance of {_personalLoan:C0}");
                netIncome = 0;
            }

            output.WriteLine($"Net income of {netIncome:C0}");
            // My net income includes amount I have paid in principle.
            var netIncome = rent - expenses;

            // We now have a net income for the month.
            // Let's see what we can do about using depreciation
            var depreciation = (simulation.HomeValue * simulation.DepreciablePercentage / (simulation.DepreciationYears * 12)).ToDollarCents();
            output.WriteLine($"Allowed monthly depreciation of {depreciation:C0} + carry-over of {_carryOverDepreciation:C0}");
            var allowableDepreciation = depreciation + _carryOverDepreciation;
            if (netIncome > 0)
            {
                var usedDepreciation = Math.Min(netIncome, _carryOverDepreciation).ToDollarCents();
                var taxableIncome = netIncome - usedDepreciation;
                _yearTaxableIncome += taxableIncome;
                output.WriteLine($"Taxable income of {taxableIncome:C0} ({_yearTaxableIncome:C0} YTD)");
                allowableDepreciation -= usedDepreciation;
                _totalUsedDepreciation += usedDepreciation;
            }

            _carryOverDepreciation = Math.Max(0m, allowableDepreciation).ToDollarCents();
            output.WriteLine($"{_carryOverDepreciation:C0} of depreciation carried over");

            // At the end of the year, we have to pay taxes.

            // If we have any income left, use it to pay down the mortgage balance.
            if (netIncome > 0)
            {
                if (simulation.LandlordLoanBalance > 0)
                {
                    var additionalPrincipal = Math.Min(simulation.LandlordLoanBalance, netIncome);
                    simulation.LandlordLoanBalance -= additionalPrincipal;
                    output.WriteLine($"Paid additional principal of {additionalPrincipal:C0} leaving balance of {simulation.LandlordLoanBalance:C0}");
                    netIncome -= additionalPrincipal;
                }
            }

            // Anything left, just subtract from personal loan.
            if (netIncome > 0)
            {
                _personalLoan -= netIncome;
                output.WriteLine($"Added net income of {netIncome:C0} to personal leaving balance of {_personalLoan:C0}");
            }
            // Cash flow used for NPV
            var cashFlow = rent - expenses - principal;

            _cashFlows.Add(cashFlow);
#endif
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
            text.AppendLine(
                $"Net present value of {_npv:C0}");
            return text.ToString().TrimEnd();
        }
    }
}
