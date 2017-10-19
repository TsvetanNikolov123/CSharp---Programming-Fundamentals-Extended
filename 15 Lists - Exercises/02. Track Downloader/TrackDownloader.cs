namespace _02.Track_Downloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrackDownloader
    {
        public static void Main()
        {
            List<string> blacklist = Console.ReadLine().Split(' ').ToList();

            List<string> resultList = new List<string>();

            string fileNames = Console.ReadLine();

            while (fileNames != "end")
            {
                resultList.Add(fileNames);
                for (int i = 0; i < blacklist.Count; i++)
                {
                    if (fileNames.Contains(blacklist[i]))
                    {
                        resultList.Remove(fileNames);
                    }
                }

                fileNames = Console.ReadLine();
            }

            resultList.Sort();

            foreach (var song in resultList)
            {
                Console.WriteLine(song);
            }
        }
    }
}
