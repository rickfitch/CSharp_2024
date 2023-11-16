using System.Text.RegularExpressions;

namespace CSharpRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\d");

            string text = "Hi there my number is 195256";

            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches) 
            {
                Console.WriteLine("count {0}\t match found {1}", match.Index, match);
            }

            Console.ReadKey();
        }
    }
}
