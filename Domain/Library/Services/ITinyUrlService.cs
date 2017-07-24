using Domain.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Library.Services
{
    public interface ITinyUrlService
    {
        List<TinyUrl> LoadAllUrls();
        List<TinyUrl> LoadUrlsForUser(string userID);
        TinyUrl CreateUrl(string url, string userID);
        TinyUrl LoadUrl(string urlID);
        TinyUrl CreateCustomUrl(string tinyUrl, string url, string userID);
        void CreateAudit(string tinyUrl);
    }
}