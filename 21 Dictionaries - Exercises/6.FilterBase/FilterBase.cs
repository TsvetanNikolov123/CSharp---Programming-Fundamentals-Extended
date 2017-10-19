namespace _6.FilterBase
{
    using System;
    using System.Collections.Generic;

    public class FilterBase
    {
        public static void Main()
        {
            Dictionary<string, int> employeeAges = new Dictionary<string, int>();
            Dictionary<string, double> employeesSalaries = new Dictionary<string, double>();
            Dictionary<string, string> emplPositions = new Dictionary<string, string>();

            string[] tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            while (tokens[0] != "filter")
            {
                string name = tokens[0];
                string value = tokens[1];

                int age;
                double salary;
                if (int.TryParse(value, out age))
                {
                    employeeAges[name] = age;
                }
                else if (double.TryParse(value, out salary))
                {
                    employeesSalaries[name] = salary;
                }
                else
                {
                    emplPositions[name] = value;
                }

                tokens = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            string condition = Console.ReadLine().ToLower();
            if (condition == "position")
            {
                foreach (KeyValuePair<string, string> employee in emplPositions)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Position: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (condition == "age")
            {
                foreach (KeyValuePair<string, int> employee in employeeAges)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Age: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (KeyValuePair<string, double> employee in employeesSalaries)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Salary: {employee.Value:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }

        }
    }
}
