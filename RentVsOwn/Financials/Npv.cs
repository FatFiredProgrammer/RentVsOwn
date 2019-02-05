using System;
using System.Collections.Generic;

namespace RentVsOwn.Financials
{
    public static class Npv
    {
        /// <summary>
        ///     Calculates the NPV for a series of cash flows
        /// </summary>
        /// <param name="initialInvestment"></param>
        /// <param name="cashFlows"></param>
        /// <param name="discountRatePerYear"></param>
        /// <returns></returns>
        public static double Calculate(double initialInvestment, IList<double> cashFlows, double discountRatePerYear)
        {
            var discountRatePerMonth = Math.Pow(1 + discountRatePerYear, 1d / 12d) - 1;

            var npv = 0d;
            for (var i = 0; i < cashFlows.Count; i++)
            {
                npv += CalculatePresentValue(cashFlows[i], discountRatePerMonth, i + 1);
            }

            return npv - initialInvestment;
        }

        /// <summary>
        ///     Calculate the Present value of a cashFlow
        /// </summary>
        public static double CalculatePresentValue(double cashFlow, double discountRatePerMonth, int exponent)
        {
            var pv = cashFlow / Math.Pow(1 + discountRatePerMonth, exponent);
            return pv;
        }

        public static decimal CalculatePresentValue(decimal cashFlow, decimal discountRatePerMonth, int exponent)
            => (decimal)CalculatePresentValue((double)cashFlow, (double)discountRatePerMonth, exponent);
    }
}
