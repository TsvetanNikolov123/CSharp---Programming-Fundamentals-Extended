namespace _08.String_Encryption
{
    using System;

    class StringEncryption
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join("", Encrypt(n)));
        }

        static string[] Encrypt(int n)
        {
            string[] result = new string[n];

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                byte charToByte = (byte)(symbol);
                byte firstDigit = 0;
                byte lastDigit = 0;

                if (charToByte < 100)
                {
                    firstDigit = (byte)(charToByte / 10);
                    lastDigit = (byte)(charToByte % 10);
                }
                else
                {
                    firstDigit = (byte)(charToByte / 100);
                    lastDigit = (byte)(charToByte % 10);
                }

                string middlePart = firstDigit.ToString() + lastDigit.ToString();

                result[i] += (char)(charToByte + lastDigit) + middlePart + (char)(charToByte - firstDigit);
            }

            return result;
        }
    }
}
