using CoreBlog.BusinessLayer.Concrete;
using CoreBlog.DataAccessLayer.Concrete;
using CoreBlog.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CoreBlog.UI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.TGetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();

            string api = "b315324a6a2fb822be17a21919adbd5e";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
