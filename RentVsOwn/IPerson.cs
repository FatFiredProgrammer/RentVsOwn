namespace RentVsOwn
{
    public interface IPerson
    {
        string Name { get; }

        decimal NetWorth { get; }

        void Simulate(Simulation simulation, IOutput output);
    }
}
