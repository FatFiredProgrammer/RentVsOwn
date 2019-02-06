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
            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum)]
            public decimal Rent { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateNpv = true, CalculateIrr = true)]
            public decimal CashFlow { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency,Grouping = ReportColumnGrouping.Sum)]
            public decimal CashFlowPresentValue { get; set; }
        }

        public string Name => nameof(Renter);

        private decimal NetWorth => _invested + _cash + _securityDeposit;

        private decimal _basis;

        private decimal _invested;

        private decimal _cash;

        private decimal _initialSecurityDeposit;

        private decimal _securityDeposit;

        private readonly Report<Data> _report = new Report<Data>();

        private void Finalize(Data data, ISimulation simulation, IOutput output)
        {
            var capitalGains = (_invested - _basis).ToDollars();
            output.WriteLine($"* Capital gains of {capitalGains:C0} on initial investment of {_basis:C0}");
            if (capitalGains > 0)
            {
                var capitalGainsTax = (simulation.CapitalGainsRate * capitalGains).ToDollars();
                output.WriteLine($"* Capital gains tax of {capitalGainsTax:C0}");
                _cash -= capitalGainsTax;
                data.CashFlow -= capitalGainsTax;
            }

            output.WriteLine($"* Cashed out investment of {_invested:C0}");
            _cash += _invested;
            data.CashFlow += _invested;
            _invested = 0;

            output.WriteLine($"* Returned security deposit of {_securityDeposit:C0}");
            _cash += _securityDeposit;
            data.CashFlow += _invested;
            _securityDeposit = 0;

            output.WriteLine($"* Cash on hand of {_cash:C0}");
        }

        /// <inheritdoc />
        public string GenerateReport()
            => _report.Generate(ReportFormat.Csv);

        private void Initialize(ISimulation simulation, IOutput output)
        {
            var initialCashFlow = simulation.OwnerDownPayment + simulation.ClosingFixedCosts + simulation.OwnerLoanAmount * simulation.ClosingVariableCostsPercentage;
            output.WriteLine(
                $"* Starting cash of {initialCashFlow:C0} ({simulation.OwnerDownPayment:C0} owner down payment + {simulation.ClosingFixedCosts:C0} owner fixed closing costs + {simulation.OwnerLoanAmount * simulation.ClosingVariableCostsPercentage:C0} owner variable closing costs)");

            _initialSecurityDeposit = (simulation.RentSecurityDepositMonths * simulation.CurrentRentPerMonth).ToDollars();
            _securityDeposit = _initialSecurityDeposit;
            output.WriteLine($"* Security deposit of {_securityDeposit:C0}");
            _basis = Math.Max(0, initialCashFlow - _securityDeposit);
            _invested = _basis;
            output.WriteLine($"* Invested  {_invested:C0}");

            _report.DiscountRatePerYear = simulation.DiscountRatePerYear;
            _report.Add(new Data
            {
                Rent = 0m,
                CashFlow = -initialCashFlow,
                CashFlowPresentValue = -initialCashFlow,
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
                // TODO: 
                data.CashFlow = -simulation.CurrentRentPerMonth;
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

            data.CashFlowPresentValue = Npv.CalculatePresentValue(data.CashFlow, simulation.DiscountRatePerMonth, simulation.Month);
            _report.Add(data);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(
                $"{Name} has net worth of {NetWorth:C0} on initial investment of {_basis:C0} + security deposit of {_initialSecurityDeposit:C0}");
            return text.ToString().TrimEnd();
        }
    }
}
