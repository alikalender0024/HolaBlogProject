using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
