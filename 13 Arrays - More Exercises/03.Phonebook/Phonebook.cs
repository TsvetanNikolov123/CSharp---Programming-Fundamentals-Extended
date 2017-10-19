namespace _03.Phonebook
{
    using System;
    using System.Linq;

    class Phonebook
    {
        static void Main()
        {
            string[] phoneArray = Console.ReadLine().Split(' ').ToArray();
            string[] nameArray = Console.ReadLine().Split(' ').ToArray();

            string input = string.Empty;

            while (input != "done")
            {
                input = Console.ReadLine();

                for (int i = 0; i < nameArray.Length; i++)
                {
                    if (input == nameArray[i])
                    {
                        Console.WriteLine($"{input} -> {phoneArray[i]}");
                    }
                }
            }
        }
    }
}
