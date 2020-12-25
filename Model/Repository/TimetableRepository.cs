using System;
using System.Collections.Generic;
using System.Text;
using Model.Entity;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Model.Repository
{
    public class TimetableRepository : IRepository<Timetable>
    {
        private DB DataContext = new DB();

        public int Add(Timetable obj)
        {
            string UserId = obj.UserId;
            string TimetableId = obj.TimetableId;
            string name = obj.name;
            List<Time> TimeOfFeed = obj.TimeOfFeed;
            string com = "('" + TimetableId + "', '" + UserId + "', '" + name + "')";
            foreach (Time t in TimeOfFeed)
            {
                string com_2 = "('" + t.TimeHMS + "', '" + name + "')";
                string com_3 = "(time, timetable_id)";
                DataContext.Add("timestamps", com_2, com_3);
            }
            DataContext.Add("timetable", com);
            return 0;
        }

        public void Remove(Timetable obj)
        {
           // _data.RemoveAll(c => c.Id == id);
        }

        public void Save()
        {
        }

        public Timetable Get(string timetable_id)
        {
            DataTable table = new DataTable();
            string com = "timetable_id= '" + timetable_id + "'";
            table = DataContext.Find("timetable", com);
            Timetable timetable = new Timetable();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    timetable.TimetableId = cells[0].ToString();
                    timetable.UserId = cells[1].ToString();
                    timetable.name = cells[2].ToString();
                }
            }
            else return null;
            com = "timetable_id= '" + timetable_id + "'";
            table = DataContext.Find("timestamps", com);
            List<Time> TimeOfFeed = new List<Time>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    Time time = new Time("1");
                    time.TimeHMS = cells[1].ToString();
                    TimeOfFeed.Add(time);
                }
            }
            else timetable.TimeOfFeed = null;
            timetable.TimeOfFeed = TimeOfFeed;
            return timetable;
        }

        public List<Timetable> GetAll()
        {
            DataTable table = new DataTable();
            table = DataContext.GetAll("timetable");
            List<Timetable> timetableList = new List<Timetable>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    Timetable timetable = new Timetable();
                    timetable.TimetableId = cells[0].ToString();
                    timetable.UserId = cells[1].ToString();
                    timetable.name = cells[2].ToString();

                    //
                    string com = "timetable_id= '" + timetable.TimetableId + "'";
                    DataTable table_in = new DataTable();
                    table_in = DataContext.Find("timestamps", com);
                    List<Time> TimeOfFeed = new List<Time>();
                    if (table_in.Rows.Count > 0)
                    {
                        foreach (DataRow row_in in table_in.Rows)
                        {
                            var cells_in = row_in.ItemArray;
                            Time time = new Time("1");
                            time.TimeHMS = cells_in[1].ToString();
                            TimeOfFeed.Add(time);
                        }
                    }
                    else timetable.TimeOfFeed = null;
                    timetable.TimeOfFeed = TimeOfFeed;
                    timetableList.Add(timetable);
                }
            }
            else return null;
 
            return timetableList;
        }
        public List<Timetable> GetList(string user_id)
        {
            DataTable table = new DataTable();
            string command = "user_id= '" + user_id + "'";
            table = DataContext.Find("timetable", command);
            List<Timetable> timetableList = new List<Timetable>();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    Timetable timetable = new Timetable();
                    timetable.TimetableId = cells[0].ToString();
                    timetable.UserId = cells[1].ToString();
                    timetable.name = cells[2].ToString();

                    //
                    string com = "timetable_id= '" + timetable.TimetableId + "'";
                    DataTable table_in = new DataTable();
                    table_in = DataContext.Find("timestamps", com);
                    List<Time> TimeOfFeed = new List<Time>();
                    if (table_in.Rows.Count > 0)
                    {
                        foreach (DataRow row_in in table_in.Rows)
                        {
                            var cells_in = row_in.ItemArray;
                            Time time = new Time("1");
                            time.TimeHMS = cells_in[1].ToString();
                            MessageBox.Show(time.TimeHMS);
                            TimeOfFeed.Add(time);
                        }
                    }
                    else timetable.TimeOfFeed = null;
                    timetable.TimeOfFeed = TimeOfFeed;
                    timetableList.Add(timetable);
                }
            }
            else return null;

            return timetableList;
        }
    }
}
