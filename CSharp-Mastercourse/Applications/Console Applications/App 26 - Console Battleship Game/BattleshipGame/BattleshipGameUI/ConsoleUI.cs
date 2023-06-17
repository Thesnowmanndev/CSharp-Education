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

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.LocationLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.LocationLetter;
                }

                if (gridSpot.LocationStatus == GridLocationStatus.Empty)
                {
                    Console.Write($" {gridSpot.LocationLetter}{gridSpot.LocationLetter} ");
                }
                else if (gridSpot.LocationStatus == GridLocationStatus.Hit)
                {
                    Console.Write(" XX ");
                }
                else if (gridSpot.LocationStatus == GridLocationStatus.Miss)
                {
                    Console.Write(" OO ");
                }
                else
                {
                    Console.Write(" ?? ");
                }
            }
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where would you like to put ship number {model.ShipLocations.Count + 1}: ");
                string input = Console.ReadLine().Trim();
                bool validLocation = IsValidGridLocation(model, input);

                if (!validLocation)
                {
                    ConsoleMessages.InvalidGridLocation(input);
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
                (row, column) = GameLogic.SplitGridLocation(shot);
                isValidShot = Validators.IsValidGridLocation(activePlayer, row, column);

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid grid location. Please try again.");
                }
            } while (isValidShot == false);

            bool shipHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.AnnotateShotResult(activePlayer, row, column, shipHit);
        }

        private static string InquireShot()
        {
            Console.Write("Please enter the grid location you would like to fire a shot at: ");
            string output = Console.ReadLine();

            return output;
        }
    }
}