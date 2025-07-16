using System;
using System.Collections.Generic;

namespace Foundation1
{
    public class Video
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Duration { get; set; }

        private List<Comment> comments = new List<Comment>();


        public Video(string title, string director, int duration)
        {
            Title = title;
            Director = director;
            Duration = duration;
        }
        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return comments.Count;
        }
        public void DisplayVideoInfo()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Director}");
            Console.WriteLine($"Length: {Duration} seconds");
            Console.WriteLine($"Number of Comments: {GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (var comment in comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
                
            }
            Console.WriteLine();
            
        }
    }
}