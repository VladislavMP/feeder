using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class User
    {
        public string password_hash { get; set; }
        public string username { get; set; }
        public string password_salt { get; set; }
        public short account_type { get; set; }
    }
}
