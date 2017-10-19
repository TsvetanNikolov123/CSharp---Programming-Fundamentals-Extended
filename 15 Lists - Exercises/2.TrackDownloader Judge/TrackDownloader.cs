namespace _2.TrackDownloader_Judge
{
    using System;
    using System.Collections.Generic;

    public class TrackDownloader
    {
        public static void Main()
        {
            string[] bannedSongs = Console.ReadLine().Split(' ');

            string song = Console.ReadLine();

            List<string> playlist = new List<string>();

            while (song != "end")
            {
                bool isContained = false;
                for (int i = 0; i < bannedSongs.Length; i++)
                {
                    if (song.Contains(bannedSongs[i]))
                    {
                        isContained = true;
                    }
                }

                if (!isContained)       // ==> това е запис равена на isContained = flase;
                {
                    playlist.Add(song);
                }
                song = Console.ReadLine();
            }
            playlist.Sort();            // ==> сортиране на масив или лист

            Console.WriteLine(string.Join("\r\n",playlist));
        }
    }
}
