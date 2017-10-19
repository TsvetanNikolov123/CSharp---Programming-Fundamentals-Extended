namespace _3.MatchHexadecimalNumbers
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class MatchHexaDecimalNumbers
    {
        public static void Main()
        {
            string regex = @"\b(?:0x)?[0-9A-F]+\b";

            string numbersString = Console.ReadLine();
            string[] numbers = Regex.Matches(numbersString, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
