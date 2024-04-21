using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public SocialMediaController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult SocialMediaList()
        {
            var result = _holaBlogContext.SocialMedias.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            _holaBlogContext.SocialMedias.Add(socialMedia);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _holaBlogContext.SocialMedias.Find(id);
            _holaBlogContext.SocialMedias.Remove(value);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = _holaBlogContext.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            _holaBlogContext.SocialMedias.Update(socialMedia);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}
