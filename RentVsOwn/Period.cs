using System;

namespace RentVsOwn
{
    public sealed class Period : IPeriod
    {
        public Period(int months)
        {
            if (months <= 0)
                throw new ArgumentException("months <= 0", nameof(months));

            Months = months;
        }

        public int Month { get; private set; } = 1;

        public int Months { get; }

        public bool IsFinal => Month == 1;

        public bool IsInitial => Month == Months;

        public bool Next()
        {
            ++Month;
            return Month <= Months;
        }
    }
}
