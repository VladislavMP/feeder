namespace test_project
{
    partial class home_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Manage_feeder_ids_btn = new System.Windows.Forms.Button();
            this.Stats_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Manage_feeder_ids_btn
            // 
            this.Manage_feeder_ids_btn.Location = new System.Drawing.Point(43, 380);
            this.Manage_feeder_ids_btn.Name = "Manage_feeder_ids_btn";
            this.Manage_feeder_ids_btn.Size = new System.Drawing.Size(256, 29);
            this.Manage_feeder_ids_btn.TabIndex = 4;
            this.Manage_feeder_ids_btn.Text = "Управление кормушками";
            this.Manage_feeder_ids_btn.UseVisualStyleBackColor = true;
            this.Manage_feeder_ids_btn.Click += new System.EventHandler(this.Manage_feeder_ids_btn_Click);
            // 
            // Stats_btn
            // 
            this.Stats_btn.Location = new System.Drawing.Point(566, 380);
            this.Stats_btn.Name = "Stats_btn";
            this.Stats_btn.Size = new System.Drawing.Size(94, 29);
            this.Stats_btn.TabIndex = 6;
            this.Stats_btn.Text = "Статистика";
            this.Stats_btn.UseVisualStyleBackColor = true;
            this.Stats_btn.Click += new System.EventHandler(this.Stats_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Location = new System.Drawing.Point(677, 380);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(94, 29);
            this.Logout_btn.TabIndex = 7;
            this.Logout_btn.Text = "Выйти";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // users
            // 
            this.users.AutoScroll = true;
            this.users.Location = new System.Drawing.Point(43, 48);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(728, 291);
            this.users.TabIndex = 8;
            // 
            // home_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.users);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Stats_btn);
            this.Controls.Add(this.Manage_feeder_ids_btn);
            this.Name = "home_admin";
            this.Text = "home_admin";
            this.Load += new System.EventHandler(this.home_admin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Manage_feeder_ids_btn;
        private System.Windows.Forms.Button Stats_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Panel users;
    }
}