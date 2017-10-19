namespace _2.Dict_Ref
{
    using System;
    using System.Collections.Generic;

    public class DictRef
    {
        public static void Main()
        {
            var resultDict = new Dictionary<string, int>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split();

                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var referencedValue = resultDict[lastElement];
                        resultDict[firstElement] = referencedValue;
                    }
                }

                line = Console.ReadLine();
            }
            foreach (var itemPricePair in resultDict)
            {
                var item = itemPricePair.Key;
                var price = itemPricePair.Value;

                Console.WriteLine($"{item} === {price}");
            }
        }
    }
}
