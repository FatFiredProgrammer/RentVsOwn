using System;
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
    public sealed class Scenario : IScenario
    {
        public Scenario()
        {
        }

        /// <summary>
        ///     Gets or sets the name of the scenario.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the years for the simulation.
        /// </summary>
        /// <value>The years.</value>
        public decimal Years { get; set; }

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
                new Owner(this),
                new Landlord(this),
                new Renter(this),
            };
            var period = new Period((int)Math.Round(Years/12, 0));
            do
            {
                simulations.ForEach(c => c.Simulate(period, output));
            }
            while (period.Next());

            // ReSharper disable once ImplicitlyCapturedClosure
            simulations.ForEach(action: c => output.WriteLine(c.ToString()));
        }

        private void Initialize()
        {
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();

            return text.ToString().TrimEnd();
        }
    }
}
