using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Controllers
{
    public class AdminCommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
