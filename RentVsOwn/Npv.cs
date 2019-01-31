using System;
using System.Collections.Generic;

namespace RentVsOwn
{
    public static class Npv
    {
        /// <summary>
        ///     Calculates the NPV for a series of cashflows
        /// </summary>
        /// <param name="initialInvestment"></param>
        /// <param name="cashFlows"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static decimal Calculate(decimal initialInvestment, IList<decimal> cashFlows, decimal rate)
        {
            //Guard.IsInRange(rate, "rate", 0, 100);

            decimal npv = 0;
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
        private static decimal CalculatePresentValue(decimal cashFlow, decimal rate, double exponent)
        {
            var pv = cashFlow / (decimal)Math.Pow((double)(1 + rate), exponent);
            return pv;
        }
    }
}
