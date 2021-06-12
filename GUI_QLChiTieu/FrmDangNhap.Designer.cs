
namespace GUI_QLChiTieu
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lblTKhoan = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMKhau = new System.Windows.Forms.Label();
            this.lnklblQuenMK = new System.Windows.Forms.LinkLabel();
            this.lnklblDangKy = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.ckboxShowHidePass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDangNhap.Location = new System.Drawing.Point(67, 18);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(147, 31);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "Đăng Nhập";
            // 
            // lblTKhoan
            // 
            this.lblTKhoan.AutoSize = true;
            this.lblTKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKhoan.Location = new System.Drawing.Point(12, 78);
            this.lblTKhoan.Name = "lblTKhoan";
            this.lblTKhoan.Size = new System.Drawing.Size(79, 19);
            this.lblTKhoan.TabIndex = 1;
            this.lblTKhoan.Text = "Tài Khoản";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(12, 101);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(260, 30);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(12, 185);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(260, 30);
            this.txtMatKhau.TabIndex = 4;
            // 
            // lblMKhau
            // 
            this.lblMKhau.AutoSize = true;
            this.lblMKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMKhau.Location = new System.Drawing.Point(12, 162);
            this.lblMKhau.Name = "lblMKhau";
            this.lblMKhau.Size = new System.Drawing.Size(78, 19);
            this.lblMKhau.TabIndex = 3;
            this.lblMKhau.Text = "Mật Khẩu";
            // 
            // lnklblQuenMK
            // 
            this.lnklblQuenMK.AutoSize = true;
            this.lnklblQuenMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblQuenMK.Location = new System.Drawing.Point(148, 275);
            this.lnklblQuenMK.Name = "lnklblQuenMK";
            this.lnklblQuenMK.Size = new System.Drawing.Size(124, 19);
            this.lnklblQuenMK.TabIndex = 7;
            this.lnklblQuenMK.TabStop = true;
            this.lnklblQuenMK.Text = "Quên Mật Khẩu ?";
            this.lnklblQuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblQuenMK_LinkClicked);
            // 
            // lnklblDangKy
            // 
            this.lnklblDangKy.AutoSize = true;
            this.lnklblDangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblDangKy.Location = new System.Drawing.Point(12, 275);
            this.lnklblDangKy.Name = "lnklblDangKy";
            this.lnklblDangKy.Size = new System.Drawing.Size(67, 19);
            this.lnklblDangKy.TabIndex = 6;
            this.lnklblDangKy.TabStop = true;
            this.lnklblDangKy.Text = "Đăng Ký";
            this.lnklblDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblDangKy_LinkClicked);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(12, 346);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(120, 40);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(152, 346);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 40);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ckboxShowHidePass
            // 
            this.ckboxShowHidePass.AutoSize = true;
            this.ckboxShowHidePass.Location = new System.Drawing.Point(12, 223);
            this.ckboxShowHidePass.Name = "ckboxShowHidePass";
            this.ckboxShowHidePass.Size = new System.Drawing.Size(115, 23);
            this.ckboxShowHidePass.TabIndex = 5;
            this.ckboxShowHidePass.Text = "Hiện mật khẩu";
            this.ckboxShowHidePass.UseVisualStyleBackColor = true;
            this.ckboxShowHidePass.CheckedChanged += new System.EventHandler(this.ckboxShowHidePass_CheckedChanged);
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.ckboxShowHidePass);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lnklblDangKy);
            this.Controls.Add(this.lnklblQuenMK);
            this.Controls.Add(this.lblMKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblTKhoan);
            this.Controls.Add(this.lblDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDangNhap_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblTKhoan;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMKhau;
        private System.Windows.Forms.LinkLabel lnklblQuenMK;
        private System.Windows.Forms.LinkLabel lnklblDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox ckboxShowHidePass;
    }
}