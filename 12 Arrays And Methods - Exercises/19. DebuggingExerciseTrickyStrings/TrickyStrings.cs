namespace _19.DebuggingExerciseTrickyStrings
{
    using System;
    
    class TrickyStrings
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 0; i < numberOfStrings; i++)
            {
                string currentString = Console.ReadLine();

                if (i != numberOfStrings - 1)
                {
                    result += currentString + delimiter;
                }
                else
                {
                    result += currentString;
                }
            }
            Console.WriteLine(result);
        }
    }
}
