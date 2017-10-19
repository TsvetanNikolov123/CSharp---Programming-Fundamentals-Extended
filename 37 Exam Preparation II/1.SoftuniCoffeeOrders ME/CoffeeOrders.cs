namespace _1.SoftuniCoffeeOrders_ME
{
    using System;
    using System.Linq;

    public class CoffeeOrders
    {
        public static void Main()
        {
            decimal ordersCount = decimal.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            while (ordersCount-- > 0)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int[] data = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                decimal count = decimal.Parse(Console.ReadLine());
                int year = data[2];
                int month = data[1];
                int monthLenght = DateTime.DaysInMonth(year, month);
                decimal orderPrice = (monthLenght * count) * pricePerCapsule;
                totalPrice += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
