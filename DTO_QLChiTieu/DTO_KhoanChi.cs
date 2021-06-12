using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLChiTieu
{
    public class DTO_KhoanChi
    {
        private string maKC;
        private string maNgDung;
        private string tenKC;
        private DateTime ngayChi;
        private float soTien;
        private string moTa;
        private string email;

        public string MaKC
        {
            get
            {
                return maKC;
            }
            set
            {
                maKC = value;
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
        public string TenKC
        {
            get
            {
                return tenKC;
            }
            set
            {
                tenKC = value;
            }
        }
        public DateTime NgayChi
        {
            get
            {
                return ngayChi;
            }
            set
            {
                ngayChi = value;
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

        public DTO_KhoanChi(string tenKC, DateTime ngayChi, float soTien, string moTa, string email)
        {
            this.tenKC = tenKC;
            this.ngayChi = ngayChi;
            this.soTien = soTien;
            this.moTa = moTa;
            this.email = email;
        }
        public DTO_KhoanChi(string maKC, string tenKC, DateTime ngayChi, float soTien, string moTa)
        {
            this.maKC = maKC;
            this.tenKC = tenKC;
            this.ngayChi = ngayChi;
            this.soTien = soTien;
            this.moTa = moTa;
        }
        public DTO_KhoanChi() { }
    }
}
