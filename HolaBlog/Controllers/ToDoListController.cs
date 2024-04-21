using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public ToDoListController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult Index()
        {
            var values = _holaBlogContext.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            _holaBlogContext.ToDoLists.Add(toDoList);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = _holaBlogContext.ToDoLists.Find(id);
            _holaBlogContext.ToDoLists.Remove(value);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = _holaBlogContext.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            _holaBlogContext.ToDoLists.Update(toDoList);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var value = _holaBlogContext.ToDoLists.Find(id);
            value.Status = true;
            _holaBlogContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var value = _holaBlogContext.ToDoLists.Find(id);
            value.Status = false;
            _holaBlogContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}