using System;
using System.Collections.Generic;
using RentVsOwn.Financials;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public sealed class Simulation : ISimulation
    {
        public const string Separator = "\r\n---\r\n";

        [ReportColumn("Name of Simulation")]
        public string Name { get; set; } = "Default Simulation";

        private string GetSummary()
            => new Report<Simulation>(this).ToString().TrimEnd();

        private void Initialize()
        {
            Name = Name ?? "Default Name";
            Years = Math.Max(1, Years);

            HomePurchaseAmount = Math.Max(1m, HomePurchaseAmount).ToDollars();

            OwnerDownPaymentPercentage = Math.Min(Math.Max(0m, OwnerDownPaymentPercentage), 100).ToPercent();
            OwnerDownPayment = (HomePurchaseAmount * OwnerDownPaymentPercentage).ToDollars();
            OwnerInterestRatePerYear = Math.Min(Math.Max(0m, OwnerInterestRatePerYear), 100).ToPercent();
            OwnerLoanAmount = HomePurchaseAmount - OwnerDownPayment;
            OwnerLoanYears = Math.Max(1, OwnerLoanYears);
            OwnerMonthlyPayment = PaymentCalculator.CalculatePayment(OwnerLoanAmount, OwnerInterestRatePerYear, OwnerLoanYears);

            LandlordDownPaymentPercentage = LandlordDownPaymentPercentage ?? OwnerDownPaymentPercentage;
            LandlordDownPaymentPercentage = Math.Min(Math.Max(0m, LandlordDownPaymentPercentage.Value), 100).ToPercent();
            LandlordDownPayment = (HomePurchaseAmount * LandlordDownPaymentPercentage.Value).ToDollars();
            LandlordInterestRate = LandlordInterestRate ?? OwnerInterestRatePerYear;
            LandlordInterestRate = Math.Min(Math.Max(0m, LandlordInterestRate.Value), 100).ToPercent();
            LandlordManagementFeePercentagePerMonth = Math.Min(Math.Max(0m, LandlordManagementFeePercentagePerMonth), 100).ToPercent();
            LandlordLoanAmount = HomePurchaseAmount - LandlordDownPayment;
            LandlordLoanYears = Math.Max(1, LandlordLoanYears ?? OwnerLoanYears);
            LandlordMonthlyPayment = PaymentCalculator.CalculatePayment(LandlordLoanAmount, LandlordInterestRate.Value, LandlordLoanYears.Value);

            DiscountRatePerYear = Math.Min(Math.Max(0m, DiscountRatePerYear), 100).ToPercent();
            CapitalGainsRatePerYear = Math.Min(Math.Max(0m, CapitalGainsRatePerYear), 100).ToPercent();
            MarginalTaxRatePerYear = Math.Min(Math.Max(0m, MarginalTaxRatePerYear), 100).ToPercent();
            InflationRatePerYear = Math.Min(Math.Max(0m, InflationRatePerYear), 100).ToPercent();

            BuyerFixedCosts = Math.Max(0m, BuyerFixedCosts).ToDollars();
            BuyerVariableCostsPercentage = Math.Min(Math.Max(0m, BuyerVariableCostsPercentage), 100).ToPercent();
            PropertyTaxPercentagePerYear = Math.Min(Math.Max(0m, PropertyTaxPercentagePerYear), 100).ToPercent();
            InsurancePerMonth = Math.Max(0m, InsurancePerMonth).ToDollarCents();
            HoaPerMonth = Math.Max(0m, HoaPerMonth).ToDollarCents();
            HomeAppreciationPercentagePerYear = Math.Min(Math.Max(0m, HomeAppreciationPercentagePerYear), 100).ToPercent();
            HomeMaintenancePercentagePerYear = Math.Min(Math.Max(0m, HomeMaintenancePercentagePerYear), 100).ToPercent();
            SellerCommissionPercentage = Math.Min(Math.Max(0m, SellerCommissionPercentage), 100).ToPercent();
            SellerFixedCosts = Math.Max(0m, SellerFixedCosts).ToDollars();
            DepreciationYears = Math.Max(1, DepreciationYears).ToValue();
            DepreciablePercentage = Math.Min(Math.Max(0m, DepreciablePercentage), 100).ToPercent();

            RentChangePerYearPercentage = Math.Min(Math.Max(0m, RentChangePerYearPercentage ?? HomeAppreciationPercentagePerYear), 100).ToPercent();
            var defaultRent =
                OwnerMonthlyPayment +
                InsurancePerMonth +
                HoaPerMonth +
                HomePurchaseAmount * PropertyTaxPercentagePerYear / 12 +
                HomePurchaseAmount * HomeMaintenancePercentagePerYear / 12;

            RentPerMonth = Math.Max(1m, RentPerMonth ?? defaultRent).ToDollars();
            RentersInsurancePerMonth = Math.Max(0m, RentersInsurancePerMonth).ToDollarCents();
            RentSecurityDepositMonths = Math.Max(0, RentSecurityDepositMonths);
        }

        private bool Next()
        {
            if (Month >= Months)
                return false;

            ++Month;
            return true;
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
            output.WriteLine(GetSummary().TrimEnd());

            // Create the various entries we are simulating
            var people = new List<IEntity>
            {
                // new Renter(this, output),
                // new Owner(this, output),

                new Landlord(this, output),
            };

            do
            {
                // Simulate this month for each entry
                people.ForEach(c =>
                {
                    if (IsNewYear)
                        c.NextYear();

                    output.WriteLine(Separator);
                    c.Simulate();
                });
            }
            while (Next()); // Move to next month.

            // Write the results for each entity plus any NPV data
            // ReSharper disable once ImplicitlyCapturedClosure
            people.ForEach(c =>
            {
                output.WriteLine(Separator);
                output.WriteLine(c.ToString().TrimEnd());

                const ReportFormat format = ReportFormat.Csv;
                var yearly = c.GenerateReport(ReportGrouping.Yearly, format);
                if (!string.IsNullOrWhiteSpace(yearly))
                {
                    output.VerboseLine(Separator);
                    output.VerboseLine($"{c.Name} Yearly Report");
                    output.VerboseLine(string.Empty);
                    output.VerboseLine(yearly.TrimEnd());
                }

                var monthly = c.GenerateReport(ReportGrouping.Monthly, format);
                if (!string.IsNullOrWhiteSpace(monthly))
                {
                    output.VerboseLine(Separator);
                    output.VerboseLine($"{c.Name} Monthly Report");
                    output.VerboseLine(string.Empty);
                    output.VerboseLine(monthly.TrimEnd());
                }
            });
        }

        /// <inheritdoc />
        public override string ToString()
            => Name ?? "Default Simulation";

        #region Period
        [ReportColumn(Format = ReportColumnFormat.Number, Precision = 1, Notes = "Number of years the simulation runs. Default is 8.7; the national average for home ownership.")]
        public decimal Years { get; set; } = 8.7m;

        [ReportColumn(Format = ReportColumnFormat.Number, Notes = "Number of months the simulation runs.")]
        public int Months => Math.Max(1, (int)Math.Round(Years * 12, 0));

        [ReportColumn(Ignore = true)]
        public int Month { get; private set; } = 1;

        [ReportColumn(Ignore = true)]
        public bool IsInitialMonth => Month == 1;

        [ReportColumn(Ignore = true)]
        public bool IsFinalMonth => Month == Months;

        [ReportColumn(Ignore = true)]
        public bool IsNewYear => Month != 1 && (Month - 1) % 12 == 0;
        #endregion

        #region Simulation Parameters
        /// <summary>
        ///     Gets or sets the home purchase amount.
        /// </summary>
        /// <value>The home purchase amount.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Home purchase amount. Default is $289,900.")]
        public decimal HomePurchaseAmount { get; set; } = 289900;

        /// <summary>
        ///     Gets or sets the home appreciation percentage per year.
        /// </summary>
        /// <value>The home appreciation percentage per year.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Home appreciation per year. Default is 3.7% (historic average).")]
        public decimal HomeAppreciationPercentagePerYear { get; set; } = .037m;
        #endregion

        #region Expenses
        /// <summary>
        ///     Gets or sets the insurance per month.
        /// </summary>
        /// <value>The insurance per month.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Insurance costs per month. Default is $150.")]
        public decimal InsurancePerMonth { get; set; } = 1800m / 12;

        /// <summary>
        ///     Gets or sets the hoa per month.
        /// </summary>
        /// <value>The hoa per month.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "HOA fees per month. Default is $100.")]
        public decimal HoaPerMonth { get; set; } = 100;

        /// <summary>
        ///     Gets or sets the home maintenance percentage per year.
        /// </summary>
        /// <value>The home maintenance percentage per year.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Home maintenance percentage per year. Default is 1.5%.")]
        public decimal HomeMaintenancePercentagePerYear { get; set; } = .015m;
        #endregion

        #region Owner
        /// <summary>
        ///     Gets or sets the owner interest rate.
        /// </summary>
        /// <value>The owner interest rate.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Home owner's mortgage interest rate. Default is 4.25%.")]
        public decimal OwnerInterestRatePerYear { get; set; } = .0425m;

        /// <summary>
        ///     Gets or sets the owner loan years.
        /// </summary>
        /// <value>The owner loan years.</value>
        [ReportColumn(Format = ReportColumnFormat.Number, Notes = "Home owner's loan term. Default is 30 years.")]
        public int OwnerLoanYears { get; set; } = 30;

        /// <summary>
        ///     Gets or sets the owner down payment percentage.
        /// </summary>
        /// <value>The owner down payment percentage.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Home owner down payment percentage. Default is 20%.")]
        public decimal OwnerDownPaymentPercentage { get; set; } = .2m;

        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Home owner down payment. Calculated.")]
        public decimal OwnerDownPayment { get; private set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Home owner loan amount. Calculated.")]
        public decimal OwnerLoanAmount { get; private set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Home owner monthly payment. Calculated.")]
        public decimal OwnerMonthlyPayment { get; private set; }
        #endregion

        #region Landlord
        /// <summary>
        ///     Gets or sets the owner interest rate.
        /// </summary>
        /// <value>The owner interest rate.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Landlord's mortgage interest rate. Default is 4.75%. If null, use home owner's value.")]
        public decimal? LandlordInterestRate { get; set; } = .0475m;

        decimal ISimulation.LandlordInterestRate => LandlordInterestRate ?? 0m;

        /// <summary>
        ///     Gets or sets the owner loan years.
        /// </summary>
        /// <value>The owner loan years.</value>
        [ReportColumn(Format = ReportColumnFormat.Number, Notes = "Landlord's loan term. Default is 20 years. If null, use home owner's value.")]
        public int? LandlordLoanYears { get; set; } = 20;

        /// <summary>
        ///     Gets or sets the owner down payment percentage.
        /// </summary>
        /// <value>The owner down payment percentage.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Landlord down payment percentage. Default is 25%. If null, use home owner's value.")]
        public decimal? LandlordDownPaymentPercentage { get; set; } = .25m;

        decimal ISimulation.LandlordDownPaymentPercentage => LandlordDownPaymentPercentage ?? 0m;

        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Landlord down payment. Calculated.")]
        public decimal LandlordDownPayment { get; private set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Landlord loan amount. Calculated.")]
        public decimal LandlordLoanAmount { get; private set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Landlord monthly payment. Calculated.")]
        public decimal LandlordMonthlyPayment { get; private set; }

        /// <summary>
        ///     Gets or sets the management fee percentage.
        /// </summary>
        /// <value>The management fee percentage.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Landlord property management fee as a percentage of monthly rent. Default is 10%.")]
        public decimal LandlordManagementFeePercentagePerMonth { get; set; } = .1m;
        #endregion

        #region Rent
        /// <summary>
        ///     Gets or sets the initial rent.
        /// </summary>
        /// <value>The initial rent.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Initial rent per month. Defaults is the home owners initial monthly expense.")]
        public decimal? RentPerMonth { get; set; }

        decimal ISimulation.RentPerMonth => RentPerMonth ?? 0m;

        /// <summary>
        ///     Gets or sets the rent security deposit months.
        /// </summary>
        /// <value>The rent security deposit months.</value>
        [ReportColumn(Format = ReportColumnFormat.Number, Notes = "Number of months of rent retained as security deposit. Defaults is 1.")]
        public int RentSecurityDepositMonths { get; set; } = 1;

        /// <summary>
        ///     Gets or sets the renters insurance per month.
        /// </summary>
        /// <value>The renters insurance per month.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Renter's insurance cost per month. Default is $15.")]
        public decimal RentersInsurancePerMonth { get; set; } = 15;

        /// <summary>
        ///     Gets or sets the rent percentage change per year.
        /// </summary>
        /// <value>The rent percentage per year.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "The percentage increase in rent each year. Default is 3%.")]
        public decimal? RentChangePerYearPercentage { get; set; } = .03m;

        decimal ISimulation.RentChangePerYearPercentage => RentChangePerYearPercentage ?? 0m;
        #endregion

        #region Buy / Sell
        /// <summary>
        ///     Gets or sets the closing fixed costs.
        /// </summary>
        /// <value>The closing fixed costs.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Fixed closing costs like title insurance, inspection, appraisal, etc. Defaults is $1,500.")]
        public decimal BuyerFixedCosts { get; set; } = 1500m;

        /// <summary>
        ///     Gets or sets the closing variable costs percentage.
        /// </summary>
        /// <value>The closing variable costs percentage.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Variable closing costs such as loan origination. Defaults is 1.5%.")]
        public decimal BuyerVariableCostsPercentage { get; set; } = .015m;

        /// <summary>
        ///     Gets or sets the sales commission percentage.
        /// </summary>
        /// <value>The sales commission percentage.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Commission percentage paid to sell a home. Default is 6% (Omaha).")]
        public decimal SellerCommissionPercentage { get; set; } = .06m;

        /// <summary>
        ///     Gets or sets the sales fixed costs.
        /// </summary>
        /// <value>The sales fixed costs.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency, Notes = "Fixed costs to sell a home. Title insurance, doc fees, etc. Default is $1000.")]
        public decimal SellerFixedCosts { get; set; } = 1000m;
        #endregion

        #region Depreciation
        /// <summary>
        ///     Gets or sets the depreciation years.
        /// </summary>
        /// <value>The depreciation years.</value>
        [ReportColumn(Format = ReportColumnFormat.Number, Precision = 2, Notes = "Number of years to depreciate. Default is 27.5.")]
        public decimal DepreciationYears { get; set; } = 27.5m;

        /// <summary>
        ///     Gets or sets the depreciable percentage.
        /// </summary>
        /// <value>The depreciable percentage.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Percentage of the home which is depreciable versus land. Defaults is 80%.")]
        public decimal DepreciablePercentage { get; set; } = .8m;
        #endregion

        #region Taxes
        /// <summary>
        ///     Gets or sets the capital gains rate.
        /// </summary>
        /// <value>The capital gains rate.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Capital gains tax rate per year. Default is 15%.")]
        public decimal CapitalGainsRatePerYear { get; set; } = .15m;

        /// <summary>
        ///     Gets or sets the marginal tax rate.
        /// </summary>
        /// <value>The marginal tax rate.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Marginal tax rate per year. Default is 24%.")]
        public decimal MarginalTaxRatePerYear { get; set; } = .24m;

        /// <summary>
        ///     Gets or sets the property tax percentage.
        /// </summary>
        /// <value>The property tax percentage.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Property tax percentage per year. Default is 2.12% (Omaha).")]
        public decimal PropertyTaxPercentagePerYear { get; set; } = .0212m;
        #endregion

        #region Financial
        /// <summary>
        ///     Gets or sets the discount rate.
        ///     This is the assumed rate of return for investments and also
        ///     the rate assumed in NPV calculations.
        /// </summary>
        /// <value>The discount rate.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Assumed rate of return per year for investments and also the rate assumed in NPV calculations. Defaults is 8%.")]
        public decimal DiscountRatePerYear { get; set; } = .08m;

        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "Monthly discount rate.")]
        public decimal DiscountRatePerMonth => Financial.ConvertDiscountRateYearToMonth(DiscountRatePerYear);

        /// <summary>
        ///     Gets or sets the inflation rate.
        ///     This controls an increase in costs each year.
        /// </summary>
        /// <value>The inflation rate.</value>
        [ReportColumn(Format = ReportColumnFormat.Percentage, Notes = "The inflation percentage per year. Defaults is 2.8%.")]
        public decimal InflationRatePerYear { get; set; } = .028m;
        #endregion
    }
}
