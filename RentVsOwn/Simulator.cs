using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
using RentVsOwn.Output;

namespace RentVsOwn
{
    /// <summary>
    ///     A description of the scenario that we are running.
    /// </summary>
    [PublicAPI]
    [DebuggerDisplay("{" + nameof(ToString) + "()}")]
    public sealed class Simulator
    {
        public const string Separator = "\r\n---\r\n";

        /// <summary>
        ///     Gets or sets the name of the scenario.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; } = "Default Simulator";

        /// <summary>
        ///     Gets or sets the years for the simulation.
        /// </summary>
        /// <value>The years.</value>
        public decimal Years { get; set; } = 8.7m;

        /// <summary>
        ///     Gets or sets the initial rent.
        /// </summary>
        /// <value>The initial rent.</value>
        public decimal? Rent { get; set; }

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
        ///     Gets or sets the home purchase amount.
        /// </summary>
        /// <value>The home purchase amount.</value>
        public decimal HomePurchaseAmount { get; set; } = 289900;

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
        /// <summary>
        /// Gets or sets the management fee percentage.
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
        /// Gets or sets the depreciable percentage.
        /// This is the percentage of the home which is depreciable versus land.
        /// </summary>
        /// <value>The depreciable percentage.</value>
        public decimal DepreciablePercentage { get; set; } = .8m;

        /// <summary>
        ///     Gets or sets the discount rate.
        ///     This is the assumed rate of return for investments and also
        ///     the rate assumed in NPV calculations.
        /// </summary>
        /// <value>The discount rate.</value>
        public decimal DiscountRate { get; set; } = .08m;

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

        /// <summary>
        ///     Gets or sets the inflation rate.
        ///     This controls an increase in costs each year.
        /// </summary>
        /// <value>The inflation rate.</value>
        public decimal InflationRate { get; set; } = .02m;

        /// <summary>
        ///     Runs the specified scenario.
        /// </summary>
        /// <param name="output">The output.</param>
        public void Run(IOutput output)
        {
            // Make sure we have someplace to white the output
            output = output ?? new DebugOutput();

            // Create the simulation data and dump it to output.
            var simulation = new Simulation(this);
            output.WriteLine(Separator);
            output.WriteLine(simulation.ToString().TrimEnd());

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
                    c.Simulate(simulation, output);
                });

            }
            while (simulation.Next(output)); // Move to next month.

            // Write the final results.
            output.VerboseLine(Separator);
            output.VerboseLine(simulation.ToString().TrimEnd());

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
    }
}
