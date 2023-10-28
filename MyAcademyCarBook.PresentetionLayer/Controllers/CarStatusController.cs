using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentetionLayer.Controllers
{
    public class CarStatusController : Controller
    {
        private readonly ICarStatusService _carStatusService;

        public CarStatusController(ICarStatusService carStatusService)
        {
            _carStatusService = carStatusService;
        }

        public IActionResult Index()
        {
            var values = _carStatusService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCarStatus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCarStatus(CarStatus carStatus)
        {
            _carStatusService.TAdd(carStatus);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCarStatus(int id)
        {
            _carStatusService.TRemove(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCarStatus(int id)
        {
            var value = _carStatusService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCarStatus(CarStatus carStatus)
        {
            _carStatusService.TUpdate(carStatus);
            return RedirectToAction("Index");
        }
    }
}
