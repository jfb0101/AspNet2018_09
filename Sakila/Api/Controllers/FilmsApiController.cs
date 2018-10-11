using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sakila.Api.Model;
using Sakila.DB.Model;
using Sakila.Service;

namespace Sakila.Api.Controllers {
    [Produces("application/json")]
    [Route("api/films")]
    public class FilmsApiController : Controller {
        private FilmService filmService;

        public FilmsApiController(FilmService filmService) {
            this.filmService = filmService;
        }

        public List<FilmApiModel> listAll() {
            var filmsListDb = filmService.listAll();
            List<FilmApiModel> filmsListApi = new List<FilmApiModel>();
            foreach( var film in filmsListDb) {
                filmsListApi.Add(new FilmApiModel(){
                    Id = film.Id,
                    Title = film.Title,
                    Language = film.Language != null ? film.Language.Name : null,
                    NumberOfAvailableInventory = filmService.numberOfAvailableInventory((int)film.Id)
                });
            }
            return filmsListApi;
        }

        [HttpPost]
        public IActionResult save([FromBody] Film film) {
            filmService.saveOrUpdate(film);
            return Ok();
        }

        [HttpGet("{id}")]
        public Film getById(int id) {
            return filmService.findById(id);
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id) {
           var film = filmService.findById(id);

           if (film != null) {
               filmService.delete(id);
               return Ok();
           } else {
               return NotFound();
           }
            
        }
    }
}