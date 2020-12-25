using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Timetable
    {
        public List<Time> TimeOfFeed;
        public string FeederId;
        public string name;
        public string Id { get; set; }

        public void Add_Time(Time t)
        {
            TimeOfFeed.Add(t);
        }
        public void Remove_Time(Time t)
        {
            TimeOfFeed.Remove(t);
        }
    }
}
