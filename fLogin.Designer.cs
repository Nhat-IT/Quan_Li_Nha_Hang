namespace Quan_Li_Nha_Hang
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDang_Nhap = new System.Windows.Forms.Button();
            this.labelDang_Nhap = new System.Windows.Forms.Label();
            this.Pass_Login = new System.Windows.Forms.TextBox();
            this.Email_Login = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDang_Nhap);
            this.panel1.Controls.Add(this.labelDang_Nhap);
            this.panel1.Controls.Add(this.Pass_Login);
            this.panel1.Controls.Add(this.Email_Login);
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 243);
            this.panel1.TabIndex = 0;
            // 
            // btnDang_Nhap
            // 
            this.btnDang_Nhap.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDang_Nhap.ForeColor = System.Drawing.Color.Black;
            this.btnDang_Nhap.Location = new System.Drawing.Point(180, 147);
            this.btnDang_Nhap.Name = "btnDang_Nhap";
            this.btnDang_Nhap.Size = new System.Drawing.Size(110, 29);
            this.btnDang_Nhap.TabIndex = 2;
            this.btnDang_Nhap.Text = "Đăng Nhập";
            this.btnDang_Nhap.UseVisualStyleBackColor = true;
            this.btnDang_Nhap.Click += new System.EventHandler(this.btnDang_Nhap_Click);
            // 
            // labelDang_Nhap
            // 
            this.labelDang_Nhap.AutoSize = true;
            this.labelDang_Nhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDang_Nhap.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDang_Nhap.Location = new System.Drawing.Point(143, 18);
            this.labelDang_Nhap.Name = "labelDang_Nhap";
            this.labelDang_Nhap.Size = new System.Drawing.Size(181, 33);
            this.labelDang_Nhap.TabIndex = 1;
            this.labelDang_Nhap.Text = "ĐĂNG NHẬP";
            this.labelDang_Nhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pass_Login
            // 
            this.Pass_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass_Login.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Pass_Login.Location = new System.Drawing.Point(118, 109);
            this.Pass_Login.Name = "Pass_Login";
            this.Pass_Login.Size = new System.Drawing.Size(223, 22);
            this.Pass_Login.TabIndex = 1;
            this.Pass_Login.Text = "Password";
            this.Pass_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass_Login.UseSystemPasswordChar = true;
            this.Pass_Login.Enter += new System.EventHandler(this.Pass_Login_Enter);
            this.Pass_Login.Leave += new System.EventHandler(this.Pass_Login_Leave);
            // 
            // Email_Login
            // 
            this.Email_Login.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Email_Login.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Email_Login.Location = new System.Drawing.Point(118, 72);
            this.Email_Login.Name = "Email_Login";
            this.Email_Login.Size = new System.Drawing.Size(223, 22);
            this.Email_Login.TabIndex = 0;
            this.Email_Login.Text = "Email Đăng Nhập";
            this.Email_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email_Login.UseWaitCursor = true;
            this.Email_Login.Enter += new System.EventHandler(this.Email_Login_Enter);
            this.Email_Login.Leave += new System.EventHandler(this.Email_Login_Leave);
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnDang_Nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 267);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Pass_Login;
        private System.Windows.Forms.Label labelDang_Nhap;
        private System.Windows.Forms.Button btnDang_Nhap;
        private System.Windows.Forms.TextBox Email_Login;
    }
}

