namespace _03.Trainegram
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Trainegram
    {
        public static void Main()
        {
            Regex train = new Regex($@"^(<\[[^0-9a-zA-Z]*\]\.)(\.\[[a-zA-Z0-9]*\]\.)*$");
            List<string> trains = new List<string>();
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input.Equals("Traincode!")) break;
                else
                {
                    if (train.IsMatch(input) && input[input.Length - 1].Equals('.')) trains.Add(input);
                }
            }
            Console.WriteLine(string.Join("\n", trains));
            Console.ReadLine();
        }
    }
}
