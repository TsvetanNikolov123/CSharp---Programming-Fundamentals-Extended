namespace _16.ArraySymmetry
{
    using System;
    using System.Linq;

    class ArraySymmetry
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            bool isSymmetric = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    isSymmetric = false;
                }
            }

            if (isSymmetric == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
