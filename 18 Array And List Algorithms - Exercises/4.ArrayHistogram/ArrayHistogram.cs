namespace _4.ArrayHistogram
{
    using System;
    using System.Collections.Generic;

    public class ArrayHistogram
    {
        public static void Main()
        {
            List<string> words = new List<string>();
            List<int> counts = new List<int>();

            string[] inputString = Console.ReadLine().Split(' ');

            for (int i = 0; i < inputString.Length; i++)
            {
                if (!words.Contains(inputString[i]))
                {
                    words.Add(inputString[i]);
                    counts.Add(1);
                }
                else
                {
                    int index = words.IndexOf(inputString[i]);
                    counts[index]++;
                }
            }
            for (int firstUnorted = 0; firstUnorted < counts.Count - 1; firstUnorted++)
            {
                var i = firstUnorted + 1;
                while (i > 0)
                {
                    if (counts[i - 1] < counts[i])
                    {
                        int tempCounts = counts[i];
                        counts[i] = counts[i - 1];
                        counts[i - 1] = tempCounts;

                        string tempWord = words[i];
                        words[i] = words[i - 1];
                        words[i - 1] = tempWord;
                    }

                    i--;
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("{0} -> {1} times ({2:f2}%)",words[i], counts[i], ((double)counts[i] / inputString.Length) * 100);
            }
        }
    }
}
