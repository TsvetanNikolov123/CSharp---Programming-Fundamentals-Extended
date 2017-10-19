namespace _6.PowerPlants
{
    using System;
    using System.Linq;

    class PowerPlants
    {
        static void Main()
        {
            int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int daysSurvived = 0;
            int season = 0;
            int power = 0;

            while (true)
            {
                for (int i = 0; i < plants.Length; i++)
                {
                    power = 0;
                    daysSurvived++;

                    for (int j = 0; j < plants.Length; j++)
                    {
                        if (i == j)
                        {
                            if (plants[i] > 0)
                            {
                                plants[i]++;
                            }
                        }

                        if (plants[j] > 0)
                        {
                            plants[j]--;
                        }

                        power += plants[j];
                    }

                    if (power > 0) continue;
                    else break;

                }

                if (power > 0)
                {
                    season++;

                    for (int i = 0; i < plants.Length; i++)
                    {
                        if (plants[i] > 0)
                        {
                            plants[i]++;
                        }
                    }
                }

                else break;

            }

            Console.WriteLine($"survived {daysSurvived} days ({season} seasons)");
        }
    }
}
