using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learn C#", "code school", 600);
        Video video2 = new Video("Understanding OOP", "technology explained", 900);
        Video video3 = new Video("Intro to Algorithms", "DataScienceHub", 1200);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Nick", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Please make more videos on this topic."));

        video2.AddComment(new Comment("Dave", "I finally understand OOP, thanks!"));
        video2.AddComment(new Comment("Isaac", "Could you cover more examples?"));
        video2.AddComment(new Comment("Frank", "Well structured video."));

        video3.AddComment(new Comment("Grace", "This was very detailed, thank you."));
        video3.AddComment(new Comment("Heidi", "Loved the way you explained the algorithms."));
        video3.AddComment(new Comment("Ivan", "Looking forward to the next video!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

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
