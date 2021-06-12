
namespace GUI_QLChiTieu
{
    partial class FrmKhoanThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoanThu));
            this.dgvKhoanThu = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblKhoanThu = new System.Windows.Forms.Label();
            this.lblNgayThu = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtKhoanThu = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.dtpkNgayThu = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMaKT = new System.Windows.Forms.Label();
            this.txtMaKT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhoanThu
            // 
            this.dgvKhoanThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoanThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanThu.Location = new System.Drawing.Point(14, 253);
            this.dgvKhoanThu.Name = "dgvKhoanThu";
            this.dgvKhoanThu.Size = new System.Drawing.Size(943, 351);
            this.dgvKhoanThu.TabIndex = 0;
            this.dgvKhoanThu.Click += new System.EventHandler(this.dgvKhoanThu_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(430, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(144, 31);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Khoản Thu";
            // 
            // lblKhoanThu
            // 
            this.lblKhoanThu.AutoSize = true;
            this.lblKhoanThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoanThu.Location = new System.Drawing.Point(73, 114);
            this.lblKhoanThu.Name = "lblKhoanThu";
            this.lblKhoanThu.Size = new System.Drawing.Size(113, 19);
            this.lblKhoanThu.TabIndex = 3;
            this.lblKhoanThu.Text = "Tên Khoản Thu";
            // 
            // lblNgayThu
            // 
            this.lblNgayThu.AutoSize = true;
            this.lblNgayThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThu.Location = new System.Drawing.Point(73, 172);
            this.lblNgayThu.Name = "lblNgayThu";
            this.lblNgayThu.Size = new System.Drawing.Size(75, 19);
            this.lblNgayThu.TabIndex = 5;
            this.lblNgayThu.Text = "Ngày Thu";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(73, 215);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(60, 19);
            this.lblSoTien.TabIndex = 7;
            this.lblSoTien.Text = "Số Tiền";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(548, 59);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(55, 19);
            this.lblMoTa.TabIndex = 9;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // txtKhoanThu
            // 
            this.txtKhoanThu.Location = new System.Drawing.Point(236, 111);
            this.txtKhoanThu.Multiline = true;
            this.txtKhoanThu.Name = "txtKhoanThu";
            this.txtKhoanThu.Size = new System.Drawing.Size(210, 30);
            this.txtKhoanThu.TabIndex = 4;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(236, 212);
            this.txtSoTien.Multiline = true;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(210, 30);
            this.txtSoTien.TabIndex = 8;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(625, 56);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(255, 75);
            this.txtMoTa.TabIndex = 10;
            // 
            // dtpkNgayThu
            // 
            this.dtpkNgayThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayThu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpkNgayThu.Location = new System.Drawing.Point(236, 166);
            this.dtpkNgayThu.Name = "dtpkNgayThu";
            this.dtpkNgayThu.Size = new System.Drawing.Size(210, 26);
            this.dtpkNgayThu.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI_QLChiTieu.Properties.Resources.remove;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(775, 202);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 45);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::GUI_QLChiTieu.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(625, 202);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 45);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI_QLChiTieu.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(775, 137);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 45);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI_QLChiTieu.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(625, 137);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 45);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMaKT
            // 
            this.lblMaKT.AutoSize = true;
            this.lblMaKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKT.Location = new System.Drawing.Point(73, 62);
            this.lblMaKT.Name = "lblMaKT";
            this.lblMaKT.Size = new System.Drawing.Size(111, 19);
            this.lblMaKT.TabIndex = 1;
            this.lblMaKT.Text = "Mã Khoàn Thu";
            // 
            // txtMaKT
            // 
            this.txtMaKT.Location = new System.Drawing.Point(236, 59);
            this.txtMaKT.Multiline = true;
            this.txtMaKT.Name = "txtMaKT";
            this.txtMaKT.Size = new System.Drawing.Size(210, 30);
            this.txtMaKT.TabIndex = 2;
            // 
            // FrmKhoanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 616);
            this.Controls.Add(this.txtMaKT);
            this.Controls.Add(this.lblMaKT);
            this.Controls.Add(this.dtpkNgayThu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtKhoanThu);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.lblNgayThu);
            this.Controls.Add(this.lblKhoanThu);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvKhoanThu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKhoanThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHOẢN THU";
            this.Load += new System.EventHandler(this.FrmKhoanThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhoanThu;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblKhoanThu;
        private System.Windows.Forms.Label lblNgayThu;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtKhoanThu;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dtpkNgayThu;
        private System.Windows.Forms.Label lblMaKT;
        private System.Windows.Forms.TextBox txtMaKT;
    }
}