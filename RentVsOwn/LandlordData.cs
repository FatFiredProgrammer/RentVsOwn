using JetBrains.Annotations;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    [PublicAPI]
    public sealed class LandlordData
    {
        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Rent { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Expenses => ManagementFee + Insurance + PropertyTax + Hoa + Maintenance + OperatingLoanInterest + OtherTaxes + Interest;

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal ManagementFee { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Insurance { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal PropertyTax { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Hoa { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Maintenance { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal OperatingLoanInterest { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal OtherTaxes { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Interest { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
        public decimal Principal { get; set; }

        /// <summary>
        ///     Gets or sets the operating loan amount required during this period.
        /// </summary>
        /// <value>The operating loan.</value>
        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum)]
        public decimal OperatingLoan { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Last)]
        public decimal HomeValue { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Last)]
        public decimal LoanBalance { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateNpv = true, CalculateIrr = true)]
        public decimal CashFlow { get; set; }

        /// <summary>
        ///     Gets or sets the cash on hand this month.
        ///     This starts with the value of the rent and then gets progressively decreased.
        ///     If we go negative, we need a personal loan.
        ///     This is really an accumulator and ends up being zeroed out.
        /// </summary>
        /// <value>The cash.</value>
        [ReportColumn(Ignore = true)]
        public decimal Cash { get; set; }
    }
}
