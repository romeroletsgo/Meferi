using DataLayer.Entities;
using DataLayer.EntitiesCode;
using Meferi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Meferi.Controllers
{
	public class HomeController : Controller
	{
		private readonly EfCoreContext _context;

		public HomeController(EfCoreContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
		
		public IActionResult Cart()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Categories()
		{
			var categories = _context.Categories.Select(c => c).ToList();
			return View(categories);
		}

		public IActionResult Category(int id)
		{
			var category = _context.Categories.FirstOrDefault(category => category.CategoryId == id);
			category.Products = category.Products ?? new List<Product>();
			return View(category);
		}

		public IActionResult Checkout()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		public IActionResult Product()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}