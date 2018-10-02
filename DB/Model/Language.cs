using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakila.DB.Model {
    [Table("language")]
    public class Language {
        [Key]
        [Column("language_id")]
        public int? Id {get;set;}
        [Column("name")]
        public string Name {get;set;}
    }
}