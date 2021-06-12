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
    public class BUS_KhoanThu
    {
        DAL_KhoanThu dalKhoanThu = new DAL_KhoanThu();

        public bool InsertKhoanThu(DTO_KhoanThu kt)
        {
            return dalKhoanThu.InsertKhoanThu(kt);
        }

        public bool UpdateKhoanThu(DTO_KhoanThu kt)
        {
            return dalKhoanThu.UpdateKhoanThu(kt);
        }

        public bool DeleteKhoanThu(string maKT)
        {
            return dalKhoanThu.DeleteKhoanThu(maKT);
        }

        public DataTable getKhoanThu()
        {
            return dalKhoanThu.getKhoanThu();
        }

        public DataTable getKhoanThuNgay(DateTime ngayBD, DateTime ngayKT)
        {
            return dalKhoanThu.getKhoanThuNgay(ngayBD, ngayKT);
        }

        public DataTable getKhoanThuThang(DateTime thang)
        {
            return dalKhoanThu.getKhoanThuThang(thang);
        }

        public DataTable getdsTkeNgay(DateTime ngayBD, DateTime ngayKT)
        {
            return dalKhoanThu.getdsTkeNgay(ngayBD, ngayKT);
        }

        public DataTable getdsTkeThang(DateTime thang)
        {
            return dalKhoanThu.getdsTkeThang(thang);
        }
    }
}
