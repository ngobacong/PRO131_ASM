using BUS_QLChiTieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLChiTieu
{
    public partial class FrmQuenMatKhau : Form
    {
        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }

        BUS_NguoiDung busNguoiDung = new BUS_NguoiDung();

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (busNguoiDung.NguoiDungQuenMK(txtEmail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                    builder.Append(RandomString(2, false));
                    MessageBox.Show(builder.ToString());
                    string matkhaumoi = busNguoiDung.encryption(builder.ToString());
                    busNguoiDung.TaoMatKhauMoi(txtEmail.Text, matkhaumoi);
                    SendMail(txtEmail.Text, builder.ToString());
                }
                else
                {
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại email!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email nhận thông tin phục hồi mật khẩu!");
                txtEmail.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void SendMail(string email, string matkhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

                NetworkCredential cred = new NetworkCredential("alienlys1309@gmail.com", "@ps12496");

                MailMessage Msg = new MailMessage();

                Msg.From = new MailAddress("alienlys1309@gmail.com");

                Msg.To.Add(email);

                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";

                Msg.Body = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là " + matkhau;

                client.Credentials = cred;

                client.EnableSsl = true;
                client.Send(Msg);

                MessageBox.Show("Một Email phục hồi mật khẩu đã được gửi tới bạn!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
