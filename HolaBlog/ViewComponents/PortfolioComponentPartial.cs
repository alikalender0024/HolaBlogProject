using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class PortfolioComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public PortfolioComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = _holaBlogContext.Portfolios.ToList();
            return View(result);
        }
    }
}
