namespace StaticClasses
{
    public class RequestData
    {
        public static double GetDouble(string message)
        {
            Console.WriteLine(message);
            string numberText = Console.ReadLine();
            double output;
            bool isDouble = double.TryParse(numberText, out output);

            while (isDouble == false)
            {
                Console.WriteLine("That was not a valid number. Please try again.");
                Console.WriteLine(message);
                numberText = Console.ReadLine();

                isDouble = double.TryParse(numberText, out output);
            }

            return output;
        }

        public static string GetString(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }
    }
}
