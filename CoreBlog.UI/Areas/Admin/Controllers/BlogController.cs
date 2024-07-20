using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
