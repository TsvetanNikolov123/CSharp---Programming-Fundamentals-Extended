namespace _1.ReverseString
{
    using System;
    using System.Linq;

    public class ReverseStrings
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            // string reversed = new string(text.Reverse().ToArray()); tova e drygia variant
            Console.WriteLine(ReverseString(text));
            
        }

        public static string ReverseString(string srtVarable)
        {
            return new string(srtVarable.Reverse().ToArray());
        }
    }
}
