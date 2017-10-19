namespace _1.SoftuniCoffeeOrders_Judge
{
    using System;
    using System.Linq;

    public class CoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal daysCaount = 0;
            decimal priceForTheCoffee = 0;
            decimal totalPrice = 0;
            decimal capsulesCount = 0;
            decimal pricePerCapsule = 0;
            for (int i = 0; i < n; i++)
            {
                pricePerCapsule = decimal.Parse(Console.ReadLine());
                int[] data = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                capsulesCount = decimal.Parse(Console.ReadLine());
                int year = data[2];
                int month = data[1];
                daysCaount = DateTime.DaysInMonth(year, month);
                priceForTheCoffee = (daysCaount * capsulesCount) * pricePerCapsule;
                totalPrice += priceForTheCoffee;

                Console.WriteLine($"The price for the coffee is: ${priceForTheCoffee:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
