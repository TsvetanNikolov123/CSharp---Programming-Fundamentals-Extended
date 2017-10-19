namespace _09.Largest_Element_in_Array
{
    using System;
    using System.Linq;
    
    class LargestElementInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n]; 

            for (int i = 0; i < number.Length; i++)
            {
               int num = int.Parse(Console.ReadLine());
                number[i] += num;
            }
            int max = number.Max();
            Console.WriteLine(max);
        }
    }
}
