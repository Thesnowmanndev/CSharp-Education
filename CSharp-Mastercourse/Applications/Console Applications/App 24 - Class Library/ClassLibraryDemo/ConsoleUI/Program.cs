using DemoLibrary.Models;

class Program
{
    private static void Main(string[] args)
    {
        ToadModel BlueToad = new ToadModel("Toad", "Blue", "White", 16);
        ToadModel YellowToad = new ToadModel("Jim", "White", "Yellow", 18);
        ToadModel PinkToad = new ToadModel("Amy", "Pink", "White", 21);

        BlueToad.Greet();
        YellowToad.Greet();
        PinkToad.Greet();

        Console.ReadLine();
    }
}