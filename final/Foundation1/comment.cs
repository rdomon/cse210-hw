using System;

public class Comment
{
    private string commenterName;
    private string commentText;

    // constructor
    public Comment(string commenterName, string commentText)
    {
        this.commenterName = commenterName;
        this.commentText = commentText;
    }

    // display comments
    public void DisplayComment()
    {
        Console.WriteLine($"- {commenterName}: {commentText}");
    }
}
