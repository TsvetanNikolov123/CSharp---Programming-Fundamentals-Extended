namespace _7.CapitalizeWords
{
    using System;
    using System.Text;

    public class CapitalizeWords
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input
                    .Split(GetPunctuationArray(),
                           StringSplitOptions.RemoveEmptyEntries);

                for (int index = 0; index < tokens.Length; ++index)
                {
                    tokens[index] = Capitalize(tokens[index]);
                }

                Console.WriteLine(string.Join(", ", tokens));
                input = Console.ReadLine();
            }
        }

        static char[] GetPunctuationArray()
        {
            return new char[] { ' ', ',', '.', '!', '?', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', ';', ':' };
        }

        static string Capitalize(string input)
        {
            StringBuilder builder = new StringBuilder(input);

            builder[0] = char.ToUpper(builder[0]);
            for (int index = 1; index < builder.Length; ++index)
            {
                builder[index] = char.ToLower(builder[index]);
            }

            return builder.ToString();
        }
            /*
            string input = Console.ReadLine().ToUpper();

            while (input != "END")
            {
                var phrase = input;
                var rx = new System.Text.RegularExpressions.Regex(@"(?<=\w)\w");
                var newString = rx.Replace(phrase, new MatchEvaluator(m => m.Value.ToLowerInvariant()));

                string[] tokens = newString
                .Split(new string[] { ",", ".", "!", "?", ";", ":"," " },
                    StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine(string.Join(", ", tokens));

                input = Console.ReadLine().ToUpper();
            }
            */
        
    }
}
