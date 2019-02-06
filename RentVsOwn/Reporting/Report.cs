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

            public static readonly Separators None = new Separators(string.Empty, string.Empty, string.Empty);

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

        private List<string> _notes = new List<string>();

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _data.Add(item);
        }

        public void AddNote(string note)
        {
            if (note == null)
                throw new ArgumentNullException(nameof(note));

            _notes.Add(note);
        }

        public string Generate(ReportGrouping grouping, ReportFormat format)
        {
            var columns = GenerateColumns().ToList();
            if (columns.Count == 0)
                return string.Empty;

            switch (format)
            {
                case ReportFormat.Markdown:
                    return GenerateNotes(format, Separators.None) + GenerateMarkdown(grouping, columns);

                case ReportFormat.Csv:
                    return GenerateNotes(format, Separators.Csv) + GenerateCsv(grouping, columns);

                case ReportFormat.Parameters:
                    return GenerateNotes(format, Separators.None) + GenerateParameters(columns);

                default:
                    throw new ArgumentOutOfRangeException(nameof(format), format, null);
            }
        }

        private void GenerateCalculated(ReportGrouping grouping, List<ReportColumn> columns)
        {
            foreach (var column in columns)
            {
                column.Calculate(grouping, (double)DiscountRatePerYear);
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

        private string GenerateCsv(ReportGrouping grouping, List<ReportColumn> columns)
        {
            var text = new StringBuilder();
            GenerateHeaders(text, grouping, columns, Separators.Csv);
            GenerateData(text, grouping, columns, Separators.Csv);
            GenerateCalculated(grouping, columns);
            GenerateFooters(text, grouping, columns, Separators.Csv);
            return text.ToString();
        }

        private void GenerateData(StringBuilder text, ReportGrouping grouping, List<ReportColumn> columns, Separators separators)
        {
            var groups = GetGroups(grouping).ToList();
            foreach (var @group in groups)
            {
                var first = true;
                text.Append(separators.First);
                switch (grouping)
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
                        throw new ArgumentOutOfRangeException(nameof(grouping), grouping.ToString());
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

        private void GenerateFooterAverage(StringBuilder text, ReportGrouping grouping, List<ReportColumn> columns, Separators separators)
        {
            if (!columns.Any(c => c.CalculateAverage))
                return;

            var first = true;
            text.Append(separators.First);
            switch (grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append("Average");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(grouping), grouping.ToString());
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

        private void GenerateFooterIrr(StringBuilder text, ReportGrouping grouping, List<ReportColumn> columns, Separators separators)
        {
            if (!columns.Any(c => c.CalculateIrr))
                return;

            var first = true;
            text.Append(separators.First);
            switch (grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append("IRR");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(grouping), grouping.ToString());
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

        private void GenerateFooterNpv(StringBuilder text, ReportGrouping grouping, List<ReportColumn> columns, Separators separators)
        {
            if (!columns.Any(c => c.CalculateNpv))
                return;

            var first = true;
            text.Append(separators.First);
            switch (grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append("NPV");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(grouping), grouping.ToString());
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

        private void GenerateFooters(StringBuilder text, ReportGrouping grouping, List<ReportColumn> columns, Separators separators)
        {
            GenerateFooterSum(text, grouping, columns, separators);
            GenerateFooterAverage(text, grouping, columns, separators);
            GenerateFooterNpv(text, grouping, columns, separators);
            GenerateFooterIrr(text, grouping, columns, separators);
        }

        private void GenerateFooterSum(StringBuilder text, ReportGrouping grouping, List<ReportColumn> columns, Separators separators)
        {
            if (!columns.Any(c => c.CalculateSum))
                return;

            var first = true;
            text.Append(separators.First);
            switch (grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append("Sum");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(grouping), grouping.ToString());
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

        private void GenerateHeaders(StringBuilder text, ReportGrouping grouping, List<ReportColumn> columns, Separators separators)
        {
            var first = true;
            text.Append(separators.First);
            switch (grouping)
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
                    throw new ArgumentOutOfRangeException(nameof(grouping), grouping.ToString());
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

        private string GenerateMarkdown(ReportGrouping grouping, List<ReportColumn> columns)
        {
            var text = new StringBuilder();
            GenerateHeaders(text, grouping, columns, Separators.Markdown);
            GenerateMarkdownAlignment(text, grouping, columns);
            GenerateData(text, grouping, columns, Separators.Markdown);
            GenerateCalculated(grouping, columns);
            GenerateFooters(text, grouping, columns, Separators.Markdown);
            return text.ToString();
        }

        private void GenerateMarkdownAlignment(StringBuilder text, ReportGrouping grouping, List<ReportColumn> columns)
        {
            text.Append(Separators.Markdown.First);

            var first = true;
            switch (grouping)
            {
                case ReportGrouping.Monthly:
                case ReportGrouping.Yearly:
                    text.Append(" ---: ");
                    first = false;
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(grouping), grouping.ToString());
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

        private string GenerateNotes(ReportFormat format, Separators separators)
        {
            if (_notes.Count == 0)
                return string.Empty;

            var text = new StringBuilder();
            foreach (var note in _notes)
            {
                text.Append(separators.First);
                text.Append(note);
                text.AppendLine(separators.Last);
            }

            text.AppendLine();
            return text.ToString();
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

        private IEnumerable<ReportGroup<T>> GetGroups(ReportGrouping grouping)
        {
            switch (grouping)
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
                    throw new ArgumentOutOfRangeException(nameof(grouping), grouping.ToString());
            }
        }

        /// <inheritdoc />
        public override string ToString()
            => Generate(ReportGrouping.NotGrouped, ReportFormat.Parameters);
    }
}
