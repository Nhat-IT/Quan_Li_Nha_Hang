
namespace Quan_Li_Nha_Hang.GUI
{
    partial class faddNewFood
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
            this.txtID_Mon = new System.Windows.Forms.TextBox();
            this.txtTen_Mon = new System.Windows.Forms.TextBox();
            this.txtDon_Vi_Tinh = new System.Windows.Forms.TextBox();
            this.cbTen_Loai = new System.Windows.Forms.ComboBox();
            this.nmGia = new System.Windows.Forms.NumericUpDown();
            this.IDMon = new System.Windows.Forms.Label();
            this.NewFood = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.addFood = new System.Windows.Forms.Button();
            this.Money = new System.Windows.Forms.Label();
            this.escape = new System.Windows.Forms.Button();
            this.DVtinh = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Het = new System.Windows.Forms.CheckBox();
            this.Con = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID_Mon
            // 
            this.txtID_Mon.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtID_Mon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Mon.Location = new System.Drawing.Point(136, 7);
            this.txtID_Mon.Margin = new System.Windows.Forms.Padding(2);
            this.txtID_Mon.Name = "txtID_Mon";
            this.txtID_Mon.ReadOnly = true;
            this.txtID_Mon.Size = new System.Drawing.Size(269, 26);
            this.txtID_Mon.TabIndex = 1;
            this.txtID_Mon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen_Mon
            // 
            this.txtTen_Mon.BackColor = System.Drawing.SystemColors.Window;
            this.txtTen_Mon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen_Mon.Location = new System.Drawing.Point(136, 43);
            this.txtTen_Mon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen_Mon.Name = "txtTen_Mon";
            this.txtTen_Mon.Size = new System.Drawing.Size(269, 26);
            this.txtTen_Mon.TabIndex = 1;
            this.txtTen_Mon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDon_Vi_Tinh
            // 
            this.txtDon_Vi_Tinh.BackColor = System.Drawing.SystemColors.Window;
            this.txtDon_Vi_Tinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDon_Vi_Tinh.Location = new System.Drawing.Point(136, 199);
            this.txtDon_Vi_Tinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtDon_Vi_Tinh.Name = "txtDon_Vi_Tinh";
            this.txtDon_Vi_Tinh.Size = new System.Drawing.Size(269, 26);
            this.txtDon_Vi_Tinh.TabIndex = 1;
            this.txtDon_Vi_Tinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbTen_Loai
            // 
            this.cbTen_Loai.DropDownHeight = 90;
            this.cbTen_Loai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTen_Loai.FormattingEnabled = true;
            this.cbTen_Loai.IntegralHeight = false;
            this.cbTen_Loai.Location = new System.Drawing.Point(136, 77);
            this.cbTen_Loai.Margin = new System.Windows.Forms.Padding(2);
            this.cbTen_Loai.Name = "cbTen_Loai";
            this.cbTen_Loai.Size = new System.Drawing.Size(269, 27);
            this.cbTen_Loai.TabIndex = 2;
            // 
            // nmGia
            // 
            this.nmGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmGia.Location = new System.Drawing.Point(136, 158);
            this.nmGia.Margin = new System.Windows.Forms.Padding(2);
            this.nmGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmGia.Name = "nmGia";
            this.nmGia.Size = new System.Drawing.Size(269, 26);
            this.nmGia.TabIndex = 3;
            // 
            // IDMon
            // 
            this.IDMon.AutoSize = true;
            this.IDMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDMon.Location = new System.Drawing.Point(11, 14);
            this.IDMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDMon.Name = "IDMon";
            this.IDMon.Size = new System.Drawing.Size(96, 19);
            this.IDMon.TabIndex = 4;
            this.IDMon.Text = "ID Món Mới";
            // 
            // NewFood
            // 
            this.NewFood.AutoSize = true;
            this.NewFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewFood.Location = new System.Drawing.Point(11, 50);
            this.NewFood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewFood.Name = "NewFood";
            this.NewFood.Size = new System.Drawing.Size(104, 19);
            this.NewFood.TabIndex = 4;
            this.NewFood.Text = "Tên Món Mới";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(11, 84);
            this.Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(69, 19);
            this.Category.TabIndex = 4;
            this.Category.Text = "Tên Loại";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(11, 126);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(82, 19);
            this.status.TabIndex = 4;
            this.status.Text = "Tình Trạng";
            // 
            // addFood
            // 
            this.addFood.Location = new System.Drawing.Point(58, 271);
            this.addFood.Margin = new System.Windows.Forms.Padding(2);
            this.addFood.Name = "addFood";
            this.addFood.Size = new System.Drawing.Size(94, 42);
            this.addFood.TabIndex = 0;
            this.addFood.Text = "Thêm Món";
            this.addFood.UseVisualStyleBackColor = true;
            this.addFood.Click += new System.EventHandler(this.addFood_Click);
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Money.Location = new System.Drawing.Point(12, 165);
            this.Money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(67, 19);
            this.Money.TabIndex = 4;
            this.Money.Text = "Giá Tiền";
            // 
            // escape
            // 
            this.escape.Location = new System.Drawing.Point(294, 271);
            this.escape.Margin = new System.Windows.Forms.Padding(2);
            this.escape.Name = "escape";
            this.escape.Size = new System.Drawing.Size(94, 42);
            this.escape.TabIndex = 0;
            this.escape.Text = "Hủy";
            this.escape.UseVisualStyleBackColor = true;
            this.escape.Click += new System.EventHandler(this.escape_Click);
            // 
            // DVtinh
            // 
            this.DVtinh.AutoSize = true;
            this.DVtinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVtinh.Location = new System.Drawing.Point(12, 205);
            this.DVtinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DVtinh.Name = "DVtinh";
            this.DVtinh.Size = new System.Drawing.Size(91, 19);
            this.DVtinh.TabIndex = 4;
            this.DVtinh.Text = "Đơn Vị Tính";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Het);
            this.panel7.Controls.Add(this.Con);
            this.panel7.Controls.Add(this.DVtinh);
            this.panel7.Controls.Add(this.escape);
            this.panel7.Controls.Add(this.Money);
            this.panel7.Controls.Add(this.addFood);
            this.panel7.Controls.Add(this.status);
            this.panel7.Controls.Add(this.Category);
            this.panel7.Controls.Add(this.NewFood);
            this.panel7.Controls.Add(this.IDMon);
            this.panel7.Controls.Add(this.nmGia);
            this.panel7.Controls.Add(this.cbTen_Loai);
            this.panel7.Controls.Add(this.txtDon_Vi_Tinh);
            this.panel7.Controls.Add(this.txtTen_Mon);
            this.panel7.Controls.Add(this.txtID_Mon);
            this.panel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(9, 9);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(449, 327);
            this.panel7.TabIndex = 1;
            // 
            // Het
            // 
            this.Het.AutoSize = true;
            this.Het.Location = new System.Drawing.Point(269, 122);
            this.Het.Name = "Het";
            this.Het.Size = new System.Drawing.Size(77, 23);
            this.Het.TabIndex = 6;
            this.Het.Text = "Đã Hết";
            this.Het.UseVisualStyleBackColor = true;
            this.Het.Click += new System.EventHandler(this.Het_Click);
            // 
            // Con
            // 
            this.Con.AutoSize = true;
            this.Con.Location = new System.Drawing.Point(136, 122);
            this.Con.Name = "Con";
            this.Con.Size = new System.Drawing.Size(55, 23);
            this.Con.TabIndex = 6;
            this.Con.Text = "Còn";
            this.Con.UseVisualStyleBackColor = true;
            this.Con.Click += new System.EventHandler(this.Con_Click);
            // 
            // faddNewFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 354);
            this.Controls.Add(this.panel7);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "faddNewFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Món Mơi";
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID_Mon;
        private System.Windows.Forms.TextBox txtTen_Mon;
        private System.Windows.Forms.TextBox txtDon_Vi_Tinh;
        private System.Windows.Forms.ComboBox cbTen_Loai;
        private System.Windows.Forms.NumericUpDown nmGia;
        private System.Windows.Forms.Label IDMon;
        private System.Windows.Forms.Label NewFood;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button addFood;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Button escape;
        private System.Windows.Forms.Label DVtinh;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox Het;
        private System.Windows.Forms.CheckBox Con;
    }
}