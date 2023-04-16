// See https://learn.microsoft.com/en-us/dotnet/csharp/methods for more

namespace Methods
{
    public static class SampleMethods
    {
        private static double celsius;
        private static double fahrenheit;

        public static void Main(string[] args)
        {
            // Voids
            SayHello();
            StoreFahrenheit();

            // Double
            CalculateCelsius();

            // Tuple
            (string firstName, string lastName) = GetFullName();
            Console.WriteLine($"Hello, {firstName} {lastName}.");
        }

        // Voids - returns no variables.
        private static void StoreFahrenheit()
        {
            AskFahrenheit();
            string fahrenheitText = Console.ReadLine().Trim();
            double.TryParse(fahrenheitText, out fahrenheit);
            fahrenheit = Math.Round(fahrenheit, 1);
            Console.WriteLine($"\n\tIt is {fahrenheit} degrees F outside.");
        }

        private static void CalculateCelsius()
        {
            celsius = FahrenheitToCelsius(fahrenheit);
            celsius = Math.Round(celsius, 1);
            Console.WriteLine($"\tIt is {celsius} degrees C outside.");
        }

        private static void SayHello() => Console.WriteLine("Hello, World.");

        private static void AskFahrenheit() => Console.Write("\nWhat is the current degrees in fahrenheit: ");

        // Returning specific type of variable - i.e. Double
        private static double FahrenheitToCelsius(double f) => celsius = (f - 32.0d) / 1.8;

        // Tuple method
        private static (string firstName, string lastName) GetFullName()
        {
            Console.WriteLine("\nApplication of Tuples:");

            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            return (firstName, lastName);
        }
    }
}