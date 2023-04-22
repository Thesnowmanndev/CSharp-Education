namespace StaticClasses
{
    public class UserMessages
    {
        public static void ApplicationStartMessage(string firstName) 
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Static Class Application {firstName}.");

            int hourOfDay = DateTime.Now.Hour;
            int minuteOfDay = DateTime.Now.Minute;

            if (hourOfDay < 12) 
            {
                Console.WriteLine($"\nGood morning {firstName}! The current time is {hourOfDay}:{minuteOfDay}.");
            }
            else if (hourOfDay >= 12 && hourOfDay <= 19) 
            { 
                Console.WriteLine($"\nGood afternoon {firstName}! The current time is {hourOfDay}:{minuteOfDay}."); 
            } 
            else
            {
                Console.WriteLine($"\nGood evening {firstName}! The current time is {hourOfDay}:{minuteOfDay}.");
            }
        }

        public static void PrintResult(string message)
        {
            Console.WriteLine(message);
        }

    }
}
