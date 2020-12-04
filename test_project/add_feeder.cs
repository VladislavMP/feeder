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
    public partial class add_feeder : Form, Iadd_feeder
    {
        public event Action Show_goback;
        private readonly ApplicationContext _context;
        public add_feeder(ApplicationContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void add_feeder_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }
    }
}
