using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model.Entity;
using Presenter;

namespace test_project
{
    public partial class edit_timetable : Form, Iedit_timetable
    {
        private readonly ApplicationContext _context;
        public event Action Show_goback;
        public event Action<List<Time>, string> Show_save_goback;

        public List<Time> loaded_timestamps;

        public edit_timetable(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void display_timestamp_list(List<Time> timestamps)
        {
            Controls["timestamps"].Controls.Clear();

            loaded_timestamps = timestamps;

            if (timestamps == null) return;
            int size = timestamps.Count;

            int i;
            List<TextBox> time_textboxes = new List<TextBox>();
            List<Button> remove_buttons = new List<Button>();

            for (i = 0; i < size; i++)
            {
                time_textboxes.Add(new TextBox());
                time_textboxes[i].Tag = i;
                time_textboxes[i].TextChanged += (sender, e) =>
                {
                    TextBox _sender = (TextBox)sender;
                    loaded_timestamps[(int)_sender.Tag].TimeHMS = _sender.Text;
                };
                time_textboxes[i].Location = new Point(50, 50 * i);
                time_textboxes[i].Width = 80;
                time_textboxes[i].Visible = true;
                time_textboxes[i].Text = timestamps[i].TimeHMS;
                Controls["timestamps"].Controls.Add(time_textboxes[i]);


                remove_buttons.Add(new Button());
                remove_buttons[i].Tag = i;
                remove_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    loaded_timestamps.RemoveAt((int)_sender.Tag);
                    display_timestamp_list(loaded_timestamps);
                };
                remove_buttons[i].Location = new Point(180, 50 * i);
                remove_buttons[i].Width = 80;
                remove_buttons[i].Visible = true;
                remove_buttons[i].Text = "Удалить";
                Controls["timestamps"].Controls.Add(remove_buttons[i]);
            }

        }

        private void edit_timetable_Load(object sender, EventArgs e)
        {
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Time timestamp = new Time();
            loaded_timestamps.Add(timestamp);
            display_timestamp_list(loaded_timestamps);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Show_save_goback?.Invoke(loaded_timestamps, timetable_name_txtbx.Text);
        }

        public void load_timetable_name(string name)
        {
            timetable_name_txtbx.Text = name;
        }

        public void display_save_timetable_response(short save_timetable_response)
        {
            switch (save_timetable_response)
            {
                case 0:
                    MessageBox.Show("Расписание успешно сохранено.");
                    break;
                case 1:
                    MessageBox.Show("Название расписания не может быть пустым.");
                    break;
                case 2:
                    MessageBox.Show("Допущена ошибка в формате времени. Используйте формат 'HH:MM' , где HH — часы, а MM — минуты.");
                    break;
            }
        }
    }
}
