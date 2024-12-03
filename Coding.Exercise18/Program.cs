namespace Coding.Exercise18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HandleMultipleExceptions();
            //Cannot provide parameters as not specified in test.
            Console.WriteLine("Run the program");
        }

        public static void HandleMultipleExceptions(string param1, int param2)
        {
            // TODO
            int[] numbers = { 1, 2, 3 };
            try
            {
                int num = int.Parse(param1);
                Console.WriteLine(numbers[param2]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}
