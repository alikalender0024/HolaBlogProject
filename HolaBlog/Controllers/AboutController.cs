using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class AboutController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public AboutController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult AboutList()
        {
            var result = _holaBlogContext.Abouts.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            _holaBlogContext.Abouts.Add(about);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _holaBlogContext.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _holaBlogContext.Abouts.Update(about);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public IActionResult DeleteAbout(int id)
        {
            var deleteAbout = GetAboutById(id);
            _holaBlogContext.Abouts.Remove(deleteAbout);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public About GetAboutById(int aboutId)
        {
            var aboutEntity = _holaBlogContext.Abouts.Find(aboutId);
            if (aboutEntity!=null)
            {
                return aboutEntity;
            }
            else
            {
                throw new Exception("Nesne Bulunumadı!");
            }
        }

    }
}
