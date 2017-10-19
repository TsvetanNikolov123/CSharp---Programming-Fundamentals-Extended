namespace _7.LargestN.Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestNElement
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            List<int> resultList = InsertionSort(list);

            List<int> largetsNElement = new List<int>();

            for (int i = 0; i < n; i++)
            {
                largetsNElement.Add(resultList[i]);
            }
            Console.WriteLine(string.Join(" ", largetsNElement));
        }

        public static List<int> InsertionSort(List<int> list)
        {
            List<int> resultList = new List<int>();

            for (int firstIndex = 0; firstIndex < list.Count; firstIndex++)
            {
                int elementToInsert = list[firstIndex];
                bool hasInserted = false;
                for (int secondIndex = 0; secondIndex < resultList.Count; secondIndex++)
                {
                    int currentListElement = resultList[secondIndex];

                    //    na sledva6tiq red znaka za sravnenie operelq dali ste e  narastva6t ili namalqva6t
                    //                  > < edin ot dvata znaka  
                    if (elementToInsert > currentListElement)
                    {
                        resultList.Insert(secondIndex, elementToInsert);
                        hasInserted = true;
                        break;
                    }
                }

                if (!hasInserted)
                {
                    resultList.Add(elementToInsert);
                }
            }

            return resultList;
        }

        public static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
