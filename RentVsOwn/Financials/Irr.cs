using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RentVsOwn.Financials
{
    /// <summary>
    ///     Internal rate of return calculator based on newton/raphson
    /// </summary>
    public class Irr
    {
        private Irr(IList<double> cashFlows, double guess)
        {
            if (cashFlows == null || cashFlows.Count < 2)
                throw new ArgumentException("cashFlows.Count < 2", nameof(cashFlows));
            if (cashFlows[0] >= 0)
                throw new ArgumentException("cashFlows[0] >= 0", nameof(cashFlows));

            _guess = guess;
            _cashFlows = cashFlows.ToList();
        }

        public static int MaxIterations { get; set; } = 25;

        public static double Precision { get; set; } = 0.00000001;

        private readonly double _guess;

        private readonly List<double> _cashFlows;

        public static double Calculate(IList<double> cashFlows, double guess)
        {
            var irr = new Irr(cashFlows, guess);
            var discountRate = irr.Calculate();
            return discountRate;
        }

        private double Calculate(double guess)
        {
            var x0 = guess;
            var i = 0;

            while (i < MaxIterations && !double.IsInfinity(x0) && !double.IsNaN(x0))
            {
                var npv = 0d;
                var ddx = 0d;

                var x2 = x0;
                npv = Reduce(_cashFlows, (pv, pmt, t) => pv + pmt / Math.Pow(x2 + 1.0d, t), 0d);
                var x3 = x0;
                ddx = Reduce(_cashFlows, (pv, pmt, t) => pv + -t * pmt / Math.Pow(x3 + 1.0d, t + 1), 0d);
                var x1 = x0 - npv / ddx;
                if (double.IsInfinity(x1) || double.IsNaN(x1))
                    break;

                if (Math.Abs(x1 - x0) <= Precision)
                    return x1;

                x0 = x1;
                ++i;
            }

            return double.NaN;
        }

        private double Calculate()
        {
            var value = Calculate(_guess);
            if (!double.IsNaN(value))
                return value;

            value = Calculate(.1d);
            if (!double.IsNaN(value))
                return value;

            return Calculate(-.1d);
        }

        private static double Reduce(IEnumerable<double> array, Func<double, double, int, double> fn, double initialValue)
        {
            var index = 0;
            return array.Aggregate(initialValue, (current, item) => fn(current, item, index++));
        }
    }
}
