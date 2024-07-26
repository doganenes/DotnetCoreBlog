using CoreBlog.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreBlog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            return Json(writers);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                ID = 1,
                Name="Ayşe"
            },
            new WriterClass
            {
                ID = 2,
                Name = "Elif"
            },
            new WriterClass
            {
                ID= 3,
                Name = "Enes"
            }
        };
    }
}
