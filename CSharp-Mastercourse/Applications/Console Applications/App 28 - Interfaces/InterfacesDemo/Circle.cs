using InterfacesDemo.Models;

namespace InterfacesDemo
{
    public class Circle : IShape
    {
        const double PIE = 3.14;

        public double CalculateArea()
        {
            double area = 0;

            Console.Write("What is the radius of the circle: ");
            string? questionRadius = Console.ReadLine().Trim();
            bool validDouble = double.TryParse(questionRadius, out double radius);

            while (!validDouble)
            {
                Console.Write("What is the radius of the circle: ");
                questionRadius = Console.ReadLine().Trim();
                validDouble = double.TryParse(questionRadius, out radius);
            }

            area = PIE * (radius * radius);

            return area;
        }

        public void Draw()
        {
            // Code rest of method
            throw new NotImplementedException();
        }
    }
}
