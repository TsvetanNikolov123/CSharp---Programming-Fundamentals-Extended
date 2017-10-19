namespace _17.Altitude
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Altitude
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            List<long> altitude = new List<long>();
            long result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    altitude.Add(long.Parse(array[i]));
                }
            }

            result = altitude[0];

            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] == "up")
                {
                    result += long.Parse(array[i + 1]);
                }
                else
                {
                    result -= long.Parse(array[i + 1]);
                    if (result <= 0)
                    {
                        Console.WriteLine("crashed");
                        return;
                    }
                }
            }

            Console.WriteLine($"got through safely. current altitude: {result}m");
        }
    }
}
