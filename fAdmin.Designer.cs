namespace Quan_Li_Nha_Hang
{
    partial class fAdmin
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Admin = new System.Windows.Forms.TabControl();
            this.tabDoanh_Thu = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThong_Ke = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabThuc_An = new System.Windows.Forms.TabPage();
            this.tabDanh_Muc = new System.Windows.Forms.TabPage();
            this.tabBan_An = new System.Windows.Forms.TabPage();
            this.tabTai_Khoan = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.Admin.SuspendLayout();
            this.tabDoanh_Thu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.tabDoanh_Thu);
            this.Admin.Controls.Add(this.tabThuc_An);
            this.Admin.Controls.Add(this.tabDanh_Muc);
            this.Admin.Controls.Add(this.tabBan_An);
            this.Admin.Controls.Add(this.tabTai_Khoan);
            this.Admin.Location = new System.Drawing.Point(0, 0);
            this.Admin.Name = "Admin";
            this.Admin.SelectedIndex = 0;
            this.Admin.Size = new System.Drawing.Size(963, 561);
            this.Admin.TabIndex = 0;
            // 
            // tabDoanh_Thu
            // 
            this.tabDoanh_Thu.Controls.Add(this.panel2);
            this.tabDoanh_Thu.Controls.Add(this.panel1);
            this.tabDoanh_Thu.Location = new System.Drawing.Point(4, 25);
            this.tabDoanh_Thu.Name = "tabDoanh_Thu";
            this.tabDoanh_Thu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanh_Thu.Size = new System.Drawing.Size(955, 532);
            this.tabDoanh_Thu.TabIndex = 0;
            this.tabDoanh_Thu.Text = "Doanh Thu";
            this.tabDoanh_Thu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThong_Ke);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 31);
            this.panel2.TabIndex = 1;
            // 
            // btnThong_Ke
            // 
            this.btnThong_Ke.Location = new System.Drawing.Point(416, -1);
            this.btnThong_Ke.Name = "btnThong_Ke";
            this.btnThong_Ke.Size = new System.Drawing.Size(110, 29);
            this.btnThong_Ke.TabIndex = 1;
            this.btnThong_Ke.Text = "Thống Kê";
            this.btnThong_Ke.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(690, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(8, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 466);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 466);
            this.dataGridView1.TabIndex = 2;
            // 
            // tabThuc_An
            // 
            this.tabThuc_An.Location = new System.Drawing.Point(4, 25);
            this.tabThuc_An.Name = "tabThuc_An";
            this.tabThuc_An.Padding = new System.Windows.Forms.Padding(3);
            this.tabThuc_An.Size = new System.Drawing.Size(955, 532);
            this.tabThuc_An.TabIndex = 1;
            this.tabThuc_An.Text = "Thức Ăn";
            this.tabThuc_An.UseVisualStyleBackColor = true;
            // 
            // tabDanh_Muc
            // 
            this.tabDanh_Muc.Location = new System.Drawing.Point(4, 25);
            this.tabDanh_Muc.Name = "tabDanh_Muc";
            this.tabDanh_Muc.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanh_Muc.Size = new System.Drawing.Size(955, 532);
            this.tabDanh_Muc.TabIndex = 2;
            this.tabDanh_Muc.Text = "Danh Mục";
            this.tabDanh_Muc.UseVisualStyleBackColor = true;
            // 
            // tabBan_An
            // 
            this.tabBan_An.Location = new System.Drawing.Point(4, 25);
            this.tabBan_An.Name = "tabBan_An";
            this.tabBan_An.Padding = new System.Windows.Forms.Padding(3);
            this.tabBan_An.Size = new System.Drawing.Size(955, 532);
            this.tabBan_An.TabIndex = 3;
            this.tabBan_An.Text = "Ban_An";
            this.tabBan_An.UseVisualStyleBackColor = true;
            // 
            // tabTai_Khoan
            // 
            this.tabTai_Khoan.Location = new System.Drawing.Point(4, 25);
            this.tabTai_Khoan.Name = "tabTai_Khoan";
            this.tabTai_Khoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabTai_Khoan.Size = new System.Drawing.Size(955, 532);
            this.tabTai_Khoan.TabIndex = 4;
            this.tabTai_Khoan.Text = "Tài Khoản";
            this.tabTai_Khoan.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 556);
            this.Controls.Add(this.Admin);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.Admin.ResumeLayout(false);
            this.tabDoanh_Thu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.TabControl Admin;
        private System.Windows.Forms.TabPage tabDoanh_Thu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabThuc_An;
        private System.Windows.Forms.TabPage tabDanh_Muc;
        private System.Windows.Forms.TabPage tabBan_An;
        private System.Windows.Forms.TabPage tabTai_Khoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThong_Ke;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}