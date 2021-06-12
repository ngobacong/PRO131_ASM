
namespace GUI_QLChiTieu
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.tabCtrlTKe = new System.Windows.Forms.TabControl();
            this.tabPageNgay = new System.Windows.Forms.TabPage();
            this.dtpkNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.txtSoDuNgay = new System.Windows.Forms.TextBox();
            this.txtChiNgay = new System.Windows.Forms.TextBox();
            this.txtThuNgay = new System.Windows.Forms.TextBox();
            this.dtpkNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dgvChiNgay = new System.Windows.Forms.DataGridView();
            this.dgvThuNgay = new System.Windows.Forms.DataGridView();
            this.lblCTKCNgay = new System.Windows.Forms.Label();
            this.lblCTKTNgay = new System.Windows.Forms.Label();
            this.lblSoDuNgay = new System.Windows.Forms.Label();
            this.lblChiNgay = new System.Windows.Forms.Label();
            this.lblThuNgay = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.tabPageThang = new System.Windows.Forms.TabPage();
            this.txtSoDuThang = new System.Windows.Forms.TextBox();
            this.txtChiThang = new System.Windows.Forms.TextBox();
            this.txtThuThang = new System.Windows.Forms.TextBox();
            this.dtpkThang = new System.Windows.Forms.DateTimePicker();
            this.dgvChiThang = new System.Windows.Forms.DataGridView();
            this.dgvThuThang = new System.Windows.Forms.DataGridView();
            this.lblCTKCThang = new System.Windows.Forms.Label();
            this.lblCTKTThang = new System.Windows.Forms.Label();
            this.llblSoDuThang = new System.Windows.Forms.Label();
            this.lblChiThang = new System.Windows.Forms.Label();
            this.lblThuThang = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.tabCtrlTKe.SuspendLayout();
            this.tabPageNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuNgay)).BeginInit();
            this.tabPageThang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlTKe
            // 
            this.tabCtrlTKe.Controls.Add(this.tabPageNgay);
            this.tabCtrlTKe.Controls.Add(this.tabPageThang);
            this.tabCtrlTKe.Location = new System.Drawing.Point(15, 44);
            this.tabCtrlTKe.Margin = new System.Windows.Forms.Padding(4);
            this.tabCtrlTKe.Name = "tabCtrlTKe";
            this.tabCtrlTKe.SelectedIndex = 0;
            this.tabCtrlTKe.Size = new System.Drawing.Size(941, 559);
            this.tabCtrlTKe.TabIndex = 0;
            // 
            // tabPageNgay
            // 
            this.tabPageNgay.Controls.Add(this.dtpkNgayKT);
            this.tabPageNgay.Controls.Add(this.lblNgayKT);
            this.tabPageNgay.Controls.Add(this.txtSoDuNgay);
            this.tabPageNgay.Controls.Add(this.txtChiNgay);
            this.tabPageNgay.Controls.Add(this.txtThuNgay);
            this.tabPageNgay.Controls.Add(this.dtpkNgayBD);
            this.tabPageNgay.Controls.Add(this.dgvChiNgay);
            this.tabPageNgay.Controls.Add(this.dgvThuNgay);
            this.tabPageNgay.Controls.Add(this.lblCTKCNgay);
            this.tabPageNgay.Controls.Add(this.lblCTKTNgay);
            this.tabPageNgay.Controls.Add(this.lblSoDuNgay);
            this.tabPageNgay.Controls.Add(this.lblChiNgay);
            this.tabPageNgay.Controls.Add(this.lblThuNgay);
            this.tabPageNgay.Controls.Add(this.lblNgayBD);
            this.tabPageNgay.Location = new System.Drawing.Point(4, 28);
            this.tabPageNgay.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageNgay.Name = "tabPageNgay";
            this.tabPageNgay.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageNgay.Size = new System.Drawing.Size(933, 527);
            this.tabPageNgay.TabIndex = 0;
            this.tabPageNgay.Text = "Theo Ngày";
            this.tabPageNgay.UseVisualStyleBackColor = true;
            // 
            // dtpkNgayKT
            // 
            this.dtpkNgayKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayKT.Location = new System.Drawing.Point(206, 80);
            this.dtpkNgayKT.Name = "dtpkNgayKT";
            this.dtpkNgayKT.Size = new System.Drawing.Size(200, 26);
            this.dtpkNgayKT.TabIndex = 11;
            this.dtpkNgayKT.ValueChanged += new System.EventHandler(this.dtpkNgayKT_ValueChanged);
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKT.Location = new System.Drawing.Point(72, 80);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(111, 19);
            this.lblNgayKT.TabIndex = 10;
            this.lblNgayKT.Text = "Ngày Kết Thúc";
            // 
            // txtSoDuNgay
            // 
            this.txtSoDuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDuNgay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSoDuNgay.Location = new System.Drawing.Point(682, 100);
            this.txtSoDuNgay.Name = "txtSoDuNgay";
            this.txtSoDuNgay.ReadOnly = true;
            this.txtSoDuNgay.Size = new System.Drawing.Size(168, 26);
            this.txtSoDuNgay.TabIndex = 7;
            // 
            // txtChiNgay
            // 
            this.txtChiNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiNgay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtChiNgay.Location = new System.Drawing.Point(682, 59);
            this.txtChiNgay.Name = "txtChiNgay";
            this.txtChiNgay.ReadOnly = true;
            this.txtChiNgay.Size = new System.Drawing.Size(168, 26);
            this.txtChiNgay.TabIndex = 5;
            // 
            // txtThuNgay
            // 
            this.txtThuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuNgay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtThuNgay.Location = new System.Drawing.Point(682, 14);
            this.txtThuNgay.Name = "txtThuNgay";
            this.txtThuNgay.ReadOnly = true;
            this.txtThuNgay.Size = new System.Drawing.Size(168, 26);
            this.txtThuNgay.TabIndex = 3;
            // 
            // dtpkNgayBD
            // 
            this.dtpkNgayBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayBD.Location = new System.Drawing.Point(206, 17);
            this.dtpkNgayBD.Name = "dtpkNgayBD";
            this.dtpkNgayBD.Size = new System.Drawing.Size(200, 26);
            this.dtpkNgayBD.TabIndex = 1;
            this.dtpkNgayBD.ValueChanged += new System.EventHandler(this.dtpkNgayBD_ValueChanged);
            // 
            // dgvChiNgay
            // 
            this.dgvChiNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiNgay.Location = new System.Drawing.Point(24, 350);
            this.dgvChiNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiNgay.Name = "dgvChiNgay";
            this.dgvChiNgay.Size = new System.Drawing.Size(890, 160);
            this.dgvChiNgay.TabIndex = 8;
            // 
            // dgvThuNgay
            // 
            this.dgvThuNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuNgay.Location = new System.Drawing.Point(24, 152);
            this.dgvThuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuNgay.Name = "dgvThuNgay";
            this.dgvThuNgay.Size = new System.Drawing.Size(890, 160);
            this.dgvThuNgay.TabIndex = 7;
            // 
            // lblCTKCNgay
            // 
            this.lblCTKCNgay.AutoSize = true;
            this.lblCTKCNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTKCNgay.Location = new System.Drawing.Point(20, 327);
            this.lblCTKCNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTKCNgay.Name = "lblCTKCNgay";
            this.lblCTKCNgay.Size = new System.Drawing.Size(138, 19);
            this.lblCTKCNgay.TabIndex = 9;
            this.lblCTKCNgay.Text = "Chi Tiết Khoản Chi";
            // 
            // lblCTKTNgay
            // 
            this.lblCTKTNgay.AutoSize = true;
            this.lblCTKTNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTKTNgay.Location = new System.Drawing.Point(20, 129);
            this.lblCTKTNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTKTNgay.Name = "lblCTKTNgay";
            this.lblCTKTNgay.Size = new System.Drawing.Size(141, 19);
            this.lblCTKTNgay.TabIndex = 8;
            this.lblCTKTNgay.Text = "Chi Tiết Khoản Thu";
            // 
            // lblSoDuNgay
            // 
            this.lblSoDuNgay.AutoSize = true;
            this.lblSoDuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDuNgay.Location = new System.Drawing.Point(567, 103);
            this.lblSoDuNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDuNgay.Name = "lblSoDuNgay";
            this.lblSoDuNgay.Size = new System.Drawing.Size(52, 19);
            this.lblSoDuNgay.TabIndex = 6;
            this.lblSoDuNgay.Text = "Số Dư";
            // 
            // lblChiNgay
            // 
            this.lblChiNgay.AutoSize = true;
            this.lblChiNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiNgay.Location = new System.Drawing.Point(567, 59);
            this.lblChiNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiNgay.Name = "lblChiNgay";
            this.lblChiNgay.Size = new System.Drawing.Size(70, 19);
            this.lblChiNgay.TabIndex = 4;
            this.lblChiNgay.Text = "Tổng Chi";
            // 
            // lblThuNgay
            // 
            this.lblThuNgay.AutoSize = true;
            this.lblThuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuNgay.Location = new System.Drawing.Point(567, 17);
            this.lblThuNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThuNgay.Name = "lblThuNgay";
            this.lblThuNgay.Size = new System.Drawing.Size(73, 19);
            this.lblThuNgay.TabIndex = 2;
            this.lblThuNgay.Text = "Tổng Thu";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBD.Location = new System.Drawing.Point(72, 17);
            this.lblNgayBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(105, 19);
            this.lblNgayBD.TabIndex = 0;
            this.lblNgayBD.Text = "Ngày Bắt Đầu";
            // 
            // tabPageThang
            // 
            this.tabPageThang.Controls.Add(this.btnExport);
            this.tabPageThang.Controls.Add(this.txtSoDuThang);
            this.tabPageThang.Controls.Add(this.txtChiThang);
            this.tabPageThang.Controls.Add(this.txtThuThang);
            this.tabPageThang.Controls.Add(this.dtpkThang);
            this.tabPageThang.Controls.Add(this.dgvChiThang);
            this.tabPageThang.Controls.Add(this.dgvThuThang);
            this.tabPageThang.Controls.Add(this.lblCTKCThang);
            this.tabPageThang.Controls.Add(this.lblCTKTThang);
            this.tabPageThang.Controls.Add(this.llblSoDuThang);
            this.tabPageThang.Controls.Add(this.lblChiThang);
            this.tabPageThang.Controls.Add(this.lblThuThang);
            this.tabPageThang.Controls.Add(this.lblThang);
            this.tabPageThang.Location = new System.Drawing.Point(4, 28);
            this.tabPageThang.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageThang.Name = "tabPageThang";
            this.tabPageThang.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageThang.Size = new System.Drawing.Size(933, 527);
            this.tabPageThang.TabIndex = 1;
            this.tabPageThang.Text = "Theo Tháng";
            this.tabPageThang.UseVisualStyleBackColor = true;
            // 
            // txtSoDuThang
            // 
            this.txtSoDuThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDuThang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSoDuThang.Location = new System.Drawing.Point(688, 103);
            this.txtSoDuThang.Name = "txtSoDuThang";
            this.txtSoDuThang.ReadOnly = true;
            this.txtSoDuThang.Size = new System.Drawing.Size(168, 26);
            this.txtSoDuThang.TabIndex = 17;
            // 
            // txtChiThang
            // 
            this.txtChiThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiThang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtChiThang.Location = new System.Drawing.Point(688, 59);
            this.txtChiThang.Name = "txtChiThang";
            this.txtChiThang.ReadOnly = true;
            this.txtChiThang.Size = new System.Drawing.Size(168, 26);
            this.txtChiThang.TabIndex = 15;
            // 
            // txtThuThang
            // 
            this.txtThuThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuThang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtThuThang.Location = new System.Drawing.Point(688, 17);
            this.txtThuThang.Name = "txtThuThang";
            this.txtThuThang.ReadOnly = true;
            this.txtThuThang.Size = new System.Drawing.Size(168, 26);
            this.txtThuThang.TabIndex = 13;
            // 
            // dtpkThang
            // 
            this.dtpkThang.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpkThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkThang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkThang.Location = new System.Drawing.Point(189, 20);
            this.dtpkThang.Name = "dtpkThang";
            this.dtpkThang.Size = new System.Drawing.Size(200, 26);
            this.dtpkThang.TabIndex = 11;
            this.dtpkThang.ValueChanged += new System.EventHandler(this.dtpkThang_ValueChanged);
            // 
            // dgvChiThang
            // 
            this.dgvChiThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiThang.Location = new System.Drawing.Point(23, 353);
            this.dgvChiThang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiThang.Name = "dgvChiThang";
            this.dgvChiThang.Size = new System.Drawing.Size(890, 160);
            this.dgvChiThang.TabIndex = 20;
            // 
            // dgvThuThang
            // 
            this.dgvThuThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuThang.Location = new System.Drawing.Point(23, 155);
            this.dgvThuThang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuThang.Name = "dgvThuThang";
            this.dgvThuThang.Size = new System.Drawing.Size(890, 160);
            this.dgvThuThang.TabIndex = 19;
            // 
            // lblCTKCThang
            // 
            this.lblCTKCThang.AutoSize = true;
            this.lblCTKCThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTKCThang.Location = new System.Drawing.Point(19, 330);
            this.lblCTKCThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTKCThang.Name = "lblCTKCThang";
            this.lblCTKCThang.Size = new System.Drawing.Size(138, 19);
            this.lblCTKCThang.TabIndex = 19;
            this.lblCTKCThang.Text = "Chi Tiết Khoản Chi";
            // 
            // lblCTKTThang
            // 
            this.lblCTKTThang.AutoSize = true;
            this.lblCTKTThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTKTThang.Location = new System.Drawing.Point(19, 132);
            this.lblCTKTThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCTKTThang.Name = "lblCTKTThang";
            this.lblCTKTThang.Size = new System.Drawing.Size(141, 19);
            this.lblCTKTThang.TabIndex = 18;
            this.lblCTKTThang.Text = "Chi Tiết Khoản Thu";
            // 
            // llblSoDuThang
            // 
            this.llblSoDuThang.AutoSize = true;
            this.llblSoDuThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSoDuThang.Location = new System.Drawing.Point(573, 106);
            this.llblSoDuThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblSoDuThang.Name = "llblSoDuThang";
            this.llblSoDuThang.Size = new System.Drawing.Size(52, 19);
            this.llblSoDuThang.TabIndex = 16;
            this.llblSoDuThang.Text = "Số Dư";
            // 
            // lblChiThang
            // 
            this.lblChiThang.AutoSize = true;
            this.lblChiThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiThang.Location = new System.Drawing.Point(573, 59);
            this.lblChiThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiThang.Name = "lblChiThang";
            this.lblChiThang.Size = new System.Drawing.Size(70, 19);
            this.lblChiThang.TabIndex = 14;
            this.lblChiThang.Text = "Tổng Chi";
            // 
            // lblThuThang
            // 
            this.lblThuThang.AutoSize = true;
            this.lblThuThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuThang.Location = new System.Drawing.Point(573, 20);
            this.lblThuThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThuThang.Name = "lblThuThang";
            this.lblThuThang.Size = new System.Drawing.Size(73, 19);
            this.lblThuThang.TabIndex = 12;
            this.lblThuThang.Text = "Tổng Thu";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(84, 20);
            this.lblThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(90, 19);
            this.lblThang.TabIndex = 10;
            this.lblThang.Text = "Chọn Tháng";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(420, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(126, 31);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thống Kê";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(189, 75);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 30);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Xuất File";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 616);
            this.Controls.Add(this.tabCtrlTKe);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ";
            this.tabCtrlTKe.ResumeLayout(false);
            this.tabPageNgay.ResumeLayout(false);
            this.tabPageNgay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuNgay)).EndInit();
            this.tabPageThang.ResumeLayout(false);
            this.tabPageThang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlTKe;
        private System.Windows.Forms.TabPage tabPageNgay;
        private System.Windows.Forms.TabPage tabPageThang;
        private System.Windows.Forms.Label lblCTKCNgay;
        private System.Windows.Forms.Label lblCTKTNgay;
        private System.Windows.Forms.Label lblSoDuNgay;
        private System.Windows.Forms.Label lblChiNgay;
        private System.Windows.Forms.Label lblThuNgay;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DateTimePicker dtpkNgayBD;
        private System.Windows.Forms.DataGridView dgvChiNgay;
        private System.Windows.Forms.DataGridView dgvThuNgay;
        private System.Windows.Forms.TextBox txtSoDuNgay;
        private System.Windows.Forms.TextBox txtChiNgay;
        private System.Windows.Forms.TextBox txtThuNgay;
        private System.Windows.Forms.TextBox txtSoDuThang;
        private System.Windows.Forms.TextBox txtChiThang;
        private System.Windows.Forms.TextBox txtThuThang;
        private System.Windows.Forms.DateTimePicker dtpkThang;
        private System.Windows.Forms.DataGridView dgvChiThang;
        private System.Windows.Forms.DataGridView dgvThuThang;
        private System.Windows.Forms.Label lblCTKCThang;
        private System.Windows.Forms.Label lblCTKTThang;
        private System.Windows.Forms.Label llblSoDuThang;
        private System.Windows.Forms.Label lblChiThang;
        private System.Windows.Forms.Label lblThuThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.DateTimePicker dtpkNgayKT;
        private System.Windows.Forms.Button btnExport;
    }
}