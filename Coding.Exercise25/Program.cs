namespace Coding.Exercise25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAreas();
        }
        public static void PrintAreas()
        {
            // TODO: Add your code here
            IShape[] shapes = new IShape[]
            {
                new Circle(5),
                new Rectangle(4, 6)
            };
            foreach (var i in shapes)
            {
                Console.WriteLine("Area: " + i.GetArea());
            }
        }
    }
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        public int _radius;
        public Circle(int radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            double area = 3.141592653589793 * _radius * _radius;
            return area;
        }
    }

    public class Rectangle : IShape
    {
        public int _width;
        public int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public double GetArea()
        {
            double area = _width * _height;
            return area;
        }
    }
}