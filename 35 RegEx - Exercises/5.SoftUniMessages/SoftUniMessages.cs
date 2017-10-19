namespace _5.SoftUniMessages
{
    using System;
    using System.Text.RegularExpressions;

    public class SoftUniMessages
    {
        public static void Main()
        {
            Regex messagePattern = new Regex(@"^\d+(?<message>[A-Za-z]+)[^a-zA-Z]+$");

            string input = Console.ReadLine();
            while (input != "Decrypt!")
            {
                int validMessageLength = int.Parse(Console.ReadLine());

                if (messagePattern.IsMatch(input))
                {
                    Match m = messagePattern.Match(input);
                    string message = m.Groups["message"].Value;

                    if (message.Length == validMessageLength)
                    {
                        string decodedMessage = DecodedMessage(input, message);

                        Console.WriteLine("{0} = {1}", message, decodedMessage);
                    }
                }

                input = Console.ReadLine();
            } 
        }

        public static string DecodedMessage(string input, string message)
        {
            string result = "";
            foreach (char symbol in input)
            {
                int index = symbol - '0';
                if (char.IsDigit(symbol) && index < message.Length)
                {
                    result += message[symbol - '0'];
                }
            }
            return result;
        }
    }
}
