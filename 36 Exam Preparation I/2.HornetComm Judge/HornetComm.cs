namespace _2.HornetComm_Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    /// <summary>
    /// 00:45:14
    /// </summary>
    public class HornetComm
    {
        public static void Main()
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string[] line = Console.ReadLine()
                             .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
            
            while (line[0] != "Hornet is Green")
            {
                if (line.Length != 2)                                                                  // проверка дали 
                {                                                                                      // масива не е 
                    line = Console.ReadLine()                                                          // с по малък размер
                             .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);  // и да не ни
                    continue;                                                                          // гръмне задачата
                }                                                                                      //

                string leftPart = line[0];
                string rightPart = line[1];

                if (leftPart.All(char.IsDigit) &&
                    rightPart.All(char.IsLetterOrDigit))
                {
                    string reversed = new string(leftPart.ToCharArray().Reverse().ToArray()); // ТОВА Е ВАЖНО ДА СЕ ЗАПОМНИ char => string

                    messages.Add($"{reversed} -> {rightPart}");
                }
                else if (leftPart.All(c => !char.IsDigit(c)) &&
                        rightPart.All(char.IsLetterOrDigit))
                {
                    string reversedCases = ReverseCases(rightPart);

                    broadcasts.Add($"{reversedCases} -> {leftPart}"); 
                }

                line = Console.ReadLine()
                .Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Count == 0 ? "None" : string.Join(Environment.NewLine,broadcasts));

            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Count == 0 ? "None" : string.Join(Environment.NewLine, messages));
        }

        private static string ReverseCases(string rightPart)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rightPart.Length; i++)
            {
                if (char.IsUpper(rightPart[i]))
                {
                    result.Append(char.ToLower(rightPart[i]));
                }
                else if (char.IsLetter(rightPart[i]))
                {
                    result.Append(char.ToUpper(rightPart[i]));
                }
                else
                {
                    result.Append(rightPart[i]);
                }
            }
            return result.ToString();
        }
    }
}
