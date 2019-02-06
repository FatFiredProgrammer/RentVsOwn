#if false
// TODO: Code needs work

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using JetBrains.Annotations;
using RentVsOwn.Financials;
using RentVsOwn.Output;
using RentVsOwn.Reporting;

namespace RentVsOwn
{
    public sealed class Owner : IEntity
    {
        [PublicAPI]
        private sealed class Data
        {
            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Expenses => Rent + RentersInsurance;

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal Rent { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateSum = true, CalculateAverage = true, IncludePeriod0 = false)]
            public decimal RentersInsurance { get; set; }

            [ReportColumn(Format = ReportColumnFormat.Currency, Grouping = ReportColumnGrouping.Sum, CalculateNpv = true, CalculateIrr = true)]
            public decimal CashFlow { get; set; }
        }

        private sealed class Monthly
        {
            public decimal Total { get; set; }

            public decimal Expenses { get; set; }

            public decimal Principal { get; set; }

            public decimal Interest { get; set; }

            public decimal NpvCashFlow { get; set; }

            public decimal HomeValue { get; set; }
        }

        public Renter(ISimulation simulation, IOutput output)
            :base(simulation, output)
        {
        }


        public string Name => nameof(Owner);

        private decimal _netWorth;

        private decimal _initialInvestment;

        private decimal _cash;

        private decimal _totalSpent;

        private decimal _averageSpent;

        private double? _npv;

        private double? _irr;

        private List<double> _cashFlows = new List<double>();

        private List<Monthly> _months = new List<Monthly>();
        private readonly Report<Data> _report = new Report<Data>();
        [ReportColumn(Ignore = true)]
        public decimal OwnerLoanBalance { get; set; }

        [ReportColumn(Ignore = true)]
        public decimal OwnerHomeValue { get; set; }

        private void Finalize(Monthly monthly, ISimulation simulation, IOutput output)
        {
            var homeValue = simulation.OwnerHomeValue;
            output.WriteLine($"* Sold home for {homeValue:C0}");
            var salesFixedCosts = simulation.SellerFixedCosts;
            var salesCommission = (simulation.SellerCommissionPercentage * homeValue).ToDollars();
            output.WriteLine($"* Fixed sales costs of {salesFixedCosts:C0} and commission of {salesCommission:C0}");
            var proceeds = homeValue - salesFixedCosts - salesCommission;
            if (simulation.OwnerLoanBalance > 0)
            {
                output.WriteLine($"* Paid off loan balance of {simulation.OwnerLoanBalance:C0}");
                proceeds -= simulation.OwnerLoanBalance;
                simulation.OwnerLoanBalance = 0;
            }

            simulation.OwnerHomeValue = 0;

            output.WriteLine($"* Home sale proceeds of {proceeds:C0}");
            _cash += proceeds;
            _cash = _cash.ToDollars();

            // Add in this very last cash flow
            _cashFlows[_cashFlows.Count - 1] += (double)proceeds;
            output.WriteLine($"* Adjusted NPV cash flow of {_cashFlows[_cashFlows.Count - 1]:C0} accounting for sale proceeds of {proceeds:C0}");
            monthly.NpvCashFlow = (decimal)_cashFlows[_cashFlows.Count - 1];

            // TODO: 
            // TODO: Code needs work
#if false
                 _npv = Npv.Calculate((double)_initialInvestment, _cashFlows, (double)simulation.DiscountRatePerYear / 12);
            output.WriteLine($"* Net present value of {_npv:C0}");
            _irr = Irr.Calculate((double)_initialInvestment, _cashFlows, (double)simulation.DiscountRatePerYear / 12) * 12;
            output.WriteLine($"* Internal rate of return of {_irr:P2}");
            Debug.Assert(Math.Abs(Npv.Calculate((double)_initialInvestment, _cashFlows, (double)_irr / 12)) < .1); 
#endif

        }

        private void Initialize(ISimulation simulation, IOutput output)
        {
            OwnerHomeValue = simulation.HomePurchaseAmount;
            OwnerLoanBalance = simulation.OwnerLoanAmount;

            _initialInvestment = 0;
            _cash = 0;
            _totalSpent = 0;
            _averageSpent = 0;
            _cashFlows = new List<double>();
            _months = new List<Monthly>();
            _npv = null;
            _irr = null;

            output.WriteLine($"* Down payment of {simulation.OwnerDownPayment:C0}");
            _initialInvestment += simulation.OwnerDownPayment;
            output.WriteLine($"* Fixed closing costs of {simulation.BuyerFixedCosts:C0}");
            _initialInvestment += simulation.BuyerFixedCosts;
            var variableClosingCosts = simulation.OwnerLoanAmount * simulation.BuyerVariableCostsPercentage;
            output.WriteLine($"* Variable closing costs of {variableClosingCosts:C0}");
            _initialInvestment += variableClosingCosts;
            output.WriteLine($"* Total initial investment of {_initialInvestment:C0}");
            output.WriteLine($"* Initial loan balance of {simulation.OwnerLoanBalance:C0}");
#if false
     Report.AddNotes
            _report.DiscountRatePerYear = simulation.DiscountRatePerYear;
            _report.AddNote(output.WriteLine($"* {_report.DiscountRatePerYear:P2} annual discount rate; {Financial.ConvertDiscountRateYearToMonth(_report.DiscountRatePerYear):P4} monthly discount rate"));
            _report.Add(new Data
            {
                CashFlow = -_initialCash,
            }); 
#endif
        }

        /// <inheritdoc />
        public string GenerateReport(ReportGrouping grouping, ReportFormat format)
            => _report.Generate(grouping, format);

        /// <inheritdoc />
        public void NextYear(ISimulation simulation, IOutput output)
        {
            output.WriteLine(Simulation.Separator);
            output.WriteLine($"{Name} Year # {Month / 12}{Environment.NewLine}");
            if (RentChangePerYearPercentage > 0)
            {
                CurrentRentPerMonth = (CurrentRentPerMonth + CurrentRentPerMonth * (RentChangePerYearPercentage ?? 0m)).ToDollars();
                output.WriteLine($"* Rent increased {RentChangePerYearPercentage:P2} to {CurrentRentPerMonth:C0}");
            }

            if (HomeAppreciationPercentagePerYear > 0)
            {
                OwnerHomeValue = (OwnerHomeValue + OwnerHomeValue * HomeAppreciationPercentagePerYear).ToDollars();
                output.WriteLine($"* Owner Home value increased {HomeAppreciationPercentagePerYear:P2} to {OwnerHomeValue:C0}");
                LandlordHomeValue = (LandlordHomeValue + LandlordHomeValue * HomeAppreciationPercentagePerYear).ToDollars();
                output.WriteLine($"* Landlord Home value increased {HomeAppreciationPercentagePerYear:P2} to {LandlordHomeValue:C0}");
            }

            if (InflationRatePerYear > 0)
            {
                RentersInsurancePerMonth = (RentersInsurancePerMonth + RentersInsurancePerMonth * InflationRatePerYear).ToDollarCents();
                output.WriteLine($"* Renters insurance increased {InflationRatePerYear:P2} to {RentersInsurancePerMonth:C2}");
                InsurancePerMonth = (InsurancePerMonth + InsurancePerMonth * InflationRatePerYear).ToDollarCents();
                output.WriteLine($"* Home owner's insurance increased {InflationRatePerYear:P2} to {InsurancePerMonth:C2}");
                HoaPerMonth = (HoaPerMonth + HoaPerMonth * InflationRatePerYear).ToDollarCents();
                output.WriteLine($"* HOA increased {InflationRatePerYear:P2} to {HoaPerMonth:C2}");
            }
        }

        private Monthly Process(ISimulation simulation, IOutput output)
        {
            var monthly = new Monthly
            {
                Principal = 0m,
                Expenses = 0m,
                Interest = 0m,
                NpvCashFlow = 0m,
                Total = 0m,
                HomeValue = simulation.OwnerHomeValue,
            };
            var expense = 0m;
            if (simulation.OwnerLoanBalance > 0)
            {
                var loanPayment = simulation.OwnerMonthlyPayment;
                monthly.Total = loanPayment;
                monthly.Interest = (simulation.OwnerLoanBalance * simulation.OwnerInterestRatePerYear / 12).ToDollars();
                monthly.Principal = Math.Min(loanPayment - monthly.Interest, simulation.OwnerLoanBalance).ToDollars();

                expense += monthly.Principal + monthly.Interest;
                output.WriteLine($"* Loan payment of {loanPayment:C0} ({monthly.Principal:C0} principal / {monthly.Interest:C0} interest)");

                simulation.OwnerLoanBalance -= monthly.Principal;
                output.WriteLine($"* New loan balance of {simulation.OwnerLoanBalance:C0}");
            }

            var propertyTax = (simulation.OwnerHomeValue * simulation.PropertyTaxPercentagePerYear / 12).ToDollars();
            expense += propertyTax;
            output.WriteLine($"* Spent {propertyTax:C0} on property tax");
            if (simulation.InsurancePerMonth > 0)
            {
                expense += simulation.InsurancePerMonth;
                monthly.Expenses += simulation.InsurancePerMonth;
                output.WriteLine($"* Spent {simulation.InsurancePerMonth:C0} on insurance");
            }

            if (simulation.HoaPerMonth > 0)
            {
                expense += simulation.HoaPerMonth;
                monthly.Expenses += simulation.HoaPerMonth;
                output.WriteLine($"* Spent {simulation.HoaPerMonth:C0} on HOA");
            }

            var homeMaintenance = (simulation.OwnerHomeValue * simulation.HomeMaintenancePercentagePerYear / 12).ToDollars();
            expense += homeMaintenance;
            monthly.Expenses += homeMaintenance;
            output.WriteLine($"* Spent {homeMaintenance:C0} on home maintenance");

            output.WriteLine($"* Total expense this month {expense:C0}");
            _totalSpent += expense;

            _months.Add(monthly);

            // monthly.PersonalLoan could be positive or negative depending on whether we took out loan or repaid one.
            // Essentially, the personal loan causes us to defer cash flow (for NPV/IRR) until we actually payback the loan.
            var cashFlow = monthly.NpvCashFlow;
            _cashFlows.Add((double)monthly.NpvCashFlow);
            output.WriteLine($"* NPV cash flow of {cashFlow:C0}");

            return monthly;
        }

        /// <inheritdoc />
        public void Simulate(ISimulation simulation, IOutput output)
        {
            if (simulation == null)
                throw new ArgumentNullException(nameof(simulation));
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            output.WriteLine($"{Name} in month # {simulation.Month}{Environment.NewLine}");

            if (simulation.IsInitialMonth)
                Initialize(simulation, output);
            var monthly = Process(simulation, output);
            if (simulation.IsFinalMonth)
                Finalize(monthly, simulation, output);


            // TODO: Code needs work
#if false
                 _report.Add(data); 
#endif

            _netWorth = _cash + simulation.OwnerHomeValue - simulation.OwnerLoanBalance;
            _averageSpent = (_totalSpent / simulation.Month).ToDollars();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine($"{Name} spent {_totalSpent:C0} (average of {_averageSpent:C0} / month) and has net worth of {_netWorth:C0} on initial investment of {_initialInvestment:C0}");
            if (_npv.HasValue)
                text.AppendLine($"Net present value of {_npv:C0}");
            if (_irr.HasValue)
                text.AppendLine($"Internal rate of return of {_irr:P2}");
            return text.ToString().TrimEnd();
        }
    }
}
#endif
