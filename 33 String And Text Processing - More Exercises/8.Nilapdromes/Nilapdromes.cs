namespace _8.Nilapdromes
{
    using System;

    public class Nilapdromes
    {
        public static void Main()
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string nilapdrome = ReturnNilalpdrome(line);

                if (nilapdrome != "")
                {
                    Console.WriteLine(nilapdrome);
                }

                line = Console.ReadLine();
            }
        }

        private static string ReturnNilalpdrome(string line)
        {
            int middleIndex = line.Length / 2;
            string border = "";

            int leftIndex = 0;
            for (int i = middleIndex + 1; i < line.Length; i++)
            {
                if (line[leftIndex] == line[i])
                {
                    border += line[i];
                    leftIndex++;
                }
                else
                {
                    border = "";
                    leftIndex = 0;

                    if (line[i] == line[leftIndex])
                    {
                        border += line[i];
                        leftIndex++;
                    }
                }
            }

            if (border != "")
            {
                int leftIndexMiddle = line.IndexOf(border);
                int rightIndexMiddle = line.LastIndexOf(border);

                string middle = line.Substring(leftIndexMiddle + border.Length, rightIndexMiddle - leftIndexMiddle - border.Length);

                if (middle != "")
                {
                    return middle + border + middle;
                }
            }

            return "";
        }
    }
}
