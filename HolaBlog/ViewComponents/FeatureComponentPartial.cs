

using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class FeatureComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public FeatureComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.socialMediaName = _holaBlogContext.SocialMedias.Select(x => x.Name).ToList();
            ViewBag.icon = _holaBlogContext.SocialMedias.Select(x => x.Icon).ToList();
            ViewBag.url = _holaBlogContext.SocialMedias.Select(x => x.Url).ToList();
            ViewBag.count = _holaBlogContext.SocialMedias.ToList().Count;

            var result = _holaBlogContext.Features.ToList();
            return View(result);
        }
    }
}
