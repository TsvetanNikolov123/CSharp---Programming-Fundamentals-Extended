namespace _5.DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;

    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            string[] frequenciesInput = Console.ReadLine().Split(' ');
            List<char> endMesssage = new List<char>();

            for (int i = 0; i < frequenciesInput.Length; i++)
            {
                string[] tokens = frequenciesInput[i].Split('.');
                int firstFreq = int.Parse(tokens[0]);
                int secondFreq = int.Parse(tokens[1]);

                char firstLetter = (char)firstFreq;
                char secondLetter = (char)secondFreq;

                if (firstFreq != 0)
                {
                    endMesssage.Insert(i, firstLetter);
                }
                if (secondFreq != 0)
                {
                    endMesssage.Insert(endMesssage.Count - 1 - i, secondLetter);
                }

            }
            endMesssage.Reverse();

            Console.WriteLine(string.Join("", endMesssage));
        }
    }
}
