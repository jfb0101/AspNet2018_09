using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Sakila.Controllers;
using Sakila.DB.Model;
using Sakila.Service;
using Xunit;

namespace SakilaTest.Controllers {
    public class FilmsControllerTest {
        [Fact]
        public void testList() {
            Func<List<Film>> listAllMock = () => {
                var list = new List<Film>();
                list.Add(new Film());
                return list;
            };
            var filmServiceMock = new Mock<IFilmService>();
            var languageServiceMock = new Mock<ILanguageService>();

            filmServiceMock.Setup(filmService => filmService.listAll()).Returns(listAllMock());
            
            var controller = new FilmsController(filmServiceMock.Object,languageServiceMock.Object);
            var result = controller.List();
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Film>>(viewResult.ViewData.Model);
        }
    }
}