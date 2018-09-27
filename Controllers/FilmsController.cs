using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sakila.DB.Model;

namespace Sakila.Controllers {
    public class FilmsController : Controller {
        List<Film> filmsList = new List<Film>();

        public FilmsController() {
            filmsList.Add(new Film(){Id = 1, Title = "Harry Potter"});
            filmsList.Add(new Film(){Id = 2, Title = "Logan"});
            filmsList.Add(new Film(){Id = 2, Title = "Vingadores"});
        }
        public IActionResult List() {
            return View(filmsList);
        }

        [HttpGet]
        public IActionResult CreateOrUpdate() {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrUpdate(Film film) {
            film.Id = 4;
            filmsList.Add(film);
            return View("List",filmsList);
        }
    }
}