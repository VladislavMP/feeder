﻿using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Service
{
    public class AuthService : IAuthService
    {
        private IRepository<User> _userrepository;
        public AuthService(IRepository<User> userrepository)
        {
            _userrepository = userrepository;
        }
        public short Login(string username, string password)
        {
            User user = _userrepository.Get(username);
            if (user == null)
            {
                return 0; 
            }
            else if (user.password_salt == password)
            {
                return user.account_type; 
            }
            return 0; 
        }
    }
}
