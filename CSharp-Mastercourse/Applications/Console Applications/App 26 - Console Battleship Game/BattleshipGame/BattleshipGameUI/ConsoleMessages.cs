namespace BattleshipGameLibrary.Helpers
{
    public class ConsoleMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship - Console Edition!");
            Console.WriteLine("Made by Kyle Martin\n");
        }

        public static void DefineWhichPlayerEntersInformation(string playerPosition)
        {
            Console.WriteLine($"Player information for { playerPosition }.");
        }

        public static void InvalidInputText(string input)
        {
            Console.WriteLine($"{input} is invalid. Name cannot contain symbols or numbers.");
        }

        public static void InvalidGridLocation(string input)
        {
            Console.WriteLine($"Error: {input} is not a valid grid location. Please try again.");
        }
    }
}