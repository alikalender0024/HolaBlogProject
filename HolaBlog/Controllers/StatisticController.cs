using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
	public class StatisticController : Controller
	{
		private readonly HolaBlogContext _holaBlogContext;

		public StatisticController(HolaBlogContext holaBlogContext)
		{
			_holaBlogContext = holaBlogContext;
		}
		public IActionResult Index()
		{
			ViewBag.testimonialCount = _holaBlogContext.Testimonials.ToList().Count;
			ViewBag.skilllCount = _holaBlogContext.Skills.ToList().Count;
			ViewBag.blogCount = _holaBlogContext.Blogs.ToList().Count;
			ViewBag.isReadMessageCount = _holaBlogContext.Messages.ToList().Where(x => x.IsRead==false).Count();
			return View();
		}
	}
}
