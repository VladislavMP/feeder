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
            FeederRepository R = new FeederRepository();
            Feeder u = R.Get("test");
            u.Feeder_id = "5";
            u.Name = "8";
            u.Timetable_id = "7";
            u.User_id = "6";
            R.Remove(u);
            //foreach (Feeder p in u)
            //{
            //    MessageBox.Show(p.Name);
            //}

        }
    }
}
