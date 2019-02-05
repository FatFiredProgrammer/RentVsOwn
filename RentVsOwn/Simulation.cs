using System;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

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

            RentChangePerYearPercentage = Math.Min(Math.Max(0m, simulator.RentChangePerYearPercentage ?? HomeAppreciationPercentagePerYear), 100).ToPercent();
            var defaultRent =
                OwnerMonthlyPayment +
                InsurancePerMonth +
                HoaPerMonth +
                HomePurchaseAmount * PropertyTaxPercentage / 12 +
                HomePurchaseAmount * HomeMaintenancePercentagePerYear / 12;
            Rent = Math.Max(1m, simulator.Rent ?? defaultRent).ToDollars();
            RentersInsurancePerMonth = Math.Max(0m, simulator.RentersInsurancePerMonth).ToDollarCents();
            RentSecurityDepositMonths = Math.Max(0, simulator.RentSecurityDepositMonths);
        }

        [ReportColumn("Name of Simulation", Format = ReportColumnFormat.Text)]
        public string Name { get; }

        [ReportColumn("Simulation Years", Format = ReportColumnFormat.Number, Precision = 1)]
        public decimal Years { get; }

        [ReportColumn("Simulation Months", Format = ReportColumnFormat.Number, Precision = 0)]
        public int Months => Math.Max(1, (int)Math.Round(Years * 12, 0));

        /// <summary>
        /// Gets the current month.
        /// </summary>
        /// <value>The month.</value>
        [ReportColumn(Ignore = true)]
        public int Month { get; private set; } = 1;

        [ReportColumn(Ignore = true)]
        public bool IsInitial => Month == 1;

        [ReportColumn(Ignore = true)]
        public bool IsFinal => Month == Months;

        [ReportColumn(Ignore = true)]
        public bool IsNewYear => Month != 1 && (Month - 1) % 12 == 0;

        [ReportColumn("Home Purchase Amount", Format = ReportColumnFormat.Currency, Precision = 0)]
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
            => new Report<Simulation>(this).ToString().TrimEnd();
    }
}
