namespace DataLayer.Entities
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public IEnumerable<Blog> OwnerOf { get; set; } = default!;
    }
}