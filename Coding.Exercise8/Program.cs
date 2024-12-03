namespace Coding.Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int c = 0; c < 3; c++)
            {
                int rsum = 0;
                for (int r = 0; r < 3; r++)
                {
                    rsum += arr[c, r];
                }
                Console.WriteLine(rsum);
            }
        }
    }
}
