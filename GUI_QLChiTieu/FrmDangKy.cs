using BUS_QLChiTieu;
using DTO_QLChiTieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLChiTieu
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        BUS_NguoiDung busNguoiDung = new BUS_NguoiDung();

        public bool IsValid(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string sex;
            if (rdbtnNam.Checked)
            {
                sex = "Nam";
            }
            else
            {
                sex = "Nữ";
            }

            //Kiểm tra tên đăng nhập
            if (txtTenDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDN.Focus();
                return;
            }
            //Kiểm tra họ tên
            else if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            //Kiểm tra email
            else if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            //Kiểm tra email có tồn tại
            else if (!IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng địa chỉ email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }
            //Kiểm tra mật khẩu
            else if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
            else if (txtMKNhapLai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKNhapLai.Focus();
                return;
            }
            else if (txtMKNhapLai.Text.Trim() != txtMatKhau.Text.Trim())
            {
                MessageBox.Show("Mật khẩu và mật khẩu nhập lại phải giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKNhapLai.Focus();
                return;
            }
            //Kiểm tra giới tính
            else if (rdbtnNam.Checked == false && rdbtnNu.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Thêm người dùng
            else
            {
                DTO_NguoiDung user = new DTO_NguoiDung(txtHoTen.Text, txtTenDN.Text, txtEmail.Text, busNguoiDung.encryption(txtMatKhau.Text), sex);
                if (busNguoiDung.DangKy(user))
                {
                    MessageBox.Show("Đăng ký thành công");
                    busNguoiDung.SendMail(txtEmail.Text);
                }
                else
                {
                    MessageBox.Show("Đăng thất bại");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
