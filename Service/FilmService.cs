using System.Collections.Generic;
using Sakila.DB;
using Sakila.DB.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace Sakila.Service
{
    public class FilmService
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

        public void foo() {
            var films = from f in ctx.Films
            where f.Title.Contains("bar")
            select f;
        }


    }
}