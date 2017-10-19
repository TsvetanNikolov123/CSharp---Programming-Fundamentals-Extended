namespace _2.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            List<double> nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            nums = nums
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
