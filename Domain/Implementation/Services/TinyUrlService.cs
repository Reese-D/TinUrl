using Domain.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.AppData;

namespace Domain.Implementation.Services
{
    public class TinyUrlService : ITinyUrlService
    {
        public ITinyUrlRepository TinyUrlRepository { get; set; }

        public TinyUrlService(ITinyUrlRepository tinyUrlRepository)
        {
            TinyUrlRepository = tinyUrlRepository;
        }
        public TinyUrl CreateUrl(string url, string userID)
        {
            var tinyUrl = GetNextTinyUrl();
            return TinyUrlRepository.CreateUrl(url, tinyUrl, userID);
        }

        public List<TinyUrl> LoadAllUrls()
        {
            return TinyUrlRepository.LoadAllUrls();
        }

        public List<TinyUrl> LoadUrlsForUser(string userID)
        {
            return TinyUrlRepository.LoadUrlsForUser(userID);
        }

        private string GetNextTinyUrl()
        {
            throw new NotImplementedException();
        }
    }
}