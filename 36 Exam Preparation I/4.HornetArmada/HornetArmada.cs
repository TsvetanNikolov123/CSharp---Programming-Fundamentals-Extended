namespace _4.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    /// <summary>
    /// Ne e gotova
    /// </summary>
    public class HornetArmada
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> legionActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> legionTypeCount = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(new string[] { " = ", " -> ", ":" },
                        StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(information[0]);
                string legionName = information[1];
                string soldierType = information[2];
                int soldierCount = int.Parse(information[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, lastActivity);
                }

                legionActivity[legionName] = lastActivity;

            }


            string command = Console.ReadLine();

        }
    }
}
