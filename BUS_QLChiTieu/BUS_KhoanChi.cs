using DAL_QLChiTieu;
using DTO_QLChiTieu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLChiTieu
{
    public class BUS_KhoanChi
    {
        DAL_KhoanChi dalKhoanChi = new DAL_KhoanChi();

        public bool InsertKhoanChi(DTO_KhoanChi kc)
        {
            return dalKhoanChi.InsertKhoanChi(kc);
        }

        public bool UpdateKhoanChi(DTO_KhoanChi kc)
        {
            return dalKhoanChi.UpdateKhoanChi(kc);
        }

        public bool DeleteKhoanChi(string maKC)
        {
            return dalKhoanChi.DeleteKhoanChi(maKC);
        }

        public DataTable getKhoanChi()
        {
            return dalKhoanChi.getKhoanChi();
        }

        public DataTable getKhoanChiNgay(DateTime ngayBD, DateTime ngayKT)
        {
            return dalKhoanChi.getKhoanChiNgay(ngayBD, ngayKT);
        }

        public DataTable getKhoanChiThang(DateTime thang)
        {
            return dalKhoanChi.getKhoanChiThang(thang);
        }
    }
}
