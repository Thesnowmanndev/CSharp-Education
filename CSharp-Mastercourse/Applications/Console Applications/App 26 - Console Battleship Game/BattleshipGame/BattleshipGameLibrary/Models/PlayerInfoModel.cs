namespace BattleshipGameLibrary.Models
{
    public class PlayerInfoModel
    {
        public string? Name { get; set; }
        public List<GridLocationModel> ShipLocations { get; set; } = new List<GridLocationModel>();
        public List<GridLocationModel> ShotGrid { get; set; } = new List<GridLocationModel>();
    }
}