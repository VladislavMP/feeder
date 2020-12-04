using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Timetable
    {
        private List<Time> TimeOfFeed;
        private string FeederId;
        private string name;
        public int Id { get; set; }

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
