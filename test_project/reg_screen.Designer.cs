namespace test_project
{
    partial class reg_screen
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
            this.register_btn = new System.Windows.Forms.Button();
            this.username_txtbx = new System.Windows.Forms.TextBox();
            this.password_txtbx = new System.Windows.Forms.TextBox();
            this.confirm_password_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.have_account_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(51, 338);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(173, 29);
            this.register_btn.TabIndex = 0;
            this.register_btn.Text = "Зарегистрироваться";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // username_txtbx
            // 
            this.username_txtbx.Location = new System.Drawing.Point(51, 83);
            this.username_txtbx.Name = "username_txtbx";
            this.username_txtbx.Size = new System.Drawing.Size(125, 27);
            this.username_txtbx.TabIndex = 1;
            // 
            // password_txtbx
            // 
            this.password_txtbx.Location = new System.Drawing.Point(51, 161);
            this.password_txtbx.Name = "password_txtbx";
            this.password_txtbx.Size = new System.Drawing.Size(125, 27);
            this.password_txtbx.TabIndex = 2;
            // 
            // confirm_password_txtbx
            // 
            this.confirm_password_txtbx.Location = new System.Drawing.Point(51, 235);
            this.confirm_password_txtbx.Name = "confirm_password_txtbx";
            this.confirm_password_txtbx.Size = new System.Drawing.Size(125, 27);
            this.confirm_password_txtbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Повторите пароль";
            // 
            // have_account_btn
            // 
            this.have_account_btn.Location = new System.Drawing.Point(260, 338);
            this.have_account_btn.Name = "have_account_btn";
            this.have_account_btn.Size = new System.Drawing.Size(175, 29);
            this.have_account_btn.TabIndex = 7;
            this.have_account_btn.Text = "Есть аккаунт?";
            this.have_account_btn.UseVisualStyleBackColor = true;
            this.have_account_btn.Click += new System.EventHandler(this.have_account_btn_Click);
            // 
            // reg_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 429);
            this.Controls.Add(this.have_account_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm_password_txtbx);
            this.Controls.Add(this.password_txtbx);
            this.Controls.Add(this.username_txtbx);
            this.Controls.Add(this.register_btn);
            this.Name = "reg_screen";
            this.Text = "reg_screen";
            this.Load += new System.EventHandler(this.reg_screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.TextBox confirm_password_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button have_account_btn;
    }
}