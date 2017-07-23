using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;
using WebApplication1.Controllers;
using Domain.Library.Services;
using Domain.Library.Repositories;
using Domain.Implementation.Services;
using Domain.Implementation.Repositories;
using Domain.AppData;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        protected LinqToSqlDataDataContext _linqToSqlDataContext { get; set; }
        protected IUserService _userService { get; set; }
        protected IUserRepository _userRepository { get; set; }

        protected ITinyUrlService _tinyUrlService { get; set; }
        protected ITinyUrlRepository _tinyUrlRepository { get; set; }
        [TestInitialize]
        public void setup()
        {
            _linqToSqlDataContext = new LinqToSqlDataDataContext();
            _userRepository = new UserRepository(_linqToSqlDataContext);
            _userService = new UserService(_userRepository);
            _tinyUrlRepository = new TinyUrlRepository(_linqToSqlDataContext);
            _tinyUrlService = new TinyUrlService(_tinyUrlRepository);
        }
        [TestMethod]
        public void Index()
        {
            
            //Arrange
            HomeController controller = new HomeController(_userService, _tinyUrlService);

            //Will need to mock out the repositories, and return just the value from the view that we need (most recent)
            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController(_userService, _tinyUrlService);

            // Act
            ViewResult result = controller.ViewUrls() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }
    }
}
