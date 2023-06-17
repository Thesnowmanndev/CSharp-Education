using BattleshipGameLibrary;
using BattleshipGameLibrary.Helpers;
using BattleshipGameLibrary.Models;

namespace BattleshipConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMessages.WelcomeMessage();

            PlayerInfoModel activePlayer = ConsoleUI.GeneratePlayer("Player 1");
            PlayerInfoModel opponent = ConsoleUI.GeneratePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                Console.Clear();
                ConsoleUI.DisplayShotGrid(activePlayer);

                ConsoleUI.RecordPlayerShot(activePlayer, opponent);

                bool doesGameResume = GameLogic.PlayerStillActive(opponent);
                if (doesGameResume == true)
                {
                    // Swap players
                    (activePlayer, opponent) = (opponent, activePlayer);
                } 
                else
                {
                    winner = activePlayer;
                }
            } while (winner == null);

            GameLogic.IdentifyWinner(winner);

            Console.ReadLine();
        }
    }
}