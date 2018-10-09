using Microsoft.AspNetCore.Mvc;

namespace Sakila.Admin.Controllers {
    [Area("Admin")]
    public class RolesController : Controller {
        public IActionResult CreateOrUpdate() {
            return View();
        }
    }
}