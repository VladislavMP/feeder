using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test_project
{
    public partial class feeder_info : Form, Ifeeder_info
    {
        public feeder_info()
        {
            InitializeComponent();
        }

        public event Action Show_goback;

        private void feeder_info_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }

        public void Display_info(string name, string id, string timetable)
        {
            feeder_info_label.Text = "Имя кормушки : " + name + "\n" + "Идентификатор кормушки: " + id + "\n" + "Активное расписание: " + timetable;
        }
    }
}
