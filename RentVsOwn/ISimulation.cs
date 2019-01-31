namespace RentVsOwn
{
    public interface ISimulation
    {
        void Simulate(IPeriod period, IOutput output);
    }
}
