using System;
using System.Collections.Generic;
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

        public static int MaxIterations { get; set; } = 50000;

        public static double Tolerance { get; set; } = 0.00000001;

        private int _iterationCount;

        private readonly double _guess;

        private readonly List<double> _cashFlows;

        public static double Calculate(IList<double> cashFlows, double guess)
        {
            var irr = new Irr(cashFlows, guess);
            var discountRate = irr.Calculate();
            return discountRate;
        }

        private double Calculate(double estimatedReturn)
        {
            _iterationCount++;
            var result = estimatedReturn - SumOfPolynomial(estimatedReturn) / CalculateDerivativeSum(estimatedReturn);
            while (!HasConverged(result) && MaxIterations != _iterationCount)
            {
                result = Calculate(result);
            }

            return result;
        }

        private double Calculate()
        {
            var result = Calculate(_guess);
            if (result > 1)
                throw new Exception("IRR calculation failed to converge.");

            return result;
        }

        /// <summary>
        ///     IRRs the derivative sum.
        /// </summary>
        /// <param name="estimatedReturnRate">The estimated return rate.</param>
        /// <returns></returns>
        private double CalculateDerivativeSum(double estimatedReturnRate)
        {
            var sumOfDerivative = 0d;
            if (IsValidIterationBounds(estimatedReturnRate))
            {
                for (var i = 1; i < _cashFlows.Count; i++)
                {
                    sumOfDerivative += _cashFlows[i] * i / Math.Pow(1 + estimatedReturnRate, i);
                }
            }

            return sumOfDerivative * -1;
        }

        private bool HasConverged(double estimatedReturnRate)
        {
            //Check that the calculated value makes the IRR polynomial zero.
            var isWithinTolerance = Math.Abs(SumOfPolynomial(estimatedReturnRate)) <= Tolerance;
            return isWithinTolerance;
        }

        private static bool IsValidIterationBounds(double estimatedReturnRate) =>
            Math.Abs(estimatedReturnRate + 1) > Tolerance &&
            estimatedReturnRate < int.MaxValue &&
            estimatedReturnRate > int.MinValue;

        private double SumOfPolynomial(double estimatedReturnRate)
        {
            var sumOfPolynomial = 0d;
            if (IsValidIterationBounds(estimatedReturnRate))
            {
                for (var j = 0; j < _cashFlows.Count; j++)
                {
                    sumOfPolynomial += _cashFlows[j] / Math.Pow(1 + estimatedReturnRate, j);
                }
            }

            return sumOfPolynomial;
        }
    }
}
