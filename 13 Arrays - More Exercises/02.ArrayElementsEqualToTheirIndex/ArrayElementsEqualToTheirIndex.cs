namespace _02.ArrayElementsEqualToTheirIndex
{
    using System;
    using System.Linq;

    class ArrayElementsEqualToTheirIndex
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int[] numbers = new int[array.Length];

            string index = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                string currentText = array[i];
                int currentNumber = int.Parse(currentText);
                if (currentNumber == i)
                {
                    index += i + " "; 
                }
            }
            Console.WriteLine(index);
        }
    }
}
