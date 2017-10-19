namespace _4.MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchDates
    {
        public static void Main()
        {
            string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            /*                                             в regex101 e    \2
            
            Since RegEx works differently across different languages, before we continue, 
            we’re going to set our backreference from \2 to \1. This is because C# backreferences
            don’t count named capture groups for backreferences. So, change it before we continue.
            
                            \b\d{2}(\W)[A-Z][a-z]{2}\1[0-9]{4}\b
            */

            string datesString = Console.ReadLine();
            MatchCollection dates = Regex.Matches(datesString, regex);


            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
