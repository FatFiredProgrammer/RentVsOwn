using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using JetBrains.Annotations;

namespace RentVsOwn.Reporting
{
    [PublicAPI]
    public sealed class Report<T>
        where T : class
    {
        public Report()
        {
        }

        public Report(T item)
        {
            Add(item);
        }

        private List<T> _data = new List<T>();

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _data.Add(item);
        }

        public string Generate(ReportFormat format)
        {
            var columns = GenerateColumns().ToList();
            if (columns.Count == 0)
                return string.Empty;

            switch (format)
            {
                case ReportFormat.Markdown:
                    return GenerateMarkdown(columns);

                case ReportFormat.Csv:
                    return GenerateCsv(columns);

                case ReportFormat.Parameters:
                    return GenerateParameters(columns);

                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }
        }

        private IEnumerable<ReportColumn> GenerateColumns()
        {
            var propertyInfos = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty);
            foreach (var propertyInfo in propertyInfos)
            {
                if (propertyInfo.GetCustomAttributes(typeof(ReportColumnAttribute), false).FirstOrDefault() is ReportColumnAttribute attribute)
                {
                    if (attribute.Ignore)
                        continue;
                }

                yield return new ReportColumn(propertyInfo);
            }
        }

        private string GenerateCsv(List<ReportColumn> columns)
        {
            var text = new StringBuilder();

            var first = true;
            foreach (var column in columns)
            {
                if (first)
                    first = false;
                else
                    text.Append("\t");
                text.Append($"\"{column.Description}\"");
            }

            text.AppendLine();

            foreach (var item in _data)
            {
                first = true;
                foreach (var column in columns)
                {
                    if (first)
                        first = false;
                    else
                        text.Append("\t");
                    text.Append($"{column.GetFormattedValue(item)}");
                }

                text.AppendLine();
            }

            return text.ToString();
        }

        private string GenerateMarkdown(List<ReportColumn> columns)
        {
            var text = new StringBuilder();

            text.Append("|");
            foreach (var column in columns)
            {
                text.Append($"{column.Description}|");
            }

            text.AppendLine();

            text.Append("|");
            foreach (var column in columns)
            {
                switch (column.Alignment)
                {
                    case ReportColumnAlignment.Left:
                        text.Append(" :--- |");
                        break;

                    case ReportColumnAlignment.Right:
                        text.Append(" ---: |");
                        break;

                    case ReportColumnAlignment.Center:
                        text.Append(" :---: |");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(column.Alignment), column.Alignment.ToString());
                }

                text.Append($"{column.Description}");
            }

            text.AppendLine();

            foreach (var item in _data)
            {
                text.Append("|");
                foreach (var column in columns)
                {
                    text.Append($"{column.GetFormattedValue(item)}|");
                }

                text.AppendLine();
            }

            return text.ToString();
        }

        private string GenerateParameters(List<ReportColumn> columns)
        {
            if (_data.Count != 1)
                throw new InvalidOperationException($"Report of {nameof(T)} expected one data element.");

            var item = _data[0];
            var text = new StringBuilder();
            text.AppendLine("|Parameter|Value|");
            text.AppendLine("| :--- | ---: |");
            foreach (var column in columns)
            {
                text.AppendLine($"|{column.Description}|{column.GetFormattedValue(item)}|");
            }

            return text.ToString();
        }

        /// <inheritdoc />
        public override string ToString()
            => Generate(ReportFormat.Parameters);
    }
}
