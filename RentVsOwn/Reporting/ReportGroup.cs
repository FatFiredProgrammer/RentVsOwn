using System;
using System.Collections.Generic;
using System.Linq;

namespace RentVsOwn.Reporting
{
    public sealed class ReportGroup<T>
        where T : class
    {
        public ReportGroup(T data)
        {
            Period = 0;
            _data = new List<T>
            {
                data
            };
        }

        public ReportGroup(T data, int period)
        {
            Period = Math.Max(0, period);
            _data = new List<T>
            {
                data
            };
        }

        public ReportGroup(IEnumerable<T> data, int period)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Period = Math.Max(0, period);
            _data = data.ToList();
        }

        private readonly List<T> _data;

        public IEnumerable<T> Data => _data;

        public int Period { get; set; }

        public object GetValue(ReportColumn column)
        {
            switch (column.Grouping)
            {
                case ReportColumnGrouping.Sum:
                    return _data.Sum(c => column.GetDecimalValue(c));

                case ReportColumnGrouping.Average:
                    return _data.Average(c => column.GetDecimalValue(c));

                case ReportColumnGrouping.Min:
                    return _data.Min(c => column.GetDecimalValue(c));

                case ReportColumnGrouping.Max:
                    return _data.Max(c => column.GetDecimalValue(c));

                case ReportColumnGrouping.First:
                    return column.GetValue(_data[0]);

                case ReportColumnGrouping.Last:
                    return column.GetValue(_data[_data.Count - 1]);

                default:
                    throw new ArgumentOutOfRangeException(nameof(column.Grouping), column.Grouping.ToString());
            }
        }
    }
}
