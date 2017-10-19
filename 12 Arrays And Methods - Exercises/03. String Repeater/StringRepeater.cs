﻿namespace _03.String_Repeater
{
    using System;

    public class StringRepeater
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str,count));
            
            //string result = RepeatString(str, count);
            //Console.WriteLine(result);
        }

        public static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }

            return repeatedString;
        }
    }
}