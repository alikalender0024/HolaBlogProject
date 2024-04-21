using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents.LayoutViewComponent
{
    public class LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
