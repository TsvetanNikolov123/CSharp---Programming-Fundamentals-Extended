namespace _5.LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, string>>();

            string input = Console.ReadLine();

            while (input != "lambada")
            {
                string[] inputTokens = input
                    .Split(new string[] { " => ", "." },
                            StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "dance")
                {
                    data = data.ToDictionary(selectorData => selectorData.Key,
                                             selectorData => selectorData.Value
                                                .ToDictionary(selectorObjectData => selectorObjectData.Key,
                                                              selectorObjectData => selectorObjectData.Key + "." + selectorObjectData.Value));
                }
                else
                {
                    string selector = inputTokens[0];
                    string selectorObject = inputTokens[1];
                    string selectorProperty = inputTokens[2];

                    if (!data.ContainsKey(selector))
                    {
                        data.Add(selector, new Dictionary<string, string>());
                    }

                    data[selector][selectorObject] = selectorProperty;
                }

                input = Console.ReadLine();
            }
            foreach (var selectorData in data)
            {
                string selector = selectorData.Key;
                Dictionary<string, string> selectorObjectsData = selectorData.Value;

                foreach (var selectorObjectData in selectorObjectsData)
                {
                    string selectorObject = selectorObjectData.Key;
                    string property = selectorObjectData.Value;

                    Console.WriteLine("{0} => {1}.{2}", selector, selectorObject, property);
                }
            }
        }
    }
}
