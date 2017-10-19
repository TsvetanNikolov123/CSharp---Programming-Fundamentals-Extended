namespace _18.BallisticsTraining
{
    using System;
    using System.Linq;

    class BallisticsTraining
    {
        static void Main()
        {
            long[] coordinates = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] commandsNumbers = Console.ReadLine().Split(' ').ToArray();
            long[] result = new long[coordinates.Length];

            for (int i = 0; i < commandsNumbers.Length - 1; i += 2)
            {
                if (commandsNumbers[i] == "up")
                {
                    result[1] += long.Parse(commandsNumbers[i + 1]);
                }
                else if (commandsNumbers[i] == "down")
                {
                    result[1] -= long.Parse(commandsNumbers[i + 1]);
                }
                else if (commandsNumbers[i] == "left")
                {
                    result[0] -= long.Parse(commandsNumbers[i + 1]);
                }
                else
                {
                    result[0] += long.Parse(commandsNumbers[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{result[0]}, {result[1]}]");

            if (coordinates[0] == result[0] && coordinates[1] == result[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
