﻿namespace test_project
{
    partial class feeder_info
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
            this.back_btn = new System.Windows.Forms.Button();
            this.check_logs_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вся информация + статистика";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(41, 388);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(94, 29);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // check_logs_btn
            // 
            this.check_logs_btn.Location = new System.Drawing.Point(599, 388);
            this.check_logs_btn.Name = "check_logs_btn";
            this.check_logs_btn.Size = new System.Drawing.Size(159, 29);
            this.check_logs_btn.TabIndex = 2;
            this.check_logs_btn.Text = "Просмотреть логи";
            this.check_logs_btn.UseVisualStyleBackColor = true;
            // 
            // feeder_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check_logs_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Name = "feeder_info";
            this.Text = "feeder_info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button check_logs_btn;
    }
}