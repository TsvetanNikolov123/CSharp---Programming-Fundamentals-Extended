namespace _1.OddOccurrences
{
    using System;
    using System.Collections.Generic;

    public class OddOccurrences
    {
        public static void Main()
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            string[] wordsInput = Console.ReadLine().ToLower().Split(' ');

            for (int i = 0; i < wordsInput.Length; i++)
            {
                if (!words.ContainsKey(wordsInput[i]))
                {
                    words.Add(wordsInput[i], 0);
                }

                words[wordsInput[i]]++;
            }

            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> word in words)
            {
                if (word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
