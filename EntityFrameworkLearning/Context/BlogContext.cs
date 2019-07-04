using EntityFrameworkLearning.classes;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLearning.Context
{
    public class BlogContext : DbContext
    {
        //public BlogContext(DbContextOptions options): base(options) { }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EmployeeDb;User ID=sa;Password=abc12345;MultipleActiveResultSets=True;Pooling=False");
        }
    }
}