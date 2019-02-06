using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using JetBrains.Annotations;
using RentVsOwn.Financials;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public sealed class Landlord : Entity
    {
        [PublicAPI]
        private sealed class Data
        {
            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Expenses => Rent + RentersInsurance;

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Rent { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal RentersInsurance { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateNpv = true, CalculateIrr = true)]
            public decimal CashFlow { get; set; }

            // TODO: Code needs work
#if false
                 public decimal Rent { get; set; }

            public decimal Expenses { get; set; } 
#endif


            public decimal Principal { get; set; }

            public decimal Interest { get; set; }

            public decimal NetIncome => Rent - Expenses;

            /// <summary>
            ///     Gets or sets the cash on hand this month.
            ///     This starts with the value of the rent and then gets progressively decreased.
            ///     If we go negative, we need a personal loan.
            /// </summary>
            /// <value>The cash.</value>
            public decimal Cash { get; set; }

            public decimal PersonalLoan { get; set; }

            public decimal NpvCashFlow { get; set; }
        }

        public Landlord(ISimulation simulation, IOutput output)
            :base(simulation, output)
        {
        }


        private decimal _netWorth;

        private decimal _initialCash;

        /// <summary>
        ///     The basis in the home.
        /// </summary>
        private decimal _basis;

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


        private readonly Report<Data> _report = new Report<Data>();

        [ReportColumn(Ignore = true)]
        public decimal LandlordLoanBalance { get; set; }

        [ReportColumn(Ignore = true)]
        public decimal LandlordHomeValue { get; set; }


        private void CalculateExpenses(Data data)
        {
            if (Simulation.LandlordManagementFeePercentagePerMonth > 0)
            {
                // TODO: Code needs work
#if false
                     var managementFee = Simulation.CurrentRentPerMonth * Simulation.LandlordManagementFeePercentagePerMonth;
                data.Expenses += managementFee;
                data.Cash -= managementFee;
                WriteLine($"* Management fee of {managementFee:C0}"); 
#endif

            }

            if (Simulation.PropertyTaxPercentagePerYear > 0)
            {
                // TODO: Code needs work
#if false
                     var propertyTax = (Simulation.LandlordHomeValue * Simulation.PropertyTaxPercentagePerYear / 12).ToDollars();
                data.Expenses += propertyTax;
                data.Cash -= propertyTax;
                WriteLine($"* Spent {propertyTax:C0} on property tax"); 
#endif

            }

            // TODO: Code needs work
#if false
                 if (Simulation.InsurancePerMonth > 0)
            {
                data.Expenses += Simulation.InsurancePerMonth;
                data.Cash -= Simulation.InsurancePerMonth;
                WriteLine($"* Spent {Simulation.InsurancePerMonth:C0} on insurance");
            }

            if (Simulation.HoaPerMonth > 0)
            {
                data.Expenses += Simulation.HoaPerMonth;
                data.Cash -= Simulation.HoaPerMonth;
                WriteLine($"* Spent {Simulation.HoaPerMonth:C0} on HOA");
            }

            if (Simulation.HomeMaintenancePercentagePerYear > 0)
            {
                var homeMaintenance = (Simulation.LandlordHomeValue * Simulation.HomeMaintenancePercentagePerYear / 12).ToDollars();
                data.Expenses += homeMaintenance;
                data.Cash -= homeMaintenance;
                WriteLine($"* Spent {homeMaintenance:C0} on home maintenance");
            } 
#endif


            // If we have a personal loan, pay interest on it.
            // TODO: Code needs work
#if false
                 if (_personalLoan > 0)
            {
                var personalLoanInterest = (_personalLoan * Simulation.DiscountRatePerYear / 12).ToDollars();
                data.Expenses += personalLoanInterest;
                data.Cash -= personalLoanInterest;
                WriteLine($"* Spent {personalLoanInterest:C0} on interest on personal loan");
            }

            // We pay the previous years taxes at the start of each new year.
            if (Simulation.IsNewYear && _currentYearTaxableIncome > 0)
            {
                var taxes = (_currentYearTaxableIncome * Simulation.MarginalTaxRatePerYear).ToDollars();
                if (taxes > 0)
                {
                    data.Expenses += taxes;
                    data.Cash -= taxes;
                    WriteLine($"* Paid last year's taxes of {taxes:C0}");
                }

                _currentYearTaxableIncome = 0;
            } 
#endif


            WriteLine($"* Total monthly expenses of {data.Expenses:C0} leaving cash of {data.Cash:C0}");
            _totalExpenses += data.Expenses;
        }

        private void CalculateTaxableIncome(Data data)
        {
            // My net income includes amount I have paid in principle.
            var taxableIncome = data.NetIncome.ToDollars();
            WriteLine($"* Net taxable income of {taxableIncome:C0}");

            // We now have a net income for the month.
            // Let's see what we can do about using depreciation
            var depreciation = (Simulation.HomePurchaseAmount * Simulation.DepreciablePercentage / (Simulation.DepreciationYears * 12)).ToDollars();
            WriteLine($"* Allowed monthly depreciation of {depreciation:C0} + carry-over of {_carryOverDepreciation:C0}");
            _carryOverDepreciation += depreciation;

            if (taxableIncome > 0)
            {
                var usedDepreciation = Math.Min(taxableIncome, _carryOverDepreciation).ToDollars();
                taxableIncome -= usedDepreciation;
                _carryOverDepreciation -= usedDepreciation;
                _totalUsedDepreciation += usedDepreciation;
                WriteLine($"* Used depreciation of {usedDepreciation:C0} resulting in adjusted taxable income of {taxableIncome:C0}");
            }

            if (_carryOverDepreciation > 0)
                WriteLine($"* Carry over depreciation of {_carryOverDepreciation:C0}");
            if (taxableIncome > 0)
            {
                _currentYearTaxableIncome += taxableIncome;
                WriteLine($"* Taxable income of {taxableIncome:C0} ({_currentYearTaxableIncome:C0} current year)");
            }
        }

        private void CloseOutPersonalLoan(ref decimal proceeds)
        {
            if (_personalLoan != 0)
            {
                proceeds -= _personalLoan;
                WriteLine($"* Closed out personal loan of {_personalLoan:C0}");
                _personalLoan = 0;
            }
        }

        private void Finalize(Data data)
        {
            var proceeds = SellHome();
            PayTaxesOnHomeSale(ref proceeds);
            PayOffLoan(ref proceeds);
            PayRemainingIncomeTax(ref proceeds);
            CloseOutPersonalLoan(ref proceeds);
            WriteLine($"* Net home sale proceeds of {proceeds:C0}");

            // Put proceeds into cash account
            _cash += proceeds;
            _cash = _cash.ToDollars();
            WriteLine($"* Total cash on hand of {_cash:C0}");

            // Add in this very last cash flow
            // TODO: Code needs work
#if false
                 _cashFlows[_cashFlows.Count - 1] += (double)proceeds;
            WriteLine($"* Adjusted NPV cash flow of {_cashFlows[_cashFlows.Count - 1]:C0} accounting for sale proceeds of {proceeds:C0}");
            data.NpvCashFlow = (decimal)_cashFlows[_cashFlows.Count - 1]; 
#endif

        }

        public override string GenerateReport(ReportGrouping grouping, ReportFormat format)
            => _report.Generate(grouping, format);

        /// <inheritdoc />
        public override void NextYear()
        {
            WriteLine(RentVsOwn.Simulation.Separator);
            WriteLine($"{Name} Year # {Simulation.Month / 12}{Environment.NewLine}");

            // TODO: Code needs work
#if false
                 if (HomeAppreciationPercentagePerYear > 0)
            {
                OwnerHomeValue = (OwnerHomeValue + OwnerHomeValue * HomeAppreciationPercentagePerYear).ToDollars();
                WriteLine($"* Owner Home value increased {HomeAppreciationPercentagePerYear:P2} to {OwnerHomeValue:C0}");
                LandlordHomeValue = (LandlordHomeValue + LandlordHomeValue * HomeAppreciationPercentagePerYear).ToDollars();
                WriteLine($"* Landlord Home value increased {HomeAppreciationPercentagePerYear:P2} to {LandlordHomeValue:C0}");
            }

            if (InflationRatePerYear > 0)
            {
                RentersInsurancePerMonth = (RentersInsurancePerMonth + RentersInsurancePerMonth * InflationRatePerYear).ToDollarCents();
                WriteLine($"* Renters insurance increased {InflationRatePerYear:P2} to {RentersInsurancePerMonth:C2}");
                InsurancePerMonth = (InsurancePerMonth + InsurancePerMonth * InflationRatePerYear).ToDollarCents();
                WriteLine($"* Home owner's insurance increased {InflationRatePerYear:P2} to {InsurancePerMonth:C2}");
                HoaPerMonth = (HoaPerMonth + HoaPerMonth * InflationRatePerYear).ToDollarCents();
                WriteLine($"* HOA increased {InflationRatePerYear:P2} to {HoaPerMonth:C2}");
            }
            if (Simulation.RentChangePerYearPercentage > 0)
            {
                _rentPerMonth = (_rentPerMonth + _rentPerMonth * Simulation.RentChangePerYearPercentage).ToDollars();
                WriteLine($"* Rent increased {Simulation.RentChangePerYearPercentage:P2} to {_rentPerMonth:C0}");
            } 
#endif


            // TODO: Code needs work
#if false
                 if (Simulation.InflationRatePerYear > 0)
            {
                _rentersInsurancePerMonth = (_rentersInsurancePerMonth + _rentersInsurancePerMonth * Simulation.InflationRatePerYear).ToDollarCents();
                WriteLine($"* Renters insurance increased {Simulation.InflationRatePerYear:P2} to {_rentersInsurancePerMonth:C2}");
            } 
#endif

        }


        private void Initialize()
        {
            LandlordHomeValue = Simulation.HomePurchaseAmount;
            LandlordLoanBalance = Simulation.LandlordLoanAmount;

            // TODO: Code needs work
#if false
                 _initialCash = 0;
            _cash = 0;
            _totalRent = 0;
            _averageRent = 0;
            _totalExpenses = 0;
            _averageExpenses = 0;
            _carryOverDepreciation = 0;
            _totalUsedDepreciation = 0;
            _personalLoan = 0;
            _currentYearTaxableIncome = 0; 
#endif


            // TODO: Code needs work
#if false
                 _basis = Simulation.LandlordHomeValue; 
#endif

            WriteLine($"* Down payment of {Simulation.LandlordDownPayment:C0}");
            _initialCash += Simulation.LandlordDownPayment;
            WriteLine($"* Fixed closing costs of {Simulation.BuyerFixedCosts:C0}");
            _initialCash += Simulation.BuyerFixedCosts;
            _basis -= Simulation.BuyerFixedCosts;
            var variableClosingCosts = (Simulation.LandlordLoanAmount * Simulation.BuyerVariableCostsPercentage).ToDollars();
            WriteLine($"* Variable closing costs of {variableClosingCosts:C0}");
            _initialCash += variableClosingCosts;
            _basis -= variableClosingCosts;
            WriteLine($"* Total initial investment of {_initialCash:C0}");
            WriteLine($"* Basis in home purchase {_basis:C0}");

            // TODO: Code needs work
#if false
                 WriteLine($"* Initial loan balance of {Simulation.LandlordLoanBalance:C0}"); 
#endif


            // TODO: Code needs work
#if false
     Report.AddNotes
            _report.DiscountRatePerYear = Simulation.DiscountRatePerYear;
            _report.AddNote(WriteLine($"* {_report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(_report.DiscountRatePerYear):P4} monthly discount rate"));
            _report.Add(new Data
            {
                CashFlow = -_initialCash,
            }); 
#endif

        }

        private Data InitializeData()
        {
            // Set up our monthly ledger
            var monthly = new Data
            {
                // TODO: Code needs work
#if false
                     Rent = Simulation.CurrentRentPerMonth,
                Interest = 0,
                Principal = 0,
                Expenses = 0,
                Cash = Simulation.CurrentRentPerMonth,
                PersonalLoan = 0, 
#endif

            };

            // TODO: Code needs work
#if false

            _totalRent += data.Rent;
            WriteLine($"* Received rent of {data.Rent:C0}");

            // See if we are still paying on loan.
            if (Simulation.LandlordLoanBalance > 0)
            {
                var loanPayment = Simulation.LandlordMonthlyPayment;
                data.Interest = (Simulation.LandlordLoanBalance * Simulation.LandlordInterestRate / 12).ToDollars();
                data.Principal = Math.Min(loanPayment - data.Interest, Simulation.LandlordLoanBalance).ToDollars();

                WriteLine($"* Loan payment of {loanPayment:C0} ({data.Principal:C0} principal / {data.Interest:C0} interest)");

                Simulation.LandlordLoanBalance -= data.Principal;
                WriteLine($"* New loan balance of {Simulation.LandlordLoanBalance:C0}");

                data.Cash -= data.Interest;
                data.Expenses += data.Interest;
                data.Cash -= data.Principal;
            } 
#endif


            return monthly;
        }

        private static void PayDownLoan(Data data)
        {
            // If we have any cash left, use it to pay down the mortgage balance.
            // TODO: Code needs work
#if false
                 if (data.Cash > 0 && Simulation.LandlordLoanBalance > 0)
            {
                var additionalPrincipal = Math.Min(Simulation.LandlordLoanBalance, data.Cash);
                Simulation.LandlordLoanBalance -= additionalPrincipal;
                data.Cash -= additionalPrincipal;
                WriteLine($"* Paid additional principal of {additionalPrincipal:C0} leaving balance of {Simulation.LandlordLoanBalance:C0} and cash of {data.Cash:C0}");
            } 
#endif

        }

        private static void PayOffLoan(ref decimal proceeds)
        {
            // TODO: Code needs work
#if false
                 if (Simulation.LandlordLoanBalance > 0)
            {
                output.WriteLine($"* Paid off loan balance of {Simulation.LandlordLoanBalance:C0}");
                proceeds -= Simulation.LandlordLoanBalance;
                Simulation.LandlordLoanBalance = 0;
            }

            Simulation.LandlordHomeValue = 0; 
#endif

        }

        private void PayRemainingIncomeTax(ref decimal proceeds)
        {
            if (_currentYearTaxableIncome > 0)
            {
                var taxes = (_currentYearTaxableIncome * Simulation.MarginalTaxRatePerYear).ToDollars();
                if (taxes > 0)
                {
                    proceeds -= taxes;
                    _totalExpenses += taxes;
                    WriteLine($"* Paid remaining yearly taxes of {taxes:C0}");
                }

                _currentYearTaxableIncome = 0;
            }
        }

        private void PayTaxesOnHomeSale(ref decimal proceeds)
        {
            var capitalGains = proceeds - _basis;
            if (capitalGains > 0)
            {
                WriteLine($"* Total gain from sale of {capitalGains:C0}");
                if (_totalUsedDepreciation > 0)
                {
                    var reclaimedDepreciation = Math.Min(capitalGains, _totalUsedDepreciation).ToDollars();
                    var reclaimedDepreciationTaxes = (reclaimedDepreciation * Simulation.MarginalTaxRatePerYear).ToDollars();
                    if (reclaimedDepreciationTaxes > 0)
                    {
                        proceeds -= reclaimedDepreciationTaxes;
                        capitalGains -= reclaimedDepreciation;
                        _totalExpenses += reclaimedDepreciationTaxes;
                        _totalUsedDepreciation -= reclaimedDepreciation;
                        WriteLine($"* Paid depreciation recapture taxes of {reclaimedDepreciationTaxes:C0} on {reclaimedDepreciation:C0}");
                    }
                }

                if (capitalGains > 0)
                {
                    var capitalGainsTaxes = (capitalGains * Simulation.CapitalGainsRatePerYear).ToDollars();
                    proceeds -= capitalGainsTaxes;
                    _totalExpenses += capitalGainsTaxes;
                    WriteLine($"* Paid capital gains taxes of {capitalGainsTaxes:C0} on {capitalGains:C0}");
                }
            }
        }

        private Data Process()
        {
            var data = InitializeData();
            CalculateExpenses(data);
            CalculateTaxableIncome(data);
            RepayPersonalLoan(data);
            PayDownLoan(data);
            TakePersonalLoan(data);
            RecordCashFlow(data);
            return data;
        }

        private void RecordCashFlow(Data data)
        {
            // Cash flow used for NPV
            if (data.Expenses + data.Principal > data.Rent)
            {
                WriteLine($"* Monthly expenses {data.Expenses:C0} + principle of {data.Principal:C0} = {data.Expenses + data.Principal:C0} against rent of {data.Rent:C0}");
                WriteLine($"* Negative cash flow of {data.Rent - (data.Expenses + data.Principal):C0}");
            }

            // TODO: Code needs work
#if false
                 // data.PersonalLoan could be positive or negative depending on whether we took out loan or repaid one.
            // Essentially, the personal loan causes us to defer cash flow (for NPV/IRR) until we actually payback the loan.
            var cashFlow = data.NetIncome - data.PersonalLoan;
            data.NpvCashFlow = cashFlow;
            _cashFlows.Add((double)cashFlow);
            WriteLine($"* NPV cash flow of {cashFlow:C0}"); 
#endif

        }

        private void RepayPersonalLoan(Data data)
        {
            if (data.Cash > 0 && _personalLoan > 0)
            {
                var personalLoanPayment = Math.Min(_personalLoan, data.Cash);
                _personalLoan -= personalLoanPayment;
                data.Cash -= personalLoanPayment;
                data.PersonalLoan = -personalLoanPayment;
                WriteLine($"* Paid back {personalLoanPayment:C0} of personal loan leaving a balance of {_personalLoan:C0} and cash of {data.Cash:C0}");
            }
        }

        private decimal SellHome()
        {
            // TODO: Code needs work
#if false
                 var homeValue = Simulation.LandlordHomeValue;
            WriteLine($"* Sold home for {homeValue:C0}");
            var salesFixedCosts = Simulation.SellerFixedCosts;
            var salesCommission = Simulation.SellerCommissionPercentage * homeValue;
            var proceeds = homeValue - (salesFixedCosts + salesCommission);
            WriteLine($"* Fixed sales costs of {salesFixedCosts:C0} and commission of {salesCommission:C0} leaving proceeds of {proceeds:C0}");
            _totalExpenses += salesFixedCosts + salesCommission;
            return proceeds; 
#endif
            return 0;

        }

        /// <inheritdoc />
        public override void Simulate()
        {
            WriteLine($"{Name} in month # {Simulation.Month}{Environment.NewLine}");

            if (Simulation.IsInitialMonth)
                Initialize();
            var monthly = Process();
            if (Simulation.IsFinalMonth)
                Finalize(monthly);

            // TODO: Code needs work
#if false
                 _months.Add(monthly);

            _averageRent = (_totalRent / Simulation.Month).ToDollars();
            _averageExpenses = (_totalExpenses / Simulation.Month).ToDollars();
            _netWorth = _cash - _personalLoan + Simulation.LandlordHomeValue - Simulation.LandlordLoanBalance; 
#endif

            // TODO: Code needs work
#if false
                 _report.Add(data); 
#endif
        }

        private void TakePersonalLoan(Data data)
        {
            if (data.Cash < 0)
            {
                var personalLoanAmount = Math.Abs(data.Cash);
                _personalLoan += personalLoanAmount;
                data.PersonalLoan = personalLoanAmount;
                WriteLine($"* Required personal loan of {personalLoanAmount:C0} creating a balance of {_personalLoan:C0}");

                data.Cash = 0;
            }
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(
                $"{Name} received total rent of {_totalRent:C0} (average of {_averageRent:C0} / month), total expenses of {_totalExpenses:C0} (average of {_averageExpenses:C0} / month), and has net worth of {_netWorth:C0} on initial investment of {_initialCash:C0}");

            // TODO: MAKE THIS COMMON!

            return text.ToString().TrimEnd();
        }
    }
}
