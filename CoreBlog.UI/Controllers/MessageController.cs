using CoreBlog.BusinessLayer.Concrete;
using CoreBlog.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreBlog.UI.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        public IActionResult InBox()
        {
            int id = 2;
            var values = message2Manager.GetInboxListByWriter(id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var blogValue = message2Manager.TGetById(id);
            
            return View(blogValue);
        }    
    }
}
