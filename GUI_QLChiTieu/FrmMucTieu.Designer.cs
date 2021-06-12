
namespace GUI_QLChiTieu
{
    partial class FrmMucTieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMucTieu));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMTNgay = new System.Windows.Forms.Label();
            this.lblMTThang = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMTNgay = new System.Windows.Forms.TextBox();
            this.txtMTThang = new System.Windows.Forms.TextBox();
            this.dtpkNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvMucTieu = new System.Windows.Forms.DataGridView();
            this.lblMaMT = new System.Windows.Forms.Label();
            this.txtMaMT = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMucTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(444, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(123, 31);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Mục Tiêu";
            // 
            // lblMTNgay
            // 
            this.lblMTNgay.AutoSize = true;
            this.lblMTNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMTNgay.Location = new System.Drawing.Point(74, 121);
            this.lblMTNgay.Name = "lblMTNgay";
            this.lblMTNgay.Size = new System.Drawing.Size(154, 19);
            this.lblMTNgay.TabIndex = 3;
            this.lblMTNgay.Text = "Mục Tiêu Hàng Ngày";
            // 
            // lblMTThang
            // 
            this.lblMTThang.AutoSize = true;
            this.lblMTThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMTThang.Location = new System.Drawing.Point(74, 174);
            this.lblMTThang.Name = "lblMTThang";
            this.lblMTThang.Size = new System.Drawing.Size(120, 19);
            this.lblMTThang.TabIndex = 5;
            this.lblMTThang.Text = "Mục Tiêu Tháng";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(74, 216);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(45, 19);
            this.lblNgay.TabIndex = 7;
            this.lblNgay.Text = "Ngày";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::GUI_QLChiTieu.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(560, 197);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 45);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::GUI_QLChiTieu.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(693, 197);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 45);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI_QLChiTieu.Properties.Resources.remove;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(815, 197);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 45);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMTNgay
            // 
            this.txtMTNgay.Location = new System.Drawing.Point(282, 121);
            this.txtMTNgay.Name = "txtMTNgay";
            this.txtMTNgay.Size = new System.Drawing.Size(190, 26);
            this.txtMTNgay.TabIndex = 4;
            // 
            // txtMTThang
            // 
            this.txtMTThang.Location = new System.Drawing.Point(282, 172);
            this.txtMTThang.Name = "txtMTThang";
            this.txtMTThang.Size = new System.Drawing.Size(190, 26);
            this.txtMTThang.TabIndex = 6;
            // 
            // dtpkNgay
            // 
            this.dtpkNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgay.Location = new System.Drawing.Point(282, 216);
            this.dtpkNgay.Name = "dtpkNgay";
            this.dtpkNgay.Size = new System.Drawing.Size(190, 26);
            this.dtpkNgay.TabIndex = 8;
            // 
            // dgvMucTieu
            // 
            this.dgvMucTieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMucTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMucTieu.Location = new System.Drawing.Point(12, 280);
            this.dgvMucTieu.Name = "dgvMucTieu";
            this.dgvMucTieu.Size = new System.Drawing.Size(945, 324);
            this.dgvMucTieu.TabIndex = 10;
            this.dgvMucTieu.Click += new System.EventHandler(this.dgvMucTieu_Click);
            // 
            // lblMaMT
            // 
            this.lblMaMT.AutoSize = true;
            this.lblMaMT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMT.Location = new System.Drawing.Point(74, 78);
            this.lblMaMT.Name = "lblMaMT";
            this.lblMaMT.Size = new System.Drawing.Size(102, 19);
            this.lblMaMT.TabIndex = 1;
            this.lblMaMT.Text = "Mã Mục Tiêu";
            // 
            // txtMaMT
            // 
            this.txtMaMT.Location = new System.Drawing.Point(282, 75);
            this.txtMaMT.Name = "txtMaMT";
            this.txtMaMT.Size = new System.Drawing.Size(190, 26);
            this.txtMaMT.TabIndex = 2;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(635, 75);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(270, 100);
            this.txtMoTa.TabIndex = 10;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(556, 78);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(55, 19);
            this.lblMoTa.TabIndex = 9;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // FrmMucTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 616);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtMaMT);
            this.Controls.Add(this.lblMaMT);
            this.Controls.Add(this.dgvMucTieu);
            this.Controls.Add(this.dtpkNgay);
            this.Controls.Add(this.txtMTThang);
            this.Controls.Add(this.txtMTNgay);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblMTThang);
            this.Controls.Add(this.lblMTNgay);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMucTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MỤC TIÊU";
            this.Load += new System.EventHandler(this.FrmMucTieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMucTieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMTNgay;
        private System.Windows.Forms.Label lblMTThang;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMTNgay;
        private System.Windows.Forms.TextBox txtMTThang;
        private System.Windows.Forms.DateTimePicker dtpkNgay;
        private System.Windows.Forms.DataGridView dgvMucTieu;
        private System.Windows.Forms.Label lblMaMT;
        private System.Windows.Forms.TextBox txtMaMT;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
    }
}