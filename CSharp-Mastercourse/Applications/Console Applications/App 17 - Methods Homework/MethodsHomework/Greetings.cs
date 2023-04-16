namespace MethodsHomework
{
    public class Greetings
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Methods Homework application!");
        }

        public static void GreetUser(string firstName, string lastName) 
        {
            Console.WriteLine($"Welcome, {firstName} {lastName}.");
        }
    }
}
