using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentetionLayer.ViewComponents.UILayout
{
    public class _HeaderUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
