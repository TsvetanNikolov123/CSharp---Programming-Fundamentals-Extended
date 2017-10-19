namespace _15.CountOfCapitalLettersInArray
{
    using System;
    using System.Linq;

    class CountOfCapitalLettersInArray
    {
        static void Main()
        {
            string[] capitalString = Console.ReadLine().Split(' ').ToArray();
            int couter = 0;

            for (int i = 0; i < capitalString.Length; i++)
            {
                if (capitalString[i].Length == 1)
                {
                    int singleLetter = capitalString[i][0];
                    if (singleLetter >= 'A' && singleLetter <= 'Z')
                    {
                        couter++;
                    }
                }
            }
            Console.WriteLine(couter);
        }
    }
}
