﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int counter = 0;
            while (ingredient != "Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                ingredient = Console.ReadLine();
                counter++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}
