using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using RentVsOwn.Financial;
using RentVsOwn.Output;

namespace RentVsOwn
{
    public sealed class Owner : IEntity
    {
        private sealed class Monthly
        {
            public decimal Total { get; set; }

            public decimal Expenses { get; set; }

            public decimal Principal { get; set; }

            public decimal Interest { get; set; }

            public decimal NpvCashFlow { get; set; }

            public decimal HomeValue { get; set; }
        }

        private string Name => nameof(Owner);

        private decimal _netWorth;

        private decimal _initialInvestment;

        private decimal _cash;

        private decimal _totalSpent;

        private decimal _averageSpent;

        private double? _npv;

        private double? _irr;

        private List<double> _cashFlows = new List<double>();

        private List<Monthly> _months = new List<Monthly>();

        private void Finalize(Monthly monthly, Simulation simulation, IOutput output)
        {
            var homeValue = simulation.OwnerHomeValue;
            output.WriteLine($"* Sold home for {homeValue:C0}");
            var salesFixedCosts = simulation.SalesFixedCosts;
            var salesCommission = (simulation.SalesCommissionPercentage * homeValue).ToDollars();
            output.WriteLine($"* Fixed sales costs of {salesFixedCosts:C0} and commission of {salesCommission:C0}");
            var proceeds = homeValue - salesFixedCosts - salesCommission;
            if (simulation.OwnerLoanBalance > 0)
            {
                output.WriteLine($"* Paid off loan balance of {simulation.OwnerLoanBalance:C0}");
                proceeds -= simulation.OwnerLoanBalance;
                simulation.OwnerLoanBalance = 0;
            }

            simulation.OwnerHomeValue = 0;

            output.WriteLine($"* Home sale proceeds of {proceeds:C0}");
            _cash += proceeds;
            _cash = _cash.ToDollars();

            // Add in this very last cash flow
            _cashFlows[_cashFlows.Count - 1] += (double)proceeds;
            output.WriteLine($"* Adjusted NPV cash flow of {_cashFlows[_cashFlows.Count - 1]:C0} accounting for sale proceeds of {proceeds:C0}");
            monthly.NpvCashFlow = (decimal)_cashFlows[_cashFlows.Count - 1];

            _npv = Npv.Calculate((double)_initialInvestment, _cashFlows, (double)simulation.DiscountRate / 12);
            output.WriteLine($"* Net present value of {_npv:C0}");
            _irr = Irr.Calculate((double)_initialInvestment, _cashFlows, (double)simulation.DiscountRate / 12) * 12;
            output.WriteLine($"* Internal rate of return of {_irr:P2}");
            Debug.Assert(Math.Abs(Npv.Calculate((double)_initialInvestment, _cashFlows, (double)_irr / 12)) < .1);
        }

        private void Initialize(Simulation simulation, IOutput output)
        {
            _initialInvestment = 0;
            _cash = 0;
            _totalSpent = 0;
            _averageSpent = 0;
            _cashFlows = new List<double>();
            _months = new List<Monthly>();
            _npv = null;
            _irr = null;

            output.WriteLine($"* Down payment of {simulation.OwnerDownPayment:C0}");
            _initialInvestment += simulation.OwnerDownPayment;
            output.WriteLine($"* Fixed closing costs of {simulation.ClosingFixedCosts:C0}");
            _initialInvestment += simulation.ClosingFixedCosts;
            var variableClosingCosts = simulation.OwnerLoanAmount * simulation.ClosingVariableCostsPercentage;
            output.WriteLine($"* Variable closing costs of {variableClosingCosts:C0}");
            _initialInvestment += variableClosingCosts;
            output.WriteLine($"* Total initial investment of {_initialInvestment:C0}");
            output.WriteLine($"* Initial loan balance of {simulation.OwnerLoanBalance:C0}");
        }

        /// <inheritdoc />
        public string GenerateReport()
        {
            var text = new StringBuilder();
            text.AppendLine("Month,Cash Flow,Total,Expenses,Principal,Interest,Home Value");
            text.AppendLine($"0,\"{-_initialInvestment:C0}\"");
            var which = 1;
            foreach (var month in _months)
            {
                text.AppendLine($"\"{which++:N0}\",\"{month.NpvCashFlow:C0}\",\"{month.Total:C0}\",\"{month.Expenses:C0}\",\"{month.Principal:C0}\",\"{month.Interest:C0}\",\"{month.HomeValue:C0}\"");
            }

            return text.ToString().TrimEnd();
        }

        private Monthly Process(Simulation simulation, IOutput output)
        {
            var monthly = new Monthly
            {
                Principal = 0m,
                Expenses = 0m,
                Interest = 0m,
                NpvCashFlow = 0m,
                Total = 0m,
                HomeValue = simulation.OwnerHomeValue,
            };
            var expense = 0m;
            if (simulation.OwnerLoanBalance > 0)
            {
                var loanPayment = simulation.OwnerMonthlyPayment;
                monthly.Total = loanPayment;
                monthly.Interest = (simulation.OwnerLoanBalance * simulation.OwnerInterestRate / 12).ToDollars();
                monthly.Principal = Math.Min(loanPayment - monthly.Interest, simulation.OwnerLoanBalance).ToDollars();

                expense += monthly.Principal + monthly.Interest;
                output.WriteLine($"* Loan payment of {loanPayment:C0} ({monthly.Principal:C0} principal / {monthly.Interest:C0} interest)");

                simulation.OwnerLoanBalance -= monthly.Principal;
                output.WriteLine($"* New loan balance of {simulation.OwnerLoanBalance:C0}");
            }

            var propertyTax = (simulation.OwnerHomeValue * simulation.PropertyTaxPercentage / 12).ToDollars();
            expense += propertyTax;
            output.WriteLine($"* Spent {propertyTax:C0} on property tax");
            if (simulation.InsurancePerMonth > 0)
            {
                expense += simulation.InsurancePerMonth;
                monthly.Expenses += simulation.InsurancePerMonth;
                output.WriteLine($"* Spent {simulation.InsurancePerMonth:C0} on insurance");
            }

            if (simulation.HoaPerMonth > 0)
            {
                expense += simulation.HoaPerMonth;
                monthly.Expenses += simulation.HoaPerMonth;
                output.WriteLine($"* Spent {simulation.HoaPerMonth:C0} on HOA");
            }

            var homeMaintenance = (simulation.OwnerHomeValue * simulation.HomeMaintenancePercentagePerYear / 12).ToDollars();
            expense += homeMaintenance;
            monthly.Expenses += homeMaintenance;
            output.WriteLine($"* Spent {homeMaintenance:C0} on home maintenance");

            output.WriteLine($"* Total expense this month {expense:C0}");
            _totalSpent += expense;

            _months.Add(monthly);

            // monthly.PersonalLoan could be positive or negative depending on whether we took out loan or repaid one.
            // Essentially, the personal loan causes us to defer cash flow (for NPV/IRR) until we actually payback the loan.
            var cashFlow = monthly.NpvCashFlow;
            _cashFlows.Add((double)monthly.NpvCashFlow);
            output.WriteLine($"* NPV cash flow of {cashFlow:C0}");

            return monthly;
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
            var monthly = Process(simulation, output);
            if (simulation.IsFinal)
                Finalize(monthly, simulation, output);

            _netWorth = _cash + simulation.OwnerHomeValue - simulation.OwnerLoanBalance;
            _averageSpent = (_totalSpent / simulation.Months).ToDollars();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine($"{Name} spent {_totalSpent:C0} (average of {_averageSpent:C0} / month) and has net worth of {_netWorth:C0} on initial investment of {_initialInvestment:C0}");
            if (_npv.HasValue)
                text.AppendLine($"Net present value of {_npv:C0}");
            if (_irr.HasValue)
                text.AppendLine($"Internal rate of return of {_irr:P2}");
            return text.ToString().TrimEnd();
        }
    }
}
