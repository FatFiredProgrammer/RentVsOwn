using System;
using RentVsOwn.Financials;
using RentVsOwn.Output;

namespace RentVsOwn
{
    public sealed class Renter : Entity<RenterData>
    {
        public Renter(ISimulation simulation, IOutput output)
            : base(simulation, output)
        {
        }

        protected override decimal NetWorth => _invested + Cash + _securityDeposit;

        private decimal _basis;

        private decimal _invested;

        private decimal _securityDeposit;

        private decimal _insurancePerMonth;

        private decimal _rentPerMonth;

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

        protected override void OnFinalMonth(RenterData data)
        {
            Cash += _invested;
            data.CashFlow += _invested;
            Report.AddNote(WriteLine($"* {_invested:C0} investment (future value)"));

            var capitalGains = (_invested - _basis).ToDollars();
            WriteLine($"* Capital gains of {capitalGains:C0} on investment basis of {_basis:C0}");
            if (capitalGains > 0)
            {
                var capitalGainsTax = (Simulation.CapitalGainsRatePerYear * capitalGains).ToDollars();
                Cash -= capitalGainsTax;
                data.CashFlow -= capitalGainsTax;
                WriteLine($"* {capitalGainsTax:C0} capital gains tax");
            }

            _invested = 0;

            Cash += _securityDeposit;
            data.CashFlow += _securityDeposit;
            WriteLine($"* {_securityDeposit:C0} security deposit returned");
            _securityDeposit = 0;

            WriteLine($"* {Cash:C0} cash on hand");
        }

        protected override void OnInitialMonth()
        {
            _insurancePerMonth = Simulation.RentersInsurancePerMonth;
            _rentPerMonth = Simulation.RentPerMonth;
            Report.AddNote(WriteLine($"* {_rentPerMonth:C0} initial rent"));

            InitialCash =
                Simulation.OwnerDownPayment +
                Simulation.BuyerFixedCosts +
                Simulation.OwnerLoanAmount *
                Simulation.BuyerVariableCostsPercentage;

            Report.AddNote(WriteLine($"* {InitialCash:C0} starting cash"));
            VerboseLine($"    * {Simulation.OwnerDownPayment:C0} down payment +  + )");
            VerboseLine($"    * {Simulation.BuyerFixedCosts:C0} fixed closing costs");
            VerboseLine($"    * {Simulation.OwnerLoanAmount * Simulation.BuyerVariableCostsPercentage:C0} variable closing costs");

            _securityDeposit = (Simulation.RentSecurityDepositMonths * Simulation.RentPerMonth).ToDollars();
            Report.AddNote(WriteLine($"* {_securityDeposit:C0} security deposit"));
            _invested = Math.Max(0, InitialCash - _securityDeposit);
            _basis = _invested;
            Report.AddNote(WriteLine($"* {_invested:C0} invested @ {Simulation.DiscountRatePerYear:P2}"));

            Report.DiscountRatePerYear = Simulation.DiscountRatePerYear;
            WriteLine($"* {Report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(Report.DiscountRatePerYear):P6} monthly discount rate");
            Report.Add(new RenterData
            {
                CashFlow = -InitialCash,
            });
        }

        protected override RenterData OnProcess()
        {
            var data = new RenterData
            {
                Rent = _rentPerMonth,
                CashFlow = -_rentPerMonth,
            };
            WriteLine($"* {_rentPerMonth:C0} rent");

            if (_insurancePerMonth > 0)
            {
                data.Insurance += _insurancePerMonth;
                data.CashFlow -= data.Insurance;
                WriteLine($"* {_insurancePerMonth:C0} renter's insurance");
            }

            var growth = (_invested * Simulation.DiscountRatePerYear / 12).ToDollarCents();
            _invested += growth;
            WriteLine($"* Investment of {_invested:C0} grew by {growth:C0} ({Simulation.DiscountRatePerYear / 12:P2})");

            return data;
        }
    }
}
