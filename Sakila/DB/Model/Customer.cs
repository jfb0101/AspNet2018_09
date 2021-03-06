using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakila.DB.Model {
    [Table("customer")]
    public class Customer {
        [Key]
        [Column("customer_id")]
        public int? Id {get;set;}
        [Column("first_name")]
        public string FirstName {get;set;}
        [Column("last_name")]
        public string LastName {get;set;}
        [Column("user_id")]
        public string UserId {get;set;}
    }
}