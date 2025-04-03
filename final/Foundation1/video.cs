using System;
using System.Collections.Generic;

public class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    // constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        this.comments = new List<Comment>();
    }

    // add comment
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // return(get) the num of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // display vid info
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"title: {title}");
        Console.WriteLine($"author: {author}");
        Console.WriteLine($"length: {lengthInSeconds} seconds");
        Console.WriteLine($"comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach(var comment in comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}