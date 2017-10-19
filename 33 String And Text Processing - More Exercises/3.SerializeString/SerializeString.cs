namespace _3.SerializeString
{
    using System;
    using System.Collections.Generic;

    public class SerializeString
    {
        public static void Main()
        {
            Dictionary<char, List<int>> lettersIndices = new Dictionary<char, List<int>>();

            string input = Console.ReadLine();
            int counter = 0;
            foreach (char @char in input)
            {
                if (!lettersIndices.ContainsKey(@char))
                {
                    lettersIndices.Add(@char, new List<int>());
                }

                lettersIndices[@char].Add(counter);
                
                counter++;
            }

            foreach (KeyValuePair<char, List<int>> record in lettersIndices)
            {
                char name = record.Key;
                List<int> numbers = record.Value;

                Console.WriteLine("{0}:{1}", name, string.Join("/", numbers));
            }
        }

    }
}

