using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entity;

namespace Model.Service
{
    public class TimetableService : ITimetableService
    {
        private IRepository<Timetable> _timetablerepository;

        private static Random random = new Random();

        public TimetableService(IRepository<Timetable> timetablerepository)
        {
            _timetablerepository = timetablerepository;
        }

        public void Add_Timetable(string current_user_id)
        {
            Timetable timetable;
            string timetable_id;

            while (true)
            {
                timetable_id = RandomString(10);
                timetable = _timetablerepository.Get(timetable_id);
                if (timetable == null) break;
            }
            
            timetable = new Timetable();
            timetable.name = "Расписание uWu";
            timetable.TimetableId = timetable_id;
            timetable.UserId = current_user_id;
            _timetablerepository.Add(timetable);
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public short Save_Timetable(string timetable_id, List<Time> timestamps, string name)
        {
            if (name == "") return 1; //пустое имя

            int size = timestamps.Count;
            int i;
            string[] words;
            int minutes;
            int hours;

            for (i = 0; i < size; i++)
            {
                words = timestamps[i].TimeHMS.Split(':');
                if (words.Length != 2) return 2;
                if (!Int32.TryParse(words[0], out hours)) return 2;
                if (!Int32.TryParse(words[1], out minutes)) return 2;
                if (minutes > 59 || hours > 24) return 2;
            }

            Timetable timetable = _timetablerepository.Get(timetable_id);
            timetable.name = name;
            timetable.TimeOfFeed = timestamps;
            string cond = "timetable_id = '" + timetable_id + "'";
            _timetablerepository.Update(timetable, cond);
            return 0;
        }


    }
}
