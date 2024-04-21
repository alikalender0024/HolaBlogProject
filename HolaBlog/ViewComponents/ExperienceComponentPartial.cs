using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class ExperienceComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public ExperienceComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = _holaBlogContext.Experiences.ToList();
            return View(result);
        }
    }
}
