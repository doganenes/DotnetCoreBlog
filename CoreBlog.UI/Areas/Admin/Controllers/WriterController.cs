using CoreBlog.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        public IActionResult GetWriterById(int writerID)
        {
            var findWriters = writers.FirstOrDefault(x => x.ID == writerID);
            var jsonWriters = JsonConvert.SerializeObject(findWriters);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonwriters = JsonConvert.SerializeObject(writers);
            return Json(jsonwriters);
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
