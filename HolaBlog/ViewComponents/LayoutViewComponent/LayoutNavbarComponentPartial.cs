using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents.LayoutViewComponent
{
    public class LayoutNavbarComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public LayoutNavbarComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = _holaBlogContext.ToDoLists.Where(x => x.Status == false).Count();
            var values = _holaBlogContext.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
