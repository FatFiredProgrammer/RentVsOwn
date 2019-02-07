namespace RentVsOwn
{
    public interface ISimulation
    {
        int Month { get; }

        bool IsInitialMonth { get; }

        bool IsFinalMonth { get; }

        bool IsNewYear { get; }

        decimal HomePurchaseAmount { get; }

        decimal OwnerInterestRatePerYear { get; }

        decimal OwnerDownPayment { get; }

        decimal OwnerLoanAmount { get; }

        decimal OwnerMonthlyPayment { get; }

        decimal RentPerMonth { get; }

        int RentSecurityDepositMonths { get; }

        decimal RentersInsurancePerMonth { get; }

        decimal RentChangePerYearPercentage { get; }

        decimal DiscountRatePerYear { get; }

        decimal CapitalGainsRatePerYear { get; }

        decimal MarginalTaxRatePerYear { get; }

        decimal LandlordInterestRatePerYear { get; }

        decimal LandlordDownPayment { get; }

        decimal LandlordLoanAmount { get; }

        decimal LandlordMonthlyPayment { get; }

        decimal LandlordManagementFeePercentagePerMonth { get; }

        decimal BuyerFixedCosts { get; }

        decimal BuyerVariableCostsPercentage { get; }

        decimal PropertyTaxPercentagePerYear { get; }

        decimal InsurancePerMonth { get; }

        decimal HoaPerMonth { get; }

        decimal HomeAppreciationPercentagePerYear { get; }

        decimal HomeMaintenancePercentagePerYear { get; }

        decimal SellerCommissionPercentage { get; }

        decimal SellerFixedCosts { get; }

        decimal DepreciationYears { get; }

        decimal DepreciablePercentage { get; }

        decimal InflationRatePerYear { get; }

        bool Allow1031Exchange { get; }
    }
}
