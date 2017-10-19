namespace _1.RemoveElementsAtOddPositions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RemoveElementsAtOddPosition
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();

            for (int i = 1; i < words.Count; i+=2)
            {
                Console.Write("{0}",words[i]);
            }
            Console.WriteLine();
        }
    }
}
