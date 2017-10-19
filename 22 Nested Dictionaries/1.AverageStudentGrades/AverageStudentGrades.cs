namespace _1.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageStudentGrades
    {
        public static void Main()
        {
            Dictionary<string, List<double>> studentGarde = new Dictionary<string, List<double>>();
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!studentGarde.ContainsKey(name))
                {
                    studentGarde.Add(name, new List<double>());
                }

                studentGarde[name].Add(grade);
            }

            foreach (var record in studentGarde)
            {
                string name = record.Key;
                List<double> grades = record.Value;
                double average = grades.Average();

                Console.Write("{0} -> ", name);
                foreach (var grade in grades)
                {
                    Console.Write("{0:f2} ", grade);
                }
                Console.WriteLine("(avg: {0:f2})", average);
            }
        }
    }
}
