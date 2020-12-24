using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class User
    {
        public User(string quick_username, string quick_pass_hash, short quick_acc_type)
        {
            username = quick_username;
            password_hash = quick_pass_hash;
            account_type = quick_acc_type;
            //gen salt
            password_salt = "37h62d3";
        }
        
        public string password_hash { get; set; }
        public string username { get; set; }
        public string password_salt { get; set; }
        public short account_type { get; set; }
    }
}
