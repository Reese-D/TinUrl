using Domain.Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.AppData;

namespace Domain.Implementation.Repositories
{
    public class UserRepository : IUserRepository
    {
        public AspNetUser LoadUser(int userID)
        {
            throw new NotImplementedException();
        }
    }
}