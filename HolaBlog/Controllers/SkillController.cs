using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class SkillController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public SkillController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult SkillList()
        {
            var result = _holaBlogContext.Skills.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            _holaBlogContext.Skills.Add(skill);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = _holaBlogContext.Skills.Find(id);
            _holaBlogContext.Skills.Remove(value);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = _holaBlogContext.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            _holaBlogContext.Skills.Update(skill);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
