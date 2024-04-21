using IntroductionToDb.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var db = new BlogContext();
            return View(db.Blogs.ToList());
        }

    }
}
