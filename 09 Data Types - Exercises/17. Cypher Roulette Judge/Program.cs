using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette_Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isReversed = false;
            string message = String.Empty;
            string previusString = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string currentStrig = Console.ReadLine();
                if (currentStrig == previusString)
                {
                    message = String.Empty;
                    if (currentStrig == "spin")
                    {                        
                        n++;
                    }
                }
                else
                {
                    if (currentStrig == "spin")
                    {
                        isReversed = !isReversed;
                        n++;
                    }
                    else
                    {
                        if (isReversed)
                        {
                            message = currentStrig + message;
                        }
                        else
                        {
                            message += currentStrig;
                        }
                    }
                }
                previusString = currentStrig;
            } 
            Console.WriteLine(message);
        }
    }
}
