﻿using ClosedXML.Excel;
using CoreBlog.DataAccessLayer.Concrete;
using CoreBlog.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using(var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach(var item in GetBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }
            }
        }
       List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{ID = 1, BlogName = "C# ile programlamaya giriş"},
                new BlogModel{ID = 2, BlogName = "Tesla Firmasının araçları"},
                new BlogModel{ID = 3, BlogName = "Euro 2024"},

            };
            return bm;
        }

        public IActionResult BlogListExcel()
        {
            return View();
        }

        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int BlogRowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }
            }
        }

        public List<BlogModel2> BlogTitleList()
        {
            List<BlogModel2> bm = new List<BlogModel2>();     
            using(var c = new Context())
            {
                bm = c.Blogs.Select(x => new BlogModel2()
                {
                    ID = x.BlogID,
                    BlogName = x.BlogTitle
                }).ToList();
            }

            return bm;
        }

        public IActionResult BlogListTitleExcel()
        {
            return View();
        }
    }
}
