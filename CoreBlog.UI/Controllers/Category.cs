using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}