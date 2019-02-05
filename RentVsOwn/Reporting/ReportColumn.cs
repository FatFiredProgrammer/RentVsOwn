using System;
using System.Linq;
using System.Reflection;

namespace RentVsOwn.Reporting
{
    public sealed class ReportColumn
    {
        public ReportColumn(PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
                throw new ArgumentNullException(nameof(propertyInfo));

            Notes = string.Empty;
            var description = propertyInfo.Name;
            PropertyInfo = propertyInfo;
            if (propertyInfo.GetCustomAttributes(typeof(ReportColumnAttribute), false).FirstOrDefault() is ReportColumnAttribute attribute)
            {
                if (!string.IsNullOrWhiteSpace(attribute.Name))
                    description = attribute.Name;

                Alignment = attribute.Alignment;
                Format = attribute.Format;
                Precision = attribute.Precision < 0 ? GetDefaultPrecision(Format) : attribute.Precision;
                Notes = attribute.Notes;
            }

            Name = string.Empty;
            var nextUpperIsWordSeparator = false;
            foreach (var letter in description)
            {
                if (char.IsUpper(letter) && nextUpperIsWordSeparator)
                {
                    Name += " ";
                    nextUpperIsWordSeparator = false;
                }
                else
                    nextUpperIsWordSeparator = true;

                Name += letter;
            }
        }

        public string Name { get; }

        public string Notes { get; }

        public ReportColumnAlignment Alignment { get; }

        public ReportColumnFormat Format { get; }

        public int Precision { get; }

        public PropertyInfo PropertyInfo { get; }

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

        public string GetFormattedValue(object data)
        {
            var value = GetValue(data);
            if (value == null)
                return string.Empty;

            switch (Format)
            {
                case ReportColumnFormat.Text:
                    return value.ToString();

                case ReportColumnFormat.Number:
                    var numberFormat = $"{{0:N{Precision}}}";
                    return string.Format(numberFormat, value);

                case ReportColumnFormat.Currency:
                    var currencyFormat = $"{{0:C{Precision}}}";
                    return string.Format(currencyFormat, value);

                case ReportColumnFormat.Percentage:
                    var percentFormat = $"{{0:P{Precision}}}";
                    return string.Format(percentFormat, value);

                default:
                    throw new ArgumentOutOfRangeException(nameof(Format), Format.ToString());
            }
        }

        public object GetValue(object data)
            => data == null ? null : PropertyInfo.GetValue(data);
    }
}
