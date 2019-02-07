using JetBrains.Annotations;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    [PublicAPI]
    public sealed class OwnerData
    {
        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Total => Expenses + Principal;

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Expenses => Insurance + PropertyTax + Hoa + Maintenance + Interest;

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Insurance { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal PropertyTax { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Hoa { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Maintenance { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Interest { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Principal { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Last)]
        public decimal HomeValue { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Last)]
        public decimal LoanBalance { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateNpv = true, CalculateIrr = true)]
        public decimal CashFlow { get; set; }
    }
}
