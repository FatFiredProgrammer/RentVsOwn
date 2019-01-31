using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using JetBrains.Annotations;

namespace RentVsOwn
{
    /// <summary>
    ///     A description of the scenario that we are running.
    /// </summary>
    [PublicAPI]
    [DebuggerDisplay("{" + nameof(ToString) + "()}")]
    public sealed class Scenario
    {
        public Scenario()
        {
        }

        /// <summary>
        ///     Gets or sets the name of the scenario.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; } = "Default Scenario";

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

        private void Initialize()
        {
        }

        /// <summary>
        ///     Runs the specified scenario.
        /// </summary>
        /// <param name="output">The output.</param>
        public void Run(IOutput output)
        {
            output = output ?? new DebugOutput();

            Initialize();
            output.WriteLine(ToString());

            var simulations = new List<ISimulation>
            {
                new Owner(),
                new Landlord(),
                new Renter(),
            };
            var period = new Period(this);
            do
            {
                simulations.ForEach(c => c.Simulate(period, output));
            }
            while (period.Next());

            // ReSharper disable once ImplicitlyCapturedClosure
            simulations.ForEach(c => output.WriteLine(c.ToString()));
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();

            return text.ToString().TrimEnd();
        }
    }
}
