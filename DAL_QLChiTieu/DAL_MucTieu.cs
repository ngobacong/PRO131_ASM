using DTO_QLChiTieu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLChiTieu
{
    public class DAL_MucTieu :DBConnect
    {
        public bool InsertMucTieu(DTO_MucTieu mt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataIntoMucTieu";
                cmd.Parameters.AddWithValue("mtNgay", mt.MtNgay);
                cmd.Parameters.AddWithValue("mtThang", mt.MtThang);
                cmd.Parameters.AddWithValue("ngay", mt.Ngay);
                cmd.Parameters.AddWithValue("mota", mt.MoTa);
                cmd.Parameters.AddWithValue("email", mt.Email);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool UpdatetMucTieu(DTO_MucTieu mt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntoMucTieu";
                cmd.Parameters.AddWithValue("maMT", mt.MaMT);
                cmd.Parameters.AddWithValue("mtNgay", mt.MtNgay);
                cmd.Parameters.AddWithValue("mtThang", mt.MtThang);
                cmd.Parameters.AddWithValue("ngay", mt.Ngay);
                cmd.Parameters.AddWithValue("mota", mt.MoTa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DeleteMucTieu(string maMT)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromMucTieu";
                cmd.Parameters.AddWithValue("maMT", maMT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable getMucTieu()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachMucTieu";
                DataTable dtMucTieu = new DataTable();
                dtMucTieu.Load(cmd.ExecuteReader());
                return dtMucTieu;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable getTkeMucTieu(DateTime ngay)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeMucTieu";
                cmd.Parameters.AddWithValue("ngay", ngay);
                DataTable dtTkeMT = new DataTable();
                dtTkeMT.Load(cmd.ExecuteReader());
                return dtTkeMT;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
