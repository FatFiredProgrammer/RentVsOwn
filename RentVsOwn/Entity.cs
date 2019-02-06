using System;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public abstract class Entity : IEntity, IOutput
    {
        protected Entity(ISimulation simulation, IOutput output)
        {
            Simulation = simulation ?? throw new ArgumentNullException(nameof(simulation));
            _output = output ?? throw new ArgumentNullException(nameof(output));
        }

        protected ISimulation Simulation { get; }

        private readonly IOutput _output;

        /// <inheritdoc />
        public string Name => GetType().Name;

        /// <inheritdoc />
        public void Flush()
            => _output.Flush();

        /// <inheritdoc />
        public abstract string GenerateReport(ReportGrouping grouping, ReportFormat format);

        public abstract void NextYear();

        public abstract void Simulate();

        /// <inheritdoc />
        public string VerboseLine(string text)
            => _output.VerboseLine(text);

        /// <inheritdoc />
        public string WriteLine(string text)
            => _output.WriteLine(text);
    }
}
