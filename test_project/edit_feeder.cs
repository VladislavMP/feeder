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

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }

        private void edit_feeder_Load(object sender, EventArgs e)
        {

        }
    }
}
