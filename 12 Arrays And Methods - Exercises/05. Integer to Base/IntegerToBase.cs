namespace _05.Integer_to_Base
{
    using System;

    class IntegerToBase
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberToBase(number, toBase));
        }

        static string NumberToBase(long number, int toBase)
        {
            string result = String.Empty;

            while (number > 0)
            {
                long remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }
            return result;
        }
    }
}
