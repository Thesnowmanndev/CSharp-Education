using BattleshipGameLibrary.Models;

namespace BattleshipGameLibrary.Helpers
{
    public class GridHandler
    {
        public static void InitializeGrid(PlayerInfoModel model)
        {
            List<string> letters = new()
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            List<int> numbers = new()
            {
                1,
                2,
                3,
                4,
                5
            };
            // Generates a grid
            // A1 A2 A3 A4 A5
            // B1 B2 B3 B4 B5
            // C1 C2 C3 C4 C5
            // D1 D2 D3 D4 D5
            // E1 E2 E3 E4 E5
            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridLocations(model, letter, number);
                }
            }
        }

        private static void AddGridLocations(PlayerInfoModel model, string letter, int number)
        {
            GridLocationModel gridLocation = new()
            {
                LocationLetter = letter,
                LocationNumber = number,
                LocationStatus = GridLocationStatus.Empty
            };

            model.ShotGrid.Add(gridLocation);
        }
    }
}