﻿namespace test_project
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.timestamps = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            // timestamps
            // 
            this.timestamps.AutoScroll = true;
            this.timestamps.Location = new System.Drawing.Point(41, 41);
            this.timestamps.Name = "timestamps";
            this.timestamps.Size = new System.Drawing.Size(713, 319);
            this.timestamps.TabIndex = 4;
            // 
            // edit_timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timestamps);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.cancel_btn);
            this.Name = "edit_timetable";
            this.Text = "edit_timetable";
            this.Load += new System.EventHandler(this.edit_timetable_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel timestamps;
    }
}