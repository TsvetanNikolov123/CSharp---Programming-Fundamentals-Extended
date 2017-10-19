namespace _1.ShootListElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShootListElements
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();

            string input = Console.ReadLine();
            int lastShotNumber = 0;

            while (true)
            {
                if (input == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was " + lastShotNumber);
                        break;
                    }

                    double average = numbers.Average();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= average)
                        {
                            lastShotNumber = numbers[i];
                            numbers.RemoveAt(i);
                            Console.WriteLine("shot " + lastShotNumber);
                            break;
                        }
                        else if (numbers.Count == 1)
                        {
                            lastShotNumber = numbers[0];
                            numbers.RemoveAt(0);
                            Console.WriteLine("shot " + lastShotNumber);
                            break;
                        }
                    }

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }
                else if (input == "stop")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("you shot them all. last one was " + lastShotNumber);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
                        break;
                    }
                }
                else
                {
                    int number = int.Parse(input);
                    numbers.Insert(0, number);
                }

                input = Console.ReadLine();
            }
        }
    }
}
