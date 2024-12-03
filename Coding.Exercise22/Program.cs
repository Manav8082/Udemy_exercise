namespace Coding.Exercise22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDrive();
        }
        public static void TestDrive()
        {
            // TODO: Create an instance of Car and call the Drive method
            Car car = new Car();
            car.Drive();
        }
        
    }
    public interface IVehicle
    {
        // TODO: Declare a method Drive
        public void Drive();
    }

    public class Car : IVehicle
    {
        // TODO: Implement the Drive method
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }
}
