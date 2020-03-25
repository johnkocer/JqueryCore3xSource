using System.Collections.Generic;

namespace BlogUi.Models
{
  public class Blog
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public ICollection<Post> Posts { get; set; } = new List<Post>();
  }
}
