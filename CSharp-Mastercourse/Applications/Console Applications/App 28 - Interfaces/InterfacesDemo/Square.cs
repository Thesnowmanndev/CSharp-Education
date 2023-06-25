using InterfacesDemo.Models;

namespace InterfacesDemo
{
    public class Square : IShape
    {
        public double CalculateArea()
        {
            double area = 0;

            Console.Write("What is the width of the square: ");
            string? questionWidth = Console.ReadLine().Trim();
            bool validDouble = double.TryParse(questionWidth, out double width);

            while (!validDouble)
            {
                Console.Write("What is the width of the square: ");
                questionWidth = Console.ReadLine().Trim();
                validDouble = double.TryParse(questionWidth, out width);
            }

            Console.Write("What is the height of the square: ");
            string? questionHeight = Console.ReadLine().Trim();
            validDouble = double.TryParse(questionHeight, out double height);

            while (!validDouble)
            {
                Console.Write("What is the height of the square: ");
                questionHeight = Console.ReadLine().Trim();
                validDouble = double.TryParse(questionHeight, out height);
            }

            area = width * height;

            return area;
        }

        public void Draw()
        {
            // Code rest of method
            throw new NotImplementedException();
        }
    }
}
