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
    }
}
