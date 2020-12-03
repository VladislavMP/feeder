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
        private readonly ApplicationContext _context;
        public home_user(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void home_user_Load(object sender, EventArgs e)
        {

        }
    }
}
