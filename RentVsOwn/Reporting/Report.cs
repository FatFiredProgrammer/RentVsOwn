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
            GenerateCsvHeaders(text, columns);

            var groups = GetGroups().ToList();
            foreach (var @group in groups)
            {
                var first = true;
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
                        text.Append(",");
                    text.Append($"\"{column.FormatValue(group.GetValue(column))}\"");
                    column.Accumulate(@group);
                }

                text.AppendLine();

            }


            return text.ToString();
        }

        private void GenerateCsvHeaders(StringBuilder text, List<ReportColumn> columns)
        {
            var first = true;
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
                    text.Append(",");
                text.Append($"\"{column.Name}\"");
            }

            text.AppendLine();
        }

        private string GenerateMarkdown(List<ReportColumn> columns)
        {
            var text = new StringBuilder();
            GenerateMarkdownHeaders(text, columns);

            // TODO: Code needs work
#if false
                 var groups = GetGroups().ToList();

            foreach (var item in _data)
            {
                text.Append("|");
                foreach (var column in columns)
                {
                    text.Append($"{column.GetFormattedValue(item)}|");
                }

                text.AppendLine();
            } 
#endif


            return text.ToString();
        }

        private void GenerateMarkdownHeaders(StringBuilder text, List<ReportColumn> columns)
        {
            text.Append("|");
            switch (Grouping)
            {
                case ReportGrouping.Monthly:
                    text.Append("Month|");
                    break;

                case ReportGrouping.Yearly:
                    text.Append("Year|");
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
            }

            foreach (var column in columns)
            {
                text.Append($"{column.Name}|");
            }

            text.AppendLine();

            text.Append("|");
            switch (Grouping)
            {
                case ReportGrouping.Monthly:
                    text.Append(" ---: |");
                    break;

                case ReportGrouping.Yearly:
                    text.Append(" ---: |");
                    break;

                case ReportGrouping.NotGrouped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(Grouping), Grouping.ToString());
            }

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
            }

            text.AppendLine();
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
                text.AppendLine($"|{column.Name}|{column.FormatValue(item)}|{column.Notes}|");
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
#if false
// TODO: Code needs work
using System.Collections.Generic;
using System.Text;

namespace RentVsOwn.Financials
{
    public sealed class Financial
    {
        public Financial()
        {
        }
        public Financial(double initialInvestment, double discountRatePerMonth)
        {

        }

        public double? Npv { get; private set; }
        public double? Irr { get; private set; }

        /// <summary>
        /// Gets or sets the discount rate per annum.
        /// </summary>
        /// <value>The rate.</value>
        public double DiscountRatePerMonth { get; set; } = .08d;
        public double InitialInvestment { get; set; }

        private List<double> _cashFlows = new List<double>();

        public void Add(double cashFlow)
        {
            // TODO: Code needs work
#if false
                 monthly.NpvCashFlow = (decimal)_cashFlows[_cashFlows.Count - 1];

            output.WriteLine($"* Net present value of {_npv:C0}");
            output.WriteLine($"* Internal rate of return of {_irr:P2}");
            Debug.Assert(Math.Abs(Npv.Calculate((double)_initialInvestment, _cashFlows, (double)_irr / 12)) < .1); 
#endif

        }

        public void Calculate()
        {
            if (_cashFlows.Count >= 1)
            {
                Npv = Financials.Npv.Calculate(InitialInvestment, _cashFlows, (double)DiscountRatePerMonth / 12);
                Irr = Financials.Irr.Calculate(InitialInvestment, _cashFlows, (double)DiscountRatePerMonth / 12) * 12;
            }
            else
            {
                Npv = null;
                Irr = null;
            }

        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            if (Npv.HasValue)
                text.AppendLine($"Net present value of {Npv:C0}");
            if (Irr.HasValue)
                text.AppendLine($"Internal rate of return of {Irr:P2}");
            return text.ToString().TrimEnd();
        }
    }
}

#endif
