using BattleshipGameLibrary;
using BattleshipGameLibrary.Helpers;
using BattleshipGameLibrary.Models;

namespace BattleshipConsole
{
    public class ConsoleUI
    {
        const int MAX_SHIPS = 5;

        public static PlayerInfoModel GeneratePlayer(string playerPosition)
        {
            PlayerInfoModel player = new();

            ConsoleMessages.DefineWhichPlayerEntersInformation(playerPosition);

            player.Name = AskPlayersName();

            GridHandler.InitializeGrid(player);

            PlaceShips(player);

            Console.Clear();
            return player;
        }

        public static bool IsValidGridLocation(PlayerInfoModel model, string location)
        {
            throw new NotImplementedException();
        }

        private static string AskPlayersName()
        {
            Console.Write("What is your name: ");
            string playersEntry = Console.ReadLine().Trim();
            bool invalidName = Validators.IsInvalidName(playersEntry);

            while (invalidName)
            {
                ConsoleMessages.InvalidInputText(playersEntry);
                Console.Write("What is your name: ");
                playersEntry = Console.ReadLine().Trim();
                invalidName = Validators.IsInvalidName(playersEntry);
            }

            return playersEntry;
        }

        public static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            string currentRow = activePlayer.ShotGrid[0].LocationLetter;
            Console.WriteLine($"{ activePlayer.Name }'s Turn!");
            Console.WriteLine("Key:    XX = Sunk    OO = Miss");
            Console.WriteLine("\n------ BOARD ------");

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.LocationLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.LocationLetter;
                }

                if (gridSpot.LocationStatus == GridLocationStatus.Empty)
                {
                    Console.Write($" {gridSpot.LocationLetter}{gridSpot.LocationNumber} ");
                }
                else if (gridSpot.LocationStatus == GridLocationStatus.Hit)
                {
                    Console.Write(" X  ");
                }
                else if (gridSpot.LocationStatus == GridLocationStatus.Miss)
                {
                    Console.Write(" O  ");
                }
                else
                {
                    Console.Write(" ?  ");
                }
            }
            Console.WriteLine("\n------ BOARD ------");
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where would you like to put ship number {model.ShipLocations.Count + 1}: ");
                string input = Console.ReadLine().Trim();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            } while (model.ShipLocations.Count < MAX_SHIPS);
        }

        public static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                string shot = InquireShot();
                try
                {
                    (row, column) = GameLogic.SplitGridLocation(shot);
                    isValidShot = Validators.IsValidGridLocation(activePlayer, row, column);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    isValidShot = false;
                }

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid grid location. Please try again.");
                }
            } while (isValidShot == false);

            bool shipHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.AnnotateShotResult(activePlayer, row, column, shipHit);

            DisplayShotResults(row, column , shipHit);
            Console.ReadLine();
        }

        private static void DisplayShotResults(string row, int column, bool shipHit)
        {
            if (shipHit)
            {
                Console.WriteLine($"Your shot at { row }{ column.ToString() } hit!"); 
            }
            else
            {
                Console.WriteLine($"Your shot at { row }{ column.ToString() } missed.");
            }

            Console.WriteLine();
        }

        private static string InquireShot()
        {
            Console.Write("\n\nPlease enter the grid location you would like to fire a shot at: ");
            string output = Console.ReadLine();

            return output;
        }
    }
}