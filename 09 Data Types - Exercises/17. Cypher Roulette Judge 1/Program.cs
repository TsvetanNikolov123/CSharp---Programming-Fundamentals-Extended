using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette_Judge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool spinRight = true;
            bool spinLeft = false;
            string currString = string.Empty;
            string prevString = string.Empty;
            string finalString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                currString = Console.ReadLine();

                if (prevString == currString)
                {
                    finalString = string.Empty;
                    continue;
                }

                if (currString == "spin")
                {
                    if (spinLeft)
                    {
                        spinLeft = false;
                        spinRight = true;
                        i -= 1;
                    }
                    else
                    {
                        spinLeft = true;
                        spinRight = false;
                        i -= 1;
                    }
                }
                else if (spinRight)
                {
                    finalString = finalString + currString;
                }
                else if (spinLeft)
                {
                    finalString = currString + finalString;
                }

                prevString = currString;
            }
            Console.WriteLine(finalString);
        }
    }
}
