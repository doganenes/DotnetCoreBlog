﻿using CoreBlog.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Admins.Where(x => x.AdminID == 2).Select(y => y.Name).FirstOrDefault();
            ViewBag.v2 = c.Admins.Where(x => x.AdminID == 2).Select(y => y.ImageURL).FirstOrDefault();
            ViewBag.v3 = c.Admins.Where(x => x.AdminID == 2).Select(y => y.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}