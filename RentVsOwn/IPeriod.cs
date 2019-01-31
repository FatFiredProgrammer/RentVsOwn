namespace RentVsOwn
{
    public interface IPeriod
    {
        int Month { get; }

        bool IsFinal { get; }

        bool IsInitial { get; }
    }
}
