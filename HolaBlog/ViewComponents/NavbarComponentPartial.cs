using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
