using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class TestimonialComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public TestimonialComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = _holaBlogContext.Testimonials.ToList();
            return View(result);
        }
    }
}
