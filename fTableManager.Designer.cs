using System.Windows.Forms;

namespace Quan_Li_Nha_Hang
{
    partial class fTableManager
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

        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.Ten_Mon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.So_Luong_Mon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Don_Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tong_Tien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnThem_Mon = new System.Windows.Forms.Button();
            this.cbThuc_An = new System.Windows.Forms.ComboBox();
            this.cbLoai_Mon_An = new System.Windows.Forms.ComboBox();
            this.btnThanh_Toán = new System.Windows.Forms.Button();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Total = new System.Windows.Forms.TextBox();
            this.Num_Giam_Gia = new System.Windows.Forms.NumericUpDown();
            this.btnGiam_GIa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Giam_Gia)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(533, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 361);
            this.panel2.TabIndex = 0;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ten_Mon,
            this.So_Luong_Mon,
            this.Don_Gia,
            this.Tong_Tien});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, -1);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(627, 358);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // Ten_Mon
            // 
            this.Ten_Mon.Text = "Tên Món";
            this.Ten_Mon.Width = 210;
            // 
            // So_Luong_Mon
            // 
            this.So_Luong_Mon.Text = "Số Lượng";
            this.So_Luong_Mon.Width = 80;
            // 
            // Don_Gia
            // 
            this.Don_Gia.Text = "Đơn Giá";
            this.Don_Gia.Width = 80;
            // 
            // Tong_Tien
            // 
            this.Tong_Tien.Text = "Tổng Tiền";
            this.Tong_Tien.Width = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.nmFoodCount);
            this.panel3.Controls.Add(this.btnThem_Mon);
            this.panel3.Controls.Add(this.cbThuc_An);
            this.panel3.Controls.Add(this.cbLoai_Mon_An);
            this.panel3.Location = new System.Drawing.Point(531, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 68);
            this.panel3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-531, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(524, 513);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(567, 20);
            this.nmFoodCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(52, 22);
            this.nmFoodCount.TabIndex = 0;
            // 
            // btnThem_Mon
            // 
            this.btnThem_Mon.Location = new System.Drawing.Point(476, 2);
            this.btnThem_Mon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem_Mon.Name = "btnThem_Mon";
            this.btnThem_Mon.Size = new System.Drawing.Size(81, 54);
            this.btnThem_Mon.TabIndex = 2;
            this.btnThem_Mon.Text = "Thêm Món";
            this.btnThem_Mon.UseVisualStyleBackColor = true;
            this.btnThem_Mon.Click += new System.EventHandler(this.btnThem_Mon_Click);
            // 
            // cbThuc_An
            // 
            this.cbThuc_An.FormattingEnabled = true;
            this.cbThuc_An.Location = new System.Drawing.Point(3, 33);
            this.cbThuc_An.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbThuc_An.Name = "cbThuc_An";
            this.cbThuc_An.Size = new System.Drawing.Size(263, 24);
            this.cbThuc_An.TabIndex = 1;
            // 
            // cbLoai_Mon_An
            // 
            this.cbLoai_Mon_An.DropDownHeight = 100;
            this.cbLoai_Mon_An.FormattingEnabled = true;
            this.cbLoai_Mon_An.IntegralHeight = false;
            this.cbLoai_Mon_An.ItemHeight = 16;
            this.cbLoai_Mon_An.Location = new System.Drawing.Point(3, 2);
            this.cbLoai_Mon_An.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoai_Mon_An.Name = "cbLoai_Mon_An";
            this.cbLoai_Mon_An.Size = new System.Drawing.Size(263, 24);
            this.cbLoai_Mon_An.TabIndex = 0;
            this.cbLoai_Mon_An.SelectedIndexChanged += new System.EventHandler(this.cbLoai_Mon_An_SelectedIndexChanged);
            // 
            // btnThanh_Toán
            // 
            this.btnThanh_Toán.Location = new System.Drawing.Point(493, 38);
            this.btnThanh_Toán.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanh_Toán.Name = "btnThanh_Toán";
            this.btnThanh_Toán.Size = new System.Drawing.Size(133, 31);
            this.btnThanh_Toán.TabIndex = 2;
            this.btnThanh_Toán.Text = "Thanh Toán";
            this.btnThanh_Toán.UseVisualStyleBackColor = true;
            this.btnThanh_Toán.Click += new System.EventHandler(this.btnThanh_Toán_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(0, 31);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(524, 513);
            this.flpTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.Num_Giam_Gia);
            this.panel1.Controls.Add(this.btnGiam_GIa);
            this.panel1.Controls.Add(this.btnThanh_Toán);
            this.panel1.Location = new System.Drawing.Point(533, 479);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 81);
            this.panel1.TabIndex = 1;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(493, 2);
            this.Total.Margin = new System.Windows.Forms.Padding(4);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(132, 22);
            this.Total.TabIndex = 4;
            this.Total.Text = "0";
            // 
            // Num_Giam_Gia
            // 
            this.Num_Giam_Gia.Location = new System.Drawing.Point(307, 41);
            this.Num_Giam_Gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Num_Giam_Gia.Name = "Num_Giam_Gia";
            this.Num_Giam_Gia.Size = new System.Drawing.Size(81, 22);
            this.Num_Giam_Gia.TabIndex = 3;
            this.Num_Giam_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGiam_GIa
            // 
            this.btnGiam_GIa.Location = new System.Drawing.Point(307, 2);
            this.btnGiam_GIa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiam_GIa.Name = "btnGiam_GIa";
            this.btnGiam_GIa.Size = new System.Drawing.Size(81, 31);
            this.btnGiam_GIa.TabIndex = 2;
            this.btnGiam_GIa.Text = "Giảm GIá";
            this.btnGiam_GIa.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1181, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(93, 24);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Nhà Hàng";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Giam_Gia)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbThuc_An;
        private System.Windows.Forms.ComboBox cbLoai_Mon_An;
        private System.Windows.Forms.Button btnThanh_Toán;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem_Mon;
        private System.Windows.Forms.NumericUpDown Num_Giam_Gia;
        private System.Windows.Forms.Button btnGiam_GIa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Ten_Mon;
        private System.Windows.Forms.ColumnHeader So_Luong_Mon;
        private System.Windows.Forms.ColumnHeader Don_Gia;
        private System.Windows.Forms.ColumnHeader Tong_Tien;
        private System.Windows.Forms.TextBox Total;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem1;
    }
}