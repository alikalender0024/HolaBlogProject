using HolaBlog.DataAccess.Context;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.ViewComponents
{
    public class ContactComponentPartial : ViewComponent
    {
        private readonly HolaBlogContext _holaBlogContext;

        public ContactComponentPartial(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = _holaBlogContext.Contacts.ToList();
            return View(result);
        }
    }
}
