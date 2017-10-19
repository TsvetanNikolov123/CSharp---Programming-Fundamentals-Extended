namespace _04.Phone
{
    using System;

    class Phone
    {
        static string[] numbers;
        static string[] names;

        static void Main()
        {
            numbers = Console.ReadLine().Split(' ');
            names = Console.ReadLine().Split(' ');

            string[] inputTokens = Console.ReadLine().Split(' ');

            while (inputTokens[0] != "done")
            {
                string command = inputTokens[0];
                string argument = inputTokens[1];
                string name;
                string telephoneNumber;
                string output;


                if (IsNumber(argument))
                {
                    name = GetEntry(argument);
                    telephoneNumber = argument;
                    output = name;
                }
                else
                {
                    name = argument;
                    telephoneNumber = GetEntry(argument);
                    output = telephoneNumber;
                }

                int digitSum = GetDigitSum(telephoneNumber);

                if (command == "call")
                {
                    Console.WriteLine("calling {0}...", output);
                    if (digitSum % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int minutes = digitSum / 60;
                        int seconds = digitSum % 60;
                        Console.WriteLine("call ended. duration: {0}:{1}",
                            minutes.ToString().PadLeft(2, '0'),
                            seconds.ToString().PadLeft(2, '0'));
                    }
                }
                else if (command == "message")
                {
                    Console.WriteLine("sending sms to {0}...", output);
                    if (digitSum % 2 == 1)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }

                inputTokens = Console.ReadLine().Split(' ');
            }
        }

        static int GetDigitSum(string telephoneNumber)
        {
            int sum = 0;
            for (int i = 0; i < telephoneNumber.Length; i++)
            {
                if (IsDigit(telephoneNumber[i]))
                {
                    sum += telephoneNumber[i] - '0';
                }
            }
            return sum;
        }

        static string GetEntry(string input)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (names[i] == input)
                {
                    return numbers[i];
                }
                else if (numbers[i] == input)
                {
                    return names[i];
                }
            }
            return string.Empty;
        }

        static bool IsNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (IsDigit(input[i]))
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsDigit(char symbol)
        {
            return (symbol >= '0' && symbol <= '9');
        }
    }
}
