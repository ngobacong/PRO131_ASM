
namespace GUI_QLChiTieu
{
    partial class FrmKhoanChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoanChi));
            this.dgvKhoanChi = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblKhoanChi = new System.Windows.Forms.Label();
            this.lblNgayChi = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtKhoanChi = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.dtpkNgayChi = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaKC = new System.Windows.Forms.TextBox();
            this.lblMaKC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanChi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhoanChi
            // 
            this.dgvKhoanChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoanChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanChi.Location = new System.Drawing.Point(14, 253);
            this.dgvKhoanChi.Name = "dgvKhoanChi";
            this.dgvKhoanChi.Size = new System.Drawing.Size(943, 351);
            this.dgvKhoanChi.TabIndex = 0;
            this.dgvKhoanChi.Click += new System.EventHandler(this.dgvKhoanChi_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(405, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(138, 31);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Khoản Chi";
            // 
            // lblKhoanChi
            // 
            this.lblKhoanChi.AutoSize = true;
            this.lblKhoanChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoanChi.Location = new System.Drawing.Point(76, 113);
            this.lblKhoanChi.Name = "lblKhoanChi";
            this.lblKhoanChi.Size = new System.Drawing.Size(110, 19);
            this.lblKhoanChi.TabIndex = 3;
            this.lblKhoanChi.Text = "Tên Khoản Chi";
            // 
            // lblNgayChi
            // 
            this.lblNgayChi.AutoSize = true;
            this.lblNgayChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayChi.Location = new System.Drawing.Point(76, 168);
            this.lblNgayChi.Name = "lblNgayChi";
            this.lblNgayChi.Size = new System.Drawing.Size(72, 19);
            this.lblNgayChi.TabIndex = 5;
            this.lblNgayChi.Text = "Ngày Chi";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(76, 214);
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
            // txtKhoanChi
            // 
            this.txtKhoanChi.Location = new System.Drawing.Point(239, 113);
            this.txtKhoanChi.Multiline = true;
            this.txtKhoanChi.Name = "txtKhoanChi";
            this.txtKhoanChi.Size = new System.Drawing.Size(210, 30);
            this.txtKhoanChi.TabIndex = 4;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(239, 211);
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
            // dtpkNgayChi
            // 
            this.dtpkNgayChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayChi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpkNgayChi.Location = new System.Drawing.Point(239, 168);
            this.dtpkNgayChi.Name = "dtpkNgayChi";
            this.dtpkNgayChi.Size = new System.Drawing.Size(210, 26);
            this.dtpkNgayChi.TabIndex = 6;
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
            this.btnSua.Location = new System.Drawing.Point(625, 201);
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
            this.btnThem.Location = new System.Drawing.Point(625, 136);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 45);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaKC
            // 
            this.txtMaKC.Location = new System.Drawing.Point(239, 59);
            this.txtMaKC.Multiline = true;
            this.txtMaKC.Name = "txtMaKC";
            this.txtMaKC.Size = new System.Drawing.Size(210, 30);
            this.txtMaKC.TabIndex = 2;
            // 
            // lblMaKC
            // 
            this.lblMaKC.AutoSize = true;
            this.lblMaKC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKC.Location = new System.Drawing.Point(76, 62);
            this.lblMaKC.Name = "lblMaKC";
            this.lblMaKC.Size = new System.Drawing.Size(108, 19);
            this.lblMaKC.TabIndex = 1;
            this.lblMaKC.Text = "Mã Khoản Chi";
            // 
            // FrmKhoanChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 616);
            this.Controls.Add(this.lblMaKC);
            this.Controls.Add(this.txtMaKC);
            this.Controls.Add(this.dtpkNgayChi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtKhoanChi);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.lblNgayChi);
            this.Controls.Add(this.lblKhoanChi);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvKhoanChi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKhoanChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHOẢN CHI";
            this.Load += new System.EventHandler(this.FrmKhoanChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhoanChi;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblKhoanChi;
        private System.Windows.Forms.Label lblNgayChi;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtKhoanChi;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dtpkNgayChi;
        private System.Windows.Forms.TextBox txtMaKC;
        private System.Windows.Forms.Label lblMaKC;
    }
}