using System;
using System.Text;

namespace RentVsOwn
{
    public sealed class Owner : IPerson
    {
        /// <inheritdoc />
        public string Name => nameof(Owner);

        /// <inheritdoc />
        public decimal NetWorth { get; private set; }

        private decimal _initialInvestment;

        private decimal _cash;

        private decimal _spent;

        private decimal _averageSpent;

        private void Finalize(Simulation simulation, IOutput output)
        {
            var homeValue = simulation.OwnerHomeValue;
            output.WriteLine($"Sold home for {homeValue:C0}");
            var salesFixedCosts = simulation.SalesFixedCosts;
            var salesCommission = simulation.SalesCommissionPercentage * homeValue;
            output.WriteLine($"Fixed sales costs of {salesFixedCosts:C0} and commission of {salesCommission:C0}");
            var proceeds = homeValue - salesFixedCosts - salesCommission;
            output.WriteLine($"Paid of loan balance of {simulation.OwnerLoanBalance:C0}");
            proceeds -= simulation.OwnerLoanBalance ;
            simulation.OwnerLoanBalance = 0;
            simulation.OwnerHomeValue = 0;

            output.WriteLine($"Home sale proceeds of {proceeds:C0}");
            _cash += proceeds;
            _cash = _cash.ToDollars();
        }

        private void Initialize(Simulation simulation, IOutput output)
        {
            _initialInvestment = 0;
            _cash = 0;
            _spent = 0;
            _averageSpent = 0;

            output.WriteLine($"Down payment of {simulation.OwnerDownPayment:C0}");
            _initialInvestment += simulation.OwnerDownPayment;
            output.WriteLine($"Fixed closing costs of {simulation.ClosingFixedCosts:C0}");
            _initialInvestment += simulation.ClosingFixedCosts;
            var variableClosingCosts = simulation.OwnerLoanAmount * simulation.ClosingVariableCostsPercentage;
            output.WriteLine($"Variable closing costs of {variableClosingCosts:C0}");
            _initialInvestment += variableClosingCosts;
            output.WriteLine($"Total initial investment of {_initialInvestment:C0}");
            output.WriteLine($"Initial loan balance of {simulation.OwnerLoanBalance:C0}");
        }

        private void Process(Simulation simulation, IOutput output)
        {
            var loanPayment = simulation.OwnerMonthlyPayment;
            _spent += loanPayment;
            var interest = (simulation.OwnerLoanBalance * simulation.OwnerInterestRate / 12).ToDollars();
            var principal = (loanPayment - interest).ToDollars();
            output.WriteLine($"Loan payment of {loanPayment:C0} ({principal:C0} principal / {interest:C0} interest)");

            simulation.OwnerLoanBalance -= principal;
            output.WriteLine($"New loan balance of {simulation.OwnerLoanBalance:C0}");

            var propertyTax = (simulation.OwnerHomeValue * simulation.PropertyTaxPercentage / 12).ToDollars();
            _spent += propertyTax;
            output.WriteLine($"Spent {propertyTax:C0} on property tax");
            if (simulation.InsurancePerMonth > 0)
            {
                _spent += simulation.InsurancePerMonth;
                output.WriteLine($"Spent {simulation.InsurancePerMonth:C0} on insurance");
            }

            if (simulation.HoaPerMonth > 0)
            {
                _spent += simulation.HoaPerMonth;
                output.WriteLine($"Spent {simulation.HoaPerMonth:C0} on HOA");
            }

            var homeMaintenance = (simulation.OwnerHomeValue * simulation.HomeMaintenancePercentagePerYear / 12).ToDollars();
            _spent += homeMaintenance;
            output.WriteLine($"Spent {homeMaintenance:C0} on home maintenance");

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
            NetWorth = _cash + simulation.OwnerHomeValue - simulation.OwnerLoanBalance;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine($"{Name} has spent {_spent:C0} (average of {_averageSpent:C0} / month) and has a net worth of {NetWorth:C0} on an initial investment of {_initialInvestment:C0}");
            return text.ToString().TrimEnd();
        }
    }
}
