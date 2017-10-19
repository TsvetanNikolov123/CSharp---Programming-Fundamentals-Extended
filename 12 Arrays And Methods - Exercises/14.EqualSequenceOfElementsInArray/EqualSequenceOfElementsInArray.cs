namespace _14.EqualSequenceOfElementsInArray
{
    using System;

    class EqualSequenceOfElementsInArray
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] splitText = text.Split(' ');
            int[] numbers = new int[splitText.Length];
            int temp = 0;
            int count = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                string currentText = splitText[i];
                int currentNumber = int.Parse(currentText);

                numbers[i] = currentNumber;

                if (currentNumber != temp)
                {
                    count++;
                }
                temp = currentNumber;
            }
            if (count != 0)
            {
                Console.WriteLine("No");

            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
