using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentetionLayer.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
