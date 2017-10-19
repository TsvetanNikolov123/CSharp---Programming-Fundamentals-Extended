namespace _4.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            string[] tokens = Console.ReadLine()
                .Split(new char[] { ',', ' ', '.', '!', '?' },
                    StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> palindromes = new SortedSet<string>();

            foreach (string token in tokens)
            {
                string reversed = new string(token.Reverse().ToArray());

                if (IsPalindrom(token))
                {
                    palindromes.Add(token);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes));
        }

        public static bool IsPalindrom(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
