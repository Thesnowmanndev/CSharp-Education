namespace MethodsHomework
{
    public class User
    {
        public static (string firstName, string lastName) GetNames() 
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine().ToLower().Trim();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine().ToLower().Trim();

            return (firstName, lastName);
        }
    }
}
