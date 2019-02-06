using System;
using System.Linq;
using System.Reflection;
using System.Text;

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
            if (propertyInfo.GetCustomAttributes(typeof(ReportColumnAttribute), false).FirstOrDefault() is ReportColumnAttribute attribute)
            {
                if (!string.IsNullOrWhiteSpace(attribute.Name))
                    name = attribute.Name;

                Alignment = attribute.Alignment;
                Grouping = attribute.Grouping;
                Format = attribute.Format;
                Precision = attribute.Precision < 0 ? GetDefaultPrecision(Format) : attribute.Precision;
                Notes = attribute.Notes;
            }

            Name = FormatName(name);
        }

        public string Name { get; }

        public string Notes { get; }

        public ReportColumnAlignment Alignment { get; }

        public ReportColumnFormat Format { get; }

        public int Precision { get; }

        public ReportColumnGrouping Grouping { get; }

        public PropertyInfo PropertyInfo { get; }

        public void Accumulate(ReportColumn column)
        {
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
                    return (decimal)number;
                case short number:
                    return (decimal)number;
                case int number:
                    return (decimal)number;
                case long number:
                    return (decimal)number;
                case byte number:
                    return (decimal)number;
                case ushort number:
                    return (decimal)number;
                case uint number:
                    return (decimal)number;
                case ulong number:
                    return (decimal)number;
                case char number:
                    return (decimal)number;
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
                case ReportColumnFormat.Number:
                    return 0;
                case ReportColumnFormat.Currency:
                    return 0;
                case ReportColumnFormat.Percentage:
                    return 2;
                case ReportColumnFormat.Text:
                    return 0;
                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }
        }

        public object GetValue(object data)
            => data == null ? null : PropertyInfo.GetValue(data);
    }
}
