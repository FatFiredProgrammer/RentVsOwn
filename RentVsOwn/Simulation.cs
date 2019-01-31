using System;
using System.Text;

namespace RentVsOwn
{
    public sealed class Simulation
    {
        public Simulation(Simulator simulator)
        {
            if (simulator == null)
                throw new ArgumentNullException(nameof(simulator));

            Name = simulator.Name ?? "Default Name";
            Months = Math.Max(1, (int)Math.Round(simulator.Years * 12, 0));
            HomePurchaseAmount = Math.Max(1m, simulator.HomePurchaseAmount).ToDollars();
            OwnerDownPaymentPercentage = Math.Min(Math.Max(0m, simulator.OwnerDownPaymentPercentage), 100).ToPercent();
            OwnerDownPayment = (HomePurchaseAmount * OwnerDownPaymentPercentage).ToDollars();
            OwnerInterestRate = Math.Max(.0001m, simulator.OwnerInterestRate).ToPercent();
            OwnerInterestRate = Math.Min(Math.Max(0m, simulator.OwnerInterestRate), 100).ToPercent();
            OwnerLoanAmount = HomePurchaseAmount - OwnerDownPayment;
            OwnerLoanYears = Math.Max(1, simulator.OwnerLoanYears);
            OwnerMonthlyPayment = PaymentCalculator.CalculatePayment(OwnerLoanAmount, OwnerInterestRate, OwnerLoanYears);
            RentChangePerYearPercentage = Math.Min(Math.Max(0m, simulator.RentChangePerYearPercentage), 100).ToPercent();
            Rent = Math.Max(1m, simulator.Rent).ToDollars();
            DiscountRate = Math.Min(Math.Max(0m, simulator.DiscountRate), 100).ToPercent();
            CapitalGainsRate = Math.Min(Math.Max(0m, simulator.CapitalGainsRate), 100).ToPercent();
            MarginalTaxRate = Math.Min(Math.Max(0m, simulator.MarginalTaxRate), 100).ToPercent();
        }

        public string Name { get; }

        public int Month { get; private set; } = 1;

        public int Months { get; }

        public bool IsInitial => Month == 1;

        public bool IsFinal => Month == Months;

        public bool IsNewYear => Month != 1 && ((Month - 1) % 12) == 0;

        public bool IsYearEnd => ((Month - 1) % 12) == 11;

        public decimal HomePurchaseAmount { get; }

        public decimal OwnerInterestRate { get; }

        public int OwnerLoanYears { get; }

        public decimal OwnerDownPaymentPercentage { get; }

        public decimal OwnerDownPayment { get; }

        public decimal OwnerLoanAmount { get; }

        public decimal OwnerMonthlyPayment { get; }

        public decimal RentChangePerYearPercentage { get; }

        public decimal Rent { get; private set; }

        public decimal DiscountRate { get; }

        public decimal CapitalGainsRate { get; }

        /// <summary>
        /// Gets or sets the marginal tax rate.
        /// </summary>
        /// <value>The marginal tax rate.</value>
        public decimal MarginalTaxRate { get; }


        public bool Next(IOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            if (Month >= Months)
                return false;

            ++Month;
            if (IsNewYear)
                NextYear(output);

            return true;
        }

        private void NextYear(IOutput output)
        {
            output.WriteLine(Simulator.Separator);
            output.WriteLine($"Year # {Month / 12}");
            if (RentChangePerYearPercentage > 0)
            {
                Rent += (Rent * RentChangePerYearPercentage).ToDollars();
                output.WriteLine($"Rent increased {RentChangePerYearPercentage:P2} to {Rent:C0}");
            }
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine($"|{Name}||");
            text.AppendLine("| --- | --: |");
            return text.ToString().TrimEnd();
        }
    }
}
