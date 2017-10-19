namespace _5.TearListInHalf_Judge1
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> inList = Console.ReadLine().Split(' ').ToList();

            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            for (int i = 0; i < inList.Count; i++)
            {
                if (i < inList.Count / 2) list2.Add(inList[i]);

                else list1.Add(inList[i]);
            }

            List<string> resList = new List<string>();

            for (int i = 0; i < list1.Count; i++)
            {
                resList.Add(list1[i][0].ToString());
                resList.Add(list2[i]);
                resList.Add(list1[i][1].ToString());
            }

            Console.WriteLine(string.Join(" ", resList));
        }
    }
}
