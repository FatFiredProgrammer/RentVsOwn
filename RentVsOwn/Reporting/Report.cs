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
        private sealed class Separators
        {
            public static readonly Separators Csv = new Separators("\"", "\",\"", "\"");

            public static readonly Separators Markdown = new Separators("|", "|", "|");

            private Separators(string first, string middle, string last)
            {
                First = first;
                Middle = middle;
                Last = last;
            }

            public string First { get; }

            public string Middle { get; }

            public string Last { get; }
        }

        public Report()
        {
        }

        public Report(T item)
        {
            Add(item);
        }

        public decimal DiscountRatePerYear { get; set; }

        private List<T> _data = new List<T>();

        public ReportGrouping Grouping { get; set; }

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

        private void GenerateCalculated(List<ReportColumn> columns)
        {
            foreach (var column in columns)
            {
                column.Calculate(Grouping, (double)DiscountRatePerYear);
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
            GenerateHeaders(text, columns, Separators.Csv);
            GenerateData(text, columns, Separators.Csv);
            GenerateCalculated(columns);
            GenerateFooters(text, columns, Separators.Csv);
            return text.ToString();
        }

        private void GenerateData(StringBuilder text, List<ReportColumn> columns, Separators separators)
        {
            var groups = GetGroups().ToList();
            foreach (var @group in groups)
            {
                var first = true;
                text.Append(separators.First);
                switch (Grouping)
                {
                    case ReportGrouping.Monthly:
                        text.Append($"{@group.Period}");
                        first = false;
                        break;

                    case ReportGrouping.Yearly:
                        text.Append($"{@group.Period}");
                        first = false;
                        break;

                    case ReportGrouping.NotGrouped:
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
                }

                foreach (var column in columns)
                {
                    if (first)
                        first = false;
                    else
                        text.Append(separators.Middle);
                    text.Append($"{column.FormatValue(group.GetValue(column))}");
                    column.Accumulate(@group);
                }

                text.AppendLine(separators.Last);
            }
        }

        private void GenerateFooterAverage(StringBuilder text, List<ReportColumn> columns, Separators separators)
        {
            if (!columns.Any(c => c.CalculateAverage))
                return;

            var first = true;
            text.Append(separators.First);
            switch (Grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append("Average");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
            }

            foreach (var column in columns)
            {
                if (first)
                    first = false;
                else
                    text.Append(separators.Middle);
                if (column.CalculateAverage)
                    text.Append($"{column.FormatValue(column.Average)}");
            }

            text.AppendLine(separators.Last);
        }

        private void GenerateFooterIrr(StringBuilder text, List<ReportColumn> columns, Separators separators)
        {
            if (!columns.Any(c => c.CalculateIrr))
                return;

            var first = true;
            text.Append(separators.First);
            switch (Grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append("IRR");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
            }

            foreach (var column in columns)
            {
                if (first)
                    first = false;
                else
                    text.Append(separators.Middle);
                if (column.CalculateIrr)
                    text.Append($"{ReportColumn.FormatValue(column.Irr, ReportColumnFormat.Percentage, 2)}");
            }

            text.AppendLine(separators.Last);
        }

        private void GenerateFooterNpv(StringBuilder text, List<ReportColumn> columns, Separators separators)
        {
            if (!columns.Any(c => c.CalculateNpv))
                return;

            var first = true;
            text.Append(separators.First);
            switch (Grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append("NPV");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
            }

            foreach (var column in columns)
            {
                if (first)
                    first = false;
                else
                    text.Append(separators.Middle);
                if (column.CalculateNpv)
                    text.Append($"{ReportColumn.FormatValue(column.Npv, ReportColumnFormat.Currency, 0)}");
            }

            text.AppendLine(separators.Last);
        }

        private void GenerateFooters(StringBuilder text, List<ReportColumn> columns, Separators separators)
        {
            GenerateFooterSum(text, columns, separators);
            GenerateFooterAverage(text, columns, separators);
            GenerateFooterNpv(text, columns, separators);
            GenerateFooterIrr(text, columns, separators);
        }

        private void GenerateFooterSum(StringBuilder text, List<ReportColumn> columns, Separators separators)
        {
            if (!columns.Any(c => c.CalculateSum))
                return;

            var first = true;
            text.Append(separators.First);
            switch (Grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append("Sum");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
            }

            foreach (var column in columns)
            {
                if (first)
                    first = false;
                else
                    text.Append(separators.Middle);
                if (column.CalculateSum)
                    text.Append($"{column.FormatValue(column.Sum)}");
            }

            text.AppendLine(separators.Last);
        }

        private void GenerateHeaders(StringBuilder text, List<ReportColumn> columns, Separators separators)
        {
            var first = true;
            text.Append(separators.First);
            switch (Grouping)
            {
                case ReportGrouping.Monthly:
                    text.Append("Month");
                    first = false;
                    break;

                case ReportGrouping.Yearly:
                    text.Append("Year");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
            }

            foreach (var column in columns)
            {
                if (first)
                    first = false;
                else
                    text.Append(separators.Middle);
                text.Append($"{column.Name}");
            }

            text.AppendLine(separators.Last);
        }

        private string GenerateMarkdown(List<ReportColumn> columns)
        {
            var text = new StringBuilder();
            GenerateHeaders(text, columns, Separators.Csv);
            GenerateMarkdownAlignment(text, columns);
            GenerateData(text, columns, Separators.Csv);
            GenerateCalculated(columns);
            GenerateFooters(text, columns, Separators.Csv);
            return text.ToString();
        }

        private void GenerateMarkdownAlignment(StringBuilder text, List<ReportColumn> columns)
        {
            text.Append(Separators.Markdown.First);

            var first = true;
            switch (Grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append(" ---: ");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
            }

            foreach (var column in columns)
            {
                if (first)
                    first = false;
                else
                    text.Append(Separators.Markdown.Middle);
                switch (column.Alignment)
                {
                    case ReportColumnAlignment.Left:
                        text.Append(" :--- ");
                        break;

                    case ReportColumnAlignment.Right:
                        text.Append(" ---: ");
                        break;

                    case ReportColumnAlignment.Center:
                        text.Append(" :---: ");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(column.Alignment), column.Alignment.ToString());
                }
            }

            text.AppendLine(Separators.Markdown.Last);
        }

        private string GenerateParameters(List<ReportColumn> columns)
        {
            if (_data.Count != 1)
                throw new InvalidOperationException($"Report of {nameof(T)} expected one data element.");

            var item = _data[0];
            var text = new StringBuilder();
            text.AppendLine("|Parameter|Value|Notes|");
            text.AppendLine("| :--- | ---: | :--- |");
            foreach (var column in columns)
            {
                text.AppendLine($"|{column.Name}|{column.FormatValue(column.GetValue(item))}|{column.Notes}|");
            }

            return text.ToString();
        }

        private IEnumerable<ReportGroup<T>> GetGroups()
        {
            switch (Grouping)
            {
                case ReportGrouping.Monthly:
                    var month = 0;
                    foreach (var group in _data.Select(c => new ReportGroup<T>(c, month++)))
                    {
                        yield return group;
                    }

                    break;

                case ReportGrouping.Yearly:
                    if (_data.Count > 0)
                    {
                        var year = 0;
                        yield return new ReportGroup<T>(_data[0], year++);

                        const int size = 12;
                        for (var i = 1; i < _data.Count; i += size)
                        {
                            yield return new ReportGroup<T>(_data.GetRange(i, Math.Min(size, _data.Count - i)), year++);
                        }
                    }

                    break;

                case ReportGrouping.NotGrouped:
                    foreach (var group in _data.Select(c => new ReportGroup<T>(c)))
                    {
                        yield return group;
                    }

                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
            }
        }

        /// <inheritdoc />
        public override string ToString()
            => Generate(ReportFormat.Parameters);
    }
}
