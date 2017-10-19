namespace _4.UnunionLists
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class UnunionLists
    {
        public static void Main()
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int listCount = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < listCount; cnt++)
            {
                List<int> currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int index = 0; index < currentList.Count; index++)
                {
                    int currentElement = currentList[index];
                    if (primalList.Contains(currentElement))
                    {
                        primalList.RemoveAll(e => e == currentElement);
                    }
                    else
                    {
                        primalList.Add(currentElement);
                    }
                }
            }
            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
