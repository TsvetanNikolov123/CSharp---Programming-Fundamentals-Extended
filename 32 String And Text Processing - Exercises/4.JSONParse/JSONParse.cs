namespace _4.JSONParse
{
    using System;
        
    public class JSONParse
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            input = input.Substring(2, input.Length - 2 - 2);

            string[] tokens = input
                .Split(new string[] { "},{" },
                    StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                string[] properties = token
                    .Split(new string[] { ",age:", ",grades:" },
                        StringSplitOptions.RemoveEmptyEntries);
                string name = properties[0]
                    .Substring(6, properties[0].Length - 6 - 1);
                string age = properties[1];
                string grades = properties[2]
                    .Substring(1, properties[2].Length -1 -1);

                if (grades == string.Empty)
                {
                    grades = "None";
                }

                Console.WriteLine("{0} : {1} -> {2}", name, age, grades);
            }
        }
    }
}
