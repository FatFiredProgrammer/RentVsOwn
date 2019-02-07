using System;
using RentVsOwn.Financials;
using RentVsOwn.Output;

namespace RentVsOwn
{
    public sealed class Owner : Entity<OwnerData>
    {
        public Owner(ISimulation simulation, IOutput output)
            : base(simulation, output)
        {
        }

        public override decimal NetWorth => Cash + _homeValue - _loanBalance;

        private decimal _loanBalance;

        private decimal _homeValue;

        private decimal _insurancePerMonth;

        private decimal _hoaPerMonth;

        protected override void Finalize(OwnerData data)
        {
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
        }

        protected override void Initialize()
        {
            _homeValue = Simulation.HomePurchaseAmount;
            Report.AddNote(WriteLine($"* {_homeValue:C0} home value"));
            _loanBalance = Simulation.OwnerLoanAmount;
            Report.AddNote(WriteLine($"* {_loanBalance:C0} loan amount"));
            _insurancePerMonth = Simulation.InsurancePerMonth;
            _hoaPerMonth = Simulation.HoaPerMonth;

            InitialCash += Simulation.OwnerDownPayment;
            Report.AddNote(WriteLine($"* {Simulation.OwnerDownPayment:C0} down payment"));

            var buyerFixedCosts = Simulation.BuyerFixedCosts;
            WriteLine($"* {Simulation.BuyerFixedCosts:C0} buyer fixed costs");
            var buyerVariableCosts = Simulation.OwnerLoanAmount * Simulation.BuyerVariableCostsPercentage;
            WriteLine($"* {buyerVariableCosts:C0} buyer variable costs of {Simulation.BuyerVariableCostsPercentage:P2}");
            var buyerCosts = buyerFixedCosts + buyerVariableCosts;
            InitialCash += buyerCosts;
            Report.AddNote(WriteLine($"* {buyerCosts:C0} total buyer costs"));

            Report.AddNote(WriteLine($"* {InitialCash:C0} starting cash"));

            Report.DiscountRatePerYear = Simulation.DiscountRatePerYear;
            WriteLine($"* {Report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(Report.DiscountRatePerYear):P4} monthly discount rate");
            Report.Add(new OwnerData
            {
                CashFlow = -InitialCash,
                LoanBalance = _loanBalance,
                HomeValue = _homeValue,
            });
        }

        /// <inheritdoc />
        public override void NextYear()
        {
            WriteLine(RentVsOwn.Simulation.Separator);
            WriteLine($"{Name} Year # {Simulation.Month / 12}{Environment.NewLine}");

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

        protected override OwnerData Process()
        {
            var data = new OwnerData
            {
                HomeValue = _homeValue,
            };
            if (_loanBalance > 0)
            {
                var loanPayment = Simulation.OwnerMonthlyPayment;
                data.Interest = (_loanBalance * Simulation.OwnerInterestRatePerYear / 12).ToDollars();
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
        }
    }
}
