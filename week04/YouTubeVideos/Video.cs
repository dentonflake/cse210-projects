
class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments;

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetTotalComments() => _comments.Count;

    public void AddComment(Comment comment) => _comments.Add(comment);

    public override string ToString()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length}";
    }

    public void Display()
    {
        Console.WriteLine($"\n{this}");
        Console.WriteLine("\nComments:\n");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment);
        }
    }
}