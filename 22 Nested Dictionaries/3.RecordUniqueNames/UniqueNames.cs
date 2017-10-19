namespace _3.RecordUniqueNames
{
    using System;
    using System.Collections.Generic;

    public class UniqueNames
    {
        public static void Main()
        {
            HashSet<string> names = new HashSet<string>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCnt; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
