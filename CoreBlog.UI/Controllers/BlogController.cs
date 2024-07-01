using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
