using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakila.DB.Model {
    [Table("rental")]
    public class Rental {
        [Key]
        [Column("rental_id")]
        public int? Id {get;set;}
        [Column("inventory_id")]
        public int? InventoryId {get;set;}
        public virtual Inventory Inventory {get;set;}
        [Column("customer_id")]
        public int? CustomerId {get;set;}
        public virtual Customer Customer {get;set;}
    }
}