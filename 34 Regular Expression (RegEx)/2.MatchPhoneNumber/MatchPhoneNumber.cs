namespace _2.MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string regex = @"(\+359-?2-[0-9]{3}-[0-9]{4})\b|(\+359 2 [0-9]{3} [0-9]{4})";
            //     \+359([ -])2\1\d{3}\1\d{4}\b    Това е същото като \1   е повторение на резултата
            //                                        от ([ -]) 
            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, regex);

            string[] matchedPhones = phoneMatches
                                    .Cast<Match>()
                                    .Select(a => a.Value.Trim())
                                    .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
