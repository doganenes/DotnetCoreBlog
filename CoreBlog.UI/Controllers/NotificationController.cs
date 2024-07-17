using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
