# Inheritence and Interface Demo

For this mini project I was tasked to create a console application that read lists to the screen and asked the user if they want to rent or purchase items within the list. If they purchased an item it would remove it from quantity. If they rented an item it would remove it from inventory and mark it as rented. If an item was rented the application will ask if the user wants to return the item. The purpose of this is to better practice Inheritence and Interfaces.

**NOTE: Code examples below could use refactoring to feature validation rather than every method having lines of validation. For future real applications I will implement validation classes.**

---

## Application Example Screens

### Purchase

!Purchase

### Rent

!Rental

### Return 

!Returns

### Error Validation

!ErrorValidation

### Application Terminated

!ApplicationTerminated

---

## Program 

```C#
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

```

## IInventoryItem

```C#
public interface IInventoryItem
{
    string ItemName { get; set; }
    int Quantity { get; set; }
}

```

## IPurchasable

```C#
public interface IPurchasable : IInventoryItem
{
    void Purchase();
}

```

## IRentable

```C#
public interface IRentable : IInventoryItem
{
    bool isRented { get; set; }
    void RentItem();
    void ReturnItem();
}

```

## BookModel

```C#
using System;

public class BookModel : IInventoryItem, IPurchasable
{
    public string ItemName { get; set; }
    public int NumberOfPages { get; set; }
    public int Quantity { get; set; }


    public void Purchase()
    {
        Quantity -= 1;
        Console.WriteLine($"{ItemName} purchased.");
    }
}

```

## VehicleModel

```C#
using System;

public class VehicleModel : IPurchasable, IRentable
{
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public bool isRented { get; set; }

    public void Purchase()
    {
        Quantity -= 1;
        Console.WriteLine($"{ItemName} purchased.");
    }

    public void RentItem()
    {
        Quantity -= 1;
        isRented = true;
        Console.WriteLine($"{ItemName} rented.");
    }

    public void ReturnItem()
    {
        Quantity += 1;
        Console.WriteLine($"{ItemName} returned to inventory.");
    }
}

```