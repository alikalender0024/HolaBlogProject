using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class BlogComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public BlogComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = _holaBlogContext.Blogs.ToList();
            return View(result);
        }
    }
}
