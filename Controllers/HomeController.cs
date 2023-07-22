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
		if (currentPage == 0)
		{
			currentPage = 1;
		}

		HttpContext.Session.SetInt32("currentPage", currentPage);

		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Slides = db.Slides!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),			
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
		};
		return View(model);
	}


	[Route("/contact")]
	public IActionResult Contact()
	{
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
		};
		return View(model);
	}

	[Route("/about")]
	public IActionResult About()
	{
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
		};
		return View(model);
	}

	[Route("/blog/{currentPage?}")]
	public IActionResult Blog(int currentPage)
	{
		if (currentPage == 0)
		{
			currentPage = 1;
		}

		HttpContext.Session.SetInt32("currentPage", currentPage);

		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
		};
		return View(model);
	}

	[Route("/blog/{title?}/{id?}")]
	public IActionResult BlogDetail(String title, int id)
	{
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Blog = db.Blogs!.FirstOrDefault(x => x.Isview == true && x.Id == id),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Comments = db.Comments!.OrderByDescending(x => x.Id).Where(x => x.Isview == true && x.Type == "blog" && x.Typeid == id).ToList(),
		};

		return View(model);
	}

	[Route("/event/{currentPage?}")]
	public IActionResult Event(int currentPage)
	{
		if (currentPage == 0)
		{
			currentPage = 1;
		}

		HttpContext.Session.SetInt32("currentPage", currentPage);

		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
		};
		return View(model);
	}

	[Route("/event/{title?}/{id?}")]
	public IActionResult EventDetail(String title, int id)
	{
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Event = db.Events!.FirstOrDefault(x => x.Isview == true && x.Id == id),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Comments = db.Comments!.OrderByDescending(x => x.Id).Where(x => x.Isview == true && x.Type == "event" && x.Typeid == id).ToList(),
		};

		return View(model);
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	[Route("/comment")]
	public IActionResult Comment(Comment postedData)
	{
		postedData.Isview = false;
		postedData.Date = DateTime.Now;
		db.Comments.Add(postedData);
		db.SaveChanges();
		TempData["Success"] = "Yorumunuz Başarıyla Kaydedildi! İncelendikten Sonra Yayınlanacaktır!";
		return Redirect(TempData["Url"]!.ToString()!);
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	[Route("/subscribe")]
	public IActionResult Subscribe(Subscribe postedData)
	{
		if (db.Subscribes.FirstOrDefault(x => x.Email == postedData.Email) == null)
		{
			db.Subscribes.Add(postedData);
			db.SaveChanges();
			TempData["SuccessSubscribe"] = "E-bülten kaydınız başarıyla gerçekleştirilmiştir!";
		}
		else
		{
			TempData["DangerSubscribe"] = "Girmiş olduğunuz e-mail adresi sistemde kayıtlıdır!";
		}

		return Redirect(TempData["Url"]!.ToString()!);
	}


	[Route("/like/{type?}/{id?}")]
	public IActionResult Like(String type, int id)
	{
		String ip = Request.HttpContext.Connection.RemoteIpAddress!.ToString();
		if (db.Likes.Where(x=>x.Ip==ip && x.Typeid==id &&x.Type==type).Count()==0)
		{
			Like toAdd = new Like();
			toAdd.Type = type;
			toAdd.Typeid = id;
			toAdd.Ip = ip;
			db.Add(toAdd);
			db.SaveChanges();
		}
		else
		{
			Like toDelete = new Like();
			toDelete.Type = type;
			toDelete.Typeid = id;
			toDelete.Ip = ip;
			db.Remove(toDelete);
			db.SaveChanges();
		}
		
		return Redirect(TempData["Url"]!.ToString()!);
	}



	[Route("/workcat")]
	public IActionResult WorkCat()
	{
		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
		};
		return View(model);
	}

	[Route("/workcat/{catTitle}/{catId}/{currentPage?}")]
	public IActionResult Work(String catTitle, int catId, int currentPage)
	{
		if (currentPage == 0)
		{
			currentPage = 1;
		}

		HttpContext.Session.SetInt32("currentPage", currentPage);

		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),
			Works = db.Works!.OrderByDescending(x => x.Id).Where(x => x.Isview == true && x.Catid == catId).ToList(),
			AllWorks = db.Works!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Workcat = db.Workcats!.FirstOrDefault(x => x.Isview == true && x.Id == catId),
		};
		return View(model);
	}

	[Route("/work/{title?}/{id?}")]
	public IActionResult WorkDetail(String title, int id)
	{
		

		Work toUpdate = db.Works.Find(id)!;
		toUpdate.Read = toUpdate.Read + 1;
		db.Entry(toUpdate).CurrentValues.SetValues(toUpdate);
		db.SaveChanges();

		var model = new IndexViewModel()
		{
			Site = db.Sites!.First(),
			Work = db.Works!.FirstOrDefault(x => x.Isview == true && x.Id == id),
			Blogs = db.Blogs!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Events = db.Events!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Likes = db.Likes!.OrderByDescending(x => x.Id).ToList(),
			Workcats = db.Workcats!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			AllWorks = db.Works!.OrderByDescending(x => x.Id).Where(x => x.Isview == true).ToList(),
			Comments = db.Comments!.OrderByDescending(x => x.Id).Where(x => x.Isview == true && x.Type == "work" && x.Typeid == id).ToList(),
		};

		return View(model);
	}


	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
