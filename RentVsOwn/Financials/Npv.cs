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
        /// <param name="discountRate"></param>
        /// <returns></returns>
        public static double Calculate(double initialInvestment, IList<double> cashFlows, double discountRate)
        {
            var npv = 0d;
            for (var i = 0; i < cashFlows.Count; i++)
            {
                npv += CalculatePresentValue(cashFlows[i], discountRate, i + 1);
            }

            return npv - initialInvestment;
        }

        /// <summary>
        ///     Calculate the Present value of a cashFlow
        /// </summary>
        public static double CalculatePresentValue(double cashFlow, double discountRate, int exponent)
        {
            var pv = cashFlow / Math.Pow(1 + discountRate, exponent);
            return pv;
        }

        public static decimal CalculatePresentValue(decimal cashFlow, decimal discountRate, int exponent)
            => (decimal)CalculatePresentValue((double)cashFlow, (double)discountRate, exponent);
    }
}
