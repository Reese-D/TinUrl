using Domain.Library.Repositories;
using Domain.Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.AppData;

namespace Domain.Implementation.Services
{
    public class UserService : IUserService
    {
        protected IUserRepository UserRepository { get; set; }
        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public AspNetUser LoadUser(string userID)
        {
            return UserRepository.LoadUser(userID);
        }
    }
}