using CoreBlog.BusinessLayer.Concrete;
using CoreBlog.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
    }
}

