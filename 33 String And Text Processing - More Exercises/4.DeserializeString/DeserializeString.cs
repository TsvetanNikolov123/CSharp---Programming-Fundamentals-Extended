namespace _4.DeserializeString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DeserializeString
    {
        public static void Main()
        {
            SortedDictionary<int, char> lettersIndices = new SortedDictionary<int, char>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(':');
                char @char = tokens[0][0];
                int[] indices = tokens[1].Split('/').Select(int.Parse).ToArray();

                foreach (var index in indices)
                {
                    lettersIndices[index] = @char;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(lettersIndices.Values.ToArray());
        }
    }
}
