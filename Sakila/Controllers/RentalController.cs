using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Sakila.Models;
using Sakila.Service;

namespace Sakila.Controllers {
    public class RentalController : Controller {
        private FilmService filmService;

        public RentalController(FilmService filmService) {
            this.filmService = filmService;
        }

        public IActionResult Index() {
            var model = new RentalViewModel();
            model.Films = filmService.listAll();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(RentalViewModel model) {
            filmService.doRental((int)model.SelectedFilmId,(int)HttpContext.Session.GetInt32("CustomerId"));
            return RedirectToAction("Success");
        }

        public IActionResult Success() {
            return View();
        }


    }
}