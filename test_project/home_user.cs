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
    public partial class home_user : Form, Ihome_user
    {

        Button txtBox;
        public event Action Show_add_feeder;
        public event Action Show_manage_timetables;
        public event Action Show_logout;

        private readonly ApplicationContext _context;
        public home_user(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void home_user_Load(object sender, EventArgs e)
        {
            
        }

        private void add_feeder_btn_Click(object sender, EventArgs e)
        {
            Show_add_feeder?.Invoke();
        }

        private void manage_timetables_btn_Click(object sender, EventArgs e)
        {
            Show_manage_timetables.Invoke();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Show_logout?.Invoke();
        }

        public void display_feeder_list(List<Feeder> feederlist)
        {
            //int size = feederlist.Count;
            int size = 10;
            int i;
            List<Button> info_buttons = new List<Button>();
            for (i = 0; i < size; i++)
            {
                info_buttons.Add(new Button());
                info_buttons[i].Tag = i.ToString();
                info_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    MessageBox.Show((string)_sender.Tag);
                };
                info_buttons[i].Location = new Point(50, 50*i);
                info_buttons[i].Width = 140;
                info_buttons[i].Visible = true;
                info_buttons[i].Text = "Информация";
                Controls["feeders"].Controls.Add(info_buttons[i]);
            }
        }
    }
}
