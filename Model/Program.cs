using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entity;
using System.Data;
using Model.Repository;

namespace Model
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* DB db = new DB();
             DataTable table = new DataTable();
             table = db.Find("users", "user_type = 1");
             foreach (DataRow row in table.Rows)
             {
                 var cells = row.ItemArray;
                 foreach (object cell in cells)
                 {
                     string cellz = cell.ToString();
                     MessageBox.Show(cellz);
                 }
             }
             if (table.Rows.Count > 1)
                 MessageBox.Show("Yes");
             else MessageBox.Show("No"); */
           /* TimetableRepository R = new TimetableRepository();
            Timetable u = new Timetable();
            Time t = new Time();
            Time y = new Time();
            t.TimeHMS = DateTime.Now.ToString("HH:mm");
            y.TimeHMS = "19:00";
            u.name = "tttt";
            u.TimetableId = "tttt";
            u.UserId = "tttt";
            MessageBox.Show(t.TimeHMS);
            u.TimeOfFeed = new List<Time>();
            u.TimeOfFeed.Add(t);
            u.TimeOfFeed.Add(y);
            R.Add(u);*/
            //foreach (Timetable p in u)
            //{
            //    MessageBox.Show(p.TimetableId);
            //}

        }
    }
}
