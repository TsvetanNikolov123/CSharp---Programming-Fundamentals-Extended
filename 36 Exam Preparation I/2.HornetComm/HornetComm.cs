namespace _2.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;
    
    /// <summary>
    ///     NE SAM SI DOVARSHIL ZADACHATA.... DAVA MI GRESHKI
    /// </summary>

    public class HornetComm
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex digits = new Regex(@"[0-9]+");
            Regex digitsWords = new Regex(@"[0-9A-Za-z]+");
            Regex lower = new Regex(@"[a-z]");
            Regex upper = new Regex(@"[A-Z]");

            Dictionary<string, string> messages = new Dictionary<string, string>();
            Dictionary<string, string> broadcasts = new Dictionary<string, string>();

            while (input != "Hornet is Green")
            {
                string[] tokens = input
                    .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                string firstQuery = tokens[0];
                string secondQuery = tokens[1];

                if (digits.IsMatch(firstQuery) && digitsWords.IsMatch(secondQuery))
                {
                    //private message
                    string frequency = new string (tokens[0].ToCharArray().Reverse().ToArray());
                    string message = tokens[1];
                    messages.Add(frequency, message);
                }
                else if (!(digits.IsMatch(firstQuery)) && digitsWords.IsMatch(secondQuery))
                {
                    //broadcast
                    string frequency = tokens[1];
                    string message = tokens[0];
                    string changetFrequency = "";
                    foreach (var element in frequency)
                    {
                        if (lower.IsMatch(element.ToString()))
                        {
                            changetFrequency += element.ToString().ToUpper();
                        }
                        else if (upper.IsMatch(element.ToString()))
                        {
                            changetFrequency += element.ToString().ToLower();
                        }
                           
                    }
                    
                    broadcasts.Add(changetFrequency, message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
