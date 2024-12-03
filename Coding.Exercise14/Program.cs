namespace Coding.Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckAny();
        }

        public static void CheckAny()
        {
            // The list has been declared for you, use it in your solution.
            List<int> myNumbers = new List<int> { 1, 5, 3 };

            // TODO: Check if any number is greater than 5 using the Any method
            // and print the result ("True" or "False") to the console.
            if (myNumbers.Any(x => x > 5))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
