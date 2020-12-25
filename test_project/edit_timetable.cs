﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model.Entity;
using Presenter;

namespace test_project
{
    public partial class edit_timetable : Form, Iedit_timetable
    {
        private readonly ApplicationContext _context;

        public event Action<string> Remove_timestamp;

        public edit_timetable(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void display_timestamp_list(Timetable timetable)
        {
            List <Time> timestamps = timetable.TimeOfFeed;

            if (timestamps == null) return;
            int size = timestamps.Count;

            int i;
            List<TextBox> time_textboxes = new List<TextBox>();
            List<Button> remove_buttons = new List<Button>();

            for (i = 0; i < size; i++)
            {

                remove_buttons.Add(new Button());
                remove_buttons[i].Tag = timestamps[i].Id;
                remove_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    Remove_timestamp?.Invoke((string)_sender.Tag);
                };
                remove_buttons[i].Location = new Point(180, 50 * i);
                remove_buttons[i].Width = 80;
                remove_buttons[i].Visible = true;
                remove_buttons[i].Text = "Удалить";
                Controls["timestamps"].Controls.Add(remove_buttons[i]);
            }

        }

        private void edit_timetable_Load(object sender, EventArgs e)
        {

        }
    }
}
