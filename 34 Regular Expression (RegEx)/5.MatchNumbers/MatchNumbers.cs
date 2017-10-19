namespace _5.MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchNumbers
    {
        public static void Main()
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string numberString = Console.ReadLine();
            MatchCollection numbers = Regex.Matches(numberString, regex);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
