using System;

namespace _01.Hello__Name_
{
    class HelloName
    {
        static void Main()
        {
            name();
        }

        public static void name()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
