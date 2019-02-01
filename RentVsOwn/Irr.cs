using System;
using System.Collections.Generic;

namespace RentVsOwn
{
    /// <summary>
    ///     Internal rate of return calculator based on newton/raphson
    /// </summary>
    public class Irr
    {
        private Irr()
        {
        }

        public static int MaxIterations = 50000;

        public static double Tolerance = 0.00000001;

        private int _numberOfIterations;

        private double _result;

        private List<double> CashFlows { get; } = new List<double>();

        /// <summary>
        ///     Gets a value indicating whether this instance is valid cash flows.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is valid cash flows; otherwise, <c>false</c>.
        /// </value>
        private bool ValidCashFlows
        {
            //Cash flows for the first period must be positive
            //There should be at least two cash flow periods
            get
            {
                const int minPeriods = 2;

                if (CashFlows.Count < minPeriods || (CashFlows[0] > 0))
                {
                    throw new ArgumentOutOfRangeException("Cash flow for the first period must be negative and there should");
                }

                return true;
            }
        }

        /// <summary>
        ///     Gets the initial guess.
        /// </summary>
        /// <value>The initial guess.</value>
        private double InitialGuess => -1 * (1 + (CashFlows[1] / CashFlows[0]));

        private List<KeyValuePair<double, double>> Results { get; } = new List<KeyValuePair<double, double>>();

        public static double Calculate(double initialInvestment, IEnumerable<double> cashFlows)
        {
            var irr = new Irr();
            irr.CashFlows.Add(-initialInvestment);
            irr.CashFlows.AddRange(cashFlows);
            return irr.Execute();
        }

        /// <summary>
        ///     Does the newton rapshon calculation.
        /// </summary>
        /// <param name="estimatedReturn">The estimated return.</param>
        /// <returns></returns>
        private void DoNewtonRapshonCalculation(double estimatedReturn)
        {
            _numberOfIterations++;
            _result = estimatedReturn - SumOfIrrPolynomial(estimatedReturn) / IRRDerivativeSum(estimatedReturn);
            Results.Add(new KeyValuePair<double, double>(_numberOfIterations, _result));

            while (!HasConverged(_result) && MaxIterations != _numberOfIterations)
            {
                DoNewtonRapshonCalculation(_result);
            }
        }

        private double Execute()
        {
            if (ValidCashFlows)
            {
                DoNewtonRapshonCalculation(InitialGuess);

                if (_result > 1)
                {
                    throw new Exception(
                        "Failed to calculate the IRR for the cash flow series. Please provide a valid cash flow sequence");
                }
            }

            return _result;
        }

        /// <summary>
        ///     Determines whether the specified estimated return rate has converged.
        /// </summary>
        /// <param name="estimatedReturnRate">The estimated return rate.</param>
        /// <returns>
        ///     <c>true</c> if the specified estimated return rate has converged; otherwise, <c>false</c>.
        /// </returns>
        private bool HasConverged(double estimatedReturnRate)
        {
            //Check that the calculated value makes the IRR polynomial zero.
            var isWithinTolerance = Math.Abs(SumOfIrrPolynomial(estimatedReturnRate)) <= Tolerance;
            return (isWithinTolerance) ? true : false;
        }

        /// <summary>
        ///     IRRs the derivative sum.
        /// </summary>
        /// <param name="estimatedReturnRate">The estimated return rate.</param>
        /// <returns></returns>
        private double IRRDerivativeSum(double estimatedReturnRate)
        {
            var sumOfDerivative = 0d;
            if (IsValidIterationBounds(estimatedReturnRate))
            {
                for (var i = 1; i < CashFlows.Count; i++)
                {
                    sumOfDerivative += CashFlows[i] * (i) / Math.Pow((1 + estimatedReturnRate), i);
                }
            }

            return sumOfDerivative * -1;
        }

        /// <summary>
        ///     Determines whether [is valid iteration bounds] [the specified estimated return rate].
        /// </summary>
        /// <param name="estimatedReturnRate">The estimated return rate.</param>
        /// <returns>
        ///     <c>true</c> if [is valid iteration bounds] [the specified estimated return rate]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsValidIterationBounds(double estimatedReturnRate) =>
            estimatedReturnRate != -1 && (estimatedReturnRate < int.MaxValue) &&
            (estimatedReturnRate > int.MinValue);

        /// <summary>
        ///     Sums the of IRR polynomial.
        /// </summary>
        /// <param name="estimatedReturnRate">The estimated return rate.</param>
        /// <returns></returns>
        private double SumOfIrrPolynomial(double estimatedReturnRate)
        {
            var sumOfPolynomial = 0d;
            if (IsValidIterationBounds(estimatedReturnRate))
            {
                for (var j = 0; j < CashFlows.Count; j++)
                {
                    sumOfPolynomial += CashFlows[j] / (Math.Pow((1 + estimatedReturnRate), j));
                }
            }

            return sumOfPolynomial;
        }
    }
}
