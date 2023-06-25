using System;
using System.Collections.Generic;

namespace InventoryDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            var vehicle = new VehicleModel { ItemName = "2023 Ford F150" };
            var book = new BookModel { ItemName = "Ford F150 Maintenance Manual", NumberOfPages = 750, Quantity = 3 };

            List<IRentable> rentables = new List<IRentable>
            {
                vehicle
            };

            List<IPurchasable> purchasables = new List<IPurchasable>
            {
                vehicle,
                book
            };

            InquireRentables(rentables);

            Console.Clear();
            InquirePurchases(purchasables);

            Console.Clear();
            InquireReturnables(rentables);

            Console.Clear();
            Console.WriteLine("Hit any key to exit.");
            Console.ReadLine();
        }

        private static void InquireReturnables(List<IRentable> rentables)
        {
            bool isValidInput = false;

            foreach (var item in rentables)
            {
                Console.Clear();

                if (item.isRented == true)
                {
                    Console.WriteLine("Return Menu");
                    Console.WriteLine();
                    Console.Write($"Would you like to return {item.ItemName} (yes / no): ");
                    string input = Console.ReadLine().Trim().ToLower();

                    try
                    {
                        if (input == "yes" || input == "no")
                        {
                            isValidInput = true;
                        }
                        else
                        {
                            isValidInput = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }

                    while (!isValidInput)
                    {
                        Console.Write($"Would you like to return {item.ItemName} (yes / no): ");
                        input = Console.ReadLine().Trim().ToLower();

                        try
                        {
                            if (input == "yes" || input == "no")
                            {
                                isValidInput = true;
                            }
                            else
                            {
                                isValidInput = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }

                    if (input == "yes")
                    {
                        item.ReturnItem();
                        Console.ReadLine();
                    }
                }
            }
        }

        private static void InquireRentables(List<IRentable> rentables)
        {

            bool isValidInput = false;

            foreach (var item in rentables)
            {
                Console.Clear();

                Console.WriteLine("Rental Menu");
                Console.WriteLine();

                Console.Write($"Would you like to rent {item.ItemName} (yes / no): ");
                string input = Console.ReadLine().Trim().ToLower();

                try
                {
                    if (input == "yes" || input == "no")
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        isValidInput = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                while (!isValidInput)
                {
                    Console.Write($"Would you like to rent {item.ItemName} (yes / no): ");
                    input = Console.ReadLine().Trim().ToLower();

                    try
                    {
                        if (input == "yes" || input == "no")
                        {
                            isValidInput = true;
                        }
                        else
                        {
                            isValidInput = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                if (input == "yes")
                {
                    item.RentItem();
                    Console.ReadLine();
                }
            }
        }

        private static void InquirePurchases(List<IPurchasable> purchasables)
        {
            bool isValidInput = false;

            foreach (var item in purchasables)
            {
                Console.Clear();

                Console.WriteLine("Purchase Menu");
                Console.WriteLine();

                Console.Write($"Would you like to purchase {item.ItemName} (yes / no): ");
                string input = Console.ReadLine().Trim().ToLower();

                try
                {
                    if (input == "yes" || input == "no")
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        isValidInput = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                while (!isValidInput)
                {
                    Console.Write($"Would you like to purchase {item.ItemName} (yes / no): ");
                    input = Console.ReadLine().Trim().ToLower();

                    try
                    {
                        if (input == "yes" || input == "no")
                        {
                            isValidInput = true;
                        }
                        else
                        {
                            isValidInput = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                if (input == "yes")
                {
                    item.Purchase();
                    Console.ReadLine();
                }
            }
        }
    }
}
