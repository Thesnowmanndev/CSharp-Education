using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesHomework
{
    public static class ControlData
    {
        public static void InputItems(List<decimal> inputData)
        {
            bool inputItems = true;
            while (inputItems)
            {
                Console.Write("\nInput item price: $");
                string itemPriceInputText = Console.ReadLine();
                decimal itemPrice;
                bool itemPriceText = decimal.TryParse(itemPriceInputText, out itemPrice);
                while (itemPriceText == false)
                {
                    Console.WriteLine("\nThe input is not valid. Please type a number. Example 3.32");
                    Console.Write("Input item price: $");
                    itemPriceInputText = Console.ReadLine();
                    itemPriceText = decimal.TryParse(itemPriceInputText, out itemPrice);
                }

                inputData.Add(itemPrice);

                Console.Write("\nWould you like to input another value? yes or no: ");
                string inputMoreItems = Console.ReadLine().ToLower().Trim();


                if (inputMoreItems != "yes" && inputMoreItems != "no")
                {
                    bool correctInput = false;
                    while (correctInput == false)
                    {
                        Console.Write("\nInput is not valid. Please enter yes or no: ");
                        inputMoreItems = Console.ReadLine().ToLower().Trim();
                        if (inputMoreItems == "yes" || inputMoreItems == "no")
                        {
                            correctInput = true;
                        }
                    }
                }
                else if (inputMoreItems == "no")
                {
                    inputItems = false;
                }
            }
        }

        public static decimal InputBalance()
        {
            Console.Clear();
            decimal balance = 0M;
            Console.Write("What is your current bank balance: $");
            string balanceText = Console.ReadLine();
            bool isValidInput = decimal.TryParse(balanceText, out balance);
            while (isValidInput == false)
            {
                Console.Write("\n Invalid input. What is your current bank balance: $");
                balanceText = Console.ReadLine();

                isValidInput = decimal.TryParse(balanceText, out balance);
            }

            return balance;
        }
    }
}
