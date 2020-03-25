using BlogUi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogUi.Ef
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Blog> Blog { get; set; }
    public DbSet<Post> Post { get; set; }
  }
}

