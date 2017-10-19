using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double kcalPerGram = energyContent / 100.0;
            double sugarPerGram = sugarContent / 100.0;

            double kcalAll = volume * kcalPerGram;
            double sugarAll = volume * sugarPerGram;
            Console.WriteLine("{0}ml {1}:",volume,name);
            Console.WriteLine("{0}kcal, {1}g sugars",kcalAll,sugarAll);
        }
    }
}
