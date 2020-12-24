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
    public partial class reg_screen : Form, Ireg_screen
    {
        private readonly ApplicationContext _context;

        public event Action Show_login_screen;
        public event Action<string, string, string> Show_register;

        public reg_screen(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void reg_screen_Load(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Show_register?.Invoke(username_txtbx.Text, password_txtbx.Text, confirm_password_txtbx.Text);
        }

        private void have_account_btn_Click(object sender, EventArgs e)
        {
            Show_login_screen?.Invoke();
        }
    }
}
