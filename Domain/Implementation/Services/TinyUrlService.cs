using Domain.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.AppData;
using Domain.Library.Services;

namespace Domain.Implementation.Services
{
    public class TinyUrlService : ITinyUrlService
    {
        public List<char> InvalidCharacters = new List<char>()
        {
            '?', '/', '{', '}', '|', '^', '\\', '`', ']', '[', ';', '/', ':', '@', '&',
            '=', '+', '$', ',', (char)127, ' ', '#', '%'
        };

        public List<char> ValidCharacters = new List<char>();
        int numValidCharacters = 0;

        public ITinyUrlRepository TinyUrlRepository { get; set; }

        public TinyUrlService(ITinyUrlRepository tinyUrlRepository)
        {
            TinyUrlRepository = tinyUrlRepository;

            for(var i = 0x0; i <= 0x1f; i++)
            {
                InvalidCharacters.Add((char)i);
            }

            for(var i = 0x0; i < 0xff; i++)
            {
                if (!InvalidCharacters.Contains((char)i))
                {
                    numValidCharacters++;
                    ValidCharacters.Add((char)i);
                }
            }
        }
        public TinyUrl CreateUrl(string url, string userID)
        {
            var tinyUrl = GetNextTinyUrl();
            return TinyUrlRepository.CreateUrl(url, tinyUrl, userID);
        }

        public TinyUrl CreateCustomUrl(string tinyUrl, string url, string userID)
        {
            if(tinyUrl.Any(a => InvalidCharacters.Any(i => i == a)))
            {
                return null;
            }
            return TinyUrlRepository.CreateUrl(url, tinyUrl, userID);
        }

        public void CreateAudit(string tinyUrl)
        {
            TinyUrlRepository.CreateAudit(tinyUrl);
        }

        public List<TinyUrl> LoadAllUrls()
        {
            return TinyUrlRepository.LoadAllUrls();
        }

        public List<TinyUrl> LoadUrlsForUser(string userID)
        {
            return TinyUrlRepository.LoadUrlsForUser(userID);
        }

        public TinyUrl LoadUrl(string urlID)
        {
            return TinyUrlRepository.LoadUrl(urlID);
        }

        private string GetNextTinyUrl()
        {
            var mostRecent = TinyUrlRepository.GetTopTinyUrl();
            if (mostRecent == null)
                return ValidCharacters.First().ToString();

            var returnVal = mostRecent.TinyUrlString;
            var lastChar = mostRecent.TinyUrlString.Last();
            var index = ValidCharacters.IndexOf(lastChar);

            if (index == numValidCharacters - 1)
            {
                return string.Concat(returnVal, ValidCharacters.First());
            }

            returnVal = returnVal.Substring(0, returnVal.Length - 1);
            return string.Concat(returnVal, ValidCharacters.ElementAt(index + 1));
        }
    }
}