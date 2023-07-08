using Art.Models.Entities;

namespace Art.Models;

public class IndexViewModel
{   
	public Site? Site { get; set; }
	
	public IEnumerable<Slide>? Slides { get; set; }
	
	public Blog? Blog { get; set; }	
	public IEnumerable<Blog>? Blogs { get; set; }	
	public IEnumerable<Comment>? Comments { get; set; }
	
}
