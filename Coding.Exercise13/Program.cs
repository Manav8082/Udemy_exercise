namespace Coding.Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
        }
        public static void PrintNumbers()
        {
            int[] numbers = { 1, 2, 3 };
            // TODO
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }
    }
}
