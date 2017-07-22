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

        public TinyUrl CreateUrl(string url, string tinyUrl, string userID)
        {
            var user = DataContext.AspNetUsers.Single(u => u.Id == userID);
            var submittedUrl = new TinyUrl()
            {
                AspNetUser = user,
                AspNetUsersID = user.Id,
                TinyUrlString = tinyUrl,
                UrlString = url,
            };
            DataContext.TinyUrls.InsertOnSubmit(submittedUrl);
            DataContext.SubmitChanges();

            return DataContext.TinyUrls.Single(u => u.TinyUrlString == tinyUrl);
        }

        public List<TinyUrl> LoadAllUrls()
        {
            return DataContext.TinyUrls.ToList();
        }

        public List<TinyUrl> LoadUrlsForUser(string userID)
        {
            return DataContext.TinyUrls
                .Where(u => u.AspNetUsersID == userID)
                .ToList();
        }
    }
}