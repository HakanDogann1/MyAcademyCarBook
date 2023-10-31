using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentetionLayer.ViewComponents.UILayout
{
    public class _CoverUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
