using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
