using JetBrains.Annotations;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    [PublicAPI]
    public sealed class RenterData
    {
        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Expenses => Rent + Insurance;

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Rent { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Insurance { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateNpv = true, CalculateIrr = true)]
        public decimal CashFlow { get; set; }
    }
}
