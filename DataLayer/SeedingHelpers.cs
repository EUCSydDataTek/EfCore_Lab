using System.Globalization;
namespace DataLayer;
using DataLayer.Entities;
using Bogus;

public static class SeedingHelpers
{

    public static void CreateRandomSeeding(this DbContextOptions<BlogDbContext> options,int amount)
    {
        var users = options.CreateRandomUsers(amount);

        var blogs = options.CreateRandomBlogs(users);

        var posts = options.CreateRandomPosts(amount * 2,blogs,users);
    }

    public static List<User> CreateRandomUsers(this DbContextOptions<BlogDbContext> options,int amount)
    {
        using var context = new BlogDbContext(options);
        int userIds = 1;

        Faker<User> faker = new Faker<User>("de")
            .RuleFor(u => u.UserId,f => userIds++)
            .RuleFor(u => u.UserName,f => f.Person.UserName)
            .RuleFor(u => u.Email,f => f.Person.Email);

        var users = faker.Generate(amount);
        context.Users.AddRange(users);
        context.DisableIncrement("Users");
        context.SaveChanges();
        context.EnableIncrement("Users");

        return users;
    }

    public static List<Blog> CreateRandomBlogs(this DbContextOptions<BlogDbContext> options,List<User> Owners)
    {
        using var context = new BlogDbContext(options);

        int BlogIds = 1;
        IEnumerator<User> UserEnumerator = Owners.GetEnumerator();

        Faker<Blog> faker = new Faker<Blog>("de")
            .RuleFor(b => b.BlogId, f => BlogIds++)
            .RuleFor(b => b.UserId,f => {
                UserEnumerator.MoveNext();
                var UserId = UserEnumerator.Current.UserId;
                return UserId;
            })
            .RuleFor(b => b.BlogName, f => f.Lorem.Lines(1));

            var blogs = faker.Generate(Owners.Count);
            context.AddRange(blogs);

            context.DisableIncrement("Blogs");
            context.SaveChanges();
            context.EnableIncrement("Blogs");

            return blogs;
    }

    public static List<Post> CreateRandomPosts(this DbContextOptions<BlogDbContext> options,int amount,List<Blog> blogs,List<User> users)
    {
        using var context = new BlogDbContext(options);
        int PostIds = 1;

        Faker<Post> faker = new Faker<Post>("de")
                .RuleFor(p => p.PostId, f => PostIds++)
                .RuleFor(p => p.title, f => f.Rant.Review())
                .RuleFor(p => p.desctription,f => f.Lorem.Text())
                .RuleFor(p => p.UserId,f => f.Random.Int(1,users.Count))
                .RuleFor(p => p.BlogId,f => f.Random.Int(1,blogs.Count));

        var posts = faker.Generate(amount);

        context.AddRange(posts);

        context.DisableIncrement("Posts");
        context.SaveChanges();
        context.EnableIncrement("Posts");

        return posts;
    }

    public static BlogDbContext DisableIncrement(this BlogDbContext context,string TableName)
    {
        if (!context.Database.IsSqlite())
        {
            if (!context.Database.IsSqlite())
            {
                context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT dbo.{TableName} ON"); 
            }
        }

        return context;
    }

    public static BlogDbContext EnableIncrement(this BlogDbContext context,string TableName)
    {
        if (!context.Database.IsSqlite())
        {
            context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT dbo.{TableName} OFF"); 
        }

        return context;
    }

}
