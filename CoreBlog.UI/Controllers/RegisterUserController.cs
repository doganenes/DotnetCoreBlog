using CoreBlog.EntityLayer.Concrete;
using CoreBlog.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

namespace CoreBlog.UI.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // kayıt işlemi yazar üzerinden gerçekleşecek.

        [HttpPost]
        public async Task<IActionResult> Index(UserSignupViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.Username,
                    NameSurname = p.NameSurname
                };

                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }


            return View();
        }
    }
}
