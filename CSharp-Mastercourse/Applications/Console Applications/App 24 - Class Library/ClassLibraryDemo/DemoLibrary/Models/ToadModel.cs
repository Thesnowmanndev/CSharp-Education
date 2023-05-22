namespace DemoLibrary.Models
{
    public class ToadModel
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string DotColor { get; set; }
        public int Age { get; set; }

        public ToadModel(string name, string color, string dotColor, int age) 
        {
            Name = name;
            Color = color;
            DotColor = dotColor;
            Age = age;
        }

        public void Greet() 
        {
            Console.WriteLine($"Hello, my name is {Name}! I am a {Color} Mushroom with {DotColor} dots and I am {Age} years old.");
        }
    }
}
