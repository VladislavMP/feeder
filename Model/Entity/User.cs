using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public short account_type { get; set; }
    }
}
