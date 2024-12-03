using System.Text.RegularExpressions;
namespace Coding.Exercise28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExtractPatterns();
        }
        public static void ExtractPatterns(string input = "aryan@gmail.com notaryan&gmail.com notaryan@gmail.com")
        {
            // TODO: Implement the method to extract and print email addresses using regex
            string pattern = @"\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            MatchCollection matchcollection = Regex.Matches(input, pattern);
            foreach (Match hit in matchcollection)
            {
                Console.WriteLine(hit.Value);
            }
        }
    }
}
