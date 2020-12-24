using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Feeder
    {
        public Feeder(string quickid, string quickname)
        {
            Id = quickid;
            Name = quickname;
        }

        public string Id;
        public string Name;
    }
}
