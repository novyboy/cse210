using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "John", 300);
        Video video2 = new Video("Video 2", "George", 300);
        Video video3 = new Video("Video 3", "Hank", 300);
        Video video4 = new Video("Video 4", "Daniel", 300);
        List<Video> videos = [video1, video2, video3, video4];
        foreach (Video video in videos) {
            Comment comment1 = new Comment("Nova", "Comment 1");
            Comment comment2 = new Comment("Josh", "Comment 2");
            Comment comment3 = new Comment("Daniel", "Comment 3");
            Comment comment4 = new Comment("Sam", "Comment 4");
            List<Comment> comments = [comment1, comment2, comment3, comment4];
            video.SetComments(comments);
            video.Display();
            Console.WriteLine($"{video.GetNumberOfComments()} Comments");
            video.DisplayComments();
        }
    }
}