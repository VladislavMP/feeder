using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IAuthService
    {
        short Login(string username, string password);
    }
}
