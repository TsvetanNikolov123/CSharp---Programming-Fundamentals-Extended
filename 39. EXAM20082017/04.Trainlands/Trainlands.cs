namespace _04.Trainlands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Trainlands
    {
        public static void Main()
        {
            var trains = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "It's Training Men!")
            {
                string[] myArr = input.Split();
                string trainName = myArr[0];

                if (myArr.Length == 5)
                {
                    string wagonName = myArr[2];
                    int wagonPower = int.Parse(myArr[4]);

                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, int>());
                    }
                    if (!trains[trainName].ContainsKey(wagonName))
                    {
                        trains[trainName].Add(wagonName, 0);
                    }
                    trains[trainName][wagonName] += wagonPower;
                }
                else
                {
                    string command = myArr[1];
                    string otherTrain = myArr[2];

                    switch (command)
                    {
                        case "->":
                            if (!trains.ContainsKey(trainName))
                            {
                                trains.Add(trainName, new Dictionary<string, int>());
                            }

                            foreach (var tr2 in trains[otherTrain])
                            {
                                trains[trainName].Add(tr2.Key, tr2.Value);
                            }
                            trains.Remove(otherTrain);
                            break;
                        case "=":
                            if (!trains.ContainsKey(trainName))
                            {
                                trains.Add(trainName, new Dictionary<string, int>());
                            }

                            trains[trainName].Clear();
                            foreach (var tr2 in trains[otherTrain])
                            {
                                trains[trainName].Add(tr2.Key, tr2.Value);
                            }
                            break;
                    }
                }
                input = Console.ReadLine();
            }


            foreach (var train in trains
                                    .OrderByDescending(p => p.Value.Values.Sum())
                                    .ThenBy(c => c.Value.Count()))

            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagon in train.Value
                                              .OrderByDescending(pp => pp.Value)
                                                                                 )
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }

        }
    }
}
