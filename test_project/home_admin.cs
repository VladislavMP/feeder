using Model.Entity;
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
        public event Action Show_feeder_id_list;
        public event Action<string> Remove_user;
        public event Action Show_global_stats;

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

        private void Manage_feeder_ids_btn_Click(object sender, EventArgs e)
        {
            Show_feeder_id_list?.Invoke();
        }

        public void Display_user_list(List<User> userlist)
        {
            Controls["users"].Controls.Clear();
            int i, size = userlist.Count;

            List<Button> remove_buttons = new List<Button>();
            List<Label> user_names = new List<Label>();
            List<Label> user_pass_hash = new List<Label>();
            List<Label> user_pass_salt = new List<Label>();

            for (i = 0; i < size; i++)
            {
                if (userlist[i].account_type == 2)
                {
                    userlist.RemoveAt(i);
                    size--;
                }
            }

            for (i = 0; i < size; i++)
            {
                user_names.Add(new Label());
                user_names[i].Location = new Point(0, 35 * i);
                user_names[i].Width = 100;
                user_names[i].Visible = true;
                user_names[i].Text = userlist[i].username;
                Controls["users"].Controls.Add(user_names[i]);

                user_pass_hash.Add(new Label());
                user_pass_hash[i].Location = new Point(100, 35 * i);
                user_pass_hash[i].Width = 100;
                user_pass_hash[i].Visible = true;
                user_pass_hash[i].Text = userlist[i].password_hash;
                Controls["users"].Controls.Add(user_pass_hash[i]);

                user_pass_salt.Add(new Label());
                user_pass_salt[i].Location = new Point(200, 35 * i);
                user_pass_salt[i].Width = 100;
                user_pass_salt[i].Visible = true;
                user_pass_salt[i].Text = userlist[i].password_salt;
                Controls["users"].Controls.Add(user_pass_salt[i]);

                remove_buttons.Add(new Button());
                remove_buttons[i].Tag = userlist[i].username;
                remove_buttons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    Remove_user.Invoke((string)_sender.Tag);
                    //MessageBox.Show((string)_sender.Tag);
                };
                remove_buttons[i].Location = new Point(400, 35 * i);
                remove_buttons[i].Width = 80;
                remove_buttons[i].Visible = true;
                remove_buttons[i].Text = "Удалить";
                Controls["users"].Controls.Add(remove_buttons[i]);


            }
        }

        private void Stats_btn_Click(object sender, EventArgs e)
        {
            Show_global_stats?.Invoke();
        }
    }
}
