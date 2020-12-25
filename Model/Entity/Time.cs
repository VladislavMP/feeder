using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entity
{
    public class Time : ITime
    {
        public string DayOfWeek;
        public string TimeHMS;
        public int Id; 

        public Time()
        {
            TimeHMS = DateTime.Now.ToString("HH:mm:ss");
            DayOfWeek = DateTime.Now.DayOfWeek.ToString();
        }
        public Time(string t)
        {
        }
        public string Get_DayOfWeek()
        {
            return this.DayOfWeek;
        }
        public string Get_TimeHMS()
        {
            return this.TimeHMS;
        }

        public bool CompareTimeHMS(Time t2)
        {
            if (this.TimeHMS == t2.TimeHMS) return true;
            return false;
        }
        public bool CompareDayOfWeek(Time t2)
        {
            if (this.DayOfWeek == t2.DayOfWeek) return true;
            return false;
        }
    }
}
