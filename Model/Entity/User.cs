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
            password = quick_pass_hash;
            account_type = quick_acc_type;
        }
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public short account_type { get; set; }
    }
}
