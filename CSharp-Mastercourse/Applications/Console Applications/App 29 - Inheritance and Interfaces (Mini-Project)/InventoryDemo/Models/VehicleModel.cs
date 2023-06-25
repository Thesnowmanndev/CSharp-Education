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
