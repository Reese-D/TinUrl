using Domain.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Implementation.Repositories
{
    public class BaseRepository
    {
        protected LinqToSqlDataDataContext DataContext { get; set; }

        public BaseRepository(LinqToSqlDataDataContext dataContext)
        {
            DataContext = dataContext;
        }
    }
}