namespace RentVsOwn
{
    public interface IPeriod
    {
        int Months { get; }

        int Month { get; }

        bool IsFinal { get; }

        bool IsInitial { get; }
    }
}
