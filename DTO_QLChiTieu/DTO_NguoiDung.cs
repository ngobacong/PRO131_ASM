using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLChiTieu
{
    public class DTO_NguoiDung
    {
        private string maNgDung;
        private string tenNgDung;
        private string tenDangNhap;
        private string email;
        private string matKhau;
        private string gioiTinh;

        public string MaNgDung
        {
            get
            {
                return maNgDung;
            }
            set
            {
                maNgDung = value;
            }
        }
        public string TenNgDung
        {
            get
            {
                return tenNgDung;
            }
            set
            {
                tenNgDung = value;
            }
        }
        public string TenDangNhap
        {
            get
            {
                return tenDangNhap;
            }
            set
            {
                tenDangNhap = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return matKhau;
            }
            set
            {
                matKhau = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }
            set
            {
                gioiTinh = value;
            }
        }

        public DTO_NguoiDung(string tenNgDung, string tenDangNhap, string email, string matKhau, string gioiTinh)
        {
            this.tenNgDung = tenNgDung;
            this.tenDangNhap = tenDangNhap;
            this.email = email;
            this.matKhau = matKhau;
            this.gioiTinh = gioiTinh;
        }
        public DTO_NguoiDung() { }
    }
}
