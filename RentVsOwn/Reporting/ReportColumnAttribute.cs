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
            => Description = description;

        public string Description { get; set; }

        public ReportColumnAlignment Alignment { get; set; }

        public ReportColumnFormat Format { get; set; }

        public int Precision { get; set; }

        public bool Ignore { get; set; }
    }
}
