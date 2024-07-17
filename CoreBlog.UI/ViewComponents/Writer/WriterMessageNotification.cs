using CoreBlog.BusinessLayer.Concrete;
using CoreBlog.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p = "deneme1@gmail.com"; 
            var values = mm.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
