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
            this.TimeNow = new System.Windows.Forms.DateTimePicker();
            this.Time = new System.Windows.Forms.Label();
            this.Ban = new System.Windows.Forms.Label();
            this.txtBan = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnThem_Mon = new System.Windows.Forms.Button();
            this.cbLoai_Mon_An = new System.Windows.Forms.ComboBox();
            this.btnThanh_Toán = new System.Windows.Forms.Button();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalSauKM = new System.Windows.Forms.TextBox();
            this.SauKM = new System.Windows.Forms.Label();
            this.TruocKM = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.Ten = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvListFoodBaseCategory = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGiaHienTai = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.GiaHienTai = new System.Windows.Forms.Label();
            this.TinhTrang = new System.Windows.Forms.Label();
            this.TenMon = new System.Windows.Forms.Label();
            this.QuanLiBan = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPTG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFoodBaseCategory)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(363, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 319);
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
            this.lsvBill.Location = new System.Drawing.Point(0, -3);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(475, 322);
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
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.TimeNow);
            this.panel3.Controls.Add(this.Time);
            this.panel3.Controls.Add(this.Ban);
            this.panel3.Controls.Add(this.txtBan);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(363, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 55);
            this.panel3.TabIndex = 0;
            // 
            // TimeNow
            // 
            this.TimeNow.Enabled = false;
            this.TimeNow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeNow.Location = new System.Drawing.Point(228, 24);
            this.TimeNow.Name = "TimeNow";
            this.TimeNow.Size = new System.Drawing.Size(245, 22);
            this.TimeNow.TabIndex = 4;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(315, 5);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(72, 17);
            this.Time.TabIndex = 3;
            this.Time.Text = "Thời Gian";
            // 
            // Ban
            // 
            this.Ban.AutoSize = true;
            this.Ban.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ban.Location = new System.Drawing.Point(54, 5);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(34, 17);
            this.Ban.TabIndex = 2;
            this.Ban.Text = "Bàn";
            // 
            // txtBan
            // 
            this.txtBan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBan.Location = new System.Drawing.Point(3, 25);
            this.txtBan.Name = "txtBan";
            this.txtBan.ReadOnly = true;
            this.txtBan.Size = new System.Drawing.Size(142, 25);
            this.txtBan.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-398, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(393, 417);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFoodCount.Location = new System.Drawing.Point(283, 22);
            this.nmFoodCount.Margin = new System.Windows.Forms.Padding(2);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(58, 29);
            this.nmFoodCount.TabIndex = 0;
            // 
            // btnThem_Mon
            // 
            this.btnThem_Mon.Location = new System.Drawing.Point(283, 75);
            this.btnThem_Mon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem_Mon.Name = "btnThem_Mon";
            this.btnThem_Mon.Size = new System.Drawing.Size(58, 44);
            this.btnThem_Mon.TabIndex = 2;
            this.btnThem_Mon.Text = "Thêm Món";
            this.btnThem_Mon.UseVisualStyleBackColor = true;
            this.btnThem_Mon.Click += new System.EventHandler(this.btnThem_Mon_Click);
            // 
            // cbLoai_Mon_An
            // 
            this.cbLoai_Mon_An.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLoai_Mon_An.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLoai_Mon_An.DropDownHeight = 100;
            this.cbLoai_Mon_An.FormattingEnabled = true;
            this.cbLoai_Mon_An.IntegralHeight = false;
            this.cbLoai_Mon_An.ItemHeight = 13;
            this.cbLoai_Mon_An.Location = new System.Drawing.Point(0, 28);
            this.cbLoai_Mon_An.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoai_Mon_An.Name = "cbLoai_Mon_An";
            this.cbLoai_Mon_An.Size = new System.Drawing.Size(338, 21);
            this.cbLoai_Mon_An.TabIndex = 0;
            this.cbLoai_Mon_An.SelectedIndexChanged += new System.EventHandler(this.cbLoai_Mon_An_SelectedIndexChanged);
            // 
            // btnThanh_Toán
            // 
            this.btnThanh_Toán.Location = new System.Drawing.Point(101, 2);
            this.btnThanh_Toán.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanh_Toán.Name = "btnThanh_Toán";
            this.btnThanh_Toán.Size = new System.Drawing.Size(183, 79);
            this.btnThanh_Toán.TabIndex = 2;
            this.btnThanh_Toán.Text = "Thanh Toán";
            this.btnThanh_Toán.UseVisualStyleBackColor = true;
            this.btnThanh_Toán.Click += new System.EventHandler(this.btnThanh_Toán_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flpTable.Location = new System.Drawing.Point(844, 89);
            this.flpTable.Margin = new System.Windows.Forms.Padding(2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(300, 367);
            this.flpTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.TotalSauKM);
            this.panel1.Controls.Add(this.SauKM);
            this.panel1.Controls.Add(this.TruocKM);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenKhach);
            this.panel1.Controls.Add(this.SDT);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.Ten);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Location = new System.Drawing.Point(363, 417);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 125);
            this.panel1.TabIndex = 1;
            // 
            // TotalSauKM
            // 
            this.TotalSauKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSauKM.Location = new System.Drawing.Point(297, 93);
            this.TotalSauKM.Name = "TotalSauKM";
            this.TotalSauKM.ReadOnly = true;
            this.TotalSauKM.Size = new System.Drawing.Size(169, 29);
            this.TotalSauKM.TabIndex = 4;
            this.TotalSauKM.Text = "0";
            // 
            // SauKM
            // 
            this.SauKM.AutoSize = true;
            this.SauKM.BackColor = System.Drawing.Color.Yellow;
            this.SauKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SauKM.Location = new System.Drawing.Point(320, 69);
            this.SauKM.Name = "SauKM";
            this.SauKM.Size = new System.Drawing.Size(122, 19);
            this.SauKM.TabIndex = 6;
            this.SauKM.Text = "Sau Khuyến Mãi";
            // 
            // TruocKM
            // 
            this.TruocKM.AutoSize = true;
            this.TruocKM.BackColor = System.Drawing.Color.Yellow;
            this.TruocKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TruocKM.Location = new System.Drawing.Point(314, 4);
            this.TruocKM.Name = "TruocKM";
            this.TruocKM.Size = new System.Drawing.Size(138, 19);
            this.TruocKM.TabIndex = 6;
            this.TruocKM.Text = "Trước Khuyến Mãi";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(100, 102);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 38);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(191, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(100, 6);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(191, 20);
            this.txtTenKhach.TabIndex = 5;
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT.Location = new System.Drawing.Point(3, 107);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(94, 15);
            this.SDT.TabIndex = 2;
            this.SDT.Text = "Số Điện Thoại : ";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(3, 75);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(44, 15);
            this.Email.TabIndex = 2;
            this.Email.Text = "Emai : ";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(3, 43);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(59, 15);
            this.address.TabIndex = 2;
            this.address.Text = "Địa Chỉ : ";
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.Location = new System.Drawing.Point(3, 11);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(76, 15);
            this.Ten.TabIndex = 2;
            this.Ten.Text = "Tên Khách : ";
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(297, 30);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(169, 29);
            this.Total.TabIndex = 4;
            this.Total.Text = "0";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvListFoodBaseCategory);
            this.panel4.Location = new System.Drawing.Point(11, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 322);
            this.panel4.TabIndex = 1;
            // 
            // dgvListFoodBaseCategory
            // 
            this.dgvListFoodBaseCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFoodBaseCategory.Location = new System.Drawing.Point(6, 3);
            this.dgvListFoodBaseCategory.MultiSelect = false;
            this.dgvListFoodBaseCategory.Name = "dgvListFoodBaseCategory";
            this.dgvListFoodBaseCategory.ReadOnly = true;
            this.dgvListFoodBaseCategory.RowHeadersWidth = 51;
            this.dgvListFoodBaseCategory.Size = new System.Drawing.Size(339, 319);
            this.dgvListFoodBaseCategory.TabIndex = 0;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(130, 5);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(67, 17);
            this.Category.TabIndex = 2;
            this.Category.Text = "Tên Loại";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PowderBlue;
            this.panel5.Controls.Add(this.nmFoodCount);
            this.panel5.Controls.Add(this.btnThem_Mon);
            this.panel5.Controls.Add(this.txtGiaHienTai);
            this.panel5.Controls.Add(this.txtTinhTrang);
            this.panel5.Controls.Add(this.txtTenMon);
            this.panel5.Controls.Add(this.GiaHienTai);
            this.panel5.Controls.Add(this.TinhTrang);
            this.panel5.Controls.Add(this.TenMon);
            this.panel5.Location = new System.Drawing.Point(12, 417);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(343, 125);
            this.panel5.TabIndex = 3;
            // 
            // txtGiaHienTai
            // 
            this.txtGiaHienTai.Location = new System.Drawing.Point(90, 99);
            this.txtGiaHienTai.Name = "txtGiaHienTai";
            this.txtGiaHienTai.ReadOnly = true;
            this.txtGiaHienTai.Size = new System.Drawing.Size(188, 20);
            this.txtGiaHienTai.TabIndex = 1;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(90, 57);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(188, 20);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(90, 11);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(188, 20);
            this.txtTenMon.TabIndex = 1;
            // 
            // GiaHienTai
            // 
            this.GiaHienTai.AutoSize = true;
            this.GiaHienTai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaHienTai.Location = new System.Drawing.Point(3, 101);
            this.GiaHienTai.Name = "GiaHienTai";
            this.GiaHienTai.Size = new System.Drawing.Size(83, 15);
            this.GiaHienTai.TabIndex = 0;
            this.GiaHienTai.Text = "Giá Hiện Tại :";
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSize = true;
            this.TinhTrang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTrang.Location = new System.Drawing.Point(2, 59);
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Size = new System.Drawing.Size(76, 15);
            this.TinhTrang.TabIndex = 0;
            this.TinhTrang.Text = "Tình Trạng :";
            // 
            // TenMon
            // 
            this.TenMon.AutoSize = true;
            this.TenMon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenMon.Location = new System.Drawing.Point(3, 13);
            this.TenMon.Name = "TenMon";
            this.TenMon.Size = new System.Drawing.Size(62, 15);
            this.TenMon.TabIndex = 0;
            this.TenMon.Text = "Tên Món :";
            // 
            // QuanLiBan
            // 
            this.QuanLiBan.AutoSize = true;
            this.QuanLiBan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLiBan.ForeColor = System.Drawing.Color.Black;
            this.QuanLiBan.Location = new System.Drawing.Point(64, 15);
            this.QuanLiBan.Name = "QuanLiBan";
            this.QuanLiBan.Size = new System.Drawing.Size(151, 26);
            this.QuanLiBan.TabIndex = 0;
            this.QuanLiBan.Text = "Quản Lí Bàn ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PowderBlue;
            this.panel6.Controls.Add(this.Category);
            this.panel6.Controls.Add(this.cbLoai_Mon_An);
            this.panel6.Location = new System.Drawing.Point(17, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 55);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PowderBlue;
            this.panel7.Controls.Add(this.QuanLiBan);
            this.panel7.Location = new System.Drawing.Point(845, 26);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 55);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPTG);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.btnThanh_Toán);
            this.panel8.Location = new System.Drawing.Point(844, 461);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 81);
            this.panel8.TabIndex = 0;
            // 
            // txtPTG
            // 
            this.txtPTG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTG.Location = new System.Drawing.Point(10, 49);
            this.txtPTG.Name = "txtPTG";
            this.txtPTG.Size = new System.Drawing.Size(82, 29);
            this.txtPTG.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khuyến Mãi";
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 550);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Nhà Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fTableManager_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFoodBaseCategory)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbLoai_Mon_An;
        private System.Windows.Forms.Button btnThanh_Toán;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem_Mon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Ten_Mon;
        private System.Windows.Forms.ColumnHeader So_Luong_Mon;
        private System.Windows.Forms.ColumnHeader Don_Gia;
        private System.Windows.Forms.ColumnHeader Tong_Tien;
        private System.Windows.Forms.TextBox Total;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private Panel panel4;
        private Label Category;
        private DataGridView dgvListFoodBaseCategory;
        private Panel panel5;
        private TextBox txtGiaHienTai;
        private TextBox txtTinhTrang;
        private TextBox txtTenMon;
        private Label GiaHienTai;
        private Label TinhTrang;
        private Label TenMon;
        private DateTimePicker TimeNow;
        private Label Time;
        private Label Ban;
        private TextBox txtBan;
        private Label QuanLiBan;
        private Label SDT;
        private Label Email;
        private Label address;
        private Label Ten;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private TextBox txtTenKhach;
        private Panel panel6;
        private Panel panel7;
        private TextBox TotalSauKM;
        private Label SauKM;
        private Label TruocKM;
        private Panel panel8;
        private TextBox txtPTG;
        private Label label1;
    }
}