namespace _1.Sum_Min_Max_Average
{
    using System;
    using System.Linq;

    public class SumMinMaxAverage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("Average = 0", nums.Average());
        }
    }
}
