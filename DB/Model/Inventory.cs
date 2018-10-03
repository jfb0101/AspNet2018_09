using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakila.DB.Model {
    [Table("inventory")]
    public class Inventory {
        [Key]
        [Column("inventory_id")]
        public int? Id {get;set;}
        [Column("film_id")]
        public int? FilmId {get;set;}
        public virtual Film Film {get;set;}


    }
}