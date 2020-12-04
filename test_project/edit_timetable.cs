using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presenter;

namespace test_project
{
    public partial class edit_timetable : Form, Iedit_timetable
    {
        private readonly ApplicationContext _context;

        public edit_timetable(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void edit_timetable_Load(object sender, EventArgs e)
        {

        }
    }
}
