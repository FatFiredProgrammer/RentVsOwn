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
            Years = Math.Max(1, simulator.Years);

            HomePurchaseAmount = Math.Max(1m, simulator.HomePurchaseAmount).ToDollars();

            OwnerHomeValue = HomePurchaseAmount;
            OwnerDownPaymentPercentage = Math.Min(Math.Max(0m, simulator.OwnerDownPaymentPercentage), 100).ToPercent();
            OwnerDownPayment = (HomePurchaseAmount * OwnerDownPaymentPercentage).ToDollars();
            OwnerInterestRate = Math.Min(Math.Max(0m, simulator.OwnerInterestRate), 100).ToPercent();
            OwnerLoanAmount = HomePurchaseAmount - OwnerDownPayment;
            OwnerLoanBalance = OwnerLoanAmount;
            OwnerLoanYears = Math.Max(1, simulator.OwnerLoanYears);
            OwnerMonthlyPayment = PaymentCalculator.CalculatePayment(OwnerLoanAmount, OwnerInterestRate, OwnerLoanYears);

            LandlordHomeValue = HomePurchaseAmount;
            LandlordDownPaymentPercentage = simulator.LandlordDownPaymentPercentage ?? simulator.OwnerDownPaymentPercentage;
            LandlordDownPaymentPercentage = Math.Min(Math.Max(0m, LandlordDownPaymentPercentage), 100).ToPercent();
            LandlordDownPayment = (HomePurchaseAmount * LandlordDownPaymentPercentage).ToDollars();
            LandlordInterestRate = simulator.LandlordInterestRate ?? simulator.OwnerInterestRate;
            LandlordInterestRate = Math.Min(Math.Max(0m, LandlordInterestRate), 100).ToPercent();
            LandlordManagementFeePercentage = Math.Min(Math.Max(0m, simulator.LandlordManagementFeePercentage), 100).ToPercent();
            LandlordLoanAmount = HomePurchaseAmount - LandlordDownPayment;
            LandlordLoanBalance = LandlordLoanAmount;
            LandlordLoanYears = Math.Max(1, simulator.LandlordLoanYears ?? OwnerLoanYears);
            LandlordMonthlyPayment = PaymentCalculator.CalculatePayment(LandlordLoanAmount, LandlordInterestRate, LandlordLoanYears);

            RentChangePerYearPercentage = Math.Min(Math.Max(0m, simulator.RentChangePerYearPercentage), 100).ToPercent();
            Rent = Math.Max(1m, simulator.Rent).ToDollars();
            RentersInsurancePerMonth = Math.Max(0m, simulator.RentersInsurancePerMonth).ToDollarCents();
            RentSecurityDepositMonths = Math.Max(0, simulator.RentSecurityDepositMonths);

            DiscountRate = Math.Min(Math.Max(0m, simulator.DiscountRate), 100).ToPercent();
            CapitalGainsRate = Math.Min(Math.Max(0m, simulator.CapitalGainsRate), 100).ToPercent();
            MarginalTaxRate = Math.Min(Math.Max(0m, simulator.MarginalTaxRate), 100).ToPercent();
            InflationRate = Math.Min(Math.Max(0m, simulator.InflationRate), 100).ToPercent();

            ClosingFixedCosts = Math.Max(0m, simulator.ClosingFixedCosts).ToDollars();
            ClosingVariableCostsPercentage = Math.Min(Math.Max(0m, simulator.ClosingVariableCostsPercentage), 100).ToPercent();
            PropertyTaxPercentage = Math.Min(Math.Max(0m, simulator.PropertyTaxPercentage), 100).ToPercent();
            InsurancePerMonth = Math.Max(0m, simulator.InsurancePerMonth).ToDollarCents();
            HoaPerMonth = Math.Max(0m, simulator.HoaPerMonth).ToDollarCents();
            HomeAppreciationPercentagePerYear = Math.Min(Math.Max(0m, simulator.HomeAppreciationPercentagePerYear), 100).ToPercent();
            HomeMaintenancePercentagePerYear = Math.Min(Math.Max(0m, simulator.HomeMaintenancePercentagePerYear), 100).ToPercent();
            SalesCommissionPercentage = Math.Min(Math.Max(0m, simulator.SalesCommissionPercentage), 100).ToPercent();
            SalesFixedCosts = Math.Max(0m, simulator.SalesFixedCosts).ToDollars();
            DepreciationYears = Math.Max(1, simulator.DepreciationYears).ToValue();
            DepreciablePercentage = Math.Min(Math.Max(0m, simulator.DepreciablePercentage), 100).ToPercent();
        }

        public string Name { get; }

        public decimal Years { get; }

        public int Months => Math.Max(1, (int)Math.Round(Years * 12, 0));

        public int Month { get; private set; } = 1;

        public bool IsInitial => Month == 1;

        public bool IsFinal => Month == Months;

        public bool IsNewYear => Month != 1 && ((Month - 1) % 12) == 0;

        public decimal HomePurchaseAmount { get; }

        public decimal OwnerHomeValue { get; set; }

        public decimal OwnerInterestRate { get; }

        public int OwnerLoanYears { get; }

        public decimal OwnerDownPaymentPercentage { get; }

        public decimal OwnerDownPayment { get; }

        public decimal OwnerLoanAmount { get; }

        public decimal OwnerLoanBalance { get; set; }

        public decimal OwnerMonthlyPayment { get; }

        public decimal RentChangePerYearPercentage { get; }

        public decimal Rent { get; private set; }

        public int RentSecurityDepositMonths { get; }

        public decimal RentersInsurancePerMonth { get; private set; }

        public decimal DiscountRate { get; }

        public decimal CapitalGainsRate { get; }

        public decimal MarginalTaxRate { get; }

        public decimal LandlordHomeValue { get; set; }

        public decimal LandlordInterestRate { get; }

        public int LandlordLoanYears { get; }

        public decimal LandlordDownPaymentPercentage { get; }

        public decimal LandlordDownPayment { get; }

        public decimal LandlordLoanAmount { get; }

        public decimal LandlordLoanBalance { get; set; }

        public decimal LandlordMonthlyPayment { get; }

        public decimal LandlordManagementFeePercentage { get; }

        public decimal ClosingFixedCosts { get; }

        public decimal ClosingVariableCostsPercentage { get; }

        public decimal PropertyTaxPercentage { get; }

        public decimal InsurancePerMonth { get; private set; }

        public decimal HoaPerMonth { get; private set; }

        public decimal HomeAppreciationPercentagePerYear { get; }

        public decimal HomeMaintenancePercentagePerYear { get; }

        public decimal SalesCommissionPercentage { get; }

        public decimal SalesFixedCosts { get; }

        public decimal DepreciationYears { get; }

        public decimal DepreciablePercentage { get; }

        public decimal InflationRate { get; }

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
            output.WriteLine($"Year # {Month / 12}{Environment.NewLine}");
            if (RentChangePerYearPercentage > 0)
            {
                Rent = (Rent + Rent * RentChangePerYearPercentage).ToDollars();
                output.WriteLine($"* Rent increased {RentChangePerYearPercentage:P2} to {Rent:C0}");
            }

            if (HomeAppreciationPercentagePerYear > 0)
            {
                OwnerHomeValue = (OwnerHomeValue + OwnerHomeValue * HomeAppreciationPercentagePerYear).ToDollars();
                output.WriteLine($"* Owner Home value increased {HomeAppreciationPercentagePerYear:P2} to {OwnerHomeValue:C0}");
                LandlordHomeValue = (LandlordHomeValue + LandlordHomeValue * HomeAppreciationPercentagePerYear).ToDollars();
                output.WriteLine($"* Landlord Home value increased {HomeAppreciationPercentagePerYear:P2} to {LandlordHomeValue:C0}");
            }

            if (InflationRate > 0)
            {
                RentersInsurancePerMonth = (RentersInsurancePerMonth + RentersInsurancePerMonth * InflationRate).ToDollarCents();
                output.WriteLine($"* Renters insurance increased {InflationRate:P2} to {RentersInsurancePerMonth:C2}");
                InsurancePerMonth = (InsurancePerMonth + InsurancePerMonth * InflationRate).ToDollarCents();
                output.WriteLine($"* Home owner's insurance increased {InflationRate:P2} to {InsurancePerMonth:C2}");
                HoaPerMonth = (HoaPerMonth + HoaPerMonth * InflationRate).ToDollarCents();
                output.WriteLine($"* HOA increased {InflationRate:P2} to {HoaPerMonth:C2}");
            }
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine($"|{Name}||");
            text.AppendLine("| --- | --: |");
            text.AppendLine($"|{nameof(Years)}|{Years:N2}|");
            text.AppendLine($"|{nameof(Months)}|{Months:N0}|");
            text.AppendLine($"|{nameof(HomePurchaseAmount)}|{HomePurchaseAmount:C0}|");

            text.AppendLine($"|{nameof(OwnerInterestRate)}|{OwnerInterestRate:P2}|");
            text.AppendLine($"|{nameof(OwnerLoanYears)}|{OwnerLoanYears:N0}|");
            text.AppendLine($"|{nameof(OwnerDownPaymentPercentage)}|{OwnerDownPaymentPercentage:P2}|");
            text.AppendLine($"|{nameof(OwnerDownPayment)}|{OwnerDownPayment:C0}|");
            text.AppendLine($"|{nameof(OwnerLoanAmount)}|{OwnerLoanAmount:C0}|");
            text.AppendLine($"|{nameof(OwnerHomeValue)}|{OwnerHomeValue:C0}|");
            text.AppendLine($"|{nameof(OwnerLoanBalance)}|{OwnerLoanBalance:C0}|");
            text.AppendLine($"|{nameof(OwnerMonthlyPayment)}|{OwnerMonthlyPayment:C0}|");

            text.AppendLine($"|{nameof(RentChangePerYearPercentage)}|{RentChangePerYearPercentage:P2}|");
            text.AppendLine($"|{nameof(Rent)}|{Rent:C0}|");
            text.AppendLine($"|{nameof(RentSecurityDepositMonths)}|{RentSecurityDepositMonths:N0}|");
            text.AppendLine($"|{nameof(RentersInsurancePerMonth)}|{RentersInsurancePerMonth:C0}|");

            text.AppendLine($"|{nameof(LandlordInterestRate)}|{LandlordInterestRate:P2}|");
            text.AppendLine($"|{nameof(LandlordLoanYears)}|{LandlordLoanYears:N0}|");
            text.AppendLine($"|{nameof(LandlordDownPaymentPercentage)}|{LandlordDownPaymentPercentage:P2}|");
            text.AppendLine($"|{nameof(LandlordDownPayment)}|{LandlordDownPayment:C0}|");
            text.AppendLine($"|{nameof(LandlordLoanAmount)}|{LandlordLoanAmount:C0}|");
            text.AppendLine($"|{nameof(LandlordHomeValue)}|{LandlordHomeValue:C0}|");
            text.AppendLine($"|{nameof(LandlordLoanBalance)}|{LandlordLoanBalance:C0}|");
            text.AppendLine($"|{nameof(LandlordMonthlyPayment)}|{LandlordMonthlyPayment:C0}|");
            text.AppendLine($"|{nameof(LandlordManagementFeePercentage)}|{LandlordManagementFeePercentage:P2}|");
            text.AppendLine($"|{nameof(DepreciationYears)}|{DepreciationYears:N2}|");
            text.AppendLine($"|{nameof(DepreciablePercentage)}|{DepreciablePercentage:P2}|");

            text.AppendLine($"|{nameof(ClosingFixedCosts)}|{ClosingFixedCosts:C0}|");
            text.AppendLine($"|{nameof(ClosingVariableCostsPercentage)}|{ClosingVariableCostsPercentage:P2}|");

            text.AppendLine($"|{nameof(PropertyTaxPercentage)}|{PropertyTaxPercentage:P2}|");
            text.AppendLine($"|{nameof(InsurancePerMonth)}|{InsurancePerMonth:C0}|");
            text.AppendLine($"|{nameof(HoaPerMonth)}|{HoaPerMonth:C0}|");
            text.AppendLine($"|{nameof(HomeAppreciationPercentagePerYear)}|{HomeAppreciationPercentagePerYear:P2}|");
            text.AppendLine($"|{nameof(HomeMaintenancePercentagePerYear)}|{HomeMaintenancePercentagePerYear:P2}|");

            text.AppendLine($"|{nameof(SalesCommissionPercentage)}|{SalesCommissionPercentage:P2}|");
            text.AppendLine($"|{nameof(SalesFixedCosts)}|{SalesFixedCosts:C0}|");

            text.AppendLine($"|{nameof(DiscountRate)}|{DiscountRate:P2}|");
            text.AppendLine($"|{nameof(CapitalGainsRate)}|{CapitalGainsRate:P2}|");
            text.AppendLine($"|{nameof(MarginalTaxRate)}|{MarginalTaxRate:P2}|");
            text.AppendLine($"|{nameof(InflationRate)}|{InflationRate:P2}|");

            return text.ToString().TrimEnd();
        }
    }
}
