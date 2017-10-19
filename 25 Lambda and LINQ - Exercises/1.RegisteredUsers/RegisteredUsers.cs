namespace _1.RegisteredUsers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class RegisteredUsers
    {
        public static void Main()
        {
            Dictionary<string, DateTime> registeredUsernames = new Dictionary<string, DateTime>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>' },
                                        StringSplitOptions.RemoveEmptyEntries);

                string username = inputParams[0];
                DateTime registryDate = DateTime.ParseExact(inputParams[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                registeredUsernames[username] = registryDate;

                inputLine = Console.ReadLine();
            }

            Dictionary<string, DateTime> orderedUsernames = registeredUsernames
                                                                .Reverse()
                                                                .OrderBy(x => x.Value)
                                                                .Take(5)
                                                                .OrderByDescending(x => x.Value)
                                                                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var orderedUsername in orderedUsernames)
            {
                Console.WriteLine("{0}", orderedUsername.Key);
            }
        }
    }
}
