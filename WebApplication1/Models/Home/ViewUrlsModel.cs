using Domain.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.HomeModels
{
    public class ViewUrlsModel
    {
        public List<TinyUrl> urls { get; set; }
        public bool displayCreate { get; set; }
    }
}