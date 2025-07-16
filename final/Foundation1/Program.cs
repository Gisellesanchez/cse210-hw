using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Adding videos
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Video Comment System!");
        Video video1 = new Video("Inception", "Christopher Nolan", 148);
        Console.WriteLine("");
        video1.AddComment(new Comment("Alice", "Amazing movie!"));
        video1.AddComment(new Comment("Bob", "Mind-blowing concepts!"));
        video1.AddComment(new Comment("John", "Great movie!"));
        video1.AddComment(new Comment("Jane", "Loved the visuals!"));
        videos.Add(video1);
      
        Console.WriteLine("");
        Video video2 = new Video("The Matrix", "Lana Wachowski, Lilly Wachowski", 136);
        Console.WriteLine("");
        video2.AddComment(new Comment("Josie", "A classic!"));
        video2.AddComment(new Comment("Dylan", "Revolutionary for its time!"));
        videos.Add(video2);

        Console.WriteLine("");
        Video video3 = new Video("Nacho Libre", "Jack Black", 200);
        Console.WriteLine("");
        video3.AddComment(new Comment("Nathan", "Amazing Plot!"));
        video3.AddComment(new Comment("Jose", "Great casting choices!"));
        videos.Add(video3);


        foreach (Video video in videos)

        {
            video.DisplayVideoInfo();
            
        }
    }
}