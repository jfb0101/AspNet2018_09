using Microsoft.EntityFrameworkCore;
using Sakila.DB.Model;

namespace Sakila.DB {
    public class SakilaDbContext : DbContext {

        public SakilaDbContext(DbContextOptions options) : base(options){}
        public DbSet<Film> Films {get;set;}

        
    }
}