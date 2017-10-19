namespace _2.CitiesByContinentAndCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();
            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent].Add(country, new List<string>());
                }
                continentsData[continent][country].Add(city);
            }
            foreach (var continentData in continentsData)
            {
                string continent = continentData.Key;
                var countriesData = continentData.Value;

                Console.WriteLine("{0}:", continent);

                foreach (var countryData in countriesData)
                {
                    string country = countryData.Key;
                    List<string> cities = countryData.Value;
                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ",cities));
                }
            }
        }
    }
}
