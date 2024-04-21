using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public BlogController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult BlogList()
        {
            var result = _holaBlogContext.Blogs.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBlog(Blog blog)
        {
            _holaBlogContext.Blogs.Add(blog);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("BlogList");
        }

        public IActionResult DeleteBlog(int id)
        {
            var value = _holaBlogContext.Blogs.Find(id);
            _holaBlogContext.Blogs.Remove(value);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("BlogList");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var value = _holaBlogContext.Blogs.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            _holaBlogContext.Blogs.Update(blog);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("BlogList");
        }
    }
}
