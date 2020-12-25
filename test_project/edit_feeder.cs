using Model.Entity;
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
    public partial class edit_feeder : Form, Iedit_feeder
    {
        private readonly ApplicationContext _context;

        public edit_feeder(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event Action Show_goback;
        public event Action<string, string> Save;
        public List<string> ids = new List<string>();

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }

        private void edit_feeder_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Save?.Invoke(feeder_name_txtbx.Text, ids[choose_timetable_cmbbx.SelectedIndex]);
        }

        private void choose_timetable_cmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           // choose_timetable_cmbbx.Items.Add
        }

        

        public void Load_existing_data(List<Timetable> timetablelist, string name, string timetable_id)
        {
            feeder_name_txtbx.Text = name;
            int size = timetablelist.Count;
            int i;
            

            choose_timetable_cmbbx.Items.Add("-//-");
            ids.Add("");
            choose_timetable_cmbbx.SelectedIndex = 0;

            for (i = 1; i < size + 1; i ++)
            {
                choose_timetable_cmbbx.Items.Add(timetablelist[i-1].name);
                ids.Add(timetablelist[i-1].TimetableId);
                if (timetablelist[i - 1].TimetableId == timetable_id) choose_timetable_cmbbx.SelectedIndex = i;
            }

        }

        public void Display_save_result(short save_result)
        {
            switch (save_result)
            {
                case 0:
                    MessageBox.Show("Сохранение успешно.");
                    break;
                case 1:
                    MessageBox.Show("Имя кормушки не может быть пустым.");
                    break;
            }
        }
    }
}
