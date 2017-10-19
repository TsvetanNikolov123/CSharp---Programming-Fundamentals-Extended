namespace _12.CountOccurrencesOfLargerNumbersInArray
{
    using System;

    class CountOccurrencesOfLargerNumbersInArray
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] splitText = text.Split(' ');
            double[] numbers = new double[splitText.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                string currentText = splitText[i];
                double currentNumber = double.Parse(currentText);
                numbers[i] = currentNumber;
            }

            double p = double.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
