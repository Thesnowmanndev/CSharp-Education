using BattleshipGameLibrary.Helpers;
using BattleshipGameLibrary.Models;
using System.ComponentModel;

namespace BattleshipGameLibrary
{
    public static class GameLogic
    {
        public static bool PlayerStillActive(PlayerInfoModel player)
        {
            bool isActive = false;

            foreach (var ship in player.ShipLocations)
            {
                if (ship.LocationStatus != GridLocationStatus.Sunk)
                {
                    isActive = true;
                }
            }

            return isActive;
        }

        private static int GetShotCount(PlayerInfoModel player)
        {
            int shotCount = 0;

            foreach (var shot in player.ShotGrid)
            {
                if (shot.LocationStatus != GridLocationStatus.Empty)
                {
                    shotCount++;
                }
            }

            return shotCount;
        }

        public static bool PlaceShip(PlayerInfoModel model, string location)
        {
            bool output = false;
            (string row, int column) = SplitGridLocation(location);

            bool isValidLocation = Validators.IsValidGridLocation(model, row, column);
            bool isLocationAvailable = Validators.isValidShipLocation(model, row, column);

            if (!isValidLocation) 
            {
                Console.WriteLine($"{ row }{column.ToString() } is not a valid location.");
            }

            if (!isLocationAvailable)
            {
                Console.WriteLine($"{row} {column.ToString()} is taken.");
            }

            if (isValidLocation && isLocationAvailable)
            {
                model.ShipLocations.Add(new GridLocationModel
                {
                    LocationLetter = row.ToUpper(),
                    LocationNumber = column,
                    LocationStatus = GridLocationStatus.Ship
                });

                output = true;
            }

            return output;
        }

        public static (string row, int column) SplitGridLocation(string shot)
        {
            string row = "";
            int column = 0;

            if (shot.Length != 2)
            {
                throw new ArgumentException("This was an invalid shot type.", $"{ shot }");
            }

            char[] chars = shot.ToArray();

            row = chars[0].ToString();

            column = int.Parse(chars[1].ToString());

            return (row, column);
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
            bool isHit = false;

            foreach (var ship in opponent.ShipLocations)
            {
                if (ship.LocationLetter == row.ToUpper() && ship.LocationNumber == column)
                {
                    isHit = true;
                    ship.LocationStatus = GridLocationStatus.Sunk;
                }
            }

            return isHit;
        }

        public static void AnnotateShotResult(PlayerInfoModel player, string row, int column, bool shipHit)
        {
            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.LocationLetter == row.ToUpper() && gridSpot.LocationNumber == column)
                {
                    if (shipHit)
                    {
                        gridSpot.LocationStatus = GridLocationStatus.Hit;
                    }
                    else
                    {
                        gridSpot.LocationStatus = GridLocationStatus.Miss;
                    }
                }
            }
        }

        public static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Congratulations to { winner.Name }!");
            Console.WriteLine($"{ winner.Name } fired { GetShotCount(winner) } shots to win the game.");
        }
    }
}