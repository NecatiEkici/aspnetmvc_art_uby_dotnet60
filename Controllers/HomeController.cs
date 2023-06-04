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

	public IActionResult Index()
	{
		var model = new IndexViewModel()
		{
			Site=db.Sites!.First(),
			Slides=db.Slides.OrderBy(x=>x.Order).Where(x=>x.Isview==true).ToList(),
		};
		
		return View(model);
	}

	[Route("/contact")]
	public IActionResult Contact()
	{
		var model = new IndexViewModel()
		{
			Site=db.Sites!.First()
		};
		return View(model);
	}

	[Route("/about")]
	public IActionResult About()
	{
		var model = new IndexViewModel()
		{
			Site=db.Sites!.First()
		};
		return View(model);
	}

	[Route("/blog")]
	public IActionResult Blog()
	{
		var model = new IndexViewModel()
		{
			Site=db.Sites!.First()
		};
		return View(model);
	}

	[Route("/event")]
	public IActionResult Event()
	{
		var model = new IndexViewModel()
		{
			Site=db.Sites!.First()
		};
		return View(model);
	}

	 [Route("/work")]
	public IActionResult Work()
	{
		var model = new IndexViewModel()
		{
			Site=db.Sites!.First()
		};
		return View(model);
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
