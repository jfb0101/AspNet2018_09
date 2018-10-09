using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sakila.Admin.Models;
using Sakila.Security;

namespace Sakila.Admin.Controllers {
    [Area("Admin")]
    public class RolesController : Controller {
        private RoleManager<ApplicationRole> roleManager;

        public RolesController(RoleManager<ApplicationRole> roleManager) {
            this.roleManager = roleManager;
        }

        public IActionResult CreateOrUpdate() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrUpdate(CreateUpdateRoleViewModel model) {
            await roleManager.CreateAsync(new ApplicationRole(){
                Name = model.Name
            });

            model.Created = true;

            return View(model);
        }
    }
}