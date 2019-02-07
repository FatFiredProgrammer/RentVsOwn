using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public interface IEntity
    {
        decimal NetWorth { get; }

        string Name { get; }

        string GenerateReport(ReportGrouping grouping, ReportFormat format);

        void NextYear();

        void Simulate();
    }
}
