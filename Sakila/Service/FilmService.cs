using System.Collections.Generic;
using Sakila.DB;
using Sakila.DB.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace Sakila.Service
{
    public interface IFilmService {
        Film findById(int id);
        List<Film> listAll();
        Film saveOrUpdate(Film film);
        void delete(int filmId);
        int numberOfAvailableInventory(int filmId);
        void doRental(int filmId,int customerId);
    }
    public class FilmService : IFilmService
    {
        private SakilaDbContext ctx;


        public FilmService(SakilaDbContext ctx)
        {
            this.ctx = ctx;
        }

        public Film findById(int id)
        {
            return (from f in ctx.Films where f.Id == id select f).SingleOrDefault();
        }
        public List<Film> listAll()
        {
            return (from f in ctx.Films.Include(f => f.Language) orderby f.Id descending select f).ToList<Film>();
        }

        public Film saveOrUpdate(Film film)
        {
            if (film.Id == null)
            {
                ctx.Films.Add(film);
            }
            else
            {
                ctx.Films.Update(film);
            }

            ctx.SaveChanges();

            return film;
        }

        public void delete(int filmId)
        {
            try
            {
                var film = new Film() { Id = filmId };
                ctx.Films.Attach(film);
                ctx.Films.Remove(film);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int numberOfAvailableInventory(int filmId) {
            var inventories = from i in ctx.Inventories
                                where !ctx.Rentals.Select(r => r.InventoryId).Contains(i.Id)
                                && i.FilmId == filmId
                                select i;
            return inventories.Count();                              

        }

        public void doRental(int filmId,int customerId) {
            Inventory availableInventory = (from i in ctx.Inventories where !ctx.Rentals.Select(r => r.InventoryId).Contains(i.Id)
            && i.FilmId == filmId
            select i).FirstOrDefault();

            Rental rental = new Rental(){
                InventoryId = availableInventory.Id,
                CustomerId = customerId
            };

            ctx.Add(rental);
            ctx.SaveChanges();
        }


    }
}