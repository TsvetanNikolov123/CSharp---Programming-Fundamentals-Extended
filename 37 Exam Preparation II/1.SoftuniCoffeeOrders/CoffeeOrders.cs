namespace _1.SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class CoffeeOrders
    {
        public static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            while (inputCount-- > 0)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long countCapsules = long.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal currentPrice = daysInMonth * countCapsules * pricePerCapsule;
                totalPrice += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
