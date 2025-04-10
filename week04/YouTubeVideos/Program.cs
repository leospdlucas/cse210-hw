class Program {
    static void Main(string[] args) {
        List<Video> videos = new List<Video>();

        var video1 = new Video { Title = "Desert Adventure", Author = "Leo Lucas", Length = 300 };
        video1.Comments.Add(new Comment("Alice", "Amazing visuals!"));
        video1.Comments.Add(new Comment("Bob", "Where was this filmed?"));
        video1.Comments.Add(new Comment("Charlie", "Looks like fun!"));
        videos.Add(video1);

        var video2 = new Video { Title = "C# Tutorial", Author = "DevTeacher", Length = 600 };
        video2.Comments.Add(new Comment("Dave", "Super helpful!"));
        video2.Comments.Add(new Comment("Eva", "Thanks for the explanations."));
        video2.Comments.Add(new Comment("Frank", "Can you do one on LINQ?"));
        videos.Add(video2);

        var video3 = new Video { Title = "Cooking Lasagna", Author = "ChefAnna", Length = 420 };
        video3.Comments.Add(new Comment("George", "This made me hungry!"));
        video3.Comments.Add(new Comment("Hannah", "Trying this tonight."));
        video3.Comments.Add(new Comment("Irene", "Delicious recipe!"));
        videos.Add(video3);

        foreach (var video in videos) {
            video.Display();
        }
    }
}