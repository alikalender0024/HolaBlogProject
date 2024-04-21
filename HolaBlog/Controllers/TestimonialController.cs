using HolaBlog.DataAccess.Context;
using HolaBlog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HolaBlog.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly HolaBlogContext _holaBlogContext;

        public TestimonialController(HolaBlogContext holaBlogContext)
        {
            _holaBlogContext= holaBlogContext;
        }
        public IActionResult TestimonialList()
        {
            var result = _holaBlogContext.Testimonials.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _holaBlogContext.Testimonials.Add(testimonial);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = _holaBlogContext.Testimonials.Find(id);
            _holaBlogContext.Testimonials.Remove(value);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = _holaBlogContext.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _holaBlogContext.Testimonials.Update(testimonial);
            _holaBlogContext.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
