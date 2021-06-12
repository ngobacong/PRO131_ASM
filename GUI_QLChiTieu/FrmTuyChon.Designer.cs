
namespace GUI_QLChiTieu
{
    partial class FrmTuyChon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTuyChon));
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabPageDoiMK = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtMKNhapLai = new System.Windows.Forms.TextBox();
            this.tabPageDoiTien = new System.Windows.Forms.TabPage();
            this.txtVND = new System.Windows.Forms.TextBox();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.lblVND = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.lblDau = new System.Windows.Forms.Label();
            this.tabCtrlTuyChon = new System.Windows.Forms.TabControl();
            this.tabPageDoiMK.SuspendLayout();
            this.tabPageDoiTien.SuspendLayout();
            this.tabCtrlTuyChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(135, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 35);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tabPageDoiMK
            // 
            this.tabPageDoiMK.Controls.Add(this.txtMKNhapLai);
            this.tabPageDoiMK.Controls.Add(this.txtMKMoi);
            this.tabPageDoiMK.Controls.Add(this.txtMKCu);
            this.tabPageDoiMK.Controls.Add(this.btnDoiMK);
            this.tabPageDoiMK.Controls.Add(this.label3);
            this.tabPageDoiMK.Controls.Add(this.label2);
            this.tabPageDoiMK.Controls.Add(this.label1);
            this.tabPageDoiMK.Location = new System.Drawing.Point(4, 28);
            this.tabPageDoiMK.Name = "tabPageDoiMK";
            this.tabPageDoiMK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoiMK.Size = new System.Drawing.Size(352, 341);
            this.tabPageDoiMK.TabIndex = 1;
            this.tabPageDoiMK.Text = "Đổi Mật Khẩu";
            this.tabPageDoiMK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mật Khẩu Cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập Mật Khẩu Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(74, 67);
            this.txtMKCu.Multiline = true;
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(200, 30);
            this.txtMKCu.TabIndex = 1;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Location = new System.Drawing.Point(111, 281);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(140, 40);
            this.btnDoiMK.TabIndex = 6;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(74, 146);
            this.txtMKMoi.Multiline = true;
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(200, 30);
            this.txtMKMoi.TabIndex = 3;
            // 
            // txtMKNhapLai
            // 
            this.txtMKNhapLai.Location = new System.Drawing.Point(74, 229);
            this.txtMKNhapLai.Multiline = true;
            this.txtMKNhapLai.Name = "txtMKNhapLai";
            this.txtMKNhapLai.Size = new System.Drawing.Size(200, 30);
            this.txtMKNhapLai.TabIndex = 5;
            // 
            // tabPageDoiTien
            // 
            this.tabPageDoiTien.Controls.Add(this.lblDau);
            this.tabPageDoiTien.Controls.Add(this.lblUSD);
            this.tabPageDoiTien.Controls.Add(this.lblVND);
            this.tabPageDoiTien.Controls.Add(this.txtUSD);
            this.tabPageDoiTien.Controls.Add(this.txtVND);
            this.tabPageDoiTien.Location = new System.Drawing.Point(4, 28);
            this.tabPageDoiTien.Name = "tabPageDoiTien";
            this.tabPageDoiTien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoiTien.Size = new System.Drawing.Size(352, 341);
            this.tabPageDoiTien.TabIndex = 0;
            this.tabPageDoiTien.Text = "Đổi Tiền Tệ";
            this.tabPageDoiTien.UseVisualStyleBackColor = true;
            // 
            // txtVND
            // 
            this.txtVND.Location = new System.Drawing.Point(68, 86);
            this.txtVND.Multiline = true;
            this.txtVND.Name = "txtVND";
            this.txtVND.Size = new System.Drawing.Size(170, 30);
            this.txtVND.TabIndex = 0;
            this.txtVND.TextChanged += new System.EventHandler(this.txtVND_TextChanged);
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(68, 220);
            this.txtUSD.Multiline = true;
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(170, 30);
            this.txtUSD.TabIndex = 3;
            this.txtUSD.TextChanged += new System.EventHandler(this.txtUSD_TextChanged);
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND.Location = new System.Drawing.Point(273, 89);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(44, 19);
            this.lblVND.TabIndex = 1;
            this.lblVND.Text = "VNĐ";
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSD.Location = new System.Drawing.Point(273, 223);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(41, 19);
            this.lblUSD.TabIndex = 4;
            this.lblUSD.Text = "USD";
            // 
            // lblDau
            // 
            this.lblDau.AutoSize = true;
            this.lblDau.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDau.Location = new System.Drawing.Point(134, 148);
            this.lblDau.Name = "lblDau";
            this.lblDau.Size = new System.Drawing.Size(29, 31);
            this.lblDau.TabIndex = 2;
            this.lblDau.Text = "=";
            // 
            // tabCtrlTuyChon
            // 
            this.tabCtrlTuyChon.Controls.Add(this.tabPageDoiTien);
            this.tabCtrlTuyChon.Controls.Add(this.tabPageDoiMK);
            this.tabCtrlTuyChon.Location = new System.Drawing.Point(12, 12);
            this.tabCtrlTuyChon.Name = "tabCtrlTuyChon";
            this.tabCtrlTuyChon.SelectedIndex = 0;
            this.tabCtrlTuyChon.Size = new System.Drawing.Size(360, 373);
            this.tabCtrlTuyChon.TabIndex = 0;
            // 
            // FrmTuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabCtrlTuyChon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTuyChon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÙY CHỌN";
            this.tabPageDoiMK.ResumeLayout(false);
            this.tabPageDoiMK.PerformLayout();
            this.tabPageDoiTien.ResumeLayout(false);
            this.tabPageDoiTien.PerformLayout();
            this.tabCtrlTuyChon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TabPage tabPageDoiMK;
        private System.Windows.Forms.TextBox txtMKNhapLai;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageDoiTien;
        private System.Windows.Forms.Label lblDau;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.TextBox txtVND;
        private System.Windows.Forms.TabControl tabCtrlTuyChon;
    }
}