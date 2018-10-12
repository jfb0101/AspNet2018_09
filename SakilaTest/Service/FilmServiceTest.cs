using Microsoft.EntityFrameworkCore;
using Sakila.DB;
using Sakila.Service;
using Xunit;

namespace SakilaTest.Service {
    public class FilmServiceTest {
        private FilmService filmService;

        [Fact]
        public void testListAll() {
            // restauração do banco
            DbContextOptions options = MySqlDbContextOptionsExtensions
            .UseMySql(new DbContextOptionsBuilder(),"server=172.16.99.230;userid=root;pwd=1q2w3e4r;port=3308;database=sakila;sslmode=none;").Options;

            SakilaDbContext ctx = new SakilaDbContext(options);
            filmService = new FilmService(ctx);
            var list = filmService.listAll();
            
            Assert.Equal(1000,list.Count);
            Assert.NotNull(list[45].Language);
        }
    }
}