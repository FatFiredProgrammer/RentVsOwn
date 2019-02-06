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

        public bool Ignore { get; set; }
    }
}
