using System;
using System.Collections.Generic;

class Program
{
    static Random rand = new Random();

    static string[] videoTitles = { "The Enigma of Cosmos", "Journey Through Time", "Infinite Dreams", "Secrets of the Universe" };
    static string[] authorNames = { "StellarExplorer", "QuantumPioneer", "AstroVisionary", "SpaceSeeker" };
    static string[] userNames = { "CrazyCatLady", "GuitarGuru", "TechieWizard", "ArtisticSoul", "FoodieExplorer" };
    static string[] comments = { "This blew my mind!", "Absolutely fantastic!", "Can't stop watching!", "Brilliant work!", "Incredible content!" };

    static string GetRandomTitle()
    {
        return videoTitles[rand.Next(videoTitles.Length)];
    }

    static string GetRandomAuthor()
    {
        return authorNames[rand.Next(authorNames.Length)];
    }

    static string GetRandomUsername()
    {
        return userNames[rand.Next(userNames.Length)];
    }

    static string GetRandomComment()
    {
        return comments[rand.Next(comments.Length)];
    }

    static void Main(string[] args)
    {
        // Create 3-4 videos with random titles, authors, and comments
        List<Video> videos = new List<Video>();
        for (int i = 0; i < 3; i++)
        {
            Video video = new Video(GetRandomTitle(), GetRandomAuthor(), rand.Next(180, 600));
            for (int j = 0; j < rand.Next(2, 5); j++)
            {
                video.AddComment(GetRandomUsername(), GetRandomComment());
            }
            videos.Add(video);
        }

        // Display information for each video
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
