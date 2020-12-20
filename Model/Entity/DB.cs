using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Model.Entity
{
    class DB
    {
        public MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=feeder_db;");
        public MySqlDataAdapter ad;

        public DB()
        {
            this.conn = new MySqlConnection("server=localhost;user=root;password=root;database=feeder_db;");
            this.ad = new MySqlDataAdapter();
        }

        public DataTable Find(string t, string c)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + t + " WHERE " + c, conn);
            DataTable table = new DataTable();
            ad.SelectCommand = command;
            ad.Fill(table);
            return table;
        }
    }
}
