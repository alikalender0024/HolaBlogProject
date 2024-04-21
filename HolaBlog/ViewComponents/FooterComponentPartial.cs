using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
