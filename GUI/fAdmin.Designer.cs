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
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.numAdmin = new System.Windows.Forms.NumericUpDown();
            this.numTang_Phuc_Vu = new System.Windows.Forms.NumericUpDown();
            this.Tang_Phuc_Vu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.label_Ten_Nhan_Vien = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.dtgvListAccount = new System.Windows.Forms.DataGridView();
            this.tabThuc_An = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nmGia = new System.Windows.Forms.NumericUpDown();
            this.cbTen_Loai = new System.Windows.Forms.ComboBox();
            this.txtDon_Vi_Tinh = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtTen_Mon = new System.Windows.Forms.TextBox();
            this.txtID_Mon = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvListFood = new System.Windows.Forms.DataGridView();
            this.tabDoanh_Thu = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThong_Ke = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgviewDoanh_Thu = new System.Windows.Forms.DataGridView();
            this.Admin = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.tabTai_Khoan.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTang_Phuc_Vu)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.tabThuc_An.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).BeginInit();
            this.tabDoanh_Thu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewDoanh_Thu)).BeginInit();
            this.Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTai_Khoan
            // 
            this.tabTai_Khoan.Controls.Add(this.panel6);
            this.tabTai_Khoan.Controls.Add(this.panel5);
            this.tabTai_Khoan.Controls.Add(this.panel10);
            this.tabTai_Khoan.Controls.Add(this.panel4);
            this.tabTai_Khoan.Controls.Add(this.panel12);
            this.tabTai_Khoan.Controls.Add(this.panel9);
            this.tabTai_Khoan.Controls.Add(this.panel8);
            this.tabTai_Khoan.Controls.Add(this.btnDelete);
            this.tabTai_Khoan.Controls.Add(this.btnAddnew);
            this.tabTai_Khoan.Controls.Add(this.dtgvListAccount);
            this.tabTai_Khoan.Location = new System.Drawing.Point(4, 22);
            this.tabTai_Khoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTai_Khoan.Name = "tabTai_Khoan";
            this.tabTai_Khoan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTai_Khoan.Size = new System.Drawing.Size(670, 372);
            this.tabTai_Khoan.TabIndex = 4;
            this.tabTai_Khoan.Text = "Tài Khoản";
            this.tabTai_Khoan.UseVisualStyleBackColor = true;
            this.tabTai_Khoan.Click += new System.EventHandler(this.tabTai_Khoan_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSex);
            this.panel6.Controls.Add(this.Sex);
            this.panel6.Location = new System.Drawing.Point(2, 194);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(334, 29);
            this.panel6.TabIndex = 17;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.Window;
            this.txtSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSex.Location = new System.Drawing.Point(124, 2);
            this.txtSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(209, 23);
            this.txtSex.TabIndex = 0;
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex.Location = new System.Drawing.Point(2, 4);
            this.Sex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(72, 19);
            this.Sex.TabIndex = 0;
            this.Sex.Text = "Giới Tính";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.labelName);
            this.panel5.Location = new System.Drawing.Point(2, 227);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(334, 29);
            this.panel5.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(124, 2);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 23);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(2, 4);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.numAdmin);
            this.panel10.Controls.Add(this.numTang_Phuc_Vu);
            this.panel10.Controls.Add(this.Tang_Phuc_Vu);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Location = new System.Drawing.Point(2, 336);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(333, 31);
            this.panel10.TabIndex = 13;
            // 
            // numAdmin
            // 
            this.numAdmin.Location = new System.Drawing.Point(303, 4);
            this.numAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numAdmin.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdmin.Name = "numAdmin";
            this.numAdmin.Size = new System.Drawing.Size(28, 20);
            this.numAdmin.TabIndex = 14;
            this.numAdmin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numTang_Phuc_Vu
            // 
            this.numTang_Phuc_Vu.Location = new System.Drawing.Point(123, 3);
            this.numTang_Phuc_Vu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.numTang_Phuc_Vu.Size = new System.Drawing.Size(67, 20);
            this.numTang_Phuc_Vu.TabIndex = 14;
            this.numTang_Phuc_Vu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Tang_Phuc_Vu
            // 
            this.Tang_Phuc_Vu.AutoSize = true;
            this.Tang_Phuc_Vu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tang_Phuc_Vu.Location = new System.Drawing.Point(2, 4);
            this.Tang_Phuc_Vu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tang_Phuc_Vu.Name = "Tang_Phuc_Vu";
            this.Tang_Phuc_Vu.Size = new System.Drawing.Size(102, 19);
            this.Tang_Phuc_Vu.TabIndex = 13;
            this.Tang_Phuc_Vu.Text = "Tầng Phục Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chủ Quán";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtEmailLogin);
            this.panel4.Controls.Add(this.label_Ten_Nhan_Vien);
            this.panel4.Location = new System.Drawing.Point(7, 429);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 36);
            this.panel4.TabIndex = 11;
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmailLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmailLogin.Location = new System.Drawing.Point(140, 9);
            this.txtEmailLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(205, 23);
            this.txtEmailLogin.TabIndex = 0;
            this.txtEmailLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Ten_Nhan_Vien
            // 
            this.label_Ten_Nhan_Vien.AutoSize = true;
            this.label_Ten_Nhan_Vien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten_Nhan_Vien.Location = new System.Drawing.Point(2, 9);
            this.label_Ten_Nhan_Vien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Ten_Nhan_Vien.Name = "label_Ten_Nhan_Vien";
            this.label_Ten_Nhan_Vien.Size = new System.Drawing.Size(127, 19);
            this.label_Ten_Nhan_Vien.TabIndex = 0;
            this.label_Ten_Nhan_Vien.Text = "Email Đăng Nhập";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.Birthday);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Location = new System.Drawing.Point(2, 163);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(334, 27);
            this.panel12.TabIndex = 18;
            // 
            // Birthday
            // 
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Birthday.Location = new System.Drawing.Point(124, 2);
            this.Birthday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(209, 21);
            this.Birthday.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Sinh";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtAddress);
            this.panel9.Controls.Add(this.Address);
            this.panel9.Location = new System.Drawing.Point(0, 260);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(336, 31);
            this.panel9.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(126, 5);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(209, 23);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(4, 5);
            this.Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(56, 19);
            this.Address.TabIndex = 0;
            this.Address.Text = "Địa chỉ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPhoneNumber);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(2, 295);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(334, 37);
            this.panel8.TabIndex = 16;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPhoneNumber.Location = new System.Drawing.Point(124, 8);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(210, 23);
            this.txtPhoneNumber.TabIndex = 0;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(573, 165);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(573, 200);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(90, 31);
            this.btnAddnew.TabIndex = 4;
            this.btnAddnew.Text = "Thêm Mới";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // dtgvListAccount
            // 
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListAccount.Location = new System.Drawing.Point(4, 2);
            this.dtgvListAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowHeadersWidth = 51;
            this.dtgvListAccount.RowTemplate.Height = 24;
            this.dtgvListAccount.Size = new System.Drawing.Size(659, 157);
            this.dtgvListAccount.TabIndex = 0;
            // 
            // tabThuc_An
            // 
            this.tabThuc_An.Controls.Add(this.panel7);
            this.tabThuc_An.Controls.Add(this.panel3);
            this.tabThuc_An.Controls.Add(this.dtgvListFood);
            this.tabThuc_An.Location = new System.Drawing.Point(4, 22);
            this.tabThuc_An.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabThuc_An.Name = "tabThuc_An";
            this.tabThuc_An.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabThuc_An.Size = new System.Drawing.Size(670, 372);
            this.tabThuc_An.TabIndex = 1;
            this.tabThuc_An.Text = "Thức Ăn";
            this.tabThuc_An.UseVisualStyleBackColor = true;
            this.tabThuc_An.Click += new System.EventHandler(this.tabThuc_An_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.nmGia);
            this.panel7.Controls.Add(this.cbTen_Loai);
            this.panel7.Controls.Add(this.txtDon_Vi_Tinh);
            this.panel7.Controls.Add(this.txtTinhTrang);
            this.panel7.Controls.Add(this.txtTen_Mon);
            this.panel7.Controls.Add(this.txtID_Mon);
            this.panel7.Location = new System.Drawing.Point(5, 282);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(663, 45);
            this.panel7.TabIndex = 0;
            // 
            // nmGia
            // 
            this.nmGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmGia.Location = new System.Drawing.Point(446, 4);
            this.nmGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmGia.Name = "nmGia";
            this.nmGia.Size = new System.Drawing.Size(99, 26);
            this.nmGia.TabIndex = 3;
            // 
            // cbTen_Loai
            // 
            this.cbTen_Loai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTen_Loai.FormattingEnabled = true;
            this.cbTen_Loai.Location = new System.Drawing.Point(243, 4);
            this.cbTen_Loai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTen_Loai.Name = "cbTen_Loai";
            this.cbTen_Loai.Size = new System.Drawing.Size(96, 27);
            this.cbTen_Loai.TabIndex = 2;
            // 
            // txtDon_Vi_Tinh
            // 
            this.txtDon_Vi_Tinh.BackColor = System.Drawing.SystemColors.Window;
            this.txtDon_Vi_Tinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDon_Vi_Tinh.Location = new System.Drawing.Point(550, 4);
            this.txtDon_Vi_Tinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDon_Vi_Tinh.Name = "txtDon_Vi_Tinh";
            this.txtDon_Vi_Tinh.Size = new System.Drawing.Size(99, 26);
            this.txtDon_Vi_Tinh.TabIndex = 1;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.SystemColors.Window;
            this.txtTinhTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(343, 4);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(99, 26);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // txtTen_Mon
            // 
            this.txtTen_Mon.BackColor = System.Drawing.SystemColors.Window;
            this.txtTen_Mon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen_Mon.Location = new System.Drawing.Point(145, 4);
            this.txtTen_Mon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTen_Mon.Name = "txtTen_Mon";
            this.txtTen_Mon.Size = new System.Drawing.Size(95, 26);
            this.txtTen_Mon.TabIndex = 1;
            this.txtTen_Mon.TextChanged += new System.EventHandler(this.txtTen_Mon_TextChanged);
            // 
            // txtID_Mon
            // 
            this.txtID_Mon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtID_Mon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Mon.Location = new System.Drawing.Point(45, 4);
            this.txtID_Mon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID_Mon.Name = "txtID_Mon";
            this.txtID_Mon.ReadOnly = true;
            this.txtID_Mon.Size = new System.Drawing.Size(96, 26);
            this.txtID_Mon.TabIndex = 1;
            this.txtID_Mon.TextChanged += new System.EventHandler(this.txtID_Mon_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(452, 317);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 51);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(28, 13);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa Món";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(119, 13);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 35);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm Món";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvListFood
            // 
            this.dtgvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListFood.Location = new System.Drawing.Point(-4, 2);
            this.dtgvListFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvListFood.Name = "dtgvListFood";
            this.dtgvListFood.RowHeadersWidth = 51;
            this.dtgvListFood.RowTemplate.Height = 24;
            this.dtgvListFood.Size = new System.Drawing.Size(670, 276);
            this.dtgvListFood.TabIndex = 0;
            // 
            // tabDoanh_Thu
            // 
            this.tabDoanh_Thu.Controls.Add(this.panel2);
            this.tabDoanh_Thu.Controls.Add(this.panel1);
            this.tabDoanh_Thu.Location = new System.Drawing.Point(4, 22);
            this.tabDoanh_Thu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDoanh_Thu.Name = "tabDoanh_Thu";
            this.tabDoanh_Thu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDoanh_Thu.Size = new System.Drawing.Size(670, 372);
            this.tabDoanh_Thu.TabIndex = 0;
            this.tabDoanh_Thu.Text = "Doanh Thu";
            this.tabDoanh_Thu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThong_Ke);
            this.panel2.Controls.Add(this.dateEnd);
            this.panel2.Controls.Add(this.dateStart);
            this.panel2.Location = new System.Drawing.Point(6, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 25);
            this.panel2.TabIndex = 1;
            // 
            // btnThong_Ke
            // 
            this.btnThong_Ke.Location = new System.Drawing.Point(289, -1);
            this.btnThong_Ke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThong_Ke.Name = "btnThong_Ke";
            this.btnThong_Ke.Size = new System.Drawing.Size(82, 24);
            this.btnThong_Ke.TabIndex = 1;
            this.btnThong_Ke.Text = "Thống Kê";
            this.btnThong_Ke.UseVisualStyleBackColor = true;
            this.btnThong_Ke.Click += new System.EventHandler(this.btnThong_Ke_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(475, 0);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(187, 20);
            this.dateEnd.TabIndex = 0;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(2, 0);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(187, 20);
            this.dateStart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgviewDoanh_Thu);
            this.panel1.Location = new System.Drawing.Point(6, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 379);
            this.panel1.TabIndex = 0;
            // 
            // dgviewDoanh_Thu
            // 
            this.dgviewDoanh_Thu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewDoanh_Thu.Location = new System.Drawing.Point(-2, 0);
            this.dgviewDoanh_Thu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgviewDoanh_Thu.Name = "dgviewDoanh_Thu";
            this.dgviewDoanh_Thu.ReadOnly = true;
            this.dgviewDoanh_Thu.RowHeadersWidth = 51;
            this.dgviewDoanh_Thu.RowTemplate.Height = 24;
            this.dgviewDoanh_Thu.Size = new System.Drawing.Size(664, 327);
            this.dgviewDoanh_Thu.TabIndex = 2;
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.tabDoanh_Thu);
            this.Admin.Controls.Add(this.tabThuc_An);
            this.Admin.Controls.Add(this.tabTai_Khoan);
            this.Admin.Location = new System.Drawing.Point(0, 0);
            this.Admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Admin.Name = "Admin";
            this.Admin.SelectedIndex = 0;
            this.Admin.Size = new System.Drawing.Size(678, 398);
            this.Admin.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 398);
            this.Controls.Add(this.Admin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.tabTai_Khoan.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTang_Phuc_Vu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.tabThuc_An.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFood)).EndInit();
            this.tabDoanh_Thu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewDoanh_Thu)).EndInit();
            this.Admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private TabPage tabTai_Khoan;
        private Panel panel6;
        private TextBox txtSex;
        private Label Sex;
        private Panel panel5;
        private TextBox txtName;
        private Label labelName;
        private Panel panel10;
        private NumericUpDown numAdmin;
        private NumericUpDown numTang_Phuc_Vu;
        private Label Tang_Phuc_Vu;
        private Label label1;
        private Panel panel4;
        private TextBox txtEmailLogin;
        private Label label_Ten_Nhan_Vien;
        private Panel panel12;
        private DateTimePicker Birthday;
        private Label label7;
        private Panel panel9;
        private TextBox txtAddress;
        private Label Address;
        private Panel panel8;
        private TextBox txtPhoneNumber;
        private Label label3;
        private Button btnDelete;
        private Button btnAddnew;
        private DataGridView dtgvListAccount;
        private TabPage tabThuc_An;
        private Panel panel7;
        private NumericUpDown nmGia;
        private ComboBox cbTen_Loai;
        private TextBox txtDon_Vi_Tinh;
        private TextBox txtTinhTrang;
        private TextBox txtTen_Mon;
        private TextBox txtID_Mon;
        private Panel panel3;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dtgvListFood;
        private TabPage tabDoanh_Thu;
        private Panel panel2;
        private Button btnThong_Ke;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Panel panel1;
        private DataGridView dgviewDoanh_Thu;
        private TabControl Admin;
    }
}