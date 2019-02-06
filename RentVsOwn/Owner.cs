using System;
using System.Text;
using JetBrains.Annotations;
using RentVsOwn.Financials;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public sealed class Owner : Entity
    {
        [PublicAPI]
        private sealed class Data
        {
            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Total => Expenses + Principal;

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Expenses => Insurance + PropertyTax + Hoa + Maintenance + Interest;

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Insurance { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal PropertyTax { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Hoa { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Maintenance { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Interest { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Principal { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateNpv = true, CalculateIrr = true)]
            public decimal CashFlow { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Last)]
            public decimal HomeValue { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Last)]
            public decimal LoanBalance { get; set; }
        }

        public Owner(ISimulation simulation, IOutput output)
            : base(simulation, output)
        {
        }

        private decimal NetWorth => _cash + _homeValue - _loanBalance;

        private decimal _initialCash;

        private decimal _cash;

        private readonly Report<Data> _report = new Report<Data>();

        private decimal _loanBalance;

        private decimal _homeValue;

        private decimal _insurancePerMonth;

        private decimal _hoaPerMonth;

        private void Finalize(Data data)
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

            _report.AddNote(WriteLine($"* {proceeds:C0} net home sale proceeds"));

            _cash += proceeds;
            _cash = _cash.ToDollars();
            WriteLine($"* {_cash:C0} cash on hand");

            data.CashFlow += proceeds;
        }

        /// <inheritdoc />
        public override string GenerateReport(ReportGrouping grouping, ReportFormat format)
            => _report.Generate(grouping, format);

        private void Initialize()
        {
            _homeValue = Simulation.HomePurchaseAmount;
            _report.AddNote(WriteLine($"* {_homeValue:C0} home value"));
            _loanBalance = Simulation.OwnerLoanAmount;
            _report.AddNote(WriteLine($"* {_loanBalance:C0} loan amount"));
            _insurancePerMonth = Simulation.InsurancePerMonth;
            _hoaPerMonth = Simulation.HoaPerMonth;

            _initialCash += Simulation.OwnerDownPayment;
            _report.AddNote(WriteLine($"* {Simulation.OwnerDownPayment:C0} down payment"));

            var buyerFixedCosts = Simulation.BuyerFixedCosts;
            WriteLine($"* {Simulation.BuyerFixedCosts:C0} buyer fixed costs");
            var buyerVariableCosts = Simulation.OwnerLoanAmount * Simulation.BuyerVariableCostsPercentage;
            WriteLine($"* {buyerVariableCosts:C0} buyer variable costs of {Simulation.BuyerVariableCostsPercentage:P2}");
            var buyerCosts = buyerFixedCosts + buyerVariableCosts;
            _initialCash += buyerCosts;
            _report.AddNote(WriteLine($"* {buyerCosts:C0} total buyer costs"));

            _report.AddNote(WriteLine($"* {_initialCash:C0} starting cash"));

            _report.DiscountRatePerYear = Simulation.DiscountRatePerYear;
            _report.AddNote(WriteLine($"* {_report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(_report.DiscountRatePerYear):P4} monthly discount rate"));
            _report.Add(new Data
            {
                CashFlow = -_initialCash,
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

        private Data Process()
        {
            var data = new Data
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

        /// <inheritdoc />
        public override void Simulate()
        {
            WriteLine($"{Name} in month # {Simulation.Month}{Environment.NewLine}");

            if (Simulation.IsInitialMonth)
                Initialize();
            var data = Process();
            if (Simulation.IsFinalMonth)
                Finalize(data);

            _report.Add(data);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine($"{Name} has net worth of {NetWorth:C0} on initial investment of {_initialCash:C0}");
            return text.ToString().TrimEnd();
        }
    }
}
