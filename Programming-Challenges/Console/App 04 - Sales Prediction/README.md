# Sales Prediction

## Scenario -

The East Coast Sales division of a company generates 62 percent of total sales. Based on that percentage, write a program that will predict how much the East Coast division will generate if the company has $4.6 million in sales this year. 

---

## Extra Credit - 

- I added validators to verify if the input only contains numbers.
- Instead of only performing the calculation in the scenario, I made the logic able to calculate sales revenue from any percentage and any annual revenue. 

---

## Application Examples:

!ScenarioCalculation

!ValidationAndOtherCalculation

---

## Code

### Program.cs

```C#
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
```

### SalesDivision.cs

```C#
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

```

### SalesPredictionUI.cs

```C#
using System.Globalization;
using System.Text.RegularExpressions;

public class SalesPredictionUI
{
    public static double AskSalesPercentage()
    {
        double output;

        Console.Write("Enter your Division's sales percentage (Example: 62 for 62%): ");
        string PercentagePredictionText = Console.ReadLine();
        
        bool isDouble = Validators.ValidateInputIsNumber(PercentagePredictionText);

        while (isDouble == false)
        {
            Console.WriteLine("\nInput was not valid. Please input a solid number without letters or symbols.\n");
            Console.Write("Enter your Division's sales percentage (Example: 62 for 62%): ");
            PercentagePredictionText = Console.ReadLine();

            isDouble = Validators.ValidateInputIsNumber(PercentagePredictionText);
        }

        isDouble = double.TryParse(PercentagePredictionText, out double value);

        output = value / 100;

        return output;
    }

    public static double AskCompanyRevenuePrediction()
    {
        double output;

        try
        {
            Console.Write("Enter your Company's annual sales revenue (Example: 62000000 for 62 million): ");
            string CompanySalesPredictionText = Console.ReadLine();

            bool isDouble = Validators.ValidateInputIsNumber(CompanySalesPredictionText);

            while (isDouble == false)
            {
                Console.WriteLine("\nInput was not valid. Please input a solid number without letters or symbols.\n");
                Console.Write("Enter your Company's annual sales revenue (Example: 62000000 for 62 million): ");
                CompanySalesPredictionText = Console.ReadLine();

                isDouble = Validators.ValidateInputIsNumber(CompanySalesPredictionText);
            }

            isDouble = double.TryParse(CompanySalesPredictionText, out output);
        }
        catch (Exception ex)
        {

            throw new ArgumentException("Error: " + ex);
        }

        return output;
    }

    public static string PrintPredictionResults(double annualRevenue, double percentage)
    {
        string formattedPercentage = (percentage * 100).ToString();
        string formattedAnnualRevenue = annualRevenue.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        string output = $"Your Division's annual sales prediction is { formattedAnnualRevenue } if your Division generates { formattedPercentage}% of the company's annual sales.";

        return output;
    }
}

```

### Validators.cs

```C#
public class Validators
{
    public static bool ValidateInputIsNumber(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false; 
        }

        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}
```