namespace _1.DistinctList_Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            int[] inputElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            HashSet<int> distinctElement = new HashSet<int>(inputElements);

            Console.WriteLine(string.Join(" ", distinctElement));
        }
    }
}
