using System;

namespace RentVsOwn
{
    public sealed class Landlord : IPerson
    {
        /// <inheritdoc />
        public string Name { get; }

        public decimal NetWorth { get; private set; }

        /// <inheritdoc />
        public void Simulate(Simulation simulation, IOutput output)
        {
            if (simulation == null)
                throw new ArgumentNullException(nameof(simulation));
            if (output == null)
                throw new ArgumentNullException(nameof(output));


            if (simulation.IsInitial)
                Initialize(simulation, output);
            Process(simulation, output);
            if (simulation.IsInitial)
                Finalize(simulation, output);
        }

        private void Process(Simulation simulation, IOutput output)
        {
        }

        private void Initialize(Simulation simulation, IOutput output)
        {
        }

        private void Finalize(Simulation simulation, IOutput output)
        {
        }
    }
}
