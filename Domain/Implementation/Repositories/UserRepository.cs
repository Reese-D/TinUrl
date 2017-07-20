using Domain.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.AppData;
using System.Web.Mvc;

namespace Domain.Implementation.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(LinqToSqlDataDataContext dataContext) : base(dataContext)
        { 
        }

        public AspNetUser LoadUser(string userID)
        {
            return DataContext.AspNetUsers.First(u => u.Id == userID);
        }
    }
}