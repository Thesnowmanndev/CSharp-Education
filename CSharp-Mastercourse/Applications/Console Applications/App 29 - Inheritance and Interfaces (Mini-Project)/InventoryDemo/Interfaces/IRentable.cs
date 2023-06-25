public interface IRentable : IInventoryItem
{
    bool isRented { get; set; }
    void RentItem();
    void ReturnItem();
}
