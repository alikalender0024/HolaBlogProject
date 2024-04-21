using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
