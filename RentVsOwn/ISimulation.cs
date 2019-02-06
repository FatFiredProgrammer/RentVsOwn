namespace RentVsOwn
{
    public interface ISimulation
    {
        string Name { get; }

        int Month { get; }

        bool IsInitialMonth { get; }

        bool IsFinalMonth { get; }

        bool IsNewYear { get; }

        decimal HomePurchaseAmount { get; }

        decimal OwnerHomeValue { get; set; }

        decimal OwnerInterestRatePerYear { get; }

        int OwnerLoanYears { get; }

        decimal OwnerDownPaymentPercentage { get; }

        decimal OwnerDownPayment { get; }

        decimal OwnerLoanAmount { get; }

        decimal OwnerLoanBalance { get; set; }

        decimal OwnerMonthlyPayment { get; }

        decimal CurrentRentPerMonth { get; }

        decimal RentPerMonth { get; }

        int RentSecurityDepositMonths { get; }

        decimal RentersInsurancePerMonth { get; }

        decimal RentChangePerYearPercentage { get; }

        decimal DiscountRatePerYear { get; }

        decimal DiscountRatePerMonth { get; }

        decimal CapitalGainsRate { get; }

        decimal MarginalTaxRate { get; }

        decimal LandlordHomeValue { get; set; }

        decimal LandlordInterestRate { get; }

        decimal LandlordDownPaymentPercentage { get; }

        decimal LandlordDownPayment { get; }

        decimal LandlordLoanAmount { get; }

        decimal LandlordLoanBalance { get; set; }

        decimal LandlordMonthlyPayment { get; }

        decimal LandlordManagementFeePercentage { get; }

        decimal PurchaseFixedCosts { get; }

        decimal PurchaseVariableCostsPercentage { get; }

        decimal PropertyTaxPercentagePerYear { get; }

        decimal InsurancePerMonth { get; }

        decimal HoaPerMonth { get; }

        decimal HomeAppreciationPercentagePerYear { get; }

        decimal HomeMaintenancePercentagePerYear { get; }

        decimal SalesCommissionPercentage { get; }

        decimal SalesFixedCosts { get; }

        decimal DepreciationYears { get; }

        decimal DepreciablePercentage { get; }

        decimal InflationRatePerYear { get; }
    }
}
