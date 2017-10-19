namespace _4.JapaneseRoulette
{
    using System;
    using System.Linq;

    public class JapaneseRoulette
    {
        public static void Main()
        {
            int[] bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isDead = false;
            int indexBullet = 0;
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    indexBullet = i;
                    break;
                }

            }
            string[] players = Console.ReadLine().Split(' ');

            for (int i = 0; i < players.Length; i++)
            {
                string[] tokens = players[i].Split(',');
                string directions = tokens[1];
                int power = int.Parse(tokens[0]);

                switch (directions)
                {
                    case "Right":
                        indexBullet = (indexBullet + power) % bullets.Length;
                        break;
                    case "Left":
                        if (indexBullet - power < 0)
                        {
                            indexBullet = bullets.Length - (Math.Abs(indexBullet - power) % bullets.Length);
                        }
                        else
                        {
                            indexBullet = indexBullet - power;
                        }
                        break;
                }

                if (indexBullet == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isDead = true;
                    break;
                }
                indexBullet = indexBullet + 1 == bullets.Length ? 0 : indexBullet + 1;
            }
            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
