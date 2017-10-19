namespace _5.NoteStatistics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class NoteStatistics
    {
        public static void Main()
        {
            List<string> initialNotes = new List<string>(new string[]
            {
                "C",
                "C#",
                "D",
                "D#",
                "E",
                "F",
                "F#",
                "G",
                "G#",
                "A",
                "A#",
                "B"
            });

            List<double> initialFrequencies = new List<double>(new double[]
            {
                261.63,
                277.18,
                293.66,
                311.13,
                329.63,
                349.23,
                369.99,
                392.00,
                415.30,
                440.00,
                466.16,
                493.88
            });

            List<double> frequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<string> totalNotes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();

            double naturalsSum = 0;
            double sharpsSum = 0;

            for (int i = 0; i < frequencies.Count; i++)
            {
                double currentFrequency = frequencies[i];
                int index = initialFrequencies.IndexOf(currentFrequency);

                string currentNote = initialNotes[index];

                if (IsNatural(currentNote))
                {
                    naturals.Add(currentNote);
                    naturalsSum += currentFrequency;
                }
                else
                {
                    sharps.Add(currentNote);
                    sharpsSum += currentFrequency;
                }

                totalNotes.Add(currentNote);
            } 

            Console.WriteLine("Notes: {0}", string.Join(" ", totalNotes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));
            Console.WriteLine("Naturals sum: {0}", naturalsSum);
            Console.WriteLine("Sharps sum: {0}", sharpsSum);
        }

        public static bool IsNatural(string note)
        {
            return (note.Length == 1);

        }
    }
}
