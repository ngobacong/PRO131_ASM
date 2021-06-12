using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLChiTieu
{
    public class DTO_MucTieu
    {
        private string maMT;
        private string maNgDung;
        private float mtNgay;
        private float mtThang;
        private DateTime ngay;
        private string moTa;
        private string email;

        public string MaMT
        {
            get
            {
                return maMT;
            }
            set
            {
                maMT = value;
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
        public float MtNgay
        {
            get
            {
                return mtNgay;
            }
            set
            {
                mtNgay = value;
            }
        }
        public float MtThang
        {
            get
            {
                return mtThang;
            }
            set
            {
                mtThang = value;
            }
        }
        public DateTime Ngay
        {
            get
            {
                return ngay;
            }
            set
            {
                ngay = value;
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

        public DTO_MucTieu(float mtNgay, float mtThang, DateTime ngay, string moTa, string email)
        {
            this.mtNgay = mtNgay;
            this.mtThang = mtThang;
            this.ngay = ngay;
            this.moTa = moTa;
            this.email = email;
        }
        public DTO_MucTieu(string maMT, float mtNgay, float mtThang, DateTime ngay, string moTa)
        {
            this.maMT = maMT;
            this.mtNgay = mtNgay;
            this.mtThang = mtThang;
            this.ngay = ngay;
            this.moTa = moTa;
        }
        public DTO_MucTieu() { }
    }
}
