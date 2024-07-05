using CoreBlog.BusinessLayer.Concrete;
using CoreBlog.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.ViewComponents.Blog
{
	public class WriterLastBlogs : ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values =bm.GetBlogListWithWriter(1);
			return View(values);
		}
	}
}