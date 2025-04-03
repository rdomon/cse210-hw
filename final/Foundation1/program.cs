using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create vid list
        List<Video> videos = new List<Video>();

        // vid 1
        Video video1 = new Video("Spring Fashion Trends 2025", "Rena Domon", 600);
        video1.AddComment(new Comment("User1", "Love the ideas! I will get the dresses!"));
        video1.AddComment(new Comment("User2", "Those dresses are so trendy and cute! I love this year's trend color!"));
        videos.Add(video1);

        // vid 2
        Video video2 = new Video("Summer Vacation Destinations", "Rena Domon", 720);
        video2.AddComment(new Comment("user1", "Great recommendations!"));
        video2.AddComment(new Comment("user2", "The beach resort looks amazing!"));
        videos.Add(video2);

        // vid 3
        Video video3 = new Video("Easy Dinner Recipes", "Rena Domon", 1200);
        video3.AddComment(new Comment("user1", "I tried the pasta recipe and it was delicious!"));
        video3.AddComment(new Comment("user2", "Can't wait to try these recipes!"));
        videos.Add(video3);

        // display all vid info
        Console.WriteLine("YouTube Video Tracker");
        Console.WriteLine("====================");
        
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}