﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cheese = 0;
            int tomatoSauce = 0;
            int salami = 0;
            int pepper = 0;

            for (int i = 1; i <= n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    cheese++;
                }
                else if (ingredients == "tomato sauce")
                {
                    tomatoSauce++;
                }
                else if (ingredients == "salami")
                {
                    salami++;
                }
                else if (ingredients == "pepper")
                {
                    pepper++;
                }
            }
            int cheeseCal = cheese * 500;
            int tomatoSauceCal = tomatoSauce * 150;
            int salamiCal = salami * 600;
            int pepperCal = pepper * 50;
            int totalCal = cheeseCal + tomatoSauceCal + salamiCal + pepperCal;

            Console.WriteLine("Total calories: {0}", totalCal);
        }
    }
}
