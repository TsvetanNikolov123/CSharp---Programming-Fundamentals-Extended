﻿namespace _06.Notifications
{
    using System;

    class Notification
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();

                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation,code);
                }
            }
        }
        
        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine("Successfully executed {0}.",operation);
            Console.WriteLine("==============================");
            Console.WriteLine("Message: {0}.",message);
        }

        static void ShowError(string operation, int code)
        {
            Console.WriteLine("Error: Failed to execute {0}.",operation);
            Console.WriteLine("==============================");
            Console.WriteLine("Error Code: {0}.",code);

            if (code > 0)
            {
                Console.WriteLine("Reason: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine("Reason: Internal System Failure.");
            }
        } 
    }
}
