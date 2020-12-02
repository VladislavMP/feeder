namespace test_project
{
    partial class add_feeder
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
            this.add_feeder_txtbx = new System.Windows.Forms.TextBox();
            this.add_feeder_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_feeder_txtbx
            // 
            this.add_feeder_txtbx.Location = new System.Drawing.Point(26, 28);
            this.add_feeder_txtbx.Name = "add_feeder_txtbx";
            this.add_feeder_txtbx.Size = new System.Drawing.Size(145, 27);
            this.add_feeder_txtbx.TabIndex = 0;
            // 
            // add_feeder_btn
            // 
            this.add_feeder_btn.Location = new System.Drawing.Point(190, 28);
            this.add_feeder_btn.Name = "add_feeder_btn";
            this.add_feeder_btn.Size = new System.Drawing.Size(94, 29);
            this.add_feeder_btn.TabIndex = 1;
            this.add_feeder_btn.Text = "Добавить";
            this.add_feeder_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(26, 403);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(94, 29);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // add_feeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.add_feeder_btn);
            this.Controls.Add(this.add_feeder_txtbx);
            this.Name = "add_feeder";
            this.Text = "add_feeder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_feeder_txtbx;
        private System.Windows.Forms.Button add_feeder_btn;
        private System.Windows.Forms.Button back_btn;
    }
}