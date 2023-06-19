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
