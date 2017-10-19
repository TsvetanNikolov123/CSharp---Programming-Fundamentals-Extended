namespace _3.CamelsBack
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CamelsBack
    {
        public static void Main()
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int camelsBack = int.Parse(Console.ReadLine());

            int roundsCnt = 0;

            while (elements.Count > camelsBack)
            {
                elements.RemoveAt(0);
                elements.RemoveAt(elements.Count - 1);
                roundsCnt++;
            }

            if (roundsCnt == 0)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", elements));
            }
            else
            {
                Console.WriteLine("{0} rounds", roundsCnt);
                Console.WriteLine("remaining: {0}", string.Join(" ", elements));
            }
        }
    }
}
