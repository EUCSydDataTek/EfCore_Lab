namespace DataLayer.Entities;

public class Post
{
    public int PostId { get; set; }

    public int UserId { get; set; }

    public int BlogId { get; set; }

    public string title { get; set; } = string.Empty;

    public string desctription { get; set; } = string.Empty;

    public User User { get; set; } = default!;

    public Blog Blog { get; set; } = default!;
}
