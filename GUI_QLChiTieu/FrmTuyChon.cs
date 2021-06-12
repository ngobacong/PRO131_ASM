using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS_QLChiTieu;
using System.Net.Mail;
using System.Net;

namespace GUI_QLChiTieu
{
    public partial class FrmTuyChon : Form
    {
        public FrmTuyChon()
        {
            InitializeComponent();
        }

        BUS_NguoiDung busNguoiDung = new BUS_NguoiDung();
        string stremail = FrmMain.mail;
        double vnd;
        double usd;

        private void txtVND_TextChanged(object sender, EventArgs e)
        {
            if(txtVND.Text == "")
            {
                txtUSD.Text = "0";
                
            }
            else
            {
                vnd = Convert.ToDouble(txtVND.Text);
                usd = vnd / 23170;
                txtUSD.Text = usd.ToString();
            }
        }

        private void txtUSD_TextChanged(object sender, EventArgs e)
        {
            if (txtUSD.Text == "")
            {
                txtVND.Text = "0";
            }
            else
            {
                usd = Convert.ToDouble(txtUSD.Text);
                vnd = usd * 23170;
                txtVND.Text = vnd.ToString();
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKCu.Focus();
                return;
            }
            else if (txtMKMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Focus();
                return;
            }
            else if (txtMKNhapLai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKNhapLai.Focus();
                return;
            }
            else if (txtMKNhapLai.Text.Trim() != txtMKMoi.Text.Trim())
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới và mật khẩu nhập lại giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Focus();
                return;
            }
            else if (txtMKMoi.Text.Trim() == txtMKCu.Text.Trim())
            {
                MessageBox.Show("Bạn phải nhập mật mới khác mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matKhauMoi = busNguoiDung.encryption(txtMKMoi.Text);
                    string matKhauCu = busNguoiDung.encryption(txtMKCu.Text);
                    if (busNguoiDung.DoiMatKhau(stremail, matKhauCu, matKhauMoi))
                    {
                        SendMail(stremail, txtMKNhapLai.Text);
                        MessageBox.Show("Cập nhật mật khẩu thành công, bạn phải đăng nhập lại");
                        this.Close();
                        Form fc = Application.OpenForms["FrmMain"];

                        if (fc != null)
                        {
                            fc.Hide();
                        }

                        FrmDangNhap dn = new FrmDangNhap();
                        dn.Show();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void SendMail(string email, string matKhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

                NetworkCredential cred = new NetworkCredential("alienlys1309@gmail.com", "@ps12496");

                MailMessage Msg = new MailMessage();

                Msg.From = new MailAddress("alienlys1309@gmail.com");

                Msg.To.Add(email);

                Msg.Subject = "Bạn đã sử dụng tính năng đổi mật khẩu";

                Msg.Body = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là " + matKhau;

                client.Credentials = cred;

                client.EnableSsl = true;
                client.Send(Msg);

                MessageBox.Show("Một Email đổi mật khẩu đã được gửi tới bạn!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
