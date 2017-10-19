namespace _1.ValueOfAString
{
    using System;

    public class ValueOfAString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string format = Console.ReadLine();

            char[] charString = input.ToCharArray();

            int sum = 0;
            if (format == "LOWERCASE")
            {
                foreach (char item in charString)
                {
                    if (item >= 97 && item <= 122)
                    {
                        sum += item;
                    }
                }
            }
            else if (format == "UPPERCASE")
            {
                foreach (char item in charString)
                {
                    if (item >= 65 && item <= 90)
                    {
                        sum += item;
                    }
                }
            }

            Console.WriteLine("The total sum is: {0}", sum);

        }
    }
}
