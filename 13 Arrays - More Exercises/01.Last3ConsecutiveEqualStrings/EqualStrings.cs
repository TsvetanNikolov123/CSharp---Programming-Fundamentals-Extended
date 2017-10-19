namespace _01.Last3ConsecutiveEqualStrings
{
    using System;
    using System.Linq;
  
    class EqualStrings
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(array);

            string equalStrings = string.Empty;
            string temp = string.Empty;
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (counter == 3)
                {
                    continue;
                }

                string currentText = array[i];
                
                if (currentText == temp)
                {
                    counter++;                    
                }
                else
                {
                    temp = currentText;
                    equalStrings = string.Empty;
                    counter = 1;
                }                
            }
            if (counter == 3)
            {
                equalStrings = temp + " " + temp + " " + temp;
                Console.WriteLine(equalStrings);
            }
        }
    }
}
