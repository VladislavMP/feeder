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
    public partial class stats : Form, Istats
    {
        public event Action Show_goback;

        public stats()
        {
            InitializeComponent();
        }

        private void stats_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }

        public void DisplayStats(int feeds)
        {
            stats_label.Text = "Кормушки были активированы " + feeds + " раз.";
        }
    }
}
