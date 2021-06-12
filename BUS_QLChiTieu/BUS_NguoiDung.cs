using DAL_QLChiTieu;
using DTO_QLChiTieu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLChiTieu
{
    public class BUS_NguoiDung
    {
        DAL_NguoiDung dalNguoiDung = new DAL_NguoiDung();

        public bool NguoiDungDangNhap(DTO_NguoiDung user)
        {
            return dalNguoiDung.NguoiDungDangNhap(user);
        }

        public bool NguoiDungQuenMK(string email)
        {
            return dalNguoiDung.NguoiDungQuenMK(email);
        }

        public bool TaoMatKhauMoi(string email, string matKhauMoi)
        {
            return dalNguoiDung.TaoMatKhauMoi(email, matKhauMoi);
        }

        public bool DoiMatKhau(string email, string matKhauCu, string matKhauMoi)
        {
            return dalNguoiDung.DoiMatKhau(email, matKhauCu, matKhauMoi);
        }

        public DataTable EmailNguoiDung(string tenDangNhap)
        {
            return dalNguoiDung.EmailNguoiDung(tenDangNhap);
        }

        public bool DangKy(DTO_NguoiDung user)
        {
            return dalNguoiDung.DangKy(user);
        }

        public string encryption(string password)
        {
            //Tạo MD5 
            MD5 md5 = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            //mã hóa chuỗi đã chuyển
            byte[] hash = md5.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder
            StringBuilder encryptdata = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                encryptdata.Append(hash[i].ToString("x2"));
            }
            return encryptdata.ToString();
        }

        public void SendMail(string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

                NetworkCredential cred = new NetworkCredential("alienlys1309@gmail.com", "@ps12496");

                MailMessage Msg = new MailMessage();

                Msg.From = new MailAddress("ngobacong2@gmail.com");

                Msg.To.Add(email);

                Msg.Subject = "Chào mừng người dùng mới";

                Msg.Body = "Chào anh/chị. Cảm ơn anh/chị đã sử dụng sản phẩm của chúng tôi";

                client.Credentials = cred;

                client.EnableSsl = true;
                client.Send(Msg);

                MessageBox.Show("Một Email đã được gửi tới bạn!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
