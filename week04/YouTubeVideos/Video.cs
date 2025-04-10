public class Video {
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // em segundos
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public int GetCommentCount() {
        return Comments.Count;
    }

    public void Display() {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        
        foreach (var comment in Comments) {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}
