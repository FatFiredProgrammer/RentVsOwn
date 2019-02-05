using System;
using System.Collections.Generic;

namespace RentVsOwn.Financial
{
    public static class Npv
    {
        /// <summary>
        ///     Calculates the NPV for a series of cash flows
        /// </summary>
        /// <param name="initialInvestment"></param>
        /// <param name="cashFlows"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static double Calculate(double initialInvestment, IList<double> cashFlows, double rate)
        {
            double npv = 0;
            for (var i = 0; i < cashFlows.Count; i++)
            {
                npv += CalculatePresentValue(cashFlows[i], rate, i + 1);
            }

            // Subtract initial investment. Example 2: http://office.microsoft.com/en-au/excel-help/npv-HP005209199.aspx
            return npv - initialInvestment;
        }

        /// <summary>
        ///     Calculate the Present value of a cashFlow
        /// </summary>
        private static double CalculatePresentValue(double cashFlow, double rate, double exponent)
        {
            var pv = cashFlow / Math.Pow(1 + rate, exponent);
            return pv;
        }
    }
}
