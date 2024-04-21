using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class MessageController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public MessageController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext = holaBlogContext;
        }
        public IActionResult Inbox()
        {
            var result = _holaBlogContext.Messages.ToList();
            return View(result);
        }
        public IActionResult ChangeIsReadToTrue(int id)
        {
            var result = _holaBlogContext.Messages.Find(id);
            result.IsRead=true;
            _holaBlogContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult ChangeIsReadToFalse(int id)
        {
            var result = _holaBlogContext.Messages.Find(id);
            result.IsRead=false;
            _holaBlogContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult DeleteMessage(int id)
        {
            var result = _holaBlogContext.Messages.Find(id);
            _holaBlogContext.Remove(result);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult MessageDetail(int id)
        {
            var result = _holaBlogContext.Messages.Find(id);
            return View(result);
        }
    }
}
