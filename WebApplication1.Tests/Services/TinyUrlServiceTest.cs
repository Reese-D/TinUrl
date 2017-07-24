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
using NSubstitute;
using System.Web;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class TinyUrlServiceTest
    {

        protected ITinyUrlService _target { get; set; }
        protected ITinyUrlRepository _tinyUrlRepository { get; set; }

        protected string _url, _tinyUrl, _userID;
        [TestInitialize]
        public void setup()
        {
            _tinyUrlRepository =Substitute.For<ITinyUrlRepository>();
            _target = new TinyUrlService(_tinyUrlRepository);
            _url = "!";

            _tinyUrlRepository.CreateUrl(Arg.Do<string>(x => _url = x), Arg.Do<string>(x => _tinyUrl = x), Arg.Do<string>(x => _userID = x))
                .ReturnsForAnyArgs(new TinyUrl()
                {
                    UrlString = _url,
                    TinyUrlString = _tinyUrl,
                    AspNetUsersID = _userID,
                    AspNetUser = null,
                });

            _tinyUrlRepository.GetTopTinyUrl().Returns(new MostRecentTinyUrl()
            {
                AsciiValue = "",
                TinyUrlString = _url,
            });

            
        }

        [TestMethod]
        public void CreateMillionValidTinyUrlStringsTest()
        {
            
            for(var i = 0; i < 1000000; i++)
            {
                _target.CreateUrl("http://wwww.somethingfake.com", "fake user");
                var httpRequest = new HttpRequest("", $"http://localhost:58280/{_tinyUrl}", "");
                var strippedUrl = httpRequest.RawUrl.Substring(1, httpRequest.RawUrl.Length - 1);
                var decodedUrl = HttpUtility.UrlDecode(strippedUrl);
                Assert.AreEqual(decodedUrl, _tinyUrl);
            }
        }

        [TestMethod]
        public void invalidUrlFails()
        {
            _target.CreateUrl("http://www.fakesite.com", "test");
            var httpRequest = new HttpRequest("", $"http://localhost:58280/#", ""); //# instead of _tinyUrl
            var strippedUrl = httpRequest.RawUrl.Substring(1, httpRequest.RawUrl.Length - 1);
            var decodedUrl = HttpUtility.UrlDecode(strippedUrl);
            Assert.AreNotEqual(decodedUrl, _tinyUrl);
        }

    }
}
