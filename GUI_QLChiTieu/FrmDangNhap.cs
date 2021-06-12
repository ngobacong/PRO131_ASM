using BUS_QLChiTieu;
using DTO_QLChiTieu;
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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        BUS_NguoiDung busNguoiDung = new BUS_NguoiDung();

        public string email { get; set; }
        public string matkhau { get; set; }

        private void ckboxShowHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxShowHidePass.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DTO_NguoiDung user = new DTO_NguoiDung();
            user.TenDangNhap = txtTaiKhoan.Text;
            user.MatKhau = busNguoiDung.encryption(txtMatKhau.Text);
            if (busNguoiDung.NguoiDungDangNhap(user))
            {
                DataTable dt = busNguoiDung.EmailNguoiDung(user.TenDangNhap);
                email = dt.Rows[0][0].ToString();
                FrmMain.mail = email;
                MessageBox.Show("Đăng nhập thành công");

                FrmMain main = new FrmMain();
                main.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, kiểm tra lại tên đăng nhập hoặc mật khẩu");
                txtMatKhau.Text = null;
                txtTaiKhoan.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lnklblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKy dk = new FrmDangKy();
            dk.Show();
        }

        private void lnklblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau quenMK = new FrmQuenMatKhau();
            quenMK.Show();
        }
    }
}
