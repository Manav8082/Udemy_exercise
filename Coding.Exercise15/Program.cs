namespace Coding.Exercise15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDictionaryValues();
        }
        public static void PrintDictionaryValues()
        {
            // TODO
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            dict.Add("1", new List<int> { 1 });
            dict.Add("2", new List<int> { 1, 2 });
            dict.Add("3", new List<int> { 1, 2, 3 });

            foreach (var i in dict)
            {
                if (i.Key == "3")
                {
                    foreach (int j in i.Value)
                    {
                        Console.Write(j + " ");
                    }
                }
            }
        }
    }
}
