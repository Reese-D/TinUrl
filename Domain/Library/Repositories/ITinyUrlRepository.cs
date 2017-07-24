using Domain.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.Repositories
{
    public interface ITinyUrlRepository
    {
        List<TinyUrl> LoadAllUrls();
        List<TinyUrl> LoadUrlsForUser(string userID);
        TinyUrl CreateUrl(string url, string tinyUrl, string userID, bool checkDuplicate = true);
        MostRecentTinyUrl GetTopTinyUrl();
        TinyUrl LoadUrl(string urlID);
        void CreateAudit(string tinyUrl);
    }
}
