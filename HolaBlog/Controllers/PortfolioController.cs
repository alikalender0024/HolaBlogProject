using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public PortfolioController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult PortfolioList()
        {
            var result = _holaBlogContext.Portfolios.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            _holaBlogContext.Portfolios.Add(portfolio);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = _holaBlogContext.Portfolios.Find(id);
            _holaBlogContext.Portfolios.Remove(value);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = _holaBlogContext.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _holaBlogContext.Portfolios.Update(portfolio);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}

