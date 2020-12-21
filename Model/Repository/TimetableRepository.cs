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

        public string Add(Timetable obj)
        {
            obj.Id = "zero"; //генерация айди и запись элементов
            //_end_index += 1;
            //_data.Add(obj);
            return obj.Id;
        }

        public void Remove(string id)
        {
            _data.RemoveAll(c => c.Id == id);
        }

        public void Save()
        {
        }

        public Timetable Find(string id)
        {
            return _data.Find(c => c.Id == id);
        }

        public Timetable Get(string id)
        {
            throw new NotImplementedException();
        }

        List<Timetable> IRepository<Timetable>.GetAll(string id)
        {
            throw new NotImplementedException();
        }

        string IRepository<Timetable>.Add(Timetable obj)
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
