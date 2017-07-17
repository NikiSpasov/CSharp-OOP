using System;
using System.Collections.Generic;
using System.Globalization;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();
        TimeSpan playList = new TimeSpan();


        for (int i = 0; i < n; i++)
        {
            
            try
            {
                string[] input = Console.ReadLine()
                    .Trim()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                int minutes = 0;
                int seconds = 0;

                string[] minutesSeconds = input[2].Split(':');

                if (input.Length != 3 )
                {
                Console.WriteLine("Invalid song.");
                    break;
                }

                minutes = int.Parse(minutesSeconds[0]);
                seconds = int.Parse(minutesSeconds[1]);
                Artist currentArtist = new Artist(input[0]);


                Song currentSong = new Song(
                    currentArtist,
                    input[1]);
                currentSong.Length = currentSong.GetMinutesAndSeconds(minutes, seconds);

                TimeSpan songTime = new TimeSpan(0, minutes, seconds);

                playList += songTime;
                songs.Add(currentSong);
                Console.WriteLine("Song added.");

            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
            }
            
        }
        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {playList.Hours}h {playList.Minutes}m {playList.Seconds}s");
    }
}
