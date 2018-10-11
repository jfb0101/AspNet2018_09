using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Sakila.Models;
using Sakila.Service;

namespace Sakila.Controllers {
    public class LoginController : Controller {
        private CustomerService customerService;

        public LoginController(CustomerService customerService) {
            this.customerService = customerService;
        }

        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model) {
            HttpContext.Session.SetString("FirstName",model.FirstName);
            HttpContext.Session.SetString("LastName",model.LastName);
            var customer = customerService.findByFirstNameAndLastName(model.FirstName,model.LastName);
            HttpContext.Session.SetInt32("CustomerId",(int)customer.Id);

            return RedirectToAction("Index","Rental");
        }

        
    }

    

    
}