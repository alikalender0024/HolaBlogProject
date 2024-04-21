using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class AboutComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public AboutComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.description = _holaBlogContext.Abouts.Select(x => x.Description).FirstOrDefault();
            ViewBag.aboutDetails = _holaBlogContext.Abouts.Select(x => x.AboutDetails).FirstOrDefault();
            ViewBag.cvDownloadUrl = _holaBlogContext.Abouts.Select(x => x.CvDownloadUrl).FirstOrDefault();
            return View();
        }
    }
}
