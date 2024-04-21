using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class ContactController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public ContactController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult ContactList()
        {
            var result = _holaBlogContext.Contacts.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _holaBlogContext.Contacts.Add(contact);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _holaBlogContext.Contacts.Find(id);
            _holaBlogContext.Contacts.Remove(value);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("ContactList");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = _holaBlogContext.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            _holaBlogContext.Contacts.Update(contact);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
