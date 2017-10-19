using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numOne = decimal.Parse(Console.ReadLine());
            decimal numTwo = decimal.Parse(Console.ReadLine());


            if (Math.Max(numOne, numTwo) <= byte.MaxValue && Math.Max(numOne, numTwo) >= byte.MinValue)
            {
                Console.WriteLine("bigger type: byte");
            }
            else if (Math.Max(numOne, numTwo) <= ushort.MaxValue)
            {
                Console.WriteLine("bigger type: ushort");
            }
            else if (Math.Max(numOne, numTwo) <= uint.MaxValue)
            {
                Console.WriteLine("bigger type: uint");
            }
            else if (Math.Max(numOne, numTwo) <= ulong.MaxValue)
            {
                Console.WriteLine("bigger type: ulong");
            }


            if (Math.Min(numOne, numTwo) <= byte.MaxValue && Math.Min(numOne, numTwo) >= byte.MinValue)
            {
                Console.WriteLine("smaller type: byte");
                Console.WriteLine($"{Math.Max(numOne, numTwo)} can overflow byte {Math.Round(Math.Max(numOne, numTwo) / byte.MaxValue)} times");
            }
            else if (Math.Min(numOne, numTwo) <= ushort.MaxValue)
            {
                Console.WriteLine("smaller type: ushort");
                Console.WriteLine($"{Math.Max(numOne, numTwo)} can overflow ushort {Math.Round(Math.Max(numOne, numTwo) / ushort.MaxValue)} times");
            }
            else if (Math.Min(numOne, numTwo) <= uint.MaxValue)
            {
                Console.WriteLine("smaller type: uint");
                Console.WriteLine($"{Math.Max(numOne, numTwo)} can overflow uint {Math.Round(Math.Max(numOne, numTwo) / uint.MaxValue)} times");
            }
            else if (Math.Min(numOne, numTwo) <= ulong.MaxValue)
            {
                Console.WriteLine("smaller type: ulong");
                Console.WriteLine($"{Math.Max(numOne, numTwo)} can overflow ulong {Math.Round(Math.Max(numOne, numTwo) / ulong.MaxValue)} times");
            }            
        }
    }
}
