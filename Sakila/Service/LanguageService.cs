using System.Collections.Generic;
using Sakila.DB;
using Sakila.DB.Model;
using System.Linq;

namespace Sakila.Service {
    public interface ILanguageService {
         List<Language> listAll();
    }
    public class LanguageService : ILanguageService {
        private SakilaDbContext context;

        public LanguageService(SakilaDbContext context) {
            this.context = context;
        }

        public List<Language> listAll() {
            return (from l in context.Languages select l).ToList();
        }
    }
}