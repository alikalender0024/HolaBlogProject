using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents.LayoutViewComponent
{
    public class LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
