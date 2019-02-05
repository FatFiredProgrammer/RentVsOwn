using System.Collections.Generic;
using System.Text;

namespace RentVsOwn.Financials
{
    public sealed class Financial
    {
        public Financial()
        {
            
        }
        public Financial(double initialInvestment, double discountRatePerMonth)
        {

        }

        public double? Npv { get; private set; }
        public double? Irr { get; private set; }

        /// <summary>
        /// Gets or sets the discount rate per annum.
        /// </summary>
        /// <value>The rate.</value>
        public double DiscountRatePerMonth { get; set; } = .08d;
        public double InitialInvestment { get; set; }

        private List<double> _cashFlows = new List<double>();

        public void Add(double cashFlow)
        {
            // TODO: Code needs work
#if false
                 monthly.NpvCashFlow = (decimal)_cashFlows[_cashFlows.Count - 1];

            output.WriteLine($"* Net present value of {_npv:C0}");
            output.WriteLine($"* Internal rate of return of {_irr:P2}");
            Debug.Assert(Math.Abs(Npv.Calculate((double)_initialInvestment, _cashFlows, (double)_irr / 12)) < .1); 
#endif

        }

        public void Calculate()
        {
            if (_cashFlows.Count >= 1)
            {
                Npv = Financials.Npv.Calculate(InitialInvestment, _cashFlows, (double)DiscountRatePerMonth / 12);
                Irr = Financials.Irr.Calculate(InitialInvestment, _cashFlows, (double)DiscountRatePerMonth / 12) * 12;
            }
            else
            {
                Npv = null;
                Irr = null;
            }

        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            if (Npv.HasValue)
                text.AppendLine($"Net present value of {Npv:C0}");
            if (Irr.HasValue)
                text.AppendLine($"Internal rate of return of {Irr:P2}");
            return text.ToString().TrimEnd();
        }
    }
}
