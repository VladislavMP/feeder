using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Model.Repository
{
    public class UserRepository : IRepository<User>
    {
        public int Add(User obj)
        {
            throw new NotImplementedException();
        }

        public User Get(string username)
        {
            User user = new User();
            user.username = username;
            if (username == "admin")
            {
                user.id = "j32jf22";
                user.password = "admin"; //тут должно быть хэширование
                user.account_type = 2;
            }
            else if (username == "test")
            {
                user.id = "jfs8fds3";
                user.password = "test"; 
                user.account_type = 1;
            }
            else
            {
                user.id = "0";
            }
            return user;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
