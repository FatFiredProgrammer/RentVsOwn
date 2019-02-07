using System;
using RentVsOwn.Financials;
using RentVsOwn.Output;

namespace RentVsOwn
{
    public sealed class Landlord : Entity<LandlordData>
    {
        public Landlord(ISimulation simulation, IOutput output)
            : base(simulation, output)
        {
        }

        protected override decimal NetWorth => Cash - _securityDeposit + _homeValue - _loanBalance - _operatingLoan;

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
        ///     This represents a operating loan we either had to take out this
        ///     month to make cash flow or an amount we paid back to against a previous operating loan
        /// </summary>
        private decimal _operatingLoan;

        /// <summary>
        ///     Current year taxable income
        /// </summary>
        private decimal _taxableIncome;

        private void CalculateExpenses(LandlordData data)
        {
            if (Simulation.LandlordVacancyFeePercentage > 0)
            {
                data.VacancyFee += _rentPerMonth * Simulation.LandlordVacancyFeePercentage;
                data.Cash -= data.VacancyFee;
                data.CashFlow -= data.VacancyFee;
                WriteLine($"* {data.VacancyFee:C0} vacancy fee");
            }

            if (Simulation.LandlordManagementFeePercentagePerMonth > 0)
            {
                data.ManagementFee += _rentPerMonth * Simulation.LandlordManagementFeePercentagePerMonth;
                data.Cash -= data.ManagementFee;
                data.CashFlow -= data.ManagementFee;
                WriteLine($"* {data.ManagementFee:C0} management fee");
            }

            if (Simulation.PropertyTaxPercentagePerYear > 0)
            {
                data.PropertyTax += (_homeValue * Simulation.PropertyTaxPercentagePerYear / 12).ToDollars();
                data.Cash -= data.PropertyTax;
                data.CashFlow -= data.PropertyTax;
                WriteLine($"* {data.PropertyTax:C0} property tax");
            }

            if (Simulation.InsurancePerMonth > 0)
            {
                data.Insurance += _insurancePerMonth;
                data.Cash -= data.Insurance;
                data.CashFlow -= data.Insurance;
                WriteLine($"* {data.Insurance:C0} insurance");
            }

            if (Simulation.HoaPerMonth > 0)
            {
                data.Hoa += _hoaPerMonth;
                data.Cash -= data.Hoa;
                data.CashFlow -= data.Hoa;
                WriteLine($"* {data.Hoa:C0} HOA");
            }

            if (Simulation.HomeMaintenancePercentagePerYear > 0)
            {
                data.Maintenance += (_homeValue * Simulation.HomeMaintenancePercentagePerYear / 12).ToDollars();
                data.Cash -= data.Maintenance;
                data.CashFlow -= data.Maintenance;
                WriteLine($"* {data.Maintenance:C0} maintenance");
            }

            // If we have a operating loan, pay interest on it.
            if (_operatingLoan > 0)
            {
                data.OperatingLoanInterest += (_operatingLoan * Simulation.DiscountRatePerYear / 12).ToDollars();
                data.Cash -= data.OperatingLoanInterest;
                data.CashFlow -= data.OperatingLoanInterest;
                WriteLine($"* {data.OperatingLoanInterest:C0} operating loan interest");
            }
        }

        private void CalculateTaxableIncome(LandlordData data)
        {
            // My net income includes amount I have paid in principle.
            // So, I get it by subtracting expenses from rent.
            var taxableIncome = (data.Rent - data.Expenses).ToDollarCents();
            WriteLine($"* {taxableIncome:C0} net taxable income");

            // We now have a net income for the month.
            // Let's see what we can do about using depreciation
            var depreciation = (Simulation.HomePurchaseAmount * Simulation.DepreciablePercentage / (Simulation.DepreciationYears * 12)).ToDollars();
            WriteLine($"* {depreciation:C0} allowed monthly depreciation + carry-over of {_carryOverDepreciation:C0}");
            _carryOverDepreciation += depreciation;

            if (taxableIncome > 0)
            {
                var usedDepreciation = Math.Min(taxableIncome, _carryOverDepreciation).ToDollarCents();
                taxableIncome -= usedDepreciation;
                _carryOverDepreciation -= usedDepreciation;
                _totalUsedDepreciation += usedDepreciation;
                WriteLine($"* {usedDepreciation:C0} depreciation used resulting in adjusted taxable income of {taxableIncome:C0}");
            }

            if (_carryOverDepreciation > 0)
                WriteLine($"* {_carryOverDepreciation:C0} carry over depreciation");
            if (taxableIncome > 0)
            {
                _taxableIncome += taxableIncome;
                WriteLine($"* {taxableIncome:C0} taxable income ({_taxableIncome:C0} current year)");
            }

            // Pay income tax at the end of the year.
            if (Simulation.IsYearEnd)
                PayIncomeTax(data);
        }

        private void CloseOutOperatingLoan(LandlordData data)
        {
            if (_operatingLoan <= 0)
                return;

            data.Cash -= _operatingLoan;
            data.CashFlow -= _operatingLoan;
            WriteLine($"* Closed out operating loan of {_operatingLoan:C0}");
            _operatingLoan = 0;
        }

        private LandlordData InitializeMonth()
        {
            // Set up our monthly ledger
            var data = new LandlordData
            {
                Rent = _rentPerMonth,
                HomeValue = _homeValue,
                CashFlow = _rentPerMonth,
                Cash = _rentPerMonth,
            };

            WriteLine($"* {data.Rent:C0} rent received");

            if (_loanBalance > 0)
            {
                var loanPayment = Simulation.LandlordMonthlyPayment;
                data.Interest += (_loanBalance * Simulation.LandlordInterestRatePerYear / 12).ToDollars();
                data.Cash -= data.Interest;
                data.CashFlow -= data.Interest;
                data.Principal += Math.Min(loanPayment - data.Interest, _loanBalance).ToDollars();
                data.Cash -= data.Principal;
                data.CashFlow -= data.Principal;
                WriteLine($"* {loanPayment:C0} loan payment ({data.Principal:C0} principal / {data.Interest:C0} interest)");

                _loanBalance -= data.Principal;
                WriteLine($"* {_loanBalance:C0} loan balance");

                data.LoanBalance = _loanBalance;
            }

            return data;
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

        protected override void OnFinalMonth(LandlordData data)
        {
            SellHome(data);
            RefundSecurityDeposit(data);
            PayIncomeTax(data);
            CloseOutOperatingLoan(data);
            Report.AddNote($"* {ToString()}");
        }

        protected override void OnInitialMonth()
        {
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

            _basis = Simulation.HomePurchaseAmount + buyerCosts;
            Report.AddNote(WriteLine($"* {_basis:C0} home value basis"));

            _securityDeposit = (Simulation.RentSecurityDepositMonths * Simulation.RentPerMonth).ToDollars();
            InitialCash -= _securityDeposit;
            Report.AddNote(WriteLine($"* {_securityDeposit:C0} security deposit received"));

            Report.AddNote(WriteLine($"* {InitialCash:C0} starting cash"));

            _rentPerMonth = Simulation.RentPerMonth;
            Report.AddNote(WriteLine($"* {_rentPerMonth:C0} initial rent"));

            Report.DiscountRatePerYear = Simulation.DiscountRatePerYear;
            WriteLine($"* {Report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(Report.DiscountRatePerYear):P6} monthly discount rate");
            Report.Add(new LandlordData
            {
                CashFlow = -InitialCash,
                LoanBalance = _loanBalance,
                HomeValue = _homeValue,
            });
        }

        protected override LandlordData OnProcess()
        {
            var data = InitializeMonth();
            CalculateExpenses(data);
            CalculateTaxableIncome(data);
            RepayOperatingLoan(data);
            PayDownLoan(data);
            PayTheBills(data);

            return data;
        }

        protected override void OnRecordData(LandlordData data)
        {
            WriteLine($"* {data.Expenses:C0} monthly expenses");

            // Note that this is different than cash flow.
            // This is for calculating net worth.
            if (data.Cash != 0)
            {
                Cash += data.Cash;
                Cash = Cash.ToDollars();
                WriteLine($"* {data.Cash:C0} cash transferred to {Cash:C0} cash on hand");
                data.Cash = 0;
            }

            base.OnRecordData(data);
        }

        private void PayDownLoan(LandlordData data)
        {
            if (data.Cash <= 0 || _loanBalance <= 0)
                return;

            var additionalPrincipal = Math.Min(_loanBalance, data.Cash);
            _loanBalance -= additionalPrincipal;
            data.LoanBalance = _loanBalance;
            data.Cash -= additionalPrincipal;
            data.CashFlow -= additionalPrincipal;
            WriteLine($"* {additionalPrincipal:C0} additional principal leaving balance of {_loanBalance:C0}");
        }

        private void PayIncomeTax(LandlordData data)
        {
            if (_taxableIncome <= 0)
                return;

            var taxes = (_taxableIncome * Simulation.MarginalTaxRatePerYear).ToDollars();
            if (taxes > 0)
            {
                data.OtherTaxes += taxes;
                data.Cash -= taxes;
                data.CashFlow -= taxes;
                WriteLine($"* {taxes:C0} income taxes");
            }

            _taxableIncome = 0;
        }

        private void PayOffLoan(LandlordData data)
        {
            if (_loanBalance <= 0)
                return;

            data.Cash -= _loanBalance;
            data.CashFlow -= _loanBalance;
            WriteLine($"* {_loanBalance:C0} loan balance paid off");
            _loanBalance = 0;
            data.LoanBalance = 0;
        }

        private void PayTaxesOnHomeSale(LandlordData data, decimal proceeds)
        {
            if (Simulation.Allow1031Exchange)
            {
                WriteLine("* No taxes on home sale because of 1031 exchange");
                return;
            }

            var capitalGains = proceeds - _basis;
            if (capitalGains <= 0)
                return;

            WriteLine($"* {capitalGains:C0} total gain from sale of house");
            if (_totalUsedDepreciation > 0)
            {
                var reclaimedDepreciation = Math.Min(capitalGains, _totalUsedDepreciation).ToDollars();
                var reclaimedDepreciationTaxes = (reclaimedDepreciation * Simulation.MarginalTaxRatePerYear).ToDollars();
                if (reclaimedDepreciationTaxes > 0)
                {
                    data.OtherTaxes += reclaimedDepreciationTaxes;
                    data.Cash -= reclaimedDepreciationTaxes;
                    data.CashFlow -= reclaimedDepreciationTaxes;
                    WriteLine($"* {reclaimedDepreciationTaxes:C0} depreciation recapture taxes on {reclaimedDepreciation:C0}");
                    capitalGains -= reclaimedDepreciation;
                    _totalUsedDepreciation -= reclaimedDepreciation;
                }
            }

            if (capitalGains > 0)
            {
                var capitalGainsTaxes = (capitalGains * Simulation.CapitalGainsRatePerYear).ToDollars();
                data.OtherTaxes += capitalGainsTaxes;
                data.Cash -= capitalGainsTaxes;
                data.CashFlow -= capitalGainsTaxes;
                WriteLine($"* {capitalGainsTaxes:C0} capital gains taxes on {capitalGains:C0}");
            }
        }

        private void PayTheBills(LandlordData data)
        {
            if (data.Cash >= 0)
                return;

            // If we have a negative cash flow, then we need to do something about it.
            // Cash flow is already dealing with the NPV.
            // This is more to account for net worth and to allow us to assign interest to operating loans.
            var operatingLoanAmount = Math.Abs(data.Cash);

            // Start by drawing on our cash
            var cashAmount = Math.Max(0, Math.Min(operatingLoanAmount, Cash));
            if (cashAmount > 0)
            {
                operatingLoanAmount -= cashAmount;
                Cash -= cashAmount;
                WriteLine($"* {cashAmount:C0} cash on hand used to cover negative cash flow");
                data.Cash += operatingLoanAmount;
            }

            if (operatingLoanAmount > 0)
            {
                _operatingLoan += operatingLoanAmount;
                data.OperatingLoan += operatingLoanAmount;
                WriteLine($"* {operatingLoanAmount:C0} operating loan creating a balance of {_operatingLoan:C0}");
                data.Cash += operatingLoanAmount;
            }
        }

        private void RefundSecurityDeposit(LandlordData data)
        {
            if (_securityDeposit <= 0)
                return;

            data.Cash -= _securityDeposit;
            data.CashFlow -= _securityDeposit;
            WriteLine($"* {_securityDeposit:C0} security deposit refunded");
            _securityDeposit = 0;
        }

        private void RepayOperatingLoan(LandlordData data)
        {
            if (data.Cash <= 0 || _operatingLoan <= 0)
                return;

            var operatingLoanPayment = Math.Min(_operatingLoan, data.Cash);
            _operatingLoan -= operatingLoanPayment;
            data.Cash -= operatingLoanPayment;
            data.CashFlow -= operatingLoanPayment;
            data.OperatingLoan = -operatingLoanPayment;
            WriteLine($"* {operatingLoanPayment:C0} operating loan payment leaving a balance of {_operatingLoan:C0}");
        }

        private void SellHome(LandlordData data)
        {
            WriteLine($"* {_homeValue:C0} gross home sale proceeds ");
            var sellerFixedCosts = Simulation.SellerFixedCosts;
            WriteLine($"* {sellerFixedCosts:C0} seller fixed costs");
            var sellerCommission = (Simulation.SellerCommissionPercentage * _homeValue).ToDollars();
            WriteLine($"* {sellerCommission:C0} seller commission");
            var sellerCosts = sellerFixedCosts + sellerCommission;
            WriteLine($"* {sellerCosts:C0} total seller costs");
            var proceeds = _homeValue - sellerCosts;
            data.Cash += proceeds;
            data.CashFlow += proceeds;
            Report.AddNote(WriteLine($"* {proceeds:C0} net home sale proceeds after seller costs"));
            _homeValue = 0;
            data.HomeValue = 0;

            PayTaxesOnHomeSale(data, proceeds);
            PayOffLoan(data);
        }
    }
}
