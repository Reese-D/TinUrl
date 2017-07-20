﻿using Domain.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.Repositories
{
    public interface IUserRepository
    {
        AspNetUser LoadUser(string userID);
    }
}