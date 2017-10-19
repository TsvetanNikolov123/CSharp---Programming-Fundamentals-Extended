namespace _02.Entertrain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Entertrain
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int locomotivesPower = int.Parse(input);
            List<int> all = new List<int>();

            input = Console.ReadLine();
            while (input != "All ofboard!")
            {
                int tokens = int.Parse(input);
                all.Add(tokens);

                if (all.Sum() > locomotivesPower)
                {
                    int average = (int)all.Average();
                    int colosest = all.OrderBy(item => Math.Abs(average - item)).First();
                    all.Remove(colosest);
                }


                input = Console.ReadLine();
            }

            all.Reverse();
            Console.Write(string.Join(" ", all));
            Console.WriteLine(" {0}", locomotivesPower);
        }
    }
}
