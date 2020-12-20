using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
/*

            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=feeder_db;");
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT user_id FROM users WHERE user_type = 1", conn);
            string test = command.ExecuteScalar().ToString();
            Console.WriteLine(test);
            Console.ReadLine();
            conn.Close();
            MessageBox.Show(test, "Notification", MessageBoxButtons.OK);
*/

namespace Model.Repository
{
    public class UserRepository : IRepository<User>
    {
        private DB DataContext = new DB();
        private User user;
        public int Add(User obj)
        {
            return 0;
        }

        public User Get(string username)
        {
            DataTable table = new DataTable();
            table = DataContext.Find("users", username);
            User user = new User();
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    var cells = row.ItemArray;
                    user.id = cells[0].ToString();
 //                   user.account_type = (short)cells[1];
                    user.username = cells[2].ToString();
                    user.password = cells[3].ToString();
                }
            }
            else return null;
            user.username = username;
            if (username == "admin")
            {
                user.id = "j32jf22";
                user.password = "admin"; //тут должно быть хэширование
                user.account_type = 2;
            }
            else if (username == "test")
            {
                user.id = "jfs8fds3";
                user.password = "test"; 
                user.account_type = 1;
            }
            else
            {
                user.id = "0";
            }
            return user;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
