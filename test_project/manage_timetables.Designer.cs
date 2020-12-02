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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.change_btn = new System.Windows.Forms.Button();
            this.toggle_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.83007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.16993F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.change_btn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.toggle_btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete_btn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.export_btn, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "<Активно?>";
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(388, 3);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(94, 29);
            this.change_btn.TabIndex = 1;
            this.change_btn.Text = "Изменить";
            this.change_btn.UseVisualStyleBackColor = true;
            // 
            // toggle_btn
            // 
            this.toggle_btn.Location = new System.Drawing.Point(247, 3);
            this.toggle_btn.Name = "toggle_btn";
            this.toggle_btn.Size = new System.Drawing.Size(94, 29);
            this.toggle_btn.TabIndex = 3;
            this.toggle_btn.Text = "Вкл/Выкл";
            this.toggle_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(608, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(94, 29);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(497, 3);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(94, 29);
            this.export_btn.TabIndex = 5;
            this.export_btn.Text = "Экспорт";
            this.export_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(40, 386);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(94, 29);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
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
            // manage_timetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "manage_timetables";
            this.Text = "manage_timetables";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button toggle_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.Button import_btn;
    }
}