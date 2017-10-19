﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (0 <= age  && age <= 18)
            {
                if (typeOfDay == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (typeOfDay == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (typeOfDay == "Holiday")
                {
                    Console.WriteLine("5$");
                }
            }
            else if (18 < age && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    Console.WriteLine("18$");
                }
                else if (typeOfDay == "Weekend")
                {
                    Console.WriteLine("20$");
                }
                else if (typeOfDay == "Holiday")
                {
                    Console.WriteLine("12$");
                }
            }
            else if (64 < age && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    Console.WriteLine("12$");
                }
                else if (typeOfDay == "Weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (typeOfDay == "Holiday")
                {
                    Console.WriteLine("10$");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
