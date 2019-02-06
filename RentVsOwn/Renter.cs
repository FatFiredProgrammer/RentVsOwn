using System;
using System.Text;
using JetBrains.Annotations;
using RentVsOwn.Financials;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public sealed class Renter : IEntity
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
        }

        public string Name => nameof(Renter);

        private decimal NetWorth => _invested + _cash + _securityDeposit;

        private decimal _initialCash;

        private decimal _basis;

        private decimal _invested;

        private decimal _cash;

        private decimal _securityDeposit;

        private readonly Report<Data> _report = new Report<Data>();

        private void Finalize(Data data, ISimulation simulation, IOutput output)
        {
            _cash += _invested;
            data.CashFlow += _invested;
            _report.AddNote(output.WriteLine($"* {_invested:C0} investment closed out"));

            var capitalGains = (_invested - _basis).ToDollars();
            output.WriteLine($"* Capital gains of {capitalGains:C0} on investment basis of {_basis:C0}");
            if (capitalGains > 0)
            {
                var capitalGainsTax = (simulation.CapitalGainsRatePerYear * capitalGains).ToDollars();
                _cash -= capitalGainsTax;
                data.CashFlow -= capitalGainsTax;
                _report.AddNote(output.WriteLine($"* {capitalGainsTax:C0} capital gains tax"));
            }

            _invested = 0;

            _cash += _securityDeposit;
            data.CashFlow += _securityDeposit;
            output.WriteLine($"* {_securityDeposit:C0} security deposit returned");
            _securityDeposit = 0;

            output.WriteLine($"* {_cash:C0} cash on hand");
        }

        /// <inheritdoc />
        public string GenerateReport(ReportGrouping grouping, ReportFormat format)
            => _report.Generate(grouping, format);

        private void Initialize(ISimulation simulation, IOutput output)
        {
            _initialCash =
                simulation.OwnerDownPayment +
                simulation.BuyerFixedCosts +
                simulation.OwnerLoanAmount *
                simulation.BuyerVariableCostsPercentage;

            _report.AddNote(output.WriteLine($"* {_initialCash:C0} starting cash"));
            output.VerboseLine($"    * {simulation.OwnerDownPayment:C0} down payment +  + )");
            output.VerboseLine($"    * {simulation.BuyerFixedCosts:C0} fixed closing costs");
            output.VerboseLine($"    * {simulation.OwnerLoanAmount * simulation.BuyerVariableCostsPercentage:C0} variable closing costs");

            _securityDeposit = (simulation.RentSecurityDepositMonths * simulation.RentPerMonth).ToDollars();
            _report.AddNote(output.WriteLine($"* {_securityDeposit:C0} security deposit"));
            _invested = Math.Max(0, _initialCash - _securityDeposit);
            _basis = _invested;
            _report.AddNote(output.WriteLine($"* {_invested:C0} invested @ {simulation.DiscountRatePerYear:P2}"));

            _report.DiscountRatePerYear = simulation.DiscountRatePerYear;
            _report.AddNote(output.WriteLine($"* {_report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(_report.DiscountRatePerYear):P4} monthly discount rate"));
            _report.Add(new Data
            {
                CashFlow = -_initialCash,
            });
        }

        private Data Process(ISimulation simulation, IOutput output)
        {
            var data = new Data
            {
                Rent = simulation.CurrentRentPerMonth,
                CashFlow = -simulation.CurrentRentPerMonth,
            };
            output.WriteLine($"* {simulation.CurrentRentPerMonth:C0} rent");

            if (simulation.RentersInsurancePerMonth > 0)
            {
                data.RentersInsurance = simulation.RentersInsurancePerMonth;
                data.CashFlow -= data.RentersInsurance;
                output.WriteLine($"* {simulation.RentersInsurancePerMonth:C0} renter's insurance");
            }

            var growth = (_invested * simulation.DiscountRatePerYear / 12).ToDollarCents();
            _invested += growth;
            output.WriteLine($"* Investment of {_invested:C0} grew by {growth:C0} ({simulation.DiscountRatePerYear / 12:P2})");

            return data;
        }

        /// <inheritdoc />
        public void Simulate(ISimulation simulation, IOutput output)
        {
            if (simulation == null)
                throw new ArgumentNullException(nameof(simulation));
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            output.WriteLine($"{Name} in month # {simulation.Month}{Environment.NewLine}");

            if (simulation.IsInitialMonth)
                Initialize(simulation, output);
            var data = Process(simulation, output);
            if (simulation.IsFinalMonth)
                Finalize(data, simulation, output);

            _report.Add(data);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine($"{Name} has net worth of {NetWorth:C0} on initial cash of {_initialCash:C0}");
            return text.ToString().TrimEnd();
        }
    }
}
