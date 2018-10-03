using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sakila.DB.Model;
using Sakila.Service;

namespace Sakila.Controllers {
    public class FilmsController : Controller {

        private FilmService filmService;
        private LanguageService languageService;

        public FilmsController(FilmService filmService, LanguageService languageService) {
            this.filmService = filmService;
            this.languageService = languageService;
        }
        
        public IActionResult List() {
            var filmsList = filmService.listAll();
            return View(filmsList);
        }

        [HttpGet]
        public IActionResult CreateOrUpdate(int? id) {
            ViewBag.LanguageList = languageService.listAll();
            if (id != null) {
                var film = filmService.findById((int)id);
                return View(film);
            } else {
                return View();    
            }

            
            
        }

        [HttpPost]
        public IActionResult CreateOrUpdate(Film film) {
            if (film.Title == null) {
                ModelState.AddModelError("Title","Title is required (FROM CONTROLLER)");
            }
            
            if (!ModelState.IsValid) {
                return View();
            }

            filmService.saveOrUpdate(film);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int? id) {
            filmService.delete((int)id);
            return RedirectToAction("List");
        }
    }
}