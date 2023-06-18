using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Art.Models;
using Art.Models.Entities;

namespace Art.Controllers;

public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	PmitLn2oqDb0001Context db = new PmitLn2oqDb0001Context();

	[Route("/{currentPage?}")]
	public IActionResult Index(int currentPage)
	{
		if (currentPage==0)
		{
			currentPage = 1;
		}
		
		HttpContext.Session.SetInt32("currentPage", currentPage);	

		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Slides = db.Slides!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
		};
		return View(model);
	}
	

	[Route("/contact")]
	public IActionResult Contact()
	{
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First()
		};
		return View(model);
	}

	[Route("/about")]
	public IActionResult About()
	{
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First()
		};
		return View(model);
	}

	[Route("/blog/{currentPage?}")]
	public IActionResult Blog(int currentPage)
	{
		if (currentPage==0)
		{
			currentPage = 1;
		}
		
		HttpContext.Session.SetInt32("currentPage", currentPage);	

		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),			
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
		};
		return View(model);
	}
	
	[Route("/blog/{title?}/{id?}")]
	public IActionResult BlogDetail(String title, int id)
	{		
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Blog = db.Blogs!.FirstOrDefault(x => x.Isview == true && x.Id==id),						
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
		};
		
		return View(model);
	}
	
	

	[Route("/event")]
	public IActionResult Event()
	{
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First()
		};
		return View(model);
	}

	[Route("/work")]
	public IActionResult Work()
	{
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First()
		};
		return View(model);
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
