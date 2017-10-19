namespace _3.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            string pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);

            string inputLine = Console.ReadLine().ToUpper();

            MatchCollection matches = regex.Matches(inputLine);

            List<char> uniqueCharacters = new List<char>();
            StringBuilder outputResult = new StringBuilder();

            foreach (Match match in matches)
            {
                string message = match.Groups[1].Value;
                int repeat = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < message.Length; i++)
                {
                    if (!uniqueCharacters.Contains(message[i]))
                    {
                        uniqueCharacters.Add(message[i]);
                    }
                }

                for (int i = 0; i < repeat; i++)
                {
                    outputResult.Append(message);
                }
            }
            Console.WriteLine("Unique symbols used: {0}",outputResult.ToString().Distinct().Count());
            Console.WriteLine(outputResult);
        }
    }
}
