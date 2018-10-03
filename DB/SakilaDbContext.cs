using Microsoft.EntityFrameworkCore;
using Sakila.DB.Model;

namespace Sakila.DB {
    public class SakilaDbContext : DbContext {

        public SakilaDbContext(DbContextOptions options) : base(options){}
        
        public DbSet<Film> Films {get;set;}
        public DbSet<Language> Languages {get;set;}
        public DbSet<Inventory> Inventories {get;set;}
        public DbSet<Rental> Rentals {get;set;}
        public DbSet<Customer> Customers {get;set;}


        
    }
}