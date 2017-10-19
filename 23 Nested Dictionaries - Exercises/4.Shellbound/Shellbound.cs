namespace _4.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main()
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "Aggregate")
            {
                string[] inputTokens = input.Split(' ');
                string city = inputTokens[0];
                int size = int.Parse(inputTokens[1]);

                if (!data.ContainsKey(city))
                {
                    data.Add(city, new List<int>());
                }

                if (!data[city].Contains(size))
                {
                    data[city].Add(size);
                }

                input = Console.ReadLine();
            }

            foreach (var record in data)
            {
                string city = record.Key;
                List<int> sizes = record.Value;
                int sumOfShells = (int)sizes.Sum();
                int avg = (int)sizes.Average();
                int giantShell = sumOfShells - avg;

                Console.WriteLine("{0} -> {1} ({2})", city, string.Join(", ", sizes), giantShell);
            }
        }
    }
}
