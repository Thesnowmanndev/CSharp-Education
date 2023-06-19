public class SalesDivision
{
    public double DivisionSalesPercentage { get; set; }
    public double CompanySalesPrediction { get; set; }
    public double DivisionSalesPrediction { get; set; }

    public string AnnualRevenueShare { get; set; }

    public static double CalculateDivisionAnnualSales(double percentage, double annualRevenue)
    {
        double output = annualRevenue * percentage;
        return output;
    }
}
