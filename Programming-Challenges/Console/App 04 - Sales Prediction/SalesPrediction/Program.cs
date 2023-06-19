SalesDivision salesDivision = new();

salesDivision.DivisionSalesPercentage = SalesPredictionUI.AskSalesPercentage();
salesDivision.CompanySalesPrediction = SalesPredictionUI.AskCompanyRevenuePrediction();
salesDivision.DivisionSalesPrediction = salesDivision.CompanySalesPrediction * salesDivision.DivisionSalesPercentage;

salesDivision.AnnualRevenueShare =
    SalesPredictionUI.PrintPredictionResults(
        salesDivision.DivisionSalesPrediction, 
        salesDivision.DivisionSalesPercentage);

Console.WriteLine("\n\n" + salesDivision.AnnualRevenueShare);

Console.ReadLine();
