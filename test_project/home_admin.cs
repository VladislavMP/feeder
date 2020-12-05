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
    public partial class home_admin : Form, Ihome_admin
    {
        public event Action Show_logout;

        private readonly ApplicationContext _context;
        public home_admin(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void home_admin_Load(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Show_logout?.Invoke();
        }
    }
}
