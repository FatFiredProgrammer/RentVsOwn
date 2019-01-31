using System;

namespace RentVsOwn
{
    public sealed class Renter : ISimulation
    {
        public Renter(IScenario scenario)
            => Scenario = scenario ?? throw new ArgumentNullException(nameof(scenario));

        private readonly IScenario Scenario;

        /// <inheritdoc />
        public void Simulate(IPeriod period, IOutput output)
        {
        }
    }
}
