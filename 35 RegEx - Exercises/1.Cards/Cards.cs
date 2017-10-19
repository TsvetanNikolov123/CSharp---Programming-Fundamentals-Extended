namespace _1.Cards
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    public class Cards
    {
        public static void Main()
        {
            Regex regex = new Regex("([1]?[0-9JQKA])([SHDC])");

            string inputCards = Console.ReadLine();

            MatchCollection matchedCards = regex.Matches(inputCards);

            List<string> validCards = new List<string>();

            foreach (Match card in matchedCards)
            {
                int power = 0;

                if (int.TryParse(card.Groups[1].Value,out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                validCards.Add(card.Value);
            }
            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
