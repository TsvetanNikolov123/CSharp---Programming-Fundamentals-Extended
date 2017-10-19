namespace _3.HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    /// <summary>
    /// me
    /// </summary>
    public class HornetAssault
    {
        public static void Main()
        {
            List<long> beehives = new List<long>(Console.ReadLine()
                .Split(' ')
                .Select(long.Parse));
            List<long> hornets = new List<long>(Console.ReadLine()
                .Split(' ')
                .Select(long.Parse));

            try
            {
                for (int i = 0; i < beehives.Count; i++)
                {
                    long sumHornets = hornets.Sum();
                    if (beehives[i] < sumHornets)
                    {
                        beehives[i] = 0;
                    }
                    else
                    {
                        beehives[i] = beehives[i] - sumHornets;
                        hornets.Remove(hornets[0]);
                    }
                }
            }
            catch (Exception)
            {

                
            }

            if (beehives.Sum() != 0)
            {
                foreach (var item in beehives)
                {
                    if (item != 0)
                    {
                        Console.Write("{0} ", item);
                    }
                }
            }
            else
            {
                foreach (var item in hornets)
                {
                    if (item != 0)
                    {
                        Console.Write("{0} ", item);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
