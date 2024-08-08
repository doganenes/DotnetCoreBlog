using CoreBlog.EntityLayer.Concrete;
using CoreBlog.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public AdminRoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppRole appRole = new AppRole
                {
                    Name = p.name
                };

                var result = await _roleManager.CreateAsync(appRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);

            RoleUpdateViewModel model = new RoleUpdateViewModel()
            {
                Id = values.Id,
                Name = values.Name
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel model)
        {
            var values = _roleManager.Roles.Where(x => x.Id == model.Id).FirstOrDefault();
            values.Name = model.Name;
            var result = await _roleManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","AdminRole");
            }

            return View(model);
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault();
            var result = await _roleManager.DeleteAsync(values);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
