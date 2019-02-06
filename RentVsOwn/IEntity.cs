using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public interface IEntity
    {
        string Name { get; }

        string GenerateReport(ReportGrouping grouping, ReportFormat format);

        void Simulate(ISimulation simulation, IOutput output);
    }
}
