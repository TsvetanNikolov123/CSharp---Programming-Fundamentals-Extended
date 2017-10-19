namespace _6.SentenceSplit
{
    using System;

    public class SentenceSplit
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string givenDelimiter = Console.ReadLine();

            string[] tokens = input
                .Split(new string[] { givenDelimiter },
                    StringSplitOptions.None);               // None e това което ме бъркаше!!!

            // Console.Write("[");
            // Console.Write(string.Join(", ",tokens));
            // Console.WriteLine("]");

            Console.WriteLine("[{0}]", string.Join(", ", tokens));
        }
    }
}
