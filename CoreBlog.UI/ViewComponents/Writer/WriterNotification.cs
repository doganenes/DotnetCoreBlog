using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
