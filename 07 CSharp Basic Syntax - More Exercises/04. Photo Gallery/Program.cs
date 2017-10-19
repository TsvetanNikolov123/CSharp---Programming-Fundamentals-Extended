using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int houers = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");

            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {houers:D2}:{minutes:D2}");

            if (size < 999)
            {
                Console.WriteLine($"Size: {size}B");
            }
            else if (size < 999999)
            {
                size /= 1000;
                Console.WriteLine($"Size: {size}KB");
            }
            else
            {
                size /= 1000000;
                Console.WriteLine($"Size: {size}MB");
            }

            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (width < height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}
