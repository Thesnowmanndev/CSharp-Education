using MethodsHomework;

public class Program
{
    public static void Main(string[] args)
    {
        Greetings.Welcome();
        (string firstName, string lastName) = User.GetNames();
        Greetings.GreetUser(firstName, lastName);
    }
}