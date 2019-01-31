using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;

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
        public decimal Rent { get; set; } = 2300;

        /// <summary>
        ///     Gets or sets the rent percentage change per year.
        /// </summary>
        /// <value>The rent percentage per year.</value>
        public decimal RentChangePerYearPercentage { get; set; } = .035m;

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
        ///     Runs the specified scenario.
        /// </summary>
        /// <param name="output">The output.</param>
        public void Run(IOutput output)
        {
            output = output ?? new DebugOutput();

            var simulation = new Simulation(this);
            output.WriteLine(Separator);
            output.WriteLine(simulation.ToString().TrimEnd());

            var people = new List<IPerson>
            {
                new Owner(),
                new Landlord(),
                new Renter(),
            };
            do
            {
                people.ForEach(c =>
                {
                    output.WriteLine(Separator);
                    c.Simulate(simulation, output);
                });
            }
            while (simulation.Next(output));

            output.WriteLine(Separator);
            output.WriteLine(simulation.ToString().TrimEnd());

            // ReSharper disable once ImplicitlyCapturedClosure
            people.ForEach(c =>
            {
                output.WriteLine(Separator);
                output.WriteLine(c.ToString().TrimEnd());
            });
        }
    }
}
