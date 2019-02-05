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
        /// <param name="annualDiscountRate"></param>
        /// <returns></returns>
        public static double Calculate(double initialInvestment, IList<double> cashFlows, double annualDiscountRate)
        {
            var monthlyDiscountRate = Math.Pow(1 + annualDiscountRate, 1d / 12d) - 1;

            var npv = 0d;
            for (var i = 0; i < cashFlows.Count; i++)
            {
                npv += CalculatePresentValue(cashFlows[i], monthlyDiscountRate, i + 1);
            }

            return npv - initialInvestment;
        }

        /// <summary>
        ///     Calculate the Present value of a cashFlow
        /// </summary>
        private static double CalculatePresentValue(double cashFlow, double monthlyDiscountRate, double exponent)
        {
            var pv = cashFlow / Math.Pow(1 + monthlyDiscountRate, exponent);
            return pv;
        }
    }
}
