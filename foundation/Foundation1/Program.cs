using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C#", "CodeAcademy", 600);
        Video video2 = new Video("Understanding OOP", "TechExplained", 900);
        Video video3 = new Video("Intro to Algorithms", "DataScienceHub", 1200);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Nick", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Please make more videos on this topic."));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "I finally understand OOP, thanks!"));
        video2.AddComment(new Comment("Isaac", "Could you cover more examples?"));
        video2.AddComment(new Comment("Frank", "Well structured video."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "This was very detailed, thank you."));
        video3.AddComment(new Comment("Heidi", "Loved the way you explained the algorithms."));
        video3.AddComment(new Comment("Ivan", "Looking forward to the next video!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
