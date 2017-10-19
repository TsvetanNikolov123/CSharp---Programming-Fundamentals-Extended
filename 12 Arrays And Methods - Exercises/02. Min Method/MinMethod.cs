namespace _02.Min_Method
{
    using System;

    class MinMethod
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(firstNumber, GetMin(secondNumber, thirdNumber)));
        }

        public static int GetMin(int firstNumber, int secondNumber)
        {
            return Math.Min(firstNumber, secondNumber);
        }
    }
}
