

namespace Coding.Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAverage();
        }

        private static void PrintAverage()
        {
            double[] temperatures = { 10.2, 20.2, 30.2, 40.2, 50.2 };
            double average = CalculateAverage(ref temperatures);
            Console.WriteLine("The average temperature is: " + average);
        }

        private static double CalculateAverage(ref double [] temperatures)
        {
            double average = 0;
            foreach (double i in temperatures)
            {
                average += i;
            }
            average /= temperatures.Length;
            return average;
        }
    }
}
