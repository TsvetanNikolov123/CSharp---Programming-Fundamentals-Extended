namespace _11.Count_of_Given_Element_in_Array
{
    using System;
    
    class CountOfGivenElementInArray
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] splitText = text.Split(' ');
            int[] numbers = new int[splitText.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                string currentText = splitText[i];
                int currentNumber = int.Parse(currentText);
                numbers[i] = currentNumber;
            }

            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
