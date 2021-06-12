using DTO_QLChiTieu;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLChiTieu
{
    public class DAL_NguoiDung : DBConnect
    {
        public bool NguoiDungDangNhap(DTO_NguoiDung user)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("tendangnhap", user.TenDangNhap);
                cmd.Parameters.AddWithValue("matKhau", user.MatKhau);

                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool NguoiDungQuenMK(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("email", email);

                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool TaoMatKhauMoi(string email, string matKhauMoi)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TaoMatKhauMoi";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matKhau", matKhauMoi);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DoiMatKhau(string email, string matKhauCu, string matKhauMoi)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "chgpwd";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("@opwd", matKhauCu);
                cmd.Parameters.AddWithValue("@npwd", matKhauMoi);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable EmailNguoiDung(string tenDangNhap)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayEmail";
                cmd.Parameters.AddWithValue("tendangnhap", tenDangNhap);
                DataTable dtNguoiDung = new DataTable();
                dtNguoiDung.Load(cmd.ExecuteReader());
                return dtNguoiDung;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool DangKy(DTO_NguoiDung user)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangKy";
                cmd.Parameters.AddWithValue("tenngdung", user.TenNgDung);
                cmd.Parameters.AddWithValue("tendangnhap", user.TenDangNhap);
                cmd.Parameters.AddWithValue("email", user.Email);
                cmd.Parameters.AddWithValue("matkhau", user.MatKhau);
                cmd.Parameters.AddWithValue("gioitinh", user.GioiTinh);

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
    }
}
