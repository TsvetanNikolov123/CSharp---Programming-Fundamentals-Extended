using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {

            // 60 / 100 Judge test => last 4 test crash
            // https://softuni.bg/forum/questions/details/15060

            int n = int.Parse(Console.ReadLine());
            string word = "";
            string wordBegininig = "";
            string tempWord = "";
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input == "spin")
                {
                    counter++;
                    i--;                    
                }

                if (input == "spin" && tempWord == input)
                {
                    word = string.Empty;
                    wordBegininig = string.Empty;
                    input = string.Empty;
                }

                if (counter % 2 == 0 && input != "spin")
                {
                    if (tempWord == input)
                    {
                        word = string.Empty;
                        wordBegininig = string.Empty;
                        input = string.Empty;
                        n++;
                    }
                    word += input;
                }
                else if (counter % 2 != 0 && input != "spin")
                {
                    if (tempWord == input)
                    {
                        word = string.Empty;
                        wordBegininig = string.Empty;
                        input = string.Empty;
                        n++;
                    }
                    wordBegininig += input;
                }
                tempWord = input;
            }
            Console.WriteLine(wordBegininig + word);
        }
    }
}
