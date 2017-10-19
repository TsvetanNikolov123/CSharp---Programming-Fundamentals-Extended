namespace _3.ShortWordsSorted
{
    using System;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            char[] delimiters = ".,:;()[]\"'\\/!? ".ToCharArray();
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()                      // Маха повтарящите се думи !!!
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
