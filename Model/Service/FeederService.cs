using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Model.Service
{
    public class FeederService : IFeederService
    {
        private IRepository<Timetable> _repository; // !!!!!!!! WRONG REPOSITORY !!!!!!! ONLY FOR DEMONSTRATION PURPOSES !!!!!!!
        public FeederService(IRepository<Timetable> repository)
        {
            _repository = repository;
        }

        public void Add_feeder(string id)
        {
            if (id == "realid") //проверяем наличие кормушки в базе
            {
                string message = "Feeder with id = \"" + id + "\" is linked to your account.";
                MessageBox.Show(message, "Notification", MessageBoxButtons.OK);
            }
            else
            {
                string message = "Feeder with id = \"" + id + "\" is not defined.";
                MessageBox.Show(message, "Failed", MessageBoxButtons.OK);
            }
        }
    }
}
