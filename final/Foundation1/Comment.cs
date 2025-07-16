using System;
using System.Collections.Generic;

namespace Foundation1
{
    public class Comment
    {
        public string CommenterName { get; set; }
        public string Text { get; set; }

        public Comment(string commenterName, string text)
        {
            CommenterName = commenterName;
            Text = text;
        }
    }

    public class CommentList
    {
        private List<Comment> comments;

        public CommentList()
        {
            comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void DisplayComments()
        {
            foreach (var comment in comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Text}");
            }
        }
    }
    }