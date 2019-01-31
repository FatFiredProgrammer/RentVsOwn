using System;
using System.Text;

namespace RentVsOwn
{
    public sealed class Renter : IPerson
    {
        /// <inheritdoc />
        public string Name => nameof(Renter);

        /// <inheritdoc />
        public decimal NetWorth => _invested + _cash;

        private decimal _basis;

        private decimal _invested;

        private decimal _cash;

        private decimal _spent;

        private void Finalize(Simulation simulation, IOutput output)
        {
            var capitalGains = (_invested - _basis).ToDollars();
            output.WriteLine($"Capital gains of {capitalGains:C0}");
            if (capitalGains > 0)
            {
                var capitalGainsTax = (simulation.CapitalGainsRate * capitalGains).ToDollars();
                output.WriteLine($"Capital gains tax of {capitalGainsTax:C0}");
                _cash -= capitalGainsTax;
            }

            _cash += _invested;
            _invested = 0;
        }

        private void Initialize(Simulation simulation, IOutput output)
        {
            _cash = 0;
            _spent = 0;
            _basis = simulation.OwnerDownPayment;
            _invested = _basis;
            output.WriteLine($"Invested down payment of {_invested:C0}");
        }

        private void Process(Simulation simulation, IOutput output)
        {
            var growth = (_invested * simulation.DiscountRate / 12).ToDollarCents();
            _invested += growth;
            output.WriteLine($"Investment grew by {growth:C0}");
            _spent += simulation.Rent;
            output.WriteLine($"Spent {simulation.Rent:C0} on rent");
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
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine($"{Name} has spent {_spent:C0} and has a net worth of {NetWorth:C0} on an initial investment of {_basis:C0}");
            return text.ToString().TrimEnd();
        }
    }
}
