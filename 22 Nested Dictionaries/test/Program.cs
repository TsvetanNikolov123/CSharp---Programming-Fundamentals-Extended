using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            var continentsData = new Dictionary<string, Dictionary<string, string>>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continentsName = input[0];
                string countryName = input[1];
                string capitalName = input[2];

                if (!continentsData.ContainsKey(continentsName))
                {
                    continentsData.Add(continentsName, new Dictionary<string, string>());
                }

                continentsData[continentsName].Add(countryName, capitalName);
            }

            foreach (var record in continentsData)
            {
                string continentName = record.Key;
                Dictionary<string, string> countriesData = record.Value;

                Console.WriteLine("{0}:", continentName);
                foreach (KeyValuePair<string, string> countryData in countriesData)
                {
                    string countryName = countryData.Key;
                    string capitalName = countryData.Value;
                    Console.WriteLine("     {0} --> {1}", countryName, capitalName);
                }
            }
        }
    }
}
