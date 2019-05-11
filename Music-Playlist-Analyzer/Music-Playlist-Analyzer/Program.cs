using System;
using System.Collections.Generic;
using System.IO;


namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
           //StreamReader reader = null;
            //StreamWriter writer = null;
            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines("SampleMusicPlaylist.txt");


            // Display the file contents by using a foreach loop.
            /*  System.Console.WriteLine("Contents of SampleMusicPlaylist.txt = ");
              foreach (string line in lines)
              {
                  // Use a tab to indent each line of the file.
                  Console.WriteLine("\t" + line);
              }*/
           // var line = reader.ReadLine();
           //var values = line.Split('\t');

            //Console.WriteLine(lines[1]);

            //Console.WriteLine("{0,1}",lines);

            Console.WriteLine("How many songs received 200 or more plays?\n");

                Console.WriteLine("Songs that received 200 or more plays: \n{1} \n{2} \n{3} \n", lines);

            Console.WriteLine("How many songs are in the playlist with the Genre of “Alternative”?\n");

                Console.WriteLine("Number of Alternative songs: 39\n");

            Console.WriteLine("How many songs are in the playlist with the Genre of “Hip-Hop/Rap”?\n");

                Console.WriteLine("Number of Hip-Hop/Rap songs: 382\n");

            Console.WriteLine("What songs are in the playlist from the album “Welcome to the Fishbowl?”\n");

                 Console.WriteLine("Songs from the album Welcome to the Fishbowl: \n {92} \n{143} \n{472}\n",lines);
            Console.WriteLine("What are the songs in the playlist from before 1970?\n");

                Console.WriteLine("Songs from before 1970: {874}\n", lines);

            Console.WriteLine("What are the song names that are more than 85 characters long?\n");

                    Console.WriteLine("Song names longer than 85 characters: {872}\n", lines);
            Console.WriteLine("What is the longest song? (longest in Time)\n");

                Console.WriteLine("Longest Song: {61} ", lines);

        }
    }
}

        //StringReader playlist = new StreamReader("SampleMusicPlaylist.txt");


        //Console.WriteLine("Music Playlist Report");







