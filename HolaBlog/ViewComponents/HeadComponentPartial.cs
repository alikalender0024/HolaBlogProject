using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
