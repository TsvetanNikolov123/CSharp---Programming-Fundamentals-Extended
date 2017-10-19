namespace _05.CharRotation
{
    using System;
    using System.Linq;  
    
    class CharRotation
    {
        static void Main()
        {
            string charValues = Console.ReadLine();
            int[] intValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] result = new char[intValues.Length];
            for (int i = 0; i < intValues.Length; i++)
            {
                //в иф-а трябва да проверяваш не дали елемента от масива с числата е на четен или нечетен индекс
                //а да проверяваш самия елемент на даденото място дали е четен или не
                if (intValues[i] % 2 == 0)
                {
                    result[i] = (char)(charValues[i] - intValues[i]);
                }
                else
                {                               //тук не е '-' а '+'
                    result[i] = (char)(charValues[i] + intValues[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}

