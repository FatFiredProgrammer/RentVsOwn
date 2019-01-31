using System;

namespace RentVsOwn
{
    public sealed class Period : IPeriod
    {
        public Period(Scenario scenario)
        {
            if (scenario == null)
                throw new ArgumentNullException(nameof(scenario));

            Months = Math.Max(1, (int)Math.Round(scenario.Years / 12, 0));
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
