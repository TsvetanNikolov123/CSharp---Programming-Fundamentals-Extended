namespace _13.IncreasingSequenceOfElements
{
    using System;

    class IncreasingSequenceOfElements
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] splitText = text.Split(' ');
            int[] numbers = new int[splitText.Length];
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                string currentText = splitText[i];
                int currentNumber = int.Parse(currentText);
                numbers[i] = currentNumber;
                if (currentNumber < temp)
                {
                    Console.WriteLine("No");
                    return;
                }
                temp = currentNumber;
            }
            Console.WriteLine("Yes");
        }
    }
}
