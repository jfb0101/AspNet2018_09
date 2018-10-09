using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sakila.DB.Model;
using Sakila.Models;
using Sakila.Security;
using Sakila.Service;

namespace Sakila.Controllers {
    public class AccountController : Controller {

        private UserManager<ApplicationUser> userManager;
        private CustomerService customerService;

        public AccountController(UserManager<ApplicationUser> userManager,CustomerService customerService) {
            this.userManager = userManager;
            this.customerService = customerService;
        }

        public IActionResult Register() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterViewModel model) {
            var user = new ApplicationUser(){Email = model.Email,UserName = model.Email};
            var result = await userManager.CreateAsync(user,model.Password);
            
            if (result.Succeeded) {
                var createdUser = await userManager.FindByEmailAsync(model.Email);
                var customer = new Customer(){
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserId = createdUser.Id
                };
                customerService.save(customer);
                return RedirectToAction("Login");
            }
            return View();

        }

        public IActionResult Login() {
            return View();
        }
    }
}