namespace _2.RandomizeWords
{
    using System;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(words.Length);

                string temp = words[i];
                words[i] = words[index];
                words[index] = temp;
            }
            words.ToList().ForEach(Console.WriteLine);
        }
    }
}
