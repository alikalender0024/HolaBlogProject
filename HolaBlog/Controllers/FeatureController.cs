using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class FeatureController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public FeatureController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult FeatureList()
        {
            var result = _holaBlogContext.Features.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeature(Feature feature)
        {
            _holaBlogContext.Features.Add(feature);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        public IActionResult DeleteFeature(int id)
        {
            var value = _holaBlogContext.Features.Find(id);
            _holaBlogContext.Features.Remove(value);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = _holaBlogContext.Features.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            _holaBlogContext.Features.Update(feature);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
