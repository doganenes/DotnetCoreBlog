﻿using CoreBlog.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(
            new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 10
            }
            );

            list.Add(
            new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14
            }
            );

            list.Add(
            new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 5
            }
            );

            list.Add(
            new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 2
            }
            );

            return Json(new {jsonlist= list});
        }
    }
}
