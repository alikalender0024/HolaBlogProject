using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents.LayoutViewComponent
{
    public class LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
