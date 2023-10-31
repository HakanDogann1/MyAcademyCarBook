using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentetionLayer.ViewComponents.UILayout
{
    public class _HeadUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           return View();   
        }
    }
}
