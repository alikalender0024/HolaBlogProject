using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
