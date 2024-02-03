// Created by Osman Said on 2024-02-02

namespace ConsoleApps;

public class Album
{
    // Fields for the album's name, artist name, and number of tracks.
    private string albumName;
    private string artistName;
    private int numOfTracks;

    // Reads the name of the album from user input.
    private void ReadAlbumName()
    {
        Console.Write("What is the name of your favorite music album? ");
        albumName = Console.ReadLine();
    }

    // Reads the name of the artist or band from user input.
    private void ReadArtistName()
    {
        Console.Write("What is the name of the Artist or Band for {0}? ", albumName);
        artistName = Console.ReadLine();
    }

    // Reads the number of tracks on the album from user input.
    private void ReadTracks()
    {
        Console.Write("How many tracks does {0} have? ", albumName);
        numOfTracks = int.Parse(Console.ReadLine());
    }

    // Displays information about the album to the console.
    private void DisplayAlbumInfo()
    {
        Console.WriteLine("+++++++++++++++++++++++++++++");
        Console.WriteLine("Album Name: {0}", albumName);
        Console.WriteLine("Artist/Band: {0}", artistName);
        Console.WriteLine("Number of Tracks: {0}", numOfTracks);
        Console.WriteLine("Enjoy listening!");
        Console.WriteLine("+++++++++++++++++++++++++++++");
    }

    // Initiates the process of reading and displaying album information.
    public void Start()
    {
        Console.WriteLine("Starting the Album Program!");
        Console.WriteLine();

        ReadAlbumName();
        ReadArtistName();
        ReadTracks();
        DisplayAlbumInfo();
    }
}