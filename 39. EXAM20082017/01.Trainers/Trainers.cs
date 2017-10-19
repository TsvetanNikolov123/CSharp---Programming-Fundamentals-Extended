namespace _01.Trainers
{
    using System;

    public class Trainers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double technicalMoney = 0;
            double theoreticalMoney = 0;
            double practicalMoney = 0;

            for (int i = 0; i < n; i++)
            {
                int distanceInMiles = int.Parse(Console.ReadLine());
                double cargoInTons = double.Parse(Console.ReadLine());
                string team = Console.ReadLine();

                int distanceInMeters = distanceInMiles * 1600;
                double cargoInKg = cargoInTons * 1000;
                double participEntMoney = (cargoInKg * 1.5) - (0.7 * distanceInMeters * 2.5);

                if (team == "Technical")
                {
                    technicalMoney += participEntMoney;
                }
                else if (team == "Theoretical")
                {
                    theoreticalMoney += participEntMoney;
                }
                else if (team == "Practical")
                {
                    practicalMoney += participEntMoney;
                }
            }
            double winner = Math.Max(technicalMoney, Math.Max(theoreticalMoney, practicalMoney));

            if (winner == technicalMoney)
            {
                Console.WriteLine($"The Technical Trainers win with ${technicalMoney:f3}.");
            }
            else if (winner == theoreticalMoney)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${theoreticalMoney:f3}.");
            }
            else if (winner == practicalMoney)
            {
                Console.WriteLine($"The Practical Trainers win with ${practicalMoney:f3}.");
            }
        }
    }
}
