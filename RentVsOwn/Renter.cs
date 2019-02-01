using System;
using System.Text;

namespace RentVsOwn
{
    public sealed class Renter : IPerson
    {
        /// <inheritdoc />
        public string Name => nameof(Renter);

        /// <inheritdoc />
        public decimal NetWorth => _invested + _cash + _securityDeposit;

        private decimal _basis;

        private decimal _invested;

        private decimal _cash;

        private decimal _totalSpent;

        private decimal _averageSpent;

        private decimal _initialSecurityDeposit;

        private decimal _securityDeposit;

        private void Finalize(Simulation simulation, IOutput output)
        {
            var capitalGains = (_invested - _basis).ToDollars();
            output.WriteLine($"* Capital gains of {capitalGains:C0} on initial investment of {_basis:C0}");
            if (capitalGains > 0)
            {
                var capitalGainsTax = (simulation.CapitalGainsRate * capitalGains).ToDollars();
                output.WriteLine($"* Capital gains tax of {capitalGainsTax:C0}");
                _cash -= capitalGainsTax;
            }

            output.WriteLine($"* Cashed out investment of {_invested:C0}");
            _cash += _invested;
            _invested = 0;
            output.WriteLine($"* Returned security deposit of {_securityDeposit:C0}");
            _cash += _securityDeposit;
            _securityDeposit = 0;
            output.WriteLine($"* Cash on hand of {_cash:C0}");
            output.WriteLine($"* Total spent {_totalSpent:C0}");
        }

        private void Initialize(Simulation simulation, IOutput output)
        {
            var initialCash = simulation.OwnerDownPayment + simulation.ClosingFixedCosts + simulation.OwnerLoanAmount * simulation.ClosingVariableCostsPercentage;
            output.WriteLine(
                $"* Starting cash of {initialCash:C0} ({simulation.OwnerDownPayment:C0} owner down payment + {simulation.ClosingFixedCosts:C0} owner fixed closing costs + {simulation.OwnerLoanAmount * simulation.ClosingVariableCostsPercentage:C0} owner variable closing costs)");

            _cash = 0;
            _totalSpent = 0;
            _averageSpent = 0;
            _initialSecurityDeposit = (simulation.RentSecurityDepositMonths * simulation.Rent).ToDollars();
            _securityDeposit = _initialSecurityDeposit;
            output.WriteLine($"* Security deposit of {_securityDeposit:C0}");
            _basis = Math.Max(0, initialCash - _securityDeposit);
            _invested = _basis;
            output.WriteLine($"* Invested  {_invested:C0}");
        }

        /// <inheritdoc />
        public string NpvData() => string.Empty;

        private void Process(Simulation simulation, IOutput output)
        {
            var growth = (_invested * simulation.DiscountRate / 12).ToDollarCents();
            _invested += growth;
            output.WriteLine($"* Investment of {_invested:C0} grew by {growth:C0} ({simulation.DiscountRate / 12:P2})");

            _totalSpent += simulation.Rent;
            output.WriteLine($"* Spent {simulation.Rent:C0} on rent");

            if (simulation.RentersInsurancePerMonth > 0)
            {
                _totalSpent += simulation.RentersInsurancePerMonth;
                output.WriteLine($"* Spent {simulation.RentersInsurancePerMonth:C0} on renters insurance");
            }
        }

        /// <inheritdoc />
        public void Simulate(Simulation simulation, IOutput output)
        {
            if (simulation == null)
                throw new ArgumentNullException(nameof(simulation));
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            output.WriteLine($"{Name} in month # {simulation.Month}{Environment.NewLine}");

            if (simulation.IsInitial)
                Initialize(simulation, output);
            Process(simulation, output);
            if (simulation.IsFinal)
                Finalize(simulation, output);

            _averageSpent = (_totalSpent / simulation.Months).ToDollars();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(
                $"{Name} spent {_totalSpent:C0} (average of {_averageSpent:C0} / month) and has net worth of {NetWorth:C0} on initial investment of {_basis:C0} + security deposit of {_initialSecurityDeposit:C0}");
            return text.ToString().TrimEnd();
        }
    }
}
