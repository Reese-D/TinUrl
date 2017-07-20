using Domain.Library.Repositories;
using Domain.Library.Services;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        protected IUserService UserService { get; set; }
        public HomeController(IUserService userService)
        {
            UserService = userService;
        }

        public ActionResult Index(string redirectId)
        {
            var user = UserService.LoadUser("3fcf7849-f773-4dc3-873d-180cfde32b95");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}