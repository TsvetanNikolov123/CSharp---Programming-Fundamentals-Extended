using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4.0;

            double beatsPerSecond = beatsPerMinute / 60.0;
            double time = numberOfBeats / beatsPerSecond;

            int minutes = (int)time / 60;
            int seconds = (int)time % 60;

            Console.WriteLine($"{Math.Round(bars, 01)} bars - {minutes}m {seconds}s");
        }
    }
}
