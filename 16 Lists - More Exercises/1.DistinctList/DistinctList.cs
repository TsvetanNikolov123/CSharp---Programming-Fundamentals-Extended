namespace _1.DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            int[] inputElements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> distinctElement = new List<int>();

            for (int i = 0; i < inputElements.Length; i++)
            {
                int currentElement = inputElements[i];

                if (!distinctElement.Contains(currentElement))
                {
                    distinctElement.Add(currentElement);
                }
            }
            Console.WriteLine(string.Join(" ", distinctElement));
        }
    }
}
