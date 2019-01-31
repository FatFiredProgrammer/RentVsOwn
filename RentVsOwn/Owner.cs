using System;
using System.Text;

namespace RentVsOwn
{
    public sealed class Owner : IPerson
    {
        /// <inheritdoc />
        public string Name => nameof(Owner);

        /// <inheritdoc />
        public decimal NetWorth => _invested + _cash;

        private decimal _basis;

        private decimal _invested;

        private decimal _cash;

        private decimal _spent;
        private decimal _averageSpent;

        private decimal _securityDeposit;

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

            output.WriteLine($"Cashed out investment of {_invested:C0}");
            _cash += _invested;
            _invested = 0;
            output.WriteLine($"Returned security deposit of {_securityDeposit:C0}");
            _cash += _securityDeposit;
        }

        private void Initialize(Simulation simulation, IOutput output)
        {
            var initialCash = simulation.OwnerDownPayment + simulation.ClosingFixedCosts + simulation.OwnerLoanAmount + simulation.ClosingVariableCostsPercentage;

            _cash = 0;
            _spent = 0;
            _averageSpent = 0;
            _securityDeposit = (simulation.RentSecurityDepositMonths * simulation.Rent).ToDollars();
            output.WriteLine($"Security deposit of {_securityDeposit:C0}");
            _basis = Math.Max(0, initialCash - _securityDeposit);
            _invested = _basis;
            output.WriteLine($"Invested  {_invested:C0}");
        }

        private void Process(Simulation simulation, IOutput output)
        {
            var growth = (_invested * simulation.DiscountRate / 12).ToDollarCents();
            _invested += growth;
            output.WriteLine($"Investment grew by {growth:C0}");
            _spent += simulation.Rent;
            output.WriteLine($"Spent {simulation.Rent:C0} on rent");
            if (simulation.RentersInsurancePerMonth > 0)
            {
                _spent += simulation.RentersInsurancePerMonth;
                output.WriteLine($"Spent {simulation.Rent:C0} on renters insurance");
            }
            _averageSpent = (_spent / simulation.Months).ToDollars();
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
            text.AppendLine($"{Name} has spent {_spent:C0} (average of {_averageSpent:C0} / month) and has a net worth of {NetWorth:C0} on an initial investment of {_basis:C0}");
            return text.ToString().TrimEnd();
        }
    }
}
// TODO: Code needs work
#if false
        public decimal HomePurchaseAmount { get; }
        public decimal OwnerInterestRate { get; }
        public int OwnerLoanYears { get; }
        public decimal OwnerDownPaymentPercentage { get; }
        public decimal OwnerDownPayment { get; }
        public decimal OwnerLoanAmount { get; }
        public decimal OwnerMonthlyPayment { get; }
        public decimal DiscountRate { get; }
        public decimal CapitalGainsRate { get; }
        public decimal MarginalTaxRate { get; }
        public decimal LandlordInterestRate { get; }
        public int LandlordLoanYears { get; }
        public decimal LandlordDownPaymentPercentage { get; }
        public decimal LandlordDownPayment { get; }
        public decimal LandlordLoanAmount { get; }
        public decimal LandlordMonthlyPayment { get; }
        public decimal ClosingFixedCosts { get; }
        public decimal ClosingVariableCostsPercentage { get; }
        public decimal PropertyTaxPercentage { get; }
        public decimal InsurancePerMonth { get; }
        public decimal HoaPerMonth { get; }
        public decimal HomeAppreciationPercentagePerYear { get; }
        public decimal HomeMaintenancePercentagePerYear { get; }
        public decimal SalesCommissionPercentage { get; }
        public decimal SalesFixedCosts { get; }
        public decimal DepreciationYears { get; }
        public decimal InflationRate { get; set; } = .02m;

#endif
