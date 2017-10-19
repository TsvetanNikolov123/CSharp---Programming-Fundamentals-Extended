namespace _2.AverageCharacterDelimiter_Judge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            List<string> elements = Console.ReadLine().Split(' ').ToList();
            double totalSum = 0;
            double countOfCharacters = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                string word = elements[i];
                countOfCharacters += word.Length;
                for (int j = 0; j < word.Length; j++)
                {
                    totalSum += word[j];
                }
            }
            char charDelimiter = (char)((int)(totalSum / countOfCharacters));
            string delimiter = charDelimiter.ToString().ToUpper();

            Console.WriteLine(string.Join(delimiter, elements));
        }
    }
}
