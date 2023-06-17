namespace BattleshipGameLibrary.Models
{
    public class GridLocationModel
    {
        public string? LocationLetter { get; set; }
        public int LocationNumber { get; set; }
        public GridLocationStatus LocationStatus { get; set; } = GridLocationStatus.Empty;
    }
}