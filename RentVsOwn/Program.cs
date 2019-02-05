using System;
using System.Linq;
using RentVsOwn.Output;

namespace RentVsOwn
{
    /// <summary>
    ///     Program entry point.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///     Defines the entry point of the application.
        /// </summary>
        private static void Main(string[] args)
        {
            var verbose = args.Any(c => string.Equals(c, "-v", StringComparison.CurrentCultureIgnoreCase)) || args.Any(c => string.Equals(c, "--verbose", StringComparison.CurrentCultureIgnoreCase));
#if DEBUG

            // var output = verbose ? new VerboseOutput() : (IOutput)new DebugOutput();
            // var output = verbose ? new VerboseOutput() : (IOutput)new ConsoleOutput();
            var output = verbose ? new TempFileOutput() : (IOutput)new TempFileOutput();
#else
            var output = verbose? new VerboseOutput() : (IOutput)new ConsoleOutput();
#endif

            try
            {
                var simulator = new Simulation
                {
                    // LandlordManagementFeePercentage = .1m,
                    HoaPerMonth = 0,
                    // Rent = 2100,
                    // LandlordDownPaymentPercentage = null,
                    // LandlordInterestRate = null,
                    // LandlordLoanYears = null,
                    // RentChangePerYearPercentage = 0m,
                    // PropertyTaxPercentage = .0084m,
                    // InsurancePerMonth = 100,
                    // HomeMaintenancePercentagePerYear = .01m,
                };
                simulator.HomeAppreciationPercentagePerYear = simulator.InflationRate;

                simulator.Run(output);
            }
            catch (Exception exception)
            {
                output.WriteLine("===== Failed =====");
                output.WriteLine($"{exception.GetType()}: {exception.Message}");
            }
            finally
            {
                output.Flush();
            }
        }
    }
}
