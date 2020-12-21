namespace test_project
{
    partial class home_user
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
            this.add_feeder_btn = new System.Windows.Forms.Button();
            this.manage_timetables_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.feeders = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // add_feeder_btn
            // 
            this.add_feeder_btn.Location = new System.Drawing.Point(34, 387);
            this.add_feeder_btn.Name = "add_feeder_btn";
            this.add_feeder_btn.Size = new System.Drawing.Size(181, 29);
            this.add_feeder_btn.TabIndex = 5;
            this.add_feeder_btn.Text = "Добавить кормушку";
            this.add_feeder_btn.UseVisualStyleBackColor = true;
            this.add_feeder_btn.Click += new System.EventHandler(this.add_feeder_btn_Click);
            // 
            // manage_timetables_btn
            // 
            this.manage_timetables_btn.Location = new System.Drawing.Point(236, 387);
            this.manage_timetables_btn.Name = "manage_timetables_btn";
            this.manage_timetables_btn.Size = new System.Drawing.Size(218, 29);
            this.manage_timetables_btn.TabIndex = 6;
            this.manage_timetables_btn.Text = "Редактировать расписания";
            this.manage_timetables_btn.UseVisualStyleBackColor = true;
            this.manage_timetables_btn.Click += new System.EventHandler(this.manage_timetables_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.Location = new System.Drawing.Point(666, 387);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(94, 29);
            this.quit_btn.TabIndex = 7;
            this.quit_btn.Tag = "";
            this.quit_btn.Text = "Выйти";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // feeders
            // 
            this.feeders.AutoScroll = true;
            this.feeders.Location = new System.Drawing.Point(34, 39);
            this.feeders.Name = "feeders";
            this.feeders.Size = new System.Drawing.Size(726, 302);
            this.feeders.TabIndex = 8;
            // 
            // home_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.feeders);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.manage_timetables_btn);
            this.Controls.Add(this.add_feeder_btn);
            this.Name = "home_user";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_user_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button add_feeder_btn;
        private System.Windows.Forms.Button manage_timetables_btn;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Panel feeders;
    }
}