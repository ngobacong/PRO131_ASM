using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLChiTieu
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public static string mail;
        string frmName;
        FrmTuyChon tuyChon = new FrmTuyChon();

        private void btnThuNhap_Click(object sender, EventArgs e)
        {
            this.panelControls.Hide();
            btnBack.Enabled = true;
            frmName = "FrmKhoanThu";

            FrmKhoanThu khoanThu = new FrmKhoanThu();
            khoanThu.TopLevel = false;

            this.panelMain.Controls.Add(khoanThu);
            khoanThu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            khoanThu.Dock = DockStyle.Fill;
            khoanThu.Show();
        }

        private void btnChiTieu_Click(object sender, EventArgs e)
        {
            this.panelControls.Hide();
            btnBack.Enabled = true;
            frmName = "FrmKhoanChi";

            FrmKhoanChi khoanChi = new FrmKhoanChi();
            khoanChi.TopLevel = false;

            this.panelMain.Controls.Add(khoanChi);
            khoanChi.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            khoanChi.Dock = DockStyle.Fill;
            khoanChi.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.panelControls.Hide();
            btnBack.Enabled = true;
            frmName = "FrmThongKe";

            FrmThongKe thongKe = new FrmThongKe();
            thongKe.TopLevel = false;

            this.panelMain.Controls.Add(thongKe);
            thongKe.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            thongKe.Dock = DockStyle.Fill;
            thongKe.Show();
        }

        private void btnMucTieu_Click(object sender, EventArgs e)
        {
            this.panelControls.Hide();
            btnBack.Enabled = true;
            frmName = "FrmMucTieu";

            FrmMucTieu mucTieu = new FrmMucTieu();
            mucTieu.TopLevel = false;

            this.panelMain.Controls.Add(mucTieu);
            mucTieu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mucTieu.Dock = DockStyle.Fill;
            mucTieu.Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Refresh();
            btnBack.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            CheckOpened(frmName);
            panelControls.Show();
        }

        private void CheckOpened(string name)
        {
            Form fc = Application.OpenForms[name];

            if (fc != null)
            {
                fc.Close();
            }
        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            tuyChon.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            tuyChon.Close();

            FrmDangNhap dn = new FrmDangNhap();
            dn.Show();

            this.Hide();
        }
    }
}
