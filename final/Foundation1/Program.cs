using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("Fly Fishing for Trout in Idaho", "John Angler", 600);
        video1.AddComment(new Comment("Alice Fisher", "Great tips on fly fishing!"));
        video1.AddComment(new Comment("Bob Troutman", "I love fishing in Idaho, thanks for the advice!"));
        video1.AddComment(new Comment("Charlie Rivers", "Very informative, can't wait to try these techniques."));

        Video video2 = new Video("Best Trout Fishing Spots in Idaho", "Jane Fisherwoman", 1200);
        video2.AddComment(new Comment("Dave Stream", "I had great success at these spots!"));
        video2.AddComment(new Comment("Eve Waterman", "Can you recommend more places to fish in the Boise area?"));
        video2.AddComment(new Comment("Frank Lake", "Excellent guide for beginners."));

        Video video3 = new Video("Trout Fishing Gear and Tackle for Idaho", "Michael Fisher", 800);
        video3.AddComment(new Comment("Grace Hook", "Very helpful gear recommendations."));
        video3.AddComment(new Comment("Heidi Line", "This was very informative."));
        video3.AddComment(new Comment("Ivan Reel", "Looking forward to more gear reviews."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display videos and their comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.Author}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
