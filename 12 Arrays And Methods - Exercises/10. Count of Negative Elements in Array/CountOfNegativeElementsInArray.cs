namespace _10.Count_of_Negative_Elements_in_Array
{
    using System;
        
    class CountOfNegativeElementsInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numArray = new int[n];

            for (int i = 0; i < numArray.Length; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numArray[i] += num;
            }

            int count = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
