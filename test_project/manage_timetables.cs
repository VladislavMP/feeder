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
    public partial class manage_timetables : Form, Imanage_timetables
    {
        private readonly ApplicationContext _context;
        public event Action Show_goback;

        public manage_timetables(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void manage_timetables_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }
    }
}
