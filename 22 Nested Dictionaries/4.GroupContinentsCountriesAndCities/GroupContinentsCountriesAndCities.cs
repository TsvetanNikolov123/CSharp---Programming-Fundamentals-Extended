namespace _4.GroupContinentsCountriesAndCities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent].Add(country, new SortedSet<string>());
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
                    SortedSet<string> cities = countryData.Value;
                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ", cities));
                }
            }
        }
    }
}
