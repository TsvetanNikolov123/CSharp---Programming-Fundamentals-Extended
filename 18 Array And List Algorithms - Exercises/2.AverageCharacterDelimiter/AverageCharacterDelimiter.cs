namespace _2.AverageCharacterDelimiter
{
    using System;
    using System.Collections.Generic;

    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            
            List<int> list = new List<int>();
            int count = 0;

            foreach (char c in str)
            {
                
                int numASCII = (int)c;

                if (numASCII == 32)
                {
                    continue;
                }
                else
                {
                    list.Add((int)c);
                    count++;
                }
            }

            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            int result = (int)sum / count;
            string toUpperChar = (Char.ToUpper((char)result)).ToString();

            string temp = str.Replace(" ", toUpperChar);
            Console.WriteLine(temp);
        }
    }
}
