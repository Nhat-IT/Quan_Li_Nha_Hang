using System.Windows.Forms;

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
            this.tabTai_Khoan = new System.Windows.Forms.TabPage();
            this.tabThuc_An = new System.Windows.Forms.TabPage();
            this.dtgvListFood = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Xem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ID_Mon = new System.Windows.Forms.Label();
            this.Ten_Mon = new System.Windows.Forms.Label();
            this.Ten_Loai = new System.Windows.Forms.Label();
            this.txtTinh_Trang = new System.Windows.Forms.Label();
            this.Gia = new System.Windows.Forms.Label();
            this.txtID_Mon = new System.Windows.Forms.TextBox();
            this.Don_Vi_Tinh = new System.Windows.Forms.Label();
            this.txtTen_Mon = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtDon_Vi_Tinh = new System.Windows.Forms.TextBox();
            this.cbTen_Loai = new System.Windows.Forms.ComboBox();
            this.nmGia = new System.Windows.Forms.NumericUpDown();
            this.tabDoanh_Thu = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgviewDoanh_Thu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnThong_Ke = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.TabControl();
            this.dtgvListAccount = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_Ten_Nhan_Vien = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Sex = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Tang_Phuc_Vu = new System.Windows.Forms.Label();
            this.numTang_Phuc_Vu = new System.Windows.Forms.NumericUpDown();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.tabTai_Khoan.SuspendLayout();
            this.tabThuc_An.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).BeginInit();
            this.tabDoanh_Thu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewDoanh_Thu)).BeginInit();
            this.panel2.SuspendLayout();
            this.Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTang_Phuc_Vu)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTai_Khoan
            // 
            this.tabTai_Khoan.Controls.Add(this.btnDelete);
            this.tabTai_Khoan.Controls.Add(this.btnModify);
            this.tabTai_Khoan.Controls.Add(this.btnAddnew);
            this.tabTai_Khoan.Controls.Add(this.panel12);
            this.tabTai_Khoan.Controls.Add(this.panel6);
            this.tabTai_Khoan.Controls.Add(this.panel5);
            this.tabTai_Khoan.Controls.Add(this.panel10);
            this.tabTai_Khoan.Controls.Add(this.panel11);
            this.tabTai_Khoan.Controls.Add(this.panel9);
            this.tabTai_Khoan.Controls.Add(this.panel8);
            this.tabTai_Khoan.Controls.Add(this.panel4);
            this.tabTai_Khoan.Controls.Add(this.dtgvListAccount);
            this.tabTai_Khoan.Location = new System.Drawing.Point(4, 25);
            this.tabTai_Khoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTai_Khoan.Name = "tabTai_Khoan";
            this.tabTai_Khoan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTai_Khoan.Size = new System.Drawing.Size(955, 532);
            this.tabTai_Khoan.TabIndex = 4;
            this.tabTai_Khoan.Text = "Tài Khoản";
            this.tabTai_Khoan.UseVisualStyleBackColor = true;
            // 
            // tabThuc_An
            // 
            this.tabThuc_An.Controls.Add(this.panel7);
            this.tabThuc_An.Controls.Add(this.panel3);
            this.tabThuc_An.Controls.Add(this.dtgvListFood);
            this.tabThuc_An.Location = new System.Drawing.Point(4, 25);
            this.tabThuc_An.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabThuc_An.Name = "tabThuc_An";
            this.tabThuc_An.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabThuc_An.Size = new System.Drawing.Size(955, 532);
            this.tabThuc_An.TabIndex = 1;
            this.tabThuc_An.Text = "Thức Ăn";
            this.tabThuc_An.UseVisualStyleBackColor = true;
            // 
            // dtgvListFood
            // 
            this.dtgvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListFood.Location = new System.Drawing.Point(8, 93);
            this.dtgvListFood.Name = "dtgvListFood";
            this.dtgvListFood.RowHeadersWidth = 51;
            this.dtgvListFood.RowTemplate.Height = 24;
            this.dtgvListFood.Size = new System.Drawing.Size(560, 426);
            this.dtgvListFood.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Delete);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.Xem);
            this.panel3.Location = new System.Drawing.Point(8, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 82);
            this.panel3.TabIndex = 2;
            // 
            // Xem
            // 
            this.Xem.Location = new System.Drawing.Point(449, 15);
            this.Xem.Name = "Xem";
            this.Xem.Size = new System.Drawing.Size(108, 67);
            this.Xem.TabIndex = 1;
            this.Xem.Text = "Xem";
            this.Xem.UseVisualStyleBackColor = true;
            this.Xem.Click += new System.EventHandler(this.Xem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 67);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(291, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 67);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(151, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 67);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.nmGia);
            this.panel7.Controls.Add(this.cbTen_Loai);
            this.panel7.Controls.Add(this.txtDon_Vi_Tinh);
            this.panel7.Controls.Add(this.txtTinhTrang);
            this.panel7.Controls.Add(this.txtTen_Mon);
            this.panel7.Controls.Add(this.Don_Vi_Tinh);
            this.panel7.Controls.Add(this.txtID_Mon);
            this.panel7.Controls.Add(this.Gia);
            this.panel7.Controls.Add(this.txtTinh_Trang);
            this.panel7.Controls.Add(this.Ten_Loai);
            this.panel7.Controls.Add(this.Ten_Mon);
            this.panel7.Controls.Add(this.ID_Mon);
            this.panel7.Location = new System.Drawing.Point(577, 93);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(375, 426);
            this.panel7.TabIndex = 0;
            // 
            // ID_Mon
            // 
            this.ID_Mon.AutoSize = true;
            this.ID_Mon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Mon.Location = new System.Drawing.Point(5, 24);
            this.ID_Mon.Name = "ID_Mon";
            this.ID_Mon.Size = new System.Drawing.Size(74, 23);
            this.ID_Mon.TabIndex = 0;
            this.ID_Mon.Text = "ID Món";
            // 
            // Ten_Mon
            // 
            this.Ten_Mon.AutoSize = true;
            this.Ten_Mon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten_Mon.Location = new System.Drawing.Point(5, 86);
            this.Ten_Mon.Name = "Ten_Mon";
            this.Ten_Mon.Size = new System.Drawing.Size(85, 23);
            this.Ten_Mon.TabIndex = 0;
            this.Ten_Mon.Text = "Tên Món";
            // 
            // Ten_Loai
            // 
            this.Ten_Loai.AutoSize = true;
            this.Ten_Loai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten_Loai.Location = new System.Drawing.Point(5, 152);
            this.Ten_Loai.Name = "Ten_Loai";
            this.Ten_Loai.Size = new System.Drawing.Size(85, 23);
            this.Ten_Loai.TabIndex = 0;
            this.Ten_Loai.Text = "Tên Loại";
            // 
            // txtTinh_Trang
            // 
            this.txtTinh_Trang.AutoSize = true;
            this.txtTinh_Trang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinh_Trang.Location = new System.Drawing.Point(5, 264);
            this.txtTinh_Trang.Name = "txtTinh_Trang";
            this.txtTinh_Trang.Size = new System.Drawing.Size(104, 23);
            this.txtTinh_Trang.TabIndex = 0;
            this.txtTinh_Trang.Text = "Tình Trạng";
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gia.Location = new System.Drawing.Point(5, 315);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(41, 23);
            this.Gia.TabIndex = 0;
            this.Gia.Text = "Giá";
            // 
            // txtID_Mon
            // 
            this.txtID_Mon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtID_Mon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Mon.Location = new System.Drawing.Point(123, 24);
            this.txtID_Mon.Name = "txtID_Mon";
            this.txtID_Mon.ReadOnly = true;
            this.txtID_Mon.Size = new System.Drawing.Size(233, 30);
            this.txtID_Mon.TabIndex = 1;
            this.txtID_Mon.TextChanged += new System.EventHandler(this.txtID_Mon_TextChanged);
            // 
            // Don_Vi_Tinh
            // 
            this.Don_Vi_Tinh.AutoSize = true;
            this.Don_Vi_Tinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Don_Vi_Tinh.Location = new System.Drawing.Point(5, 207);
            this.Don_Vi_Tinh.Name = "Don_Vi_Tinh";
            this.Don_Vi_Tinh.Size = new System.Drawing.Size(82, 23);
            this.Don_Vi_Tinh.TabIndex = 0;
            this.Don_Vi_Tinh.Text = "ĐV Tính";
            // 
            // txtTen_Mon
            // 
            this.txtTen_Mon.BackColor = System.Drawing.SystemColors.Window;
            this.txtTen_Mon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen_Mon.Location = new System.Drawing.Point(123, 86);
            this.txtTen_Mon.Name = "txtTen_Mon";
            this.txtTen_Mon.Size = new System.Drawing.Size(233, 30);
            this.txtTen_Mon.TabIndex = 1;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.SystemColors.Window;
            this.txtTinhTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(123, 257);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(233, 30);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // txtDon_Vi_Tinh
            // 
            this.txtDon_Vi_Tinh.BackColor = System.Drawing.SystemColors.Window;
            this.txtDon_Vi_Tinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDon_Vi_Tinh.Location = new System.Drawing.Point(123, 204);
            this.txtDon_Vi_Tinh.Name = "txtDon_Vi_Tinh";
            this.txtDon_Vi_Tinh.Size = new System.Drawing.Size(233, 30);
            this.txtDon_Vi_Tinh.TabIndex = 1;
            // 
            // cbTen_Loai
            // 
            this.cbTen_Loai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTen_Loai.FormattingEnabled = true;
            this.cbTen_Loai.Location = new System.Drawing.Point(123, 149);
            this.cbTen_Loai.Name = "cbTen_Loai";
            this.cbTen_Loai.Size = new System.Drawing.Size(233, 31);
            this.cbTen_Loai.TabIndex = 2;
            // 
            // nmGia
            // 
            this.nmGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmGia.Location = new System.Drawing.Point(123, 313);
            this.nmGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmGia.Name = "nmGia";
            this.nmGia.Size = new System.Drawing.Size(233, 30);
            this.nmGia.TabIndex = 3;
            // 
            // tabDoanh_Thu
            // 
            this.tabDoanh_Thu.Controls.Add(this.panel2);
            this.tabDoanh_Thu.Controls.Add(this.panel1);
            this.tabDoanh_Thu.Location = new System.Drawing.Point(4, 25);
            this.tabDoanh_Thu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDoanh_Thu.Name = "tabDoanh_Thu";
            this.tabDoanh_Thu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDoanh_Thu.Size = new System.Drawing.Size(955, 532);
            this.tabDoanh_Thu.TabIndex = 0;
            this.tabDoanh_Thu.Text = "Doanh Thu";
            this.tabDoanh_Thu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgviewDoanh_Thu);
            this.panel1.Location = new System.Drawing.Point(8, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 466);
            this.panel1.TabIndex = 0;
            // 
            // dgviewDoanh_Thu
            // 
            this.dgviewDoanh_Thu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewDoanh_Thu.Location = new System.Drawing.Point(-3, 0);
            this.dgviewDoanh_Thu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgviewDoanh_Thu.Name = "dgviewDoanh_Thu";
            this.dgviewDoanh_Thu.ReadOnly = true;
            this.dgviewDoanh_Thu.RowHeadersWidth = 51;
            this.dgviewDoanh_Thu.RowTemplate.Height = 24;
            this.dgviewDoanh_Thu.Size = new System.Drawing.Size(943, 466);
            this.dgviewDoanh_Thu.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThong_Ke);
            this.panel2.Controls.Add(this.dateEnd);
            this.panel2.Controls.Add(this.dateStart);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 31);
            this.panel2.TabIndex = 1;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(3, 2);
            this.dateStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(248, 22);
            this.dateStart.TabIndex = 0;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(691, 2);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(248, 22);
            this.dateEnd.TabIndex = 0;
            // 
            // btnThong_Ke
            // 
            this.btnThong_Ke.Location = new System.Drawing.Point(416, -1);
            this.btnThong_Ke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThong_Ke.Name = "btnThong_Ke";
            this.btnThong_Ke.Size = new System.Drawing.Size(109, 30);
            this.btnThong_Ke.TabIndex = 1;
            this.btnThong_Ke.Text = "Thống Kê";
            this.btnThong_Ke.UseVisualStyleBackColor = true;
            this.btnThong_Ke.Click += new System.EventHandler(this.btnThong_Ke_Click);
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.tabDoanh_Thu);
            this.Admin.Controls.Add(this.tabThuc_An);
            this.Admin.Controls.Add(this.tabTai_Khoan);
            this.Admin.Location = new System.Drawing.Point(0, 0);
            this.Admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Admin.Name = "Admin";
            this.Admin.SelectedIndex = 0;
            this.Admin.Size = new System.Drawing.Size(963, 561);
            this.Admin.TabIndex = 0;
            // 
            // dtgvListAccount
            // 
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListAccount.Location = new System.Drawing.Point(8, 5);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowHeadersWidth = 51;
            this.dtgvListAccount.RowTemplate.Height = 24;
            this.dtgvListAccount.Size = new System.Drawing.Size(455, 522);
            this.dtgvListAccount.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtEmailLogin);
            this.panel4.Controls.Add(this.label_Ten_Nhan_Vien);
            this.panel4.Location = new System.Drawing.Point(469, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 44);
            this.panel4.TabIndex = 1;
            // 
            // label_Ten_Nhan_Vien
            // 
            this.label_Ten_Nhan_Vien.AutoSize = true;
            this.label_Ten_Nhan_Vien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten_Nhan_Vien.Location = new System.Drawing.Point(3, 17);
            this.label_Ten_Nhan_Vien.Name = "label_Ten_Nhan_Vien";
            this.label_Ten_Nhan_Vien.Size = new System.Drawing.Size(156, 23);
            this.label_Ten_Nhan_Vien.TabIndex = 0;
            this.label_Ten_Nhan_Vien.Text = "Email Đăng Nhập";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.labelName);
            this.panel5.Location = new System.Drawing.Point(469, 64);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 46);
            this.panel5.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(186, 9);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 27);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPhoneNumber);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(469, 170);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(486, 46);
            this.panel8.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPhoneNumber.Location = new System.Drawing.Point(186, 13);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(273, 27);
            this.txtPhoneNumber.TabIndex = 0;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtAddress);
            this.panel9.Controls.Add(this.Address);
            this.panel9.Location = new System.Drawing.Point(469, 282);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(480, 53);
            this.panel9.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(186, 20);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 27);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(3, 21);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(68, 23);
            this.Address.TabIndex = 0;
            this.Address.Text = "Địa chỉ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.numTang_Phuc_Vu);
            this.panel10.Controls.Add(this.Tang_Phuc_Vu);
            this.panel10.Location = new System.Drawing.Point(469, 339);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(480, 54);
            this.panel10.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSex);
            this.panel6.Controls.Add(this.Sex);
            this.panel6.Location = new System.Drawing.Point(469, 114);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(480, 52);
            this.panel6.TabIndex = 2;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(3, 16);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(91, 23);
            this.Sex.TabIndex = 0;
            this.Sex.Text = "Giới Tính";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.Birthday);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Location = new System.Drawing.Point(469, 220);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(611, 69);
            this.panel12.TabIndex = 3;
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(186, 26);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(273, 22);
            this.Birthday.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Sinh";
            // 
            // Tang_Phuc_Vu
            // 
            this.Tang_Phuc_Vu.AutoSize = true;
            this.Tang_Phuc_Vu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tang_Phuc_Vu.Location = new System.Drawing.Point(3, 21);
            this.Tang_Phuc_Vu.Name = "Tang_Phuc_Vu";
            this.Tang_Phuc_Vu.Size = new System.Drawing.Size(122, 23);
            this.Tang_Phuc_Vu.TabIndex = 13;
            this.Tang_Phuc_Vu.Text = "Tầng phục vụ";
            // 
            // numTang_Phuc_Vu
            // 
            this.numTang_Phuc_Vu.Location = new System.Drawing.Point(186, 24);
            this.numTang_Phuc_Vu.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numTang_Phuc_Vu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTang_Phuc_Vu.Name = "numTang_Phuc_Vu";
            this.numTang_Phuc_Vu.Size = new System.Drawing.Size(120, 22);
            this.numTang_Phuc_Vu.TabIndex = 14;
            this.numTang_Phuc_Vu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtNewPassword);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Location = new System.Drawing.Point(469, 397);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(480, 53);
            this.panel11.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNewPassword.Location = new System.Drawing.Point(186, 17);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(273, 27);
            this.txtNewPassword.TabIndex = 0;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật Khẩu Mới";
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(480, 471);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(120, 48);
            this.btnAddnew.TabIndex = 4;
            this.btnAddnew.Text = "Thêm Mới";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(655, 471);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(120, 48);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Sửa";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(829, 471);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 48);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.Window;
            this.txtSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSex.Location = new System.Drawing.Point(186, 12);
            this.txtSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(273, 27);
            this.txtSex.TabIndex = 0;
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmailLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmailLogin.Location = new System.Drawing.Point(186, 13);
            this.txtEmailLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(273, 27);
            this.txtEmailLogin.TabIndex = 0;
            this.txtEmailLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 556);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.tabTai_Khoan.ResumeLayout(false);
            this.tabThuc_An.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).EndInit();
            this.tabDoanh_Thu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewDoanh_Thu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTang_Phuc_Vu)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private TabPage tabTai_Khoan;
        private TabPage tabThuc_An;
        private Panel panel7;
        private NumericUpDown nmGia;
        private ComboBox cbTen_Loai;
        private TextBox txtDon_Vi_Tinh;
        private TextBox txtTinhTrang;
        private TextBox txtTen_Mon;
        private Label Don_Vi_Tinh;
        private TextBox txtID_Mon;
        private Label Gia;
        private Label txtTinh_Trang;
        private Label Ten_Loai;
        private Label Ten_Mon;
        private Label ID_Mon;
        private Panel panel3;
        private Button Delete;
        private Button btnSua;
        private Button btnThem;
        private Button Xem;
        private DataGridView dtgvListFood;
        private TabPage tabDoanh_Thu;
        private Panel panel2;
        private Button btnThong_Ke;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Panel panel1;
        private DataGridView dgviewDoanh_Thu;
        private TabControl Admin;
        private DataGridView dtgvListAccount;
        private Panel panel5;
        private TextBox txtName;
        private Label labelName;
        private Panel panel4;
        private Label label_Ten_Nhan_Vien;
        private Panel panel10;
        private Panel panel9;
        private TextBox txtAddress;
        private Label Address;
        private Panel panel8;
        private TextBox txtPhoneNumber;
        private Label label3;
        private Panel panel6;
        private Label Sex;
        private Panel panel12;
        private DateTimePicker Birthday;
        private Label label7;
        private Label Tang_Phuc_Vu;
        private NumericUpDown numTang_Phuc_Vu;
        private Panel panel11;
        private TextBox txtNewPassword;
        private Label label4;
        private Button btnDelete;
        private Button btnModify;
        private Button btnAddnew;
        private TextBox txtSex;
        private TextBox txtEmailLogin;
    }
}