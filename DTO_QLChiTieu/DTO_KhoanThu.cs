using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLChiTieu
{
    public class DTO_KhoanThu
    {
        private string maKT;
        private string maNgDung;
        private string tenKT;
        private DateTime ngayThu;
        private float soTien;
        private string moTa;
        private string email;

        public string MaKT
        {
            get
            {
                return maKT;
            }
            set
            {
                maKT = value;
            }
        }
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
        public string TenKT
        {
            get
            {
                return tenKT;
            }
            set
            {
                tenKT = value;
            }
        }
        public DateTime NgayThu
        {
            get
            {
                return ngayThu;
            }
            set
            {
                ngayThu = value;
            }
        }
        public float SoTien
        {
            get
            {
                return soTien;
            }
            set
            {
                soTien = value;
            }
        }
        public string MoTa
        {
            get
            {
                return moTa;
            }
            set
            {
                moTa = value;
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

        public DTO_KhoanThu(string tenKT, DateTime ngayThu, float soTien, string moTa, string email)
        {
            this.tenKT = tenKT;
            this.ngayThu = ngayThu;
            this.soTien = soTien;
            this.moTa = moTa;
            this.email = email;
        }
        public DTO_KhoanThu(string maKT, string tenKT, DateTime ngayThu, float soTien, string moTa)
        {
            this.maKT = maKT;
            this.tenKT = tenKT;
            this.ngayThu = ngayThu;
            this.soTien = soTien;
            this.moTa = moTa;
        }
        public DTO_KhoanThu() { }
    }
}
