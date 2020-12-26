﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model.Entity;
using Presenter;
using Sim;

namespace test_project
{
    public partial class feeder_id_list : Form, Ifeeder_id_list
    {
        public feeder_id_list()
        {
            InitializeComponent();
        }

        public event Action Show_goback;
        public event Action<string> Add_feeder;
        public event Action<string> Remove_feeder;
        public event Action<string> Show_feeder_info;

        private void feeder_id_list_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Show_goback?.Invoke();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Add_feeder?.Invoke(feeder_id_txtbx.Text);
        }

        public void display_GLOBAL_feeder_list(List<Feeder> GLOBAL_feederlist)
        {

            Controls["feeder_ids"].Controls.Clear();

            if (GLOBAL_feederlist == null) return;
            int size = GLOBAL_feederlist.Count;

            int i;

            List<Button> remove_buttons = new List<Button>();
            List<Button> info_buttons = new List<Button>();
            //List<Label> feeder_names = new List<Label>();
            List<Label> feeder_ids = new List<Label>();
            List<Label> feeder_owners = new List<Label>();

            for (i = 0; i < size; i++)
            {
                remove_buttons.Add(new Button());
                remove_buttons[i].Tag = GLOBAL_feederlist[i].Feeder_id;
                remove_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    Remove_feeder?.Invoke((string)_sender.Tag);
                };
                remove_buttons[i].Location = new Point(320, 35 * i);
                remove_buttons[i].Width = 80;
                remove_buttons[i].Visible = true;
                remove_buttons[i].Text = "Удалить";
                Controls["feeder_ids"].Controls.Add(remove_buttons[i]);

                info_buttons.Add(new Button());
                info_buttons[i].Tag = GLOBAL_feederlist[i].Feeder_id;
                info_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    Show_feeder_info?.Invoke((string)_sender.Tag);
                };
                info_buttons[i].Location = new Point(420, 35 * i);
                info_buttons[i].Width = 80;
                info_buttons[i].Visible = true;
                info_buttons[i].Text = "Инфо";
                Controls["feeder_ids"].Controls.Add(info_buttons[i]);


                /*feeder_names.Add(new Label());
                feeder_names[i].Location = new Point(0, 35 * i);
                feeder_names[i].Width = 100;
                feeder_names[i].Visible = true;
                feeder_names[i].Text = GLOBAL_feederlist[i].Name;
                Controls["feeder_ids"].Controls.Add(feeder_names[i]);*/

                feeder_ids.Add(new Label());
                feeder_ids[i].Location = new Point(0, 35 * i);
                feeder_ids[i].Width = 140;
                feeder_ids[i].Visible = true;
                feeder_ids[i].Text = GLOBAL_feederlist[i].Feeder_id;
                Controls["feeder_ids"].Controls.Add(feeder_ids[i]);

                feeder_owners.Add(new Label());
                feeder_owners[i].Location = new Point(160, 35 * i);
                feeder_owners[i].Width = 140;
                feeder_owners[i].Visible = true;
                feeder_owners[i].Text = GLOBAL_feederlist[i].User_id;
                Controls["feeder_ids"].Controls.Add(feeder_owners[i]);
            }
        }

        public void UpdateSim()
        {
            TestSim.Refresh();
        }
    }
}
