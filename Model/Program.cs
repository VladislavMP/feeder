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
            //UserRepository R = new UserRepository();
            //User user = R.Get("user_id = 2");
            //MessageBox.Show(user.password);
        }
    }
}
