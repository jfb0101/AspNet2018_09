using System.Collections.Generic;
using Sakila.DB.Model;

namespace Sakila.Models {
    public class RentalViewModel {
        public List<Film> Films {get;set;}
        public int? SelectedFilmId {get;set;}
    }
}