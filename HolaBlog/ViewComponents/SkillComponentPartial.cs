using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class SkillComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public SkillComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = _holaBlogContext.Skills.ToList();
            return View(result);
        }
    }
}
