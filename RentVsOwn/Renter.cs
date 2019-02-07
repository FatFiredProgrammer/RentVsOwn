using System;
using System.Text;
using JetBrains.Annotations;
using RentVsOwn.Financials;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public sealed class Renter : Entity<RenterData>
    {
        public Renter(ISimulation simulation, IOutput output)
            : base(simulation, output)
        {
        }

        public override decimal NetWorth => _invested + _cash + _securityDeposit;

        private decimal _initialCash;

        private decimal _basis;

        private decimal _invested;

        private decimal _cash;

        private decimal _securityDeposit;

        private decimal _insurancePerMonth;

        private decimal _rentPerMonth;

        private readonly Report<RenterData> _report = new Report<RenterData>();

        private void Finalize(RenterData data)
        {
            _cash += _invested;
            data.CashFlow += _invested;
            _report.AddNote(WriteLine($"* {_invested:C0} investment closed out"));

            var capitalGains = (_invested - _basis).ToDollars();
            WriteLine($"* Capital gains of {capitalGains:C0} on investment basis of {_basis:C0}");
            if (capitalGains > 0)
            {
                var capitalGainsTax = (Simulation.CapitalGainsRatePerYear * capitalGains).ToDollars();
                _cash -= capitalGainsTax;
                data.CashFlow -= capitalGainsTax;
                _report.AddNote(WriteLine($"* {capitalGainsTax:C0} capital gains tax"));
            }

            _invested = 0;

            _cash += _securityDeposit;
            data.CashFlow += _securityDeposit;
            WriteLine($"* {_securityDeposit:C0} security deposit returned");
            _securityDeposit = 0;

            WriteLine($"* {_cash:C0} cash on hand");
        }

        /// <inheritdoc />
        public override string GenerateReport(ReportGrouping grouping, ReportFormat format)
            => _report.Generate(grouping, format);

        private void Initialize()
        {
            _insurancePerMonth = Simulation.RentersInsurancePerMonth;
            _rentPerMonth = Simulation.RentPerMonth;

            _initialCash =
                Simulation.OwnerDownPayment +
                Simulation.BuyerFixedCosts +
                Simulation.OwnerLoanAmount *
                Simulation.BuyerVariableCostsPercentage;

            _report.AddNote(WriteLine($"* {_initialCash:C0} starting cash"));
            VerboseLine($"    * {Simulation.OwnerDownPayment:C0} down payment +  + )");
            VerboseLine($"    * {Simulation.BuyerFixedCosts:C0} fixed closing costs");
            VerboseLine($"    * {Simulation.OwnerLoanAmount * Simulation.BuyerVariableCostsPercentage:C0} variable closing costs");

            _securityDeposit = (Simulation.RentSecurityDepositMonths * Simulation.RentPerMonth).ToDollars();
            _report.AddNote(WriteLine($"* {_securityDeposit:C0} security deposit"));
            _invested = Math.Max(0, _initialCash - _securityDeposit);
            _basis = _invested;
            _report.AddNote(WriteLine($"* {_invested:C0} invested @ {Simulation.DiscountRatePerYear:P2}"));

            _report.DiscountRatePerYear = Simulation.DiscountRatePerYear;
            _report.AddNote(WriteLine(
                $"* {_report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(_report.DiscountRatePerYear):P4} monthly discount rate"));
            _report.Add(new RenterData
            {
                CashFlow = -_initialCash,
            });
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

            if (Simulation.InflationRatePerYear > 0)
            {
                _insurancePerMonth = (_insurancePerMonth + _insurancePerMonth * Simulation.InflationRatePerYear).ToDollarCents();
                WriteLine($"* Renters insurance increased {Simulation.InflationRatePerYear:P2} to {_insurancePerMonth:C2}");
            }
        }

        private RenterData Process()
        {
            var data = new RenterData
            {
                Rent = _rentPerMonth,
                CashFlow = -_rentPerMonth,
            };
            WriteLine($"* {_rentPerMonth:C0} rent");

            if (_insurancePerMonth > 0)
            {
                data.Insurance = _insurancePerMonth;
                data.CashFlow -= data.Insurance;
                WriteLine($"* {_insurancePerMonth:C0} renter's insurance");
            }

            var growth = (_invested * Simulation.DiscountRatePerYear / 12).ToDollarCents();
            _invested += growth;
            WriteLine($"* Investment of {_invested:C0} grew by {growth:C0} ({Simulation.DiscountRatePerYear / 12:P2})");

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
    }
}
