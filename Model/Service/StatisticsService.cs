using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
namespace Model.Service
{
    public class StatisticsService
    {
        private DB DataBase = new DB();
        public void Save()
        {
            DataBase.Update("statistics", "stats = '" + Statistics.feeding_counter.ToString() +"'", "id = 1");
        }
        public void Get()
        {
            DataTable table = new DataTable();
            table = DataBase.GetAll("statistics");
            var cell = table.Rows[0].ItemArray;
            Statistics.feeding_counter = (int)cell[0];
        }
    }
}
