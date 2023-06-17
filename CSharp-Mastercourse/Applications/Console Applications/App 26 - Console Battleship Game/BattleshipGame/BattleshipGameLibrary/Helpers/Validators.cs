using BattleshipGameLibrary.Models;
using System.Text.RegularExpressions;

namespace BattleshipGameLibrary.Helpers
{
    public class Validators
    {
        public static bool IsInvalidName(string name)
        {
            bool containsNonLetters = Regex.IsMatch(name, @"[^a-zA-Z]");
            return containsNonLetters;
        }

        public static bool isValidShipLocation(PlayerInfoModel model, string row, int column)
        {
            bool isValid = true;

            foreach (var ship in model.ShipLocations)
            {
                if (ship.LocationLetter == row.ToUpper() && ship.LocationNumber == column)
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        public static bool IsValidGridLocation(PlayerInfoModel activePlayer, string row, int column)
        {
            bool isValid = false;

            foreach (var item in activePlayer.ShotGrid)
            {
                if (item.LocationLetter == row.ToUpper() && item.LocationNumber == column)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        public static bool ValidShot(PlayerInfoModel player, string row, int column)
        {
            bool isValid = false;

            foreach (var gridLocation in player.ShotGrid)
            {
                if (gridLocation.LocationLetter == row.ToUpper() && gridLocation.LocationNumber == column)
                {
                    if (gridLocation.LocationStatus == GridLocationStatus.Empty)
                    {
                        isValid = true;
                    }
                }
            }

            return isValid;
        }
    }
}