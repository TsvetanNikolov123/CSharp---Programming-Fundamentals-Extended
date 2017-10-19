namespace _2.Placeholders
{
    using System;

    public class Placeholders
    {
        public static void Main()
        {
            string input = Console.ReadLine();                          // Приемаме си стринга от конзолата 
                                                                        // 
            while (input != "end")                                      // Въртиме цикъл докато не ни подадът на конзалата "end"
            {                                                           // 
                string[] inputTokens = input                            // С този първи масив от стрингове ние си разделяме стринга на текст 
                    .Split(new string[] { " -> " },                     // и стринг с плейсхолдъри, като ги сплитваме 
                        StringSplitOptions.RemoveEmptyEntries);         // и махаме празните пространства
                                                                        // 
                string text = inputTokens[0];                           // 
                                                                        // 
                string[] parameters = inputTokens[1]                    // тук сплитваме плейсхолдърите по запетая като ги взимаме от предишния масив на първи индекс
                    .Split(new string[] { ", " },                       // 
                        StringSplitOptions.RemoveEmptyEntries);         // 
                                                                        // 
                for (int index = 0; index < parameters.Length; index++) // въртиме зикъл от 0 до дължината на втория ни масив или до бройката плейсхолдъри
                {                                                       // 
                    string parameter = parameters[index];               // тук параметъра е равен на индекса на масива параменъри при този цикъл на завъртане, съответно 0, 1, 2 и т.н
                    string placeholder = "{" + index + "}";             // тук правиме стринг който е равен на скобките и между тях слагаме индекса на цикъла в мамента и сатава съответно {0}, {1}, {2} и т.н.
                                                                        // 
                    text = text.Replace(placeholder, parameter);        // тук заместваме
                }                                                       // 
                                                                        // 
                Console.WriteLine(text);                                // 
                input = Console.ReadLine();                             // 
            }
        }
    }
}
