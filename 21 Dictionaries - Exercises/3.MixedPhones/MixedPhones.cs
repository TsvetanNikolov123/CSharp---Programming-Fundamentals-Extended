namespace _3.MixedPhones
{
    using System;
    using System.Collections.Generic;

    public class MixedPhones
    {
        public static void Main()
        {
            var phoneNumbers = new SortedDictionary<string, decimal>();

            var line = Console.ReadLine();
            while (line != "Over")
            {
                var tokens = line.Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var firstElement = tokens[0];
                var secondElement = tokens[1];

                var phoneNUmber = 0m;
                if (decimal.TryParse(firstElement, out phoneNUmber))
                {
                    phoneNumbers[secondElement] = phoneNUmber;
                }
                else if (decimal.TryParse(secondElement, out phoneNUmber))
                {
                    phoneNumbers[firstElement] = phoneNUmber;
                }

                line = Console.ReadLine();
            }

            foreach (var nameNumberPair in phoneNumbers)
            {
                var name = nameNumberPair.Key;
                var phoneNumber = nameNumberPair.Value;

                Console.WriteLine($"{name} -> {phoneNumber}");
            }
        }
    }
}
