using System.Collections.Generic;
using Sakila.DB;
using Sakila.DB.Model;
using System.Linq;

namespace Sakila.Service {
    public class LanguageService {
        private SakilaDbContext context;

        public LanguageService(SakilaDbContext context) {
            this.context = context;
        }

        public List<Language> listAll() {
            return (from l in context.Languages select l).ToList();
        }
    }
}