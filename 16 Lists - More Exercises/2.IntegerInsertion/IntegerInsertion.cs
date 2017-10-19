namespace _2.IntegerInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class IntegerInsertion
    {
        public static void Main()
        {
            List<int> elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                int currentNumber = int.Parse(input);
                int firstDigit = input[0] - '0';

                elements.Insert(firstDigit, currentNumber);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
