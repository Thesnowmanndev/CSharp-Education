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
