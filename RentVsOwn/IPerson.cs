namespace RentVsOwn
{
    public interface IPerson
    {
        string Name { get; }

        decimal NetWorth { get; }

        string NpvData();

        void Simulate(Simulation simulation, IOutput output);
    }
}
