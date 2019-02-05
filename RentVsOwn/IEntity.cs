using RentVsOwn.Output;

namespace RentVsOwn
{
    public interface IEntity
    {
        string GenerateReport();

        void Simulate(Simulation simulation, IOutput output);
    }
}
