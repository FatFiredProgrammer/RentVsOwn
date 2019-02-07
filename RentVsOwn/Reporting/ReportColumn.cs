using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using RentVsOwn.Financials;

namespace RentVsOwn.Reporting
{
    public sealed class ReportColumn
    {
        public ReportColumn(PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
                throw new ArgumentNullException(nameof(propertyInfo));

            Notes = string.Empty;
            var name = propertyInfo.Name;
            PropertyInfo = propertyInfo;
            if (PropertyInfo.PropertyType == typeof(bool))
            {
                Alignment = ReportColumnAlignment.Right;
                Grouping = ReportColumnGrouping.Last;
                Format = ReportColumnFormat.Boolean;
            }
            else if (PropertyInfo.PropertyType == typeof(string))
            {
                Alignment = ReportColumnAlignment.Left;
                Grouping = ReportColumnGrouping.Last;
                Format = ReportColumnFormat.Text;
            }
            else
            {
                Alignment = ReportColumnAlignment.Right;
                Grouping = ReportColumnGrouping.Sum;
                Format = ReportColumnFormat.Number;
            }

            if (propertyInfo.GetCustomAttributes(typeof(ReportColumnAttribute), false).FirstOrDefault() is ReportColumnAttribute attribute)
            {
                if (!string.IsNullOrWhiteSpace(attribute.Name))
                    name = attribute.Name;

                Alignment = attribute.Alignment;
                Notes = attribute.Notes;
                Grouping = attribute.Grouping;
                Format = attribute.Format;
                Precision = attribute.Precision;
                CalculateAverage = attribute.CalculateAverage;
                CalculateSum = attribute.CalculateSum;
                IncludePeriod0 = attribute.IncludePeriod0;
                CalculateNpv = attribute.CalculateNpv;
                CalculateIrr = attribute.CalculateIrr;
            }

            Precision = Precision < 0 ? GetDefaultPrecision(Format) : Precision;
            Name = FormatName(name);
        }

        public string Name { get; }

        public string Notes { get; }

        public ReportColumnAlignment Alignment { get; }

        public ReportColumnFormat Format { get; }

        public int Precision { get; } = -1;

        public ReportColumnGrouping Grouping { get; }

        public PropertyInfo PropertyInfo { get; }

        public bool CalculateAverage { get; }

        public bool CalculateSum { get; }

        public bool IncludePeriod0 { get; }

        public bool CalculateNpv { get; }

        public bool CalculateIrr { get; }

        public int Count { get; private set; }

        public decimal Sum { get; private set; }

        public decimal Average { get; private set; }

        public decimal Irr { get; private set; }

        public decimal Npv { get; private set; }

        private readonly List<double> _cashFlows = new List<double>();

        public void Accumulate<T>(ReportGroup<T> group)
            where T : class
        {
            if (!CalculateAverage && !CalculateSum && !CalculateIrr && !CalculateNpv)
                return;

            if (!IncludePeriod0 && !CalculateIrr && !CalculateNpv && group.Period == 0)
                return;

            Count++;
            var cashFlow = 0d;
            foreach (var data in group.Data)
            {
                var value = GetDecimalValue(data);
                Sum += value;
                if (CalculateIrr || CalculateNpv)
                    cashFlow += (double)value;
            }

            if (CalculateIrr || CalculateNpv)
                _cashFlows.Add(cashFlow);
            Average = Sum / Count;
        }

        public void Calculate(ReportGrouping grouping, double discountRatePerYear)
        {
            // The underlying data is always monthly
            var discountRate = grouping == ReportGrouping.Yearly ? discountRatePerYear : Financial.ConvertDiscountRateYearToMonth(discountRatePerYear);
            if (CalculateNpv)
                Npv = (decimal)Financials.Npv.Calculate(_cashFlows, discountRate);
            if (CalculateIrr)
            {
                var irr = Financials.Irr.Calculate(_cashFlows, discountRate);
                Irr = double.IsNaN(irr) ? 0m : (decimal)irr;
            }

            // If we ask for yearly, convert the resulting IRR
            if (grouping == ReportGrouping.Monthly)
                Irr = Financial.ConvertDiscountRateMonthToYear(Irr);
        }

        private static string FormatName(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            var result = new StringBuilder();
            var nextUpperIsWordSeparator = false;
            foreach (var letter in name)
            {
                if (char.IsUpper(letter) && nextUpperIsWordSeparator)
                {
                    result.Append(' ');
                    nextUpperIsWordSeparator = false;
                }
                else
                    nextUpperIsWordSeparator = true;

                result.Append(letter);
            }

            return result.ToString();
        }

        public string FormatValue(object value)
            => FormatValue(value, Format, Precision);

        public static string FormatValue(object value, ReportColumnFormat format, int precision)
        {
            if (value == null)
                return string.Empty;

            switch (format)
            {
                case ReportColumnFormat.Text:
                    return value.ToString();

                case ReportColumnFormat.Boolean:
                    return (bool)value ? "Yes" : "No";

                case ReportColumnFormat.Number:
                    var numberFormat = $"{{0:N{precision}}}";
                    return string.Format(numberFormat, value);

                case ReportColumnFormat.Currency:
                    var currencyFormat = $"{{0:C{precision}}}";
                    return string.Format(currencyFormat, value);

                case ReportColumnFormat.Percentage:
                    var percentFormat = $"{{0:P{precision}}}";
                    return string.Format(percentFormat, value);

                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format.ToString());
            }
        }

        public decimal GetDecimalValue(object data)
        {
            var value = GetValue(data);

            switch (value)
            {
                case null:
                    return 0m;
                case sbyte number:
                    return number;
                case short number:
                    return number;
                case int number:
                    return number;
                case long number:
                    return number;
                case byte number:
                    return number;
                case ushort number:
                    return number;
                case uint number:
                    return number;
                case ulong number:
                    return number;
                case char number:
                    return number;
                case float number:
                    return (decimal)number;
                case double number:
                    return (decimal)number;
                case decimal number:
                    return number;
                default:
                    return 0m;
            }
        }

        private static int GetDefaultPrecision(ReportColumnFormat format)
        {
            switch (format)
            {
                case ReportColumnFormat.Percentage:
                    return 2;
                default:
                    return 0;
            }
        }

        public object GetValue(object data)
            => data == null ? null : PropertyInfo.GetValue(data);
    }
}
