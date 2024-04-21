using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public ExperienceController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult ExperienceList()
        {
            var result = _holaBlogContext.Experiences.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            _holaBlogContext.Experiences.Add(experience);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = _holaBlogContext.Experiences.Find(id);
            _holaBlogContext.Experiences.Remove(value);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = _holaBlogContext.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            _holaBlogContext.Experiences.Update(experience);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
