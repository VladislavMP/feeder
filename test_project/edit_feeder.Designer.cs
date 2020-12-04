namespace test_project
{
    partial class edit_feeder
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
            this.feeder_name_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.choose_timetable_cmbbx = new System.Windows.Forms.ComboBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feeder_name_txtbx
            // 
            this.feeder_name_txtbx.Location = new System.Drawing.Point(26, 36);
            this.feeder_name_txtbx.Name = "feeder_name_txtbx";
            this.feeder_name_txtbx.Size = new System.Drawing.Size(125, 27);
            this.feeder_name_txtbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбрать расписание";
            // 
            // choose_timetable_cmbbx
            // 
            this.choose_timetable_cmbbx.FormattingEnabled = true;
            this.choose_timetable_cmbbx.Location = new System.Drawing.Point(26, 114);
            this.choose_timetable_cmbbx.Name = "choose_timetable_cmbbx";
            this.choose_timetable_cmbbx.Size = new System.Drawing.Size(151, 28);
            this.choose_timetable_cmbbx.TabIndex = 3;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(26, 399);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(94, 29);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // edit_feeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.choose_timetable_cmbbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feeder_name_txtbx);
            this.Name = "edit_feeder";
            this.Text = "edit_feeder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox feeder_name_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox choose_timetable_cmbbx;
        private System.Windows.Forms.Button back_btn;
    }
}