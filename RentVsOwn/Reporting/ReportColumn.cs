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

            Description = propertyInfo.Name;
            PropertyInfo = propertyInfo;
            if (propertyInfo.GetCustomAttributes(typeof(ReportColumnAttribute), false).FirstOrDefault() is ReportColumnAttribute attribute)
            {
                if (!string.IsNullOrWhiteSpace(attribute.Description))
                    Description = attribute.Description;
                Alignment = attribute.Alignment;
                Format = attribute.Format;
                Precision = attribute.Precision;
            }
        }

        public string Description { get; set; }

        public ReportColumnAlignment Alignment { get; set; }

        public ReportColumnFormat Format { get; set; }

        public int Precision { get; set; }

        public PropertyInfo PropertyInfo { get; set; }

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
