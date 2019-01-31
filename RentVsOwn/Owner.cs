using System;

namespace RentVsOwn
{
    public sealed class Owner : ISimulation
    {
        public Owner(IScenario scenario)
            => Scenario = scenario ?? throw new ArgumentNullException(nameof(scenario));

        private readonly IScenario Scenario;

        /// <inheritdoc />
        public void Simulate(IPeriod period, IOutput output)
        {
            throw new System.NotImplementedException();
        }
    }
}
