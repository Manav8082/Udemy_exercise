namespace Coding.Exercise17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintWithFinally();
        }
        public static void PrintWithFinally()
        {
            // TODO
            try
            {
                Console.WriteLine("Trying...");
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }
        }
    }
}
