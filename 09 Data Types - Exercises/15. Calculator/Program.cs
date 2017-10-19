using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstOperand = int.Parse(Console.ReadLine());
            char theOperator = char.Parse(Console.ReadLine());
            int secondOperand = int.Parse(Console.ReadLine());

            switch (theOperator)
            {
                case '+':
                    Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
                    break;
                case '-':
                    Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
                    break;
                case '*':
                    Console.WriteLine($"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
                    break;
                case '/':
                    Console.WriteLine($"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
                    break;                
            }
        }
    }
}
