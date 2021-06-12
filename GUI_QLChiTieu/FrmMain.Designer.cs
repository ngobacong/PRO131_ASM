
namespace GUI_QLChiTieu
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTuyChon = new System.Windows.Forms.Button();
            this.btnMucTieu = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnChiTieu = new System.Windows.Forms.Button();
            this.btnThuNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Location = new System.Drawing.Point(12, 97);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(984, 620);
            this.panelMain.TabIndex = 8;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::GUI_QLChiTieu.Properties.Resources.logout;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangXuat.Location = new System.Drawing.Point(648, 248);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(152, 113);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTuyChon
            // 
            this.btnTuyChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuyChon.Image = global::GUI_QLChiTieu.Properties.Resources.options;
            this.btnTuyChon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTuyChon.Location = new System.Drawing.Point(348, 248);
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.Size = new System.Drawing.Size(152, 113);
            this.btnTuyChon.TabIndex = 5;
            this.btnTuyChon.Text = "Tùy Chọn";
            this.btnTuyChon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTuyChon.UseVisualStyleBackColor = true;
            this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click);
            // 
            // btnMucTieu
            // 
            this.btnMucTieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMucTieu.Image = global::GUI_QLChiTieu.Properties.Resources.target;
            this.btnMucTieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMucTieu.Location = new System.Drawing.Point(23, 248);
            this.btnMucTieu.Name = "btnMucTieu";
            this.btnMucTieu.Size = new System.Drawing.Size(152, 113);
            this.btnMucTieu.TabIndex = 4;
            this.btnMucTieu.Text = "Mục TIêu";
            this.btnMucTieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMucTieu.UseVisualStyleBackColor = true;
            this.btnMucTieu.Click += new System.EventHandler(this.btnMucTieu_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = global::GUI_QLChiTieu.Properties.Resources.thongKe;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThongKe.Location = new System.Drawing.Point(648, 27);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(152, 113);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnChiTieu
            // 
            this.btnChiTieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTieu.Image = global::GUI_QLChiTieu.Properties.Resources.pay;
            this.btnChiTieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChiTieu.Location = new System.Drawing.Point(348, 27);
            this.btnChiTieu.Name = "btnChiTieu";
            this.btnChiTieu.Size = new System.Drawing.Size(152, 113);
            this.btnChiTieu.TabIndex = 2;
            this.btnChiTieu.Text = "Chi Tiêu";
            this.btnChiTieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChiTieu.UseVisualStyleBackColor = true;
            this.btnChiTieu.Click += new System.EventHandler(this.btnChiTieu_Click);
            // 
            // btnThuNhap
            // 
            this.btnThuNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThuNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuNhap.Image = global::GUI_QLChiTieu.Properties.Resources.collection;
            this.btnThuNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThuNhap.Location = new System.Drawing.Point(34, 27);
            this.btnThuNhap.Name = "btnThuNhap";
            this.btnThuNhap.Size = new System.Drawing.Size(152, 113);
            this.btnThuNhap.TabIndex = 1;
            this.btnThuNhap.Text = "Thu Nhập";
            this.btnThuNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThuNhap.UseVisualStyleBackColor = true;
            this.btnThuNhap.Click += new System.EventHandler(this.btnThuNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Chi Tiêu Cá Nhân";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::GUI_QLChiTieu.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 53);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnThuNhap);
            this.panelControls.Controls.Add(this.btnDangXuat);
            this.panelControls.Controls.Add(this.btnMucTieu);
            this.panelControls.Controls.Add(this.btnThongKe);
            this.panelControls.Controls.Add(this.btnTuyChon);
            this.panelControls.Controls.Add(this.btnChiTieu);
            this.panelControls.Location = new System.Drawing.Point(67, 102);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(859, 389);
            this.panelControls.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CHI TIÊU CÁ NHÂN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTuyChon;
        private System.Windows.Forms.Button btnMucTieu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnChiTieu;
        private System.Windows.Forms.Button btnThuNhap;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelControls;
    }
}

