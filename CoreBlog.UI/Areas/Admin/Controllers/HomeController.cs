using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
