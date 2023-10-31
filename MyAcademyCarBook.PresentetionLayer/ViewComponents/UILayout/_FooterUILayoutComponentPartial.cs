using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentetionLayer.ViewComponents.UILayout
{
    public class _FooterUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
