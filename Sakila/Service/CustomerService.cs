using Sakila.DB;
using Sakila.DB.Model;
using System.Linq;

namespace Sakila.Service {
    public class CustomerService {
        private SakilaDbContext ctx;

        public CustomerService(SakilaDbContext ctx) {
            this.ctx = ctx;
        }

        public Customer findById(int id) {
           return (from c in ctx.Customers where c.Id == id select c).FirstOrDefault();
        }

        public Customer findByFirstNameAndLastName(string firstName, string lastName) {
            return (from c in ctx.Customers where c.FirstName == firstName && c.LastName == lastName select c).FirstOrDefault();
        }

        public Customer save(Customer customer) {
            if (customer.Id == null) {
                ctx.Customers.Add(customer);
            } else {
                ctx.Customers.Update(customer);
            }

            ctx.SaveChanges();

            return customer;
        }
    }
}