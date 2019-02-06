using System;
using JetBrains.Annotations;

namespace RentVsOwn.Financials
{
    [PublicAPI]
    public static class Financial
    {
        public static double ConvertDiscountRateMonthToYear(double discountRatePerMonth)
        {
            var discountRatePerYear = Math.Pow(1d + discountRatePerMonth, 12) - 1;
            return discountRatePerYear;
        }

        public static decimal ConvertDiscountRateMonthToYear(decimal discountRatePerMonth)
            => (decimal)ConvertDiscountRateMonthToYear((double)discountRatePerMonth);

        public static double ConvertDiscountRateYearToMonth(double discountRatePerYear)
        {
            var discountRatePerMonth = Math.Pow(1 + discountRatePerYear, 1d / 12d) - 1;
            return discountRatePerMonth;
        }

        public static decimal ConvertDiscountRateYearToMonth(decimal discountRatePerYear)
            => (decimal)ConvertDiscountRateYearToMonth((double)discountRatePerYear);
    }
}
