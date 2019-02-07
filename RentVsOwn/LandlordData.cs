using JetBrains.Annotations;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    [PublicAPI]
    public sealed class LandlordData
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

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateNpv = true, CalculateIrr = true)]
        public decimal CashFlow { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Last)]
        public decimal HomeValue { get; set; }

        [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Last)]
        public decimal LoanBalance { get; set; }

        // TODO: Code needs work
#if false
                 public decimal Rent { get; set; }

            public decimal Expenses { get; set; }
#endif

        // TODO: Code needs work
#if false
             public decimal Principal { get; set; }

        public decimal Interest { get; set; }

        public decimal NetIncome => Rent - Expenses;
#endif

        /// <summary>
        ///     Gets or sets the cash on hand this month.
        ///     This starts with the value of the rent and then gets progressively decreased.
        ///     If we go negative, we need a personal loan.
        /// </summary>
        /// <value>The cash.</value>
        public decimal Cash { get; set; }

        public decimal PersonalLoan { get; set; }

        public decimal NpvCashFlow { get; set; }
    }
}
