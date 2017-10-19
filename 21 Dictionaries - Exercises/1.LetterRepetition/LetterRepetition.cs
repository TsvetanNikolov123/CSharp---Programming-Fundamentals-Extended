namespace _1.LetterRepetition
{
    using System;
    using System.Collections.Generic;

    public class LetterRepetition
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();
            
            // С всяко завъртане на цикъла, ние проверяваме дали речника ни съдържа съответния char,
            // и ако не го съдържа го добавя в речника със бройка 0 (това става в if проверката)и след това
            // го увеличава. Ако вече го съдържа в себе си, просто го увеличава 

            foreach (char letter in input) // За всеки char в input-а 
            {
                if (!lettersCount.ContainsKey(letter))  // Ако речника не съдържа Key == char-а в този цикъл
                {
                    lettersCount[letter] = 0;       // създаваме си го в речника с нулева бройка
                }

                lettersCount[letter]++;     // и тук си увеличаваме бройката на чаровете които сме серщнали 
            }

            foreach (var letterCountPair in lettersCount)
            {
                var letter = letterCountPair.Key;
                var count = letterCountPair.Value;
                Console.WriteLine($"{letter} -> {count}");
            }
        }
    }
}