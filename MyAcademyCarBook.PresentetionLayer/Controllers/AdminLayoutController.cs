using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentetionLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
