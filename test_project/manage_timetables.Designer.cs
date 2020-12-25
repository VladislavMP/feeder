namespace test_project
{
    partial class manage_timetables
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
            this.back_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.timetables = new System.Windows.Forms.Panel();
            this.add_timetable_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(40, 386);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(94, 29);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // import_btn
            // 
            this.import_btn.Location = new System.Drawing.Point(663, 386);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(94, 29);
            this.import_btn.TabIndex = 2;
            this.import_btn.Text = "Импорт";
            this.import_btn.UseVisualStyleBackColor = true;
            // 
            // timetables
            // 
            this.timetables.AutoScroll = true;
            this.timetables.Location = new System.Drawing.Point(40, 39);
            this.timetables.Name = "timetables";
            this.timetables.Size = new System.Drawing.Size(717, 298);
            this.timetables.TabIndex = 3;
            // 
            // add_timetable_btn
            // 
            this.add_timetable_btn.Location = new System.Drawing.Point(523, 386);
            this.add_timetable_btn.Name = "add_timetable_btn";
            this.add_timetable_btn.Size = new System.Drawing.Size(94, 29);
            this.add_timetable_btn.TabIndex = 4;
            this.add_timetable_btn.Text = "Создать";
            this.add_timetable_btn.UseVisualStyleBackColor = true;
            this.add_timetable_btn.Click += new System.EventHandler(this.add_timetable_btn_Click);
            // 
            // manage_timetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_timetable_btn);
            this.Controls.Add(this.timetables);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.back_btn);
            this.Name = "manage_timetables";
            this.Text = "manage_timetables";
            this.Load += new System.EventHandler(this.manage_timetables_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.Panel timetables;
        private System.Windows.Forms.Button add_timetable_btn;
    }
}