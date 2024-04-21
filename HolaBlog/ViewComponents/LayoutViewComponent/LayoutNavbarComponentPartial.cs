using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents.LayoutViewComponent
{
    public class LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
