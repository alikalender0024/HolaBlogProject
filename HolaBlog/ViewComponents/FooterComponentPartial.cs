using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class FooterComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public FooterComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IViewComponentResult Invoke()
        {
            var result = _holaBlogContext.SocialMedias.ToList();
            return View(result);
        }
    }
}
