using System;
using System.Collections.Generic;

namespace Songs
{
    internal class Program
    {
        public class Songs
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Songs> numSongs = new List<Songs>();

            for (int i = 0; i < n; i++)
            {
                string[] songs = Console.ReadLine().Split("_");

                Songs newSong = new Songs() { Type = songs[0], Name = songs[1], Time = songs[2] };
                numSongs.Add(newSong);
            }
            string lastCommand = Console.ReadLine();
            if(lastCommand == "all")
            {
                for (int i = 0; i < numSongs.Count; i++)
                {
                    Console.WriteLine(numSongs[i].Name);
                }
            }
            else
            {
                for (int i = 0; i < numSongs.Count ; i++)
                {
                    if (lastCommand == numSongs[i].Type)
                    {
                        Console.WriteLine(numSongs[i].Name);
                    }
                }
            }
        }
    }
}
