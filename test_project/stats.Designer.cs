namespace test_project
{
    partial class stats
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
            this.stats_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stats_label
            // 
            this.stats_label.AutoSize = true;
            this.stats_label.Location = new System.Drawing.Point(47, 42);
            this.stats_label.Name = "stats_label";
            this.stats_label.Size = new System.Drawing.Size(142, 20);
            this.stats_label.TabIndex = 0;
            this.stats_label.Text = "Статистика текстом";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(47, 378);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(94, 29);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.stats_label);
            this.Name = "stats";
            this.Text = "stats";
            this.Load += new System.EventHandler(this.stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stats_label;
        private System.Windows.Forms.Button back_btn;
    }
}