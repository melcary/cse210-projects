using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial for beginners", "Programming Master", 1200);
        video1.AddComment(new Comment("Alisia123", "Great tutorial!"));
        video1.AddComment(new Comment("UserMilo", "Very Helpful, Thanks!"));
        video1.AddComment(new Comment("JuanCR", "Could you make one about OOP?"));
        videos.Add(video1);

        Video video2 = new Video("How to make Pancakes", "CookingWithAmy", 600);
        video2.AddComment(new Comment("LoverM", "I tried this and it was delicious!"));
        video2.AddComment(new Comment("Chef Jhon", "Nice recipe, but I would add cinnamon"));
        video2.AddComment(new Comment("BakingnBeg", "My first try was a success, thank you!"));

        videos.Add(video2);

        Video video3 = new Video("Morning Yoga Routine", "YogaWithSara", 1800);
        video3.AddComment(new Comment("15Mary", "Perfect way to start the day"));
        video3.AddComment(new Comment("Yogi", "Some poses were challenging but great <3"));
        video3.AddComment(new Comment("Lara", "This video was very helpful!"));

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}