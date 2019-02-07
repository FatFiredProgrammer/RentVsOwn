using System;
using RentVsOwn.Output;

namespace RentVsOwn
{
    public sealed class Landlord : Entity<LandlordData>
    {
        public Landlord(ISimulation simulation, IOutput output)
            : base(simulation, output)
        {
        }

        public override decimal NetWorth => Cash - _securityDeposit + _homeValue - _loanBalance - _personalLoan;

        /// <summary>
        ///     The basis in the home.
        /// </summary>
        private decimal _basis;

        private decimal _carryOverDepreciation;

        private decimal _totalUsedDepreciation;

        private decimal _securityDeposit;

        private decimal _rentPerMonth;

        private decimal _loanBalance;

        private decimal _homeValue;

        private decimal _insurancePerMonth;

        private decimal _hoaPerMonth;

        /// <summary>
        ///     This represents a personal loan we either had to take out this
        ///     month to make cash flow or an amount we paid back to against a previous personal loan
        /// </summary>
        private decimal _personalLoan;

        /// <summary>
        ///     Current year taxable income
        /// </summary>
        private decimal _taxableIncome;

        private void CalculateCash(LandlordData data)
        {
            // TODO: 
            WriteLine($"* Total monthly expenses of {data.Expenses:C0} leaving cash of {data.Cash:C0}");
        }

        private void CalculateExpenses(LandlordData data)
        {
            // TODO: 
            if (Simulation.LandlordManagementFeePercentagePerMonth > 0)
            {
                data.ManagementFee = _rentPerMonth * Simulation.LandlordManagementFeePercentagePerMonth;
                WriteLine($"* {data.ManagementFee:C0} management fee");
            }

            if (Simulation.PropertyTaxPercentagePerYear > 0)
            {
                // TODO: Code needs work
#if false
                     data.P = (Simulation.LandlordHomeValue * Simulation.PropertyTaxPercentagePerYear / 12).ToDollars();
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
            if (Simulation.IsNewYear && _taxableIncome > 0)
            {
                var taxes = (_taxableIncome * Simulation.MarginalTaxRatePerYear).ToDollars();
                if (taxes > 0)
                {
                    data.Expenses += taxes;
                    data.Cash -= taxes;
                    WriteLine($"* Paid last year's taxes of {taxes:C0}");
                }

                _taxableIncome = 0;
            } 
#endif

            WriteLine($"* {data.Expenses:C0} total monthly expenses");
        }

        private void CalculateTaxableIncome(LandlordData data)
        {
            // TODO: 

            // My net income includes amount I have paid in principle.
            //            var taxableIncome = data.NetIncome.ToDollars();
            // TODO: 
            var taxableIncome = 0m;
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
                _taxableIncome += taxableIncome;
                WriteLine($"* Taxable income of {taxableIncome:C0} ({_taxableIncome:C0} current year)");
            }
        }

        private void CloseOutPersonalLoan(ref decimal proceeds)
        {
            // TODO: 
            if (_personalLoan != 0)
            {
                proceeds -= _personalLoan;
                WriteLine($"* Closed out personal loan of {_personalLoan:C0}");
                _personalLoan = 0;
            }
        }

        protected override void Finalize(LandlordData data)
        {
            // TODO: 
            var proceeds = SellHome();
            PayTaxesOnHomeSale(ref proceeds);
            PayOffLoan(ref proceeds);
            PayRemainingIncomeTax(ref proceeds);
            CloseOutPersonalLoan(ref proceeds);
            WriteLine($"* Net home sale proceeds of {proceeds:C0}");

            // Put proceeds into cash account
            Cash += proceeds;
            Cash = Cash.ToDollars();
            WriteLine($"* Total cash on hand of {Cash:C0}");

            // Add in this very last cash flow
            // TODO: Code needs work
#if false
                 CashFlows[CashFlows.Count - 1] += (double)proceeds;
            WriteLine($"* Adjusted NPV cash flow of {CashFlows[CashFlows.Count - 1]:C0} accounting for sale proceeds of {proceeds:C0}");
            data.NpvCashFlow = (decimal)CashFlows[CashFlows.Count - 1]; 
#endif
#if false
// TODO: Code needs work
            Cash += _invested;
            data.CashFlow += _invested;
            Report.AddNote(WriteLine($"* {_invested:C0} investment closed out"));

            var capitalGains = (_invested - _basis).ToDollars();
            WriteLine($"* Capital gains of {capitalGains:C0} on investment basis of {_basis:C0}");
            if (capitalGains > 0)
            {
                var capitalGainsTax = (Simulation.CapitalGainsRatePerYear * capitalGains).ToDollars();
                Cash -= capitalGainsTax;
                data.CashFlow -= capitalGainsTax;
                Report.AddNote(WriteLine($"* {capitalGainsTax:C0} capital gains tax"));
            }

            _invested = 0;

            Cash += _securityDeposit;
            data.CashFlow += _securityDeposit;
            WriteLine($"* {_securityDeposit:C0} security deposit returned");
            _securityDeposit = 0;

            WriteLine($"* {Cash:C0} cash on hand");

#endif
#if false
// TODO: Code needs work
            WriteLine($"* {_homeValue:C0} gross home sale proceeds ");
            var sellerFixedCosts = Simulation.SellerFixedCosts;
            WriteLine($"* {sellerFixedCosts:C0} seller fixed costs");
            var sellerCommission = (Simulation.SellerCommissionPercentage * _homeValue).ToDollars();
            WriteLine($"* {sellerCommission:C0} seller commission");
            var sellerCosts = sellerFixedCosts + sellerCommission;
            WriteLine($"* {sellerCosts:C0} total seller costs");
            var proceeds = _homeValue - sellerCosts;

            if (_loanBalance > 0)
            {
                WriteLine($"* {_loanBalance:C0} loan balance paid");
                proceeds -= _loanBalance;
                _loanBalance = 0;
            }

            _homeValue = 0;

            Report.AddNote(WriteLine($"* {proceeds:C0} net home sale proceeds"));

            Cash += proceeds;
            Cash = Cash.ToDollars();
            WriteLine($"* {Cash:C0} cash on hand");

            data.CashFlow += proceeds;

#endif
        }

        protected override void Initialize()
        {
            // TODO: Code needs work
#if false
             private decimal _basis;
        private decimal _securityDeposit;
        private decimal _rentPerMonth;
        private decimal _loanBalance;
        private decimal _homeValue;
        private decimal _insurancePerMonth;
        private decimal _hoaPerMonth;
        private decimal _personalLoan;
        private decimal _taxableIncome; 
#endif

            // TODO: 

            // TODO: Code needs work
#if false
            LandlordHomeValue = Simulation.HomePurchaseAmount;
            LandlordLoanBalance = Simulation.LandlordLoanAmount;
                 InitialCash = 0;
            Cash = 0;
            _totalRent = 0;
            _averageRent = 0;
            _totalExpenses = 0;
            _averageExpenses = 0;
            _carryOverDepreciation = 0;
            _totalUsedDepreciation = 0;
            _personalLoan = 0;
            _taxableIncome = 0; 
#endif

            // TODO: Code needs work
#if false
                 _basis = Simulation.LandlordHomeValue; 
#endif

            WriteLine($"* Down payment of {Simulation.LandlordDownPayment:C0}");
            InitialCash += Simulation.LandlordDownPayment;
            WriteLine($"* Fixed closing costs of {Simulation.BuyerFixedCosts:C0}");
            InitialCash += Simulation.BuyerFixedCosts;
            _basis -= Simulation.BuyerFixedCosts;
            var variableClosingCosts = (Simulation.LandlordLoanAmount * Simulation.BuyerVariableCostsPercentage).ToDollars();
            WriteLine($"* Variable closing costs of {variableClosingCosts:C0}");
            InitialCash += variableClosingCosts;
            _basis -= variableClosingCosts;
            WriteLine($"* Total initial investment of {InitialCash:C0}");
            WriteLine($"* Basis in home purchase {_basis:C0}");

            // TODO: Code needs work
#if false
                 WriteLine($"* Initial loan balance of {Simulation.LandlordLoanBalance:C0}"); 
#endif

            // TODO: Code needs work
#if false
     Report.AddNotes
            Report.DiscountRatePerYear = Simulation.DiscountRatePerYear;
            Report.AddNote(WriteLine($"* {Report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(Report.DiscountRatePerYear):P4} monthly discount rate"));
            Report.Add(new Data
            {
                CashFlow = -InitialCash,
            }); 
#endif
#if false
// TODO: Code needs work
            _rentersInsurancePerMonth = Simulation.RentersInsurancePerMonth;
            _rentPerMonth = Simulation.RentPerMonth;

            InitialCash =
                Simulation.LandlordDownPayment +
                Simulation.BuyerFixedCosts +
                Simulation.LandlordLoanAmount *
                Simulation.BuyerVariableCostsPercentage;

            Report.AddNote(WriteLine($"* {InitialCash:C0} starting cash"));
            VerboseLine($"    * {Simulation.LandlordDownPayment:C0} down payment +  + )");
            VerboseLine($"    * {Simulation.BuyerFixedCosts:C0} fixed closing costs");
            VerboseLine($"    * {Simulation.LandlordLoanAmount * Simulation.BuyerVariableCostsPercentage:C0} variable closing costs");

            _securityDeposit = (Simulation.RentSecurityDepositMonths * Simulation.RentPerMonth).ToDollars();
            Report.AddNote(WriteLine($"* {_securityDeposit:C0} security deposit"));
            _invested = Math.Max(0, InitialCash - _securityDeposit);
            _basis = _invested;
            Report.AddNote(WriteLine($"* {_invested:C0} invested @ {Simulation.DiscountRatePerYear:P2}"));

            Report.DiscountRatePerYear = Simulation.DiscountRatePerYear;
            Report.AddNote(WriteLine(
                $"* {Report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(Report.DiscountRatePerYear):P4} monthly discount rate"));
            Report.Add(new Data
            {
                CashFlow = -InitialCash,
            });

#endif
#if false
// TODO: Code needs work
            _homeValue = Simulation.HomePurchaseAmount;
            Report.AddNote(WriteLine($"* {_homeValue:C0} home value"));
            _loanBalance = Simulation.LandlordLoanAmount;
            Report.AddNote(WriteLine($"* {_loanBalance:C0} loan amount"));
            _insurancePerMonth = Simulation.InsurancePerMonth;
            _hoaPerMonth = Simulation.HoaPerMonth;

            InitialCash += Simulation.LandlordDownPayment;
            Report.AddNote(WriteLine($"* {Simulation.LandlordDownPayment:C0} down payment"));

            var buyerFixedCosts = Simulation.BuyerFixedCosts;
            WriteLine($"* {Simulation.BuyerFixedCosts:C0} buyer fixed costs");
            var buyerVariableCosts = Simulation.LandlordLoanAmount * Simulation.BuyerVariableCostsPercentage;
            WriteLine($"* {buyerVariableCosts:C0} buyer variable costs of {Simulation.BuyerVariableCostsPercentage:P2}");
            var buyerCosts = buyerFixedCosts + buyerVariableCosts;
            InitialCash += buyerCosts;
            Report.AddNote(WriteLine($"* {buyerCosts:C0} total buyer costs"));

            Report.AddNote(WriteLine($"* {InitialCash:C0} starting cash"));

            Report.DiscountRatePerYear = Simulation.DiscountRatePerYear;
            Report.AddNote(WriteLine($"* {Report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(Report.DiscountRatePerYear):P4} monthly discount rate"));
            Report.Add(new Data
            {
                CashFlow = -InitialCash,
                LoanBalance = _loanBalance,
                HomeValue = _homeValue,
            });

#endif
        }

        private LandlordData InitializeData()
        {
            // TODO: 
            // Set up our monthly ledger
            var monthly = new LandlordData
            {
                Rent = _rentPerMonth,

                // TODO: Code needs work
#if false
                Interest = 0,
                Principal = 0,
                Expenses = 0,
                Cash = _rentPerMonth,
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

        /// <inheritdoc />
        public override void NextYear()
        {
            WriteLine(RentVsOwn.Simulation.Separator);
            WriteLine($"{Name} Year # {Simulation.Month / 12}{Environment.NewLine}");
            if (Simulation.RentChangePerYearPercentage > 0)
            {
                _rentPerMonth = (_rentPerMonth + _rentPerMonth * Simulation.RentChangePerYearPercentage).ToDollars();
                WriteLine($"* Rent increased {Simulation.RentChangePerYearPercentage:P2} to {_rentPerMonth:C0}");
            }

            if (Simulation.HomeAppreciationPercentagePerYear > 0)
            {
                _homeValue = (_homeValue + _homeValue * Simulation.HomeAppreciationPercentagePerYear).ToDollars();
                WriteLine($"* Owner Home value increased {Simulation.HomeAppreciationPercentagePerYear:P2} to {_homeValue:C0}");
            }

            if (Simulation.InflationRatePerYear > 0)
            {
                _insurancePerMonth = (_insurancePerMonth + _insurancePerMonth * Simulation.InflationRatePerYear).ToDollarCents();
                WriteLine($"* Home owner's insurance increased {Simulation.InflationRatePerYear:P2} to {_insurancePerMonth:C2}");
                _hoaPerMonth = (_hoaPerMonth + _hoaPerMonth * Simulation.InflationRatePerYear).ToDollarCents();
                WriteLine($"* HOA increased {Simulation.InflationRatePerYear:P2} to {_hoaPerMonth:C2}");
            }
        }

        private static void PayDownLoan(LandlordData data)
        {
            // TODO:
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
            // TODO:
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
            // TODO:
            if (_taxableIncome > 0)
            {
                var taxes = (_taxableIncome * Simulation.MarginalTaxRatePerYear).ToDollars();
                if (taxes > 0)
                {
                    proceeds -= taxes;
                    WriteLine($"* Paid remaining yearly taxes of {taxes:C0}");
                }

                _taxableIncome = 0;
            }
        }

        private void PayTaxesOnHomeSale(ref decimal proceeds)
        {
            // TODO:
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
                        _totalUsedDepreciation -= reclaimedDepreciation;
                        WriteLine($"* Paid depreciation recapture taxes of {reclaimedDepreciationTaxes:C0} on {reclaimedDepreciation:C0}");
                    }
                }

                if (capitalGains > 0)
                {
                    var capitalGainsTaxes = (capitalGains * Simulation.CapitalGainsRatePerYear).ToDollars();
                    proceeds -= capitalGainsTaxes;
                    WriteLine($"* Paid capital gains taxes of {capitalGainsTaxes:C0} on {capitalGains:C0}");
                }
            }
        }

        protected override LandlordData Process()
        {
            // TODO:
            var data = InitializeData();
            CalculateExpenses(data);
            CalculateCash(data);
            CalculateTaxableIncome(data);
            RepayPersonalLoan(data);
            PayDownLoan(data);
            TakePersonalLoan(data);
            RecordCashFlow(data);
            return data;
#if false
// TODO: Code needs work
            var data = new Data
            {
                Rent = _rentPerMonth,
                CashFlow = -_rentPerMonth,
            };
            WriteLine($"* {_rentPerMonth:C0} rent");

            if (_rentersInsurancePerMonth > 0)
            {
                data.Insurance = _rentersInsurancePerMonth;
                data.CashFlow -= data.Insurance;
                WriteLine($"* {_rentersInsurancePerMonth:C0} renter's insurance");
            }

            var growth = (_invested * Simulation.DiscountRatePerYear / 12).ToDollarCents();
            _invested += growth;
            WriteLine($"* Investment of {_invested:C0} grew by {growth:C0} ({Simulation.DiscountRatePerYear / 12:P2})");

            return data;

#endif
#if false
// TODO: Code needs work
            var data = new Data
            {
                HomeValue = _homeValue,
            };
            if (_loanBalance > 0)
            {
                var loanPayment = Simulation.LandlordMonthlyPayment;
                data.Interest = (_loanBalance * Simulation.LandlordInterestRatePerYear / 12).ToDollars();
                data.Principal = Math.Min(loanPayment - data.Interest, _loanBalance).ToDollars();
                WriteLine($"* {loanPayment:C0} loan payment ({data.Principal:C0} principal / {data.Interest:C0} interest)");

                _loanBalance -= data.Principal;
                WriteLine($"* {_loanBalance:C0} loan balance");
            }

            data.LoanBalance = _loanBalance;

            data.PropertyTax = (_homeValue * Simulation.PropertyTaxPercentagePerYear / 12).ToDollars();
            WriteLine($"* {data.PropertyTax:C0} property tax");

            if (Simulation.InsurancePerMonth > 0)
            {
                data.Insurance = Simulation.InsurancePerMonth;
                WriteLine($"* {data.Insurance:C0} insurance");
            }

            if (Simulation.HoaPerMonth > 0)
            {
                data.Hoa = Simulation.HoaPerMonth;
                WriteLine($"* {data.Hoa:C0} HOA");
            }

            data.Maintenance = (_homeValue * Simulation.HomeMaintenancePercentagePerYear / 12).ToDollars();
            WriteLine($"* {data.Maintenance:C0} home maintenance");

            WriteLine($"* {data.Total:C0} total payments");

            data.CashFlow = -data.Total;

            return data;

#endif
        }

        private void RecordCashFlow(LandlordData data)
        {
            // TODO:
            // Cash flow used for NPV
            // TODO: Code needs work
#if false
                 if (data.Expenses + data.Principal > data.Rent)
            {
                WriteLine($"* Monthly expenses {data.Expenses:C0} + principle of {data.Principal:C0} = {data.Expenses + data.Principal:C0} against rent of {data.Rent:C0}");
                WriteLine($"* Negative cash flow of {data.Rent - (data.Expenses + data.Principal):C0}");
            } 
#endif

            // TODO: Code needs work
#if false
                 // data.PersonalLoan could be positive or negative depending on whether we took out loan or repaid one.
            // Essentially, the personal loan causes us to defer cash flow (for NPV/IRR) until we actually payback the loan.
            var cashFlow = data.NetIncome - data.PersonalLoan;
            data.NpvCashFlow = cashFlow;
            CashFlows.Add((double)cashFlow);
            WriteLine($"* NPV cash flow of {cashFlow:C0}"); 
#endif
        }

        private void RepayPersonalLoan(LandlordData data)
        {
            // TODO:
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
            // TODO:
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

        private void TakePersonalLoan(LandlordData data)
        {
            // TODO:
            // if (data.Cash < 0)
            {
                var personalLoanAmount = Math.Abs(data.Cash);
                _personalLoan += personalLoanAmount;
                data.PersonalLoan = personalLoanAmount;
                WriteLine($"* Required personal loan of {personalLoanAmount:C0} creating a balance of {_personalLoan:C0}");

                data.Cash = 0;
            }
        }
    }
}

// TODO: Use a single pay taxes routine.
