namespace Coding.Exercise30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,1,1,2, 3, 4, 5,1,1,1,1,11 };
            Console.WriteLine("Ans is: " + SumOfTwo(nums,2));
        }

        public static int SumOfTwo(int[] nums, int SumToFind)
        {
            // todo
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int result = 0;

            foreach (int value in nums)
            {
                Console.WriteLine(value);
                if (dic.ContainsKey(SumToFind - value) && dic[SumToFind - value] > 0)
                {

                    dic[SumToFind - value] -= 1;

                    result++;
                    continue;
                }
                if (dic.ContainsKey(value))
                {
                    dic[value] += 1;
                }
                else
                {
                    dic.Add(value, 1);
                }
            }
            return result;
        }
    }

}
