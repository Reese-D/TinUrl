using Domain.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.AppData;

namespace Domain.Implementation.Repositories
{
    public class TinyUrlRepository : BaseRepository, ITinyUrlRepository
    {
        public TinyUrlRepository(LinqToSqlDataDataContext dataContext) : base(dataContext)
        {
        }

        public TinyUrl CreateUrl(string url, string tinyUrl, string userID, bool checkDuplicate = true)
        {
            var duplicate = DataContext.TinyUrls.Any(t => t.UrlString == url);
            if (duplicate && checkDuplicate)
            {
                return JoinUrl(userID, url);
            }
            
            var user = DataContext.AspNetUsers.SingleOrDefault(u => u.Id == userID);
            if(user == null)
            {
                user = DataContext.AspNetUsers.Single(u => u.Id == "Everyone");
            }
            var submittedUrl = new TinyUrl()
            {
                AspNetUser = user,
                AspNetUsersID = user.Id,
                TinyUrlString = tinyUrl,
                UrlString = url,
            };
            DataContext.TinyUrls.InsertOnSubmit(submittedUrl);

            var audit = createTinyUrlAudit(tinyUrl, url, user.Id);

            DataContext.TinyUrlsAuditTables.InsertOnSubmit(audit);

            DataContext.SubmitChanges();

            return DataContext.TinyUrls.Single(u => u.TinyUrlString == tinyUrl);
        }

        public void CreateAudit(string tinyUrl)
        {
            var data = DataContext.TinyUrls.Single(t => t.TinyUrlString == tinyUrl);
            var audit = createTinyUrlAudit(data.TinyUrlString, data.UrlString, data.AspNetUsersID);
        }

        public List<TinyUrl> LoadAllUrls()
        {
            return DataContext.TinyUrls.ToList();
        }

        public List<TinyUrl> LoadUrlsForUser(string userID)
        {
            return DataContext.GetTinyUrlsForUser(userID)
                .Select(u => new TinyUrl()
                {
                    AspNetUsersID = u.AspNetUsersID,
                    TinyUrlString = u.TinyUrlString,
                    UrlString = u.UrlString,
                })
                .ToList();
        }

        public MostRecentTinyUrl GetTopTinyUrl()
        {
            return DataContext.MostRecentTinyUrls.FirstOrDefault();
        }

        public TinyUrl LoadUrl(string urlID)
        {
            return DataContext.TinyUrls.Single(u => u.TinyUrlString == urlID);
        }

        private TinyUrlsAuditTable createTinyUrlAudit(string tinyUrl, string url, string userID)
        {
            return new TinyUrlsAuditTable()
            {
                AspNetUsersID = userID,
                TinyUrlString = tinyUrl,
                UrlString = url,
                UtcCreatedDate = DateTime.UtcNow,
            };
        }

        private TinyUrl JoinUrl(string userID, string url)
        {
            var tinyUrl =  DataContext.TinyUrls.First(u => u.UrlString == url);
            if(!DataContext.TinyUrlAspNetUserJoinTables
                .Any(a => a.AspNetUsersID == userID && a.TinyUrlString == tinyUrl.TinyUrlString))
            {
                var urlJoin = new TinyUrlAspNetUserJoinTable()
                {
                    AspNetUsersID = userID,
                    TinyUrlString = tinyUrl.TinyUrlString,
                };
                DataContext.TinyUrlAspNetUserJoinTables.InsertOnSubmit(urlJoin);
                DataContext.SubmitChanges();
            }

            return tinyUrl;
            
        }
    }
}