namespace Sakila.Api.Model {
    public class FilmApiModel {
        public int? Id {get;set;}
        public string Title {get;set;}
        public string Description {get;set;}
        public string Language {get;set;}
        public int? NumberOfAvailableInventory {get;set;}
    }
}