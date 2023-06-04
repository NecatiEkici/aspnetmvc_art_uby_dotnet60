using Art.Models.Entities;

namespace Art.Models;

public class IndexViewModel
{   
	public Site? Site { get; set; }
	public IEnumerable<Slide>? Slides { get; set; }
}
