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
    public class BUS_MucTieu
    {
        DAL_MucTieu dalMucTieu = new DAL_MucTieu();

        public bool InsertMucTieu(DTO_MucTieu mt)
        {
            return dalMucTieu.InsertMucTieu(mt);
        }

        public bool UpdateMucTieu(DTO_MucTieu mt)
        {
            return dalMucTieu.UpdatetMucTieu(mt);
        }

        public bool DeleteMucTieu(string maMT)
        {
            return dalMucTieu.DeleteMucTieu(maMT);
        }

        public DataTable getMucTieu()
        {
            return dalMucTieu.getMucTieu();
        }

        public DataTable getTkeMucTieu(DateTime ngay)
        {
            return dalMucTieu.getTkeMucTieu(ngay);
        }
    }
}
