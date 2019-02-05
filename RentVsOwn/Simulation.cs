using System;
using System.Collections.Generic;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public sealed class Simulation
    {
        public const string Separator = "\r\n---\r\n";

        [ReportColumn("Name of Simulation", Format = ReportColumnFormat.Text)]
        public string Name { get; set; } = "Default Simulation";

        [ReportColumn(Format = ReportColumnFormat.Number, Precision = 1)]
        public decimal SimulationYears { get; set; } = 8.7m;

        [ReportColumn(Format = ReportColumnFormat.Number, Precision = 0)]
        public int Months => Math.Max(1, (int)Math.Round(SimulationYears * 12, 0));

        /// <summary>
        ///     Gets the current month.
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

        /// <summary>
        ///     Gets or sets the home purchase amount.
        /// </summary>
        /// <value>The home purchase amount.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency, Precision = 0)]
        public decimal HomePurchaseAmount { get; set; } = 289900;

        public decimal OwnerHomeValue { get; set; }

        /// <summary>
        ///     Gets or sets the owner interest rate.
        /// </summary>
        /// <value>The owner interest rate.</value>
        public decimal OwnerInterestRate { get; set; } = .0425m;

        /// <summary>
        ///     Gets or sets the owner loan years.
        /// </summary>
        /// <value>The owner loan years.</value>
        public int OwnerLoanYears { get; set; } = 30;

        /// <summary>
        ///     Gets or sets the owner down payment percentage.
        /// </summary>
        /// <value>The owner down payment percentage.</value>
        public decimal OwnerDownPaymentPercentage { get; set; } = .2m;

        public decimal OwnerDownPayment { get; set; }

        public decimal OwnerLoanAmount { get; set; }

        public decimal OwnerLoanBalance { get; set; }

        public decimal OwnerMonthlyPayment { get; private set; }

        [ReportColumn(Ignore = true)]
        public decimal CurrentRent { get; private set; }

        /// <summary>
        ///     Gets or sets the initial rent.
        /// </summary>
        /// <value>The initial rent.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency)]
        public decimal? InitialRent { get; set; }

        /// <summary>
        ///     Gets or sets the rent security deposit months.
        /// </summary>
        /// <value>The rent security deposit months.</value>
        public int RentSecurityDepositMonths { get; set; } = 1;

        /// <summary>
        ///     Gets or sets the renters insurance per month.
        /// </summary>
        /// <value>The renters insurance per month.</value>
        public decimal RentersInsurancePerMonth { get; set; } = 15;

        /// <summary>
        ///     Gets or sets the rent percentage change per year.
        /// </summary>
        /// <value>The rent percentage per year.</value>
        public decimal? RentChangePerYearPercentage { get; set; }

        /// <summary>
        ///     Gets or sets the discount rate.
        ///     This is the assumed rate of return for investments and also
        ///     the rate assumed in NPV calculations.
        /// </summary>
        /// <value>The discount rate.</value>
        public decimal AnnualDiscountRate { get; set; } = .08m;

        /// <summary>
        ///     Gets or sets the capital gains rate.
        /// </summary>
        /// <value>The capital gains rate.</value>
        public decimal CapitalGainsRate { get; set; } = .15m;

        /// <summary>
        ///     Gets or sets the marginal tax rate.
        /// </summary>
        /// <value>The marginal tax rate.</value>
        public decimal MarginalTaxRate { get; set; } = .24m;

        public decimal LandlordHomeValue { get; set; }

        /// <summary>
        ///     Gets or sets the owner interest rate.
        /// </summary>
        /// <value>The owner interest rate.</value>
        public decimal? LandlordInterestRate { get; set; } = .0475m;

        /// <summary>
        ///     Gets or sets the owner loan years.
        /// </summary>
        /// <value>The owner loan years.</value>
        public int? LandlordLoanYears { get; set; } = 20;

        /// <summary>
        ///     Gets or sets the owner down payment percentage.
        /// </summary>
        /// <value>The owner down payment percentage.</value>
        public decimal? LandlordDownPaymentPercentage { get; set; } = .25m;

        public decimal LandlordDownPayment { get; private set; }

        public decimal LandlordLoanAmount { get; private set; }

        public decimal LandlordLoanBalance { get; set; }

        public decimal LandlordMonthlyPayment { get; private set; }

        /// <summary>
        ///     Gets or sets the management fee percentage.
        /// </summary>
        /// <value>The management fee percentage.</value>
        public decimal LandlordManagementFeePercentage { get; set; } = .1m;

        /// <summary>
        ///     Gets or sets the closing fixed costs.
        /// </summary>
        /// <value>The closing fixed costs.</value>
        public decimal ClosingFixedCosts { get; set; } = 500m;

        /// <summary>
        ///     Gets or sets the closing variable costs percentage.
        /// </summary>
        /// <value>The closing variable costs percentage.</value>
        public decimal ClosingVariableCostsPercentage { get; set; } = .015m;

        /// <summary>
        ///     Gets or sets the property tax percentage.
        /// </summary>
        /// <value>The property tax percentage.</value>
        public decimal PropertyTaxPercentage { get; set; } = .021m;

        /// <summary>
        ///     Gets or sets the insurance per month.
        /// </summary>
        /// <value>The insurance per month.</value>
        public decimal InsurancePerMonth { get; set; } = 2000m / 12;

        /// <summary>
        ///     Gets or sets the hoa per month.
        /// </summary>
        /// <value>The hoa per month.</value>
        public decimal HoaPerMonth { get; set; } = 100;

        /// <summary>
        ///     Gets or sets the home appreciation percentage per year.
        /// </summary>
        /// <value>The home appreciation percentage per year.</value>
        public decimal HomeAppreciationPercentagePerYear { get; set; } = .037m;

        /// <summary>
        ///     Gets or sets the home maintenance percentage per year.
        /// </summary>
        /// <value>The home maintenance percentage per year.</value>
        public decimal HomeMaintenancePercentagePerYear { get; set; } = .015m;

        /// <summary>
        ///     Gets or sets the sales commission percentage.
        /// </summary>
        /// <value>The sales commission percentage.</value>
        public decimal SalesCommissionPercentage { get; set; } = .06m;

        /// <summary>
        ///     Gets or sets the sales fixed costs.
        /// </summary>
        /// <value>The sales fixed costs.</value>
        public decimal SalesFixedCosts { get; set; } = 1000m;

        /// <summary>
        ///     Gets or sets the depreciation years.
        /// </summary>
        /// <value>The depreciation years.</value>
        public decimal DepreciationYears { get; set; } = 27.5m;

        /// <summary>
        ///     Gets or sets the depreciable percentage.
        ///     This is the percentage of the home which is depreciable versus land.
        /// </summary>
        /// <value>The depreciable percentage.</value>
        public decimal DepreciablePercentage { get; set; } = .8m;

        /// <summary>
        ///     Gets or sets the inflation rate.
        ///     This controls an increase in costs each year.
        /// </summary>
        /// <value>The inflation rate.</value>
        public decimal InflationRate { get; set; } = .02m;

        private void Initialize()
        {
            Name = Name ?? "Default Name";
            SimulationYears = Math.Max(1, SimulationYears);

            HomePurchaseAmount = Math.Max(1m, HomePurchaseAmount).ToDollars();

            OwnerHomeValue = HomePurchaseAmount;
            OwnerDownPaymentPercentage = Math.Min(Math.Max(0m, OwnerDownPaymentPercentage), 100).ToPercent();
            OwnerDownPayment = (HomePurchaseAmount * OwnerDownPaymentPercentage).ToDollars();
            OwnerInterestRate = Math.Min(Math.Max(0m, OwnerInterestRate), 100).ToPercent();
            OwnerLoanAmount = HomePurchaseAmount - OwnerDownPayment;
            OwnerLoanBalance = OwnerLoanAmount;
            OwnerLoanYears = Math.Max(1, OwnerLoanYears);
            OwnerMonthlyPayment = PaymentCalculator.CalculatePayment(OwnerLoanAmount, OwnerInterestRate, OwnerLoanYears);

            LandlordHomeValue = HomePurchaseAmount;
            LandlordDownPaymentPercentage = LandlordDownPaymentPercentage ?? OwnerDownPaymentPercentage;
            LandlordDownPaymentPercentage = Math.Min(Math.Max(0m, LandlordDownPaymentPercentage.Value), 100).ToPercent();
            LandlordDownPayment = (HomePurchaseAmount * LandlordDownPaymentPercentage.Value).ToDollars();
            LandlordInterestRate = LandlordInterestRate ?? OwnerInterestRate;
            LandlordInterestRate = Math.Min(Math.Max(0m, LandlordInterestRate.Value), 100).ToPercent();
            LandlordManagementFeePercentage = Math.Min(Math.Max(0m, LandlordManagementFeePercentage), 100).ToPercent();
            LandlordLoanAmount = HomePurchaseAmount - LandlordDownPayment;
            LandlordLoanBalance = LandlordLoanAmount;
            LandlordLoanYears = Math.Max(1, LandlordLoanYears ?? OwnerLoanYears);
            LandlordMonthlyPayment = PaymentCalculator.CalculatePayment(LandlordLoanAmount, LandlordInterestRate.Value, LandlordLoanYears.Value);

            AnnualDiscountRate = Math.Min(Math.Max(0m, AnnualDiscountRate), 100).ToPercent();
            CapitalGainsRate = Math.Min(Math.Max(0m, CapitalGainsRate), 100).ToPercent();
            MarginalTaxRate = Math.Min(Math.Max(0m, MarginalTaxRate), 100).ToPercent();
            InflationRate = Math.Min(Math.Max(0m, InflationRate), 100).ToPercent();

            ClosingFixedCosts = Math.Max(0m, ClosingFixedCosts).ToDollars();
            ClosingVariableCostsPercentage = Math.Min(Math.Max(0m, ClosingVariableCostsPercentage), 100).ToPercent();
            PropertyTaxPercentage = Math.Min(Math.Max(0m, PropertyTaxPercentage), 100).ToPercent();
            InsurancePerMonth = Math.Max(0m, InsurancePerMonth).ToDollarCents();
            HoaPerMonth = Math.Max(0m, HoaPerMonth).ToDollarCents();
            HomeAppreciationPercentagePerYear = Math.Min(Math.Max(0m, HomeAppreciationPercentagePerYear), 100).ToPercent();
            HomeMaintenancePercentagePerYear = Math.Min(Math.Max(0m, HomeMaintenancePercentagePerYear), 100).ToPercent();
            SalesCommissionPercentage = Math.Min(Math.Max(0m, SalesCommissionPercentage), 100).ToPercent();
            SalesFixedCosts = Math.Max(0m, SalesFixedCosts).ToDollars();
            DepreciationYears = Math.Max(1, DepreciationYears).ToValue();
            DepreciablePercentage = Math.Min(Math.Max(0m, DepreciablePercentage), 100).ToPercent();

            RentChangePerYearPercentage = Math.Min(Math.Max(0m, RentChangePerYearPercentage ?? HomeAppreciationPercentagePerYear), 100).ToPercent();
            var defaultRent =
                OwnerMonthlyPayment +
                InsurancePerMonth +
                HoaPerMonth +
                HomePurchaseAmount * PropertyTaxPercentage / 12 +
                HomePurchaseAmount * HomeMaintenancePercentagePerYear / 12;

            InitialRent = Math.Max(1m, InitialRent ?? defaultRent).ToDollars();
            CurrentRent = InitialRent.Value;
            RentersInsurancePerMonth = Math.Max(0m, RentersInsurancePerMonth).ToDollarCents();
            RentSecurityDepositMonths = Math.Max(0, RentSecurityDepositMonths);
        }

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
            output.WriteLine(Separator);
            output.WriteLine($"Year # {Month / 12}{Environment.NewLine}");
            if (RentChangePerYearPercentage > 0)
            {
                CurrentRent = (CurrentRent + CurrentRent * (RentChangePerYearPercentage ?? 0m)).ToDollars();
                output.WriteLine($"* Rent increased {RentChangePerYearPercentage:P2} to {CurrentRent:C0}");
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

        /// <summary>
        ///     Runs the specified scenario.
        /// </summary>
        /// <param name="output">The output.</param>
        public void Run(IOutput output)
        {
            // Make sure we have someplace to white the output
            output = output ?? new DebugOutput();

            // Create the simulation data and dump it to output.
            Initialize();
            output.WriteLine(Separator);
            output.WriteLine(ToString().TrimEnd());

            // Create the various entries we are simulating
            var people = new List<IEntity>
            {
                new Owner(),
                new Renter(),
                new Landlord(),
            };

            do
            {
                // Simulate this month for each entry
                people.ForEach(c =>
                {
                    output.WriteLine(Separator);
                    c.Simulate(this, output);
                });
            }
            while (Next(output)); // Move to next month.

            // Write the final results.
            output.VerboseLine(Separator);
            output.VerboseLine(ToString().TrimEnd());

            // Write the results for each entity plus any NPV data
            // ReSharper disable once ImplicitlyCapturedClosure
            people.ForEach(c =>
            {
                output.WriteLine(Separator);
                output.WriteLine(c.ToString().TrimEnd());
                var report = c.GenerateReport();
                if (!string.IsNullOrWhiteSpace(report))
                {
                    output.VerboseLine(Separator);
                    output.VerboseLine(report.TrimEnd());
                }
            });
        }

        /// <inheritdoc />
        public override string ToString()
            => new Report<Simulation>(this).ToString().TrimEnd();
    }
}
