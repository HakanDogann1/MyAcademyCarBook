using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentetionLayer.ViewComponents.UILayout
{
    public class _ScriptUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
