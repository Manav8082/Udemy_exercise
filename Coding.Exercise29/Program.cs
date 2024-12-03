namespace Coding.Exercise29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotHungryCats("O~~O~O~O F O~O~");
        }
    public static int NotHungryCats(string kitchen)
        {
            kitchen = kitchen.Replace(" ","");
            Console.WriteLine(kitchen);
            string[] cats = kitchen.Split('F');
            string left = cats[0];
            Console.WriteLine(left+"---");
            string right = cats[1];
            Console.WriteLine("---"+right);
            int ans = 0;
            for (int i = 0; i < left.Length; i = i + 2)
            {
                if (left[i] == 'O')
                {
                    ans++;
                }
            }
            for (int i = 0; i < right.Length; i = i + 2)
            {
                if (right[i] == '~')
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
            return ans;
        }
    }
}
