using CoreBlog.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Controllers
{
    public class NewsletterController : Controller
    {
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(Newsletter p)
        {
            return PartialView();
        }
    }
}
