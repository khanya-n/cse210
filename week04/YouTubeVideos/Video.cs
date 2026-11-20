public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = [];

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    private void DisplayComments()
    {
        Console.WriteLine($"Comments: {GetNumberOfComments()}\n");
        
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}\t{_length}s");
        Console.WriteLine($"by {_author}\n");
        DisplayComments();
    }
}