using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentetionLayer.Controllers
{
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			TempData["PageName"] = "Hizmetler";
			TempData["Description"] = "Sizlere sunduğumuz hizmetler...";

            return View();
		}
	}
}
