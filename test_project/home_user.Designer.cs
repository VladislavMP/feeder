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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.info_btn = new System.Windows.Forms.Button();
            this.settings_btn = new System.Windows.Forms.Button();
            this.add_feeder_btn = new System.Windows.Forms.Button();
            this.manage_timetables_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кормушка №1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кормушка №2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кормушка №3";
            // 
            // info_btn
            // 
            this.info_btn.Location = new System.Drawing.Point(264, 33);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(94, 29);
            this.info_btn.TabIndex = 3;
            this.info_btn.Text = "Инфо";
            this.info_btn.UseVisualStyleBackColor = true;
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(392, 33);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(122, 29);
            this.settings_btn.TabIndex = 4;
            this.settings_btn.Text = "Настройка";
            this.settings_btn.UseVisualStyleBackColor = true;
            // 
            // add_feeder_btn
            // 
            this.add_feeder_btn.Location = new System.Drawing.Point(34, 387);
            this.add_feeder_btn.Name = "add_feeder_btn";
            this.add_feeder_btn.Size = new System.Drawing.Size(181, 29);
            this.add_feeder_btn.TabIndex = 5;
            this.add_feeder_btn.Text = "Добавить кормушку";
            this.add_feeder_btn.UseVisualStyleBackColor = true;
            // 
            // manage_timetables_btn
            // 
            this.manage_timetables_btn.Location = new System.Drawing.Point(236, 387);
            this.manage_timetables_btn.Name = "manage_timetables_btn";
            this.manage_timetables_btn.Size = new System.Drawing.Size(218, 29);
            this.manage_timetables_btn.TabIndex = 6;
            this.manage_timetables_btn.Text = "Редактировать расписания";
            this.manage_timetables_btn.UseVisualStyleBackColor = true;
            // 
            // quit_btn
            // 
            this.quit_btn.Location = new System.Drawing.Point(666, 387);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(94, 29);
            this.quit_btn.TabIndex = 7;
            this.quit_btn.Text = "Выйти";
            this.quit_btn.UseVisualStyleBackColor = true;
            // 
            // home_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.manage_timetables_btn);
            this.Controls.Add(this.add_feeder_btn);
            this.Controls.Add(this.settings_btn);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "home_user";
            this.Text = "home_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button add_feeder_btn;
        private System.Windows.Forms.Button manage_timetables_btn;
        private System.Windows.Forms.Button quit_btn;
    }
}