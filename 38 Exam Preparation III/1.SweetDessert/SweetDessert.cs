namespace _1.SweetDessert
{
    using System;

    public class SweetDessert
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int guestCnt = int.Parse(Console.ReadLine());
            double bananasPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            int portions = (guestCnt / 6);

            if (guestCnt % 6 != 0)
            {
                portions++;
            }


            double totalPrice =
                bananasPrice * 2 +
                eggsPrice * 4 +
                berriesPrice * 0.2;

            totalPrice *= portions;

            if (totalPrice > money)
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", totalPrice - money);
            }
            else
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", totalPrice);
            }
        }
    }
}
