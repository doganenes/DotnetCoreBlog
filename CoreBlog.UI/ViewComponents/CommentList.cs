using CoreBlog.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.ViewComponents
{
    public class CommentList : ViewComponent
    {
         public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "Enes"
                },
                new UserComment
                {
                    ID=2,
                    Username = "Emre"
                },
                new UserComment
                {
                    ID = 3,
                    Username = "Merve"
                }
            };
            return View(commentValues);
        }
    }
}