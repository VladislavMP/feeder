using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Time : ITime
    {
        public string TimeHMS { get; set; }
        public int Id { get; set; }

        public Time()
        {
            TimeHMS = DateTime.Now.ToString("HH:mm");
        }
        public Time(string t)
        {
        }
    }
}
