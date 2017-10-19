using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling_At_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kmForLightYeras = 9450000000000;
            decimal kmPerSeconds = 300000;
            decimal ly = decimal.Parse(Console.ReadLine());

            decimal secondsTotal = (ly * kmForLightYeras) / kmPerSeconds;
            int minutes = (int)(secondsTotal / 60);
            secondsTotal %= 60;
            int hours = minutes / 60;
            minutes %= 60;
            int days = hours / 24;
            hours %= 24;
            int weeks = days / 7;
            days %= 7;
            
            Console.WriteLine("{0} weeks", weeks);
            Console.WriteLine("{0} days", days);
            Console.WriteLine("{0} hours", hours);
            Console.WriteLine("{0} minutes", minutes);
            Console.WriteLine("{0} seconds", (int)secondsTotal);
            /* https://answers.yahoo.com/question/index?qid=20080405225231AAGeZFe */
        }
    }
}
