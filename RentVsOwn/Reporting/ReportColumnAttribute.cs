using System;

namespace RentVsOwn.Reporting
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ReportColumnAttribute : Attribute
    {
        public ReportColumnAttribute()
        {
        }

        public ReportColumnAttribute(string description)
            => Name = description;

        public string Name { get; set; }

        public string Notes { get; set; }

        public ReportColumnAlignment Alignment { get; set; }

        public ReportColumnFormat Format { get; set; }

        public int Precision { get; set; } = -1;

        public ReportColumnGrouping Grouping { get; set; }

        public bool CalculateAverage { get; set; }

        public bool CalculateSum { get; set; }

        public bool IncludePeriod0 { get; set; } = true;

        public bool CalculateNpv { get; set; }

        public bool CalculateIrr { get; set; }

        public bool Ignore { get; set; }
    }
}
