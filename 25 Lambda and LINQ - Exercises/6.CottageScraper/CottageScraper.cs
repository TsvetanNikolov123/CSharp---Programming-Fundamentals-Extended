namespace _6.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CottageScraper
    {
        public static void Main()
        {
            var data = new List<KeyValuePair<string, int>>(); // това на практика е речник който може да има повтарящи се ключове

            string input = Console.ReadLine();
            while (input != "chop chop")
            {
                string[] inputTokens = input
                    .Split(new string[] { " -> " },
                            StringSplitOptions.RemoveEmptyEntries);

                string woodType = inputTokens[0];
                int woodHeight = int.Parse(inputTokens[1]);

                data.Add(new KeyValuePair<string, int>(woodType, woodHeight));

                input = Console.ReadLine();
            }

            string wantedType = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());

            var pricePerMeter = Math.Round(data.Average(d => d.Value), 2);

            double usedLogsValue = data
                .Where(d => d.Key == wantedType && d.Value >= minHeight)
                .Sum(d => d.Value);

            double unusedLogsValue = data
                .Where(d => d.Key != wantedType || d.Value < minHeight)
                .Sum(d => d.Value);

            usedLogsValue = Math.Round(usedLogsValue * pricePerMeter, 2);
            unusedLogsValue = Math.Round(unusedLogsValue * pricePerMeter * 0.25, 2);
            double totalPrice = Math.Round(usedLogsValue + unusedLogsValue, 2);

            Console.WriteLine("Price per meter: ${0:f2}", pricePerMeter);
            Console.WriteLine("Used logs price: ${0:f2}", usedLogsValue);
            Console.WriteLine("Unused logs price: ${0:f2}", unusedLogsValue);
            Console.WriteLine("CottageScraper subtotal: ${0:f2}", totalPrice);

        }
    }
}
