using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Service
{
    public class AuthService : IAuthService
    {
        public short Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return 2; //admin
            }
            else if (username == "test" && password == "test")
            {
                return 1; //normal user
            }
            return 0; //access denied
        }
    }
}
