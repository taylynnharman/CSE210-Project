//write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.
//Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.
using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video
        {
            Title = "Finding Nemo Merch Haul",
            Author = "Johnny Appleseed",
            Duration = 32
        };
        video1.Comments.Add(new Comment { Name = "Kay Smith", Text = "Totally going to buy the nemo plushie for my niece!" });
        video1.Comments.Add(new Comment {Name = "Arnold Howard", Text = "A little pricey, but could be cool."});
        video1.Comments.Add(new Comment {Name = "Katie Lou", Text = "So cute."});

        Video video2 = new Video
        {
            Title = "Tommy gets new toys",
            Author = "TommyToys",
            Duration = 45
        };
        video2.Comments.Add(new Comment { Name = "Helena V.", Text = "Totally Rad Tommy!" });
        video2.Comments.Add(new Comment {Name = "Stan Harold", Text = "Where can I get one?"});
        video2.Comments.Add(new Comment {Name = "Reba Lois", Text = "I just want a giant plushie!"});

        Video video3 = new Video
        {
            Title = "My Dog Playing with his stuffed lightning mcqueen",
            Author = "Kim Harmon",
            Duration = 10
        };
        video3.Comments.Add(new Comment { Name = "Brittan Jones", Text = "Cute stuffy, and even cuter dog :)" });
        video3.Comments.Add(new Comment {Name = "Lexi Macentire", Text = "My dog loves their stuffed animal from Stuffies!"});
        video3.Comments.Add(new Comment {Name = "Lightning McQueen", Text = "Ouch..."});

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach(Video video in videos){
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length in Minutes: {video.Duration}, Number of Comments: {video.NumComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
    
}