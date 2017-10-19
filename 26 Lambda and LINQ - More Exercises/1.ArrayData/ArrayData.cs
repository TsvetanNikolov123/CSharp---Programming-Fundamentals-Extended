namespace _1.ArrayData
{
    using System;
    using System.Linq;

    public class ArrayData
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string cmd = Console.ReadLine();

            double avg = numbers.Average();
            numbers = numbers.Where(n => n >= avg).ToArray();

            string output;
            if (cmd == "Min")
            {
                output = numbers.Min().ToString();
            }
            else if (cmd == "Max")
            {
                output = numbers.Max().ToString();
            }
            else // if (cmd == "All")
            {
                output = string.Join(" ", numbers.OrderBy(n => n));
            }

            Console.WriteLine(output);
        }
    }
}
