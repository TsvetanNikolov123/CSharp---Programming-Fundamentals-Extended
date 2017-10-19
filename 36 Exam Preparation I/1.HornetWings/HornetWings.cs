namespace _1.HornetWings
{
    using System;

    public class HornetWings
    {
        public static void Main()
        {

            double wingFlapsN = double.Parse(Console.ReadLine());  // flaps to do
            double distanceM = double.Parse(Console.ReadLine()); // meters per 1000 wing flaps
            double enduranceP = double.Parse(Console.ReadLine()); //wing flaps before 5 sec rest
            
            double distance = (wingFlapsN / 1000) * distanceM;  //output distance
            double hornetFlaps = wingFlapsN / 100;
            long restSeconds = ((long)wingFlapsN / (long)enduranceP) * 5;
            double timePassed = hornetFlaps + restSeconds;      // output time

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{timePassed} s.");
        }
    }
}
