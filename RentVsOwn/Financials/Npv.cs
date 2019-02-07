using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace RentVsOwn.Financials
{
    [PublicAPI]
    public static class Npv
    {
        /// <summary>
        ///     Calculates the NPV for a series of cash flows
        /// </summary>
        /// <param name="cashFlows"></param>
        /// <param name="discountRate"></param>
        /// <returns></returns>
        public static double Calculate(IList<double> cashFlows, double discountRate)
        {
            if (cashFlows == null || cashFlows.Count < 2)
                throw new ArgumentException("cashFlows.Count < 2", nameof(cashFlows));
            if (cashFlows[0] >= 0)
                throw new ArgumentException("cashFlows[0] >= 0", nameof(cashFlows));

            var npv = 0d;
            for (var i = 1; i < cashFlows.Count; i++)
            {
                npv += CalculatePresentValue(cashFlows[i], discountRate, i);
            }

            return npv + cashFlows[0];
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
