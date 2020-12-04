namespace test_project
{
    partial class edit_timetable
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.time_txtbx = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.time_txtbx, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete_btn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // time_txtbx
            // 
            this.time_txtbx.Location = new System.Drawing.Point(3, 3);
            this.time_txtbx.Name = "time_txtbx";
            this.time_txtbx.Size = new System.Drawing.Size(229, 27);
            this.time_txtbx.TabIndex = 0;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(361, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(94, 29);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(542, 392);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(94, 29);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Отменить";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(660, 392);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 29);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(41, 392);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(167, 29);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Добавить время";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // edit_timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "edit_timetable";
            this.Text = "edit_timetable";
            this.Load += new System.EventHandler(this.edit_timetable_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox time_txtbx;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button add_btn;
    }
}