namespace DataLayer.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }

        public int UserId { get; set; }
        
        public string BlogName { get; set; } = string.Empty;

        public IEnumerable<Post> Posts { get; set; } = default!;

        public User Owner { get; set; } = default!;
    }
}