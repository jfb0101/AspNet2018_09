using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sakila.Admin.Models;
using Sakila.Security;
using System.Linq;

namespace Sakila.Admin.Controllers {
    [Area("Admin")]
    public class RolesController : Controller {
        private RoleManager<ApplicationRole> roleManager;
        private UserManager<ApplicationUser> userManager;

        public RolesController(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager) {
            this.roleManager = roleManager;
            this.userManager = userManager;
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

        public IActionResult AssignRoleToUser() {
            var model = new AssignRoleToUserViewModel();
            model.RoleList = roleManager.Roles.Where(r => r.Name == "admin" || r.Name == "user").ToList();
            model.UserList = userManager.Users.ToList();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRoleToUser(AssignRoleToUserViewModel model) {
             model.RoleList = roleManager.Roles.Where(r => r.Name == "admin" || r.Name == "user").ToList();
            model.UserList = userManager.Users.ToList();
            var user = await userManager.FindByIdAsync(model.SelectedUserId);
            var role = await roleManager.FindByIdAsync(model.SelectedRoleId);

            await userManager.AddToRoleAsync(user,role.Name);

            model.Assigned = true;

            return View(model);
        }

    }

    
}