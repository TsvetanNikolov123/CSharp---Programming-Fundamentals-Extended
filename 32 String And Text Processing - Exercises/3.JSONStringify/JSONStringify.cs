namespace _3.JSONStringify
{
    using System;
    using System.Text;

    public class JSONStringify
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            builder.Append("[");

            while (input != "stringify")
            {
                string[] tokens = input
                    .Split(new string[] { " : ", " ->" },
                        StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string age = tokens[1];
                string[] grades = new string[] { };

                if (tokens.Length > 2)
                {
                    grades = tokens[2]
                    .Split(new string[] { ", ", " " },
                        StringSplitOptions.RemoveEmptyEntries);
                }

                builder.Append(string.Format("{{name:\"{0}\",age:{1},grades:[{2}]}},",
                    name,
                    age,
                    string.Join(", ",grades)));

                input = Console.ReadLine();
            }

            builder.Remove(builder.Length - 1, 1);
            builder.Append("]");

            Console.WriteLine(builder.ToString());
        }
    }
}
