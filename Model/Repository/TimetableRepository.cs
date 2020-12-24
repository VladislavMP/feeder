using System;
using System.Collections.Generic;
using System.Text;
using Model.Entity;
using MySql.Data.MySqlClient;

namespace Model.Repository
{
    public class TimetableRepository : IRepository<Timetable>
    {
        private static List<Timetable> _data = new List<Timetable>();
        private static int _end_index = 0;

        public int Add(Timetable obj)
        {
            //obj.Id = _end_index;
            //_end_index += 1;
            //_data.Add(obj);
            return 0;
        }

        public void Remove(Timetable obj)
        {
           // _data.RemoveAll(c => c.Id == id);
        }

        public void Save()
        {
        }

        public Timetable Find(int id)
        {
            //  return _data.Find(c => c.Id == id);
            return null;
        }

        public Timetable Get(string id)
        {
            throw new NotImplementedException();
        }

        /*       public List<Timetable> GetAll()
      {
          string connStr = "server=localhost;user=root;database=Timetable;password=root";
          List<Timetable> timetables;
          return timetables;
      }*/
    }
}
