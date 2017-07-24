using Domain.AppData;
using Domain.Library.Repositories;
using Domain.Library.Services;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Attributes;
using WebApplication1.Models;
using WebApplication1.Models.HomeModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        protected IUserService UserService { get; set; }
        protected ITinyUrlService TinyUrlService { get; set; }
        public HomeController(IUserService userService, ITinyUrlService tinyUrlService)
        {
            UserService = userService;
            TinyUrlService = tinyUrlService;
        }

        public ActionResult Index()
        {
            var rawUrl = HttpContext.Request.RawUrl;
            if (rawUrl.Length == 1)
                return View();

            var redirectID = rawUrl.Substring(1, rawUrl.Length-1); //strip leading forward-slash
            var redirectUrl = TinyUrlService.LoadUrl(redirectID)?.UrlString;
            if(redirectUrl == null)
            {
                return RedirectToAction("custom404", "Errors");
            }
            TinyUrlService.CreateAudit(redirectID);
            return Redirect(redirectUrl);
        }

        [HttpGet]
        public ActionResult ViewUrls()
        {
            var model = new ViewUrlsModel()
            {
                urls = TinyUrlService.LoadAllUrls(),
                displayCreate = false,
            };
            return View(model);
        }

        [HttpGet]
        [RequiresLoggin]
        public ActionResult ViewMyUrls(string userID, bool validUrl = true, bool exists = false)
        {
            if (string.IsNullOrWhiteSpace(userID))
            {
                userID = ((AspNetUser)Session["User"]).Id;
            }
            var model = new ViewUrlsModel()
            {
                urls = TinyUrlService.LoadUrlsForUser(userID),
                displayCreate = true,
            };

            if (!validUrl)
                ModelState.AddModelError("url", "Invalid Uri supplied. perhaps you didn't preface it with http(s)?");
            if (exists)
                ModelState.AddModelError("url", "This alias already exists, please specify a new one");
            
            return View("ViewUrls", model);
        }

        [HttpGet]
        public ActionResult CreateTinyUrl()
        {
            var model = new CreateTinyUrlModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateTinyUrl(CreateTinyUrlModel model)
        {
            var user = ((AspNetUser)Session["User"]);
            var userID = user?.Id ?? "Everyone";
            Uri uriResult;
            var isValid = Uri.TryCreate(model.url, UriKind.Absolute, out uriResult) 
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            TinyUrl result = null;
            if (isValid)
            {
                if (!string.IsNullOrWhiteSpace(model.alias))
                {
                    result = TinyUrlService.CreateCustomUrl(model.alias, model.url, userID);
                }
                else
                {
                    result = TinyUrlService.CreateUrl(model.url, userID);
                }
            }
            if(userID == "Everyone")
            {
                return RedirectToAction("ViewUrls");
            }
            return RedirectToAction("ViewMyUrls", new { userID, validUrl = isValid, exists = result == null });
        }
    }
}