using System;
using System.Text;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public abstract class Entity<TData> : IEntity, IOutput
        where TData : class
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

        public abstract decimal NetWorth { get; }

        protected decimal InitialCash { get; set; }

        protected decimal Cash { get; set; }

        protected Report<TData> Report { get; } = new Report<TData>();

        /// <inheritdoc />
        public void Flush()
            => _output.Flush();

        /// <inheritdoc />
        public abstract string GenerateReport(ReportGrouping grouping, ReportFormat format);

        public abstract void NextYear();

        public abstract void Simulate();

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine($"{Name} has {NetWorth:C0} net worth on {InitialCash:C0} initial investment.");
            return text.ToString().TrimEnd();
        }

        /// <inheritdoc />
        public string VerboseLine(string text)
            => _output.VerboseLine(text);

        /// <inheritdoc />
        public string WriteLine(string text)
            => _output.WriteLine(text);
    }
}
