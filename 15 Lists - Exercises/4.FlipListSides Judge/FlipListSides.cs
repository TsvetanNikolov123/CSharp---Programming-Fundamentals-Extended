namespace _4.FlipListSides_Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlipListSides
    {
        public static void Main()
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            string firstElement = list[0];
            string lastElement = list[list.Count - 1];
            list.Reverse();
            list[0] = firstElement;
            list[list.Count - 1] = lastElement;

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
