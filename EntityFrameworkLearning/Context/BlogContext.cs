using EntityFrameworkLearning.classes;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLearning.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options): base(options) { }
        public DbSet<Blog> Blogs { get; set; }
    }
}