﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentetionLayer.Controllers
{
    public class PriceController : Controller
    {
        private readonly IPriceService _priceService;
        private readonly ICarService _carService;

        public PriceController(IPriceService priceService, ICarService carService)
        {
            _priceService = priceService;
            _carService = carService;
        }

        public IActionResult Index()
        {
            var values = _priceService.TGetPricesWithCars();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePrice()
        {
            List<SelectListItem> values = (from x in _carService.TGetAllCarsWithBrands()
                                           select new SelectListItem
                                           {
                                               Text=x.Brand.BrandName + " " + x.Model,
                                               Value=x.CarId.ToString()
                                           }).ToList();

            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult CreatePrice(Price price)
        {

            _priceService.TAdd(price);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePrice(int id)
        {
            _priceService.TRemove(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePrice(int id)
        {
            List<SelectListItem> values = (from x in _carService.TGetAllCarsWithBrands()
                                           select new SelectListItem
                                           {
                                               Text = x.Brand.BrandName + " " + x.Model,
                                               Value = x.CarId.ToString()
                                           }).ToList();

            ViewBag.v = values;
            var value = _priceService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePrice(Price price)
        {
            List<SelectListItem> values = (from x in _carService.TGetAllCarsWithBrands()
                                           select new SelectListItem
                                           {
                                               Text = x.Brand.BrandName + " " + x.Model,
                                               Value = x.CarId.ToString()
                                           }).ToList();

            ViewBag.v = values;
            _priceService.TUpdate(price);
            return RedirectToAction("Index");
        }
    }
}
