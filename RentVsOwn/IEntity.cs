using RentVsOwn.Output;

namespace RentVsOwn
{
    public interface IEntity
    {
        string Name { get; }

        string GenerateReport();

        void Simulate(ISimulation simulation, IOutput output);
    }
}
