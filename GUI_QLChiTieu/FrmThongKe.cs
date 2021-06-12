using BUS_QLChiTieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace GUI_QLChiTieu
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        BUS_KhoanThu busKhoanThu = new BUS_KhoanThu();
        BUS_KhoanChi busKhoanChi = new BUS_KhoanChi();
        BUS_MucTieu busMucTieu = new BUS_MucTieu();

        private void dtpkThang_ValueChanged(object sender, EventArgs e)
        {
            dgvThuThang.DataSource = busKhoanThu.getKhoanThuThang(dtpkThang.Value);
            dgvThuThang.Columns[0].HeaderText = "Mã Khoản Thu";
            dgvThuThang.Columns[1].Visible = false;
            dgvThuThang.Columns[2].HeaderText = "Tên Khoản Thu";
            dgvThuThang.Columns[3].HeaderText = "Ngày Thu";
            dgvThuThang.Columns[4].HeaderText = "Số Tiền";
            dgvThuThang.Columns[5].HeaderText = "Mô Tả";

            dgvChiThang.DataSource = busKhoanChi.getKhoanChiThang(dtpkThang.Value);
            dgvChiThang.Columns[0].HeaderText = "Mã Khoản Chi";
            dgvChiThang.Columns[1].Visible = false;
            dgvChiThang.Columns[2].HeaderText = "Tên Khoản Chi";
            dgvChiThang.Columns[3].HeaderText = "Ngày Chi";
            dgvChiThang.Columns[4].HeaderText = "Số Tiền";
            dgvChiThang.Columns[5].HeaderText = "Mô Tả";

            System.Data.DataTable dtThang = busKhoanThu.getdsTkeThang(dtpkThang.Value);
            txtThuThang.Text = string.Format("{0:#,##00}", dtThang.Rows[0][0]);
            txtChiThang.Text = string.Format("{0:#,##00}", dtThang.Rows[0][1]);
            txtSoDuThang.Text = string.Format("{0:#,##00}", dtThang.Rows[0][2]);

            int chi;
            int limit;
            System.Data.DataTable dtTkeMT = busMucTieu.getTkeMucTieu(dtpkThang.Value);
            if (dtTkeMT != null && dtTkeMT.Rows.Count > 0)
            {
                chi = Convert.ToInt32(dtThang.Rows[0][1].ToString());
                limit = Convert.ToInt32(dtTkeMT.Rows[0][3].ToString());
                if (chi > limit)
                {
                    MessageBox.Show("Bạn đã vượt quá giới hạn chi tiêu tháng này", "Phê bình");
                }
                else
                {
                    MessageBox.Show("Bạn đã không vượt quá giới hạn chi tiêu tháng này", "Chúc mừng");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa đặt mục tiêu cho tháng này");
            }
        }

        private void dtpkNgayBD_ValueChanged(object sender, EventArgs e)
        {
            dgvThuNgay.DataSource = busKhoanThu.getKhoanThuNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            dgvThuNgay.Columns[0].HeaderText = "Mã Khoản Thu";
            dgvThuNgay.Columns[1].Visible = false;
            dgvThuNgay.Columns[2].HeaderText = "Tên Khoản Thu";
            dgvThuNgay.Columns[3].HeaderText = "Ngày Thu";
            dgvThuNgay.Columns[4].HeaderText = "Số Tiền";
            dgvThuNgay.Columns[5].HeaderText = "Mô Tả";

            dgvChiNgay.DataSource = busKhoanChi.getKhoanChiNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            dgvChiNgay.Columns[0].HeaderText = "Mã Khoản Chi";
            dgvChiNgay.Columns[1].Visible = false;
            dgvChiNgay.Columns[2].HeaderText = "Tên Khoản Chi";
            dgvChiNgay.Columns[3].HeaderText = "Ngày Chi";
            dgvChiNgay.Columns[4].HeaderText = "Số Tiền";
            dgvChiNgay.Columns[5].HeaderText = "Mô Tả";

            System.Data.DataTable dtNgay = busKhoanThu.getdsTkeNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            txtThuNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][0]);
            txtChiNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][1]);
            txtSoDuNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][2]);
        }

        private void dtpkNgayKT_ValueChanged(object sender, EventArgs e)
        {
            dgvThuNgay.DataSource = busKhoanThu.getKhoanThuNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            dgvThuNgay.Columns[0].HeaderText = "Mã Khoản Thu";
            dgvThuNgay.Columns[1].Visible = false;
            dgvThuNgay.Columns[2].HeaderText = "Tên Khoản Thu";
            dgvThuNgay.Columns[3].HeaderText = "Ngày Thu";
            dgvThuNgay.Columns[4].HeaderText = "Số Tiền";
            dgvThuNgay.Columns[5].HeaderText = "Mô Tả";

            dgvChiNgay.DataSource = busKhoanChi.getKhoanChiNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            dgvChiNgay.Columns[0].HeaderText = "Mã Khoản Chi";
            dgvChiNgay.Columns[1].Visible = false;
            dgvChiNgay.Columns[2].HeaderText = "Tên Khoản Chi";
            dgvChiNgay.Columns[3].HeaderText = "Ngày Chi";
            dgvChiNgay.Columns[4].HeaderText = "Số Tiền";
            dgvChiNgay.Columns[5].HeaderText = "Mô Tả";

            System.Data.DataTable dtNgay = busKhoanThu.getdsTkeNgay(dtpkNgayBD.Value, dtpkNgayKT.Value);
            txtThuNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][0]);
            txtChiNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][1]);
            txtSoDuNgay.Text = string.Format("{0:#,##00}", dtNgay.Rows[0][2]);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string saveExcelFile = @"E:\QLChiTieu.xlsx";
            Excel.Application xlapp = new Excel.Application();
            Excel.Workbook xlworkbook;
            Excel.Worksheet xlworksheet;
            object misValue = System.Reflection.Missing.Value;

            xlworkbook = xlapp.Workbooks.Add(misValue);
            xlworksheet = (Excel.Worksheet)xlworkbook.Worksheets.get_Item(1);
            if (xlworksheet == null)
            {
                MessageBox.Show("Không thể tạo được WorkSheet");
                return;
            }
            int row = 1;
            string fontName = "Times New Roman";
            int fontSizeTieuDe = 18;
            int fontSizeTenTruong = 14;
            int fontSizeNoiDung = 12;

            //Tạo Ô Tiêu Đề
            Range row1_TieuDe_QLChiTieu = xlworksheet.get_Range("A1", "M1");
            row1_TieuDe_QLChiTieu.Merge();
            row1_TieuDe_QLChiTieu.Font.Size = fontSizeTieuDe;
            row1_TieuDe_QLChiTieu.Font.Name = fontName;
            row1_TieuDe_QLChiTieu.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row1_TieuDe_QLChiTieu.Value2 = "Quản Lý Chi Tiêu";
            //Tạo Ô Mã Khoản Thu
            Range row3_MaKhoanThu = xlworksheet.get_Range("A3", "A3");
            row3_MaKhoanThu.Merge();
            row3_MaKhoanThu.Font.Size = fontSizeTenTruong;
            row3_MaKhoanThu.Font.Name = fontName;
            row3_MaKhoanThu.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_MaKhoanThu.Value2 = "Mã Khoản Thu";
            row3_MaKhoanThu.ColumnWidth = 14;
            //Tạo Ô Mã Người Dùng
            Range row3_MaNgDungThu = xlworksheet.get_Range("B3", "B3");
            row3_MaNgDungThu.Merge();
            row3_MaNgDungThu.Font.Size = fontSizeTenTruong;
            row3_MaNgDungThu.Font.Name = fontName;
            row3_MaNgDungThu.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_MaNgDungThu.Value2 = "Mã Người Dùng";
            row3_MaNgDungThu.ColumnWidth = 14;
            //Tạo Ô Tên Khoản Thu
            Range row3_TenKhoanThu = xlworksheet.get_Range("C3", "C3");
            row3_TenKhoanThu.Merge();
            row3_TenKhoanThu.Font.Size = fontSizeTenTruong;
            row3_TenKhoanThu.Font.Name = fontName;
            row3_TenKhoanThu.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_TenKhoanThu.Value2 = "Tên Khoản Thu";
            row3_TenKhoanThu.ColumnWidth = 15;
            //Tạo Ô Ngày Thu
            Range row3_NgayThu = xlworksheet.get_Range("D3", "D3");
            row3_NgayThu.Font.Size = fontSizeTenTruong;
            row3_NgayThu.Font.Name = fontName;
            row3_NgayThu.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_NgayThu.Value2 = "Ngày Thu";
            row3_NgayThu.ColumnWidth = 12;
            //Tạo Ô Số Tiền
            Range row3_SoTienThu = xlworksheet.get_Range("E3", "E3");
            row3_SoTienThu.Font.Size = fontSizeTenTruong;
            row3_SoTienThu.Font.Name = fontName;
            row3_SoTienThu.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_SoTienThu.Value2 = "Số Tiền";
            row3_SoTienThu.ColumnWidth = 11.5;
            //Tạo Ô Mô Tả
            Range row3_MoTaThu = xlworksheet.get_Range("F3", "F3");
            row3_MoTaThu.Font.Size = fontSizeTenTruong;
            row3_MoTaThu.Font.Name = fontName;
            row3_MoTaThu.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_MoTaThu.Value2 = "Mô Tả";
            row3_MoTaThu.ColumnWidth = 16;

            //Tạo Ô Mã Khoản Chi
            Range row3_MaKhoanChi = xlworksheet.get_Range("H3", "H3");
            row3_MaKhoanChi.Merge();
            row3_MaKhoanChi.Font.Size = fontSizeTenTruong;
            row3_MaKhoanChi.Font.Name = fontName;
            row3_MaKhoanChi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_MaKhoanChi.Value2 = "Mã Khoản Thu";
            row3_MaKhoanChi.ColumnWidth = 14;
            //Tạo Ô Mã Người Dùng
            Range row3_MaNgDungChi = xlworksheet.get_Range("I3", "I3");
            row3_MaNgDungChi.Merge();
            row3_MaNgDungChi.Font.Size = fontSizeTenTruong;
            row3_MaNgDungChi.Font.Name = fontName;
            row3_MaNgDungChi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_MaNgDungChi.Value2 = "Mã Người Dùng";
            row3_MaNgDungChi.ColumnWidth = 14;
            //Tạo Ô Tên Khoản Chi
            Range row3_TenKhoanChi = xlworksheet.get_Range("J3", "J3");
            row3_TenKhoanChi.Merge();
            row3_TenKhoanChi.Font.Size = fontSizeTenTruong;
            row3_TenKhoanChi.Font.Name = fontName;
            row3_TenKhoanChi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_TenKhoanChi.Value2 = "Tên Khoản Thu";
            row3_TenKhoanChi.ColumnWidth = 15;
            //Tạo Ô Tên Ngày Chi
            Range row3_NgayChi = xlworksheet.get_Range("K3", "K3");
            row3_NgayChi.Font.Size = fontSizeTenTruong;
            row3_NgayChi.Font.Name = fontName;
            row3_NgayChi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_NgayChi.Value2 = "Ngày Thu";
            row3_NgayChi.ColumnWidth = 12;
            //Tạo Ô Số Tiền
            Range row3_SoTienChi = xlworksheet.get_Range("L3", "L3");
            row3_SoTienChi.Font.Size = fontSizeTenTruong;
            row3_SoTienChi.Font.Name = fontName;
            row3_SoTienChi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_SoTienChi.Value2 = "Số Tiền";
            row3_SoTienChi.ColumnWidth = 11.5;
            //Tạo Ô Mô Tả
            Range row3_MoTaChi = xlworksheet.get_Range("M3", "M3");
            row3_MoTaChi.Font.Size = fontSizeTenTruong;
            row3_MoTaChi.Font.Name = fontName;
            row3_MoTaChi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_MoTaChi.Value2 = "Mô Tả";
            row3_MoTaChi.ColumnWidth = 16;

            //Tạo Ô Tổng Thu
            Range row3_TongThu = xlworksheet.get_Range("O3", "O3");
            row3_TongThu.Font.Size = fontSizeTenTruong;
            row3_TongThu.Font.Name = fontName;
            row3_TongThu.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_TongThu.Value2 = "Tổng Thu";
            row3_TongThu.ColumnWidth = 10;
            //Tạo Ô Tổng Chi
            Range row3_TongChi = xlworksheet.get_Range("O4", "O4");
            row3_TongChi.Font.Size = fontSizeTenTruong;
            row3_TongChi.Font.Name = fontName;
            row3_TongChi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_TongChi.Value2 = "Tổng Chi";
            row3_TongChi.ColumnWidth = 10;
            //Tạo Ô Số Dư
            Range row3_SoDu = xlworksheet.get_Range("O5", "O5");
            row3_SoDu.Font.Size = fontSizeTenTruong;
            row3_SoDu.Font.Name = fontName;
            row3_SoDu.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3_SoDu.Value2 = "Số Dư";
            row3_SoDu.ColumnWidth = 10;

            //In Dữ Liệu Ra Excel
            row = 3;
            //Khoản Thu
            for (int i = 0; i <= dgvThuThang.RowCount - 1; i++)
            {
                for (int j = 0; j <= dgvThuThang.ColumnCount - 1; j++)
                {
                    Range rowData = xlworksheet.get_Range("A" + row, "F" + row);
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    DataGridViewCell cell = dgvThuThang[j, i];
                    xlworksheet.Cells[i + 4, j + 1] = cell.Value;
                }
            }
            //Khoản Chi
            for (int i = 0; i <= dgvChiThang.RowCount - 1; i++)
            {
                for (int j = 0; j <= dgvChiThang.ColumnCount - 1; j++)
                {
                    Range rowData = xlworksheet.get_Range("H" + row, "M" + row);
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    DataGridViewCell cell = dgvChiThang[j, i];
                    xlworksheet.Cells[i + 4, j + 8] = cell.Value;
                }
            }
            //Thống Kê
            System.Data.DataTable dtTke = busKhoanThu.getdsTkeThang(dtpkThang.Value);
            for(int i = 0; i < 3; i++)
            {
             
                Range rowData = xlworksheet.get_Range("P" + (i+3));
                rowData.Font.Size = fontSizeNoiDung;
                rowData.Font.Name = fontName;
                xlworksheet.Cells[i + 3, 16] = dtTke.Rows[0][i].ToString();
            }

            //Tô Nền Vàng Các Ô Tiêu Đề
            Range rowAF_oTieuDe = xlworksheet.get_Range("A3", "F3");
            Range rowHM_oTieuDe = xlworksheet.get_Range("H3", "M3");
            //Nền Vàng
            rowAF_oTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            rowHM_oTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            //In Đậm
            row1_TieuDe_QLChiTieu.Font.Bold = true;
            rowAF_oTieuDe.Font.Bold = true;
            rowHM_oTieuDe.Font.Bold = true;
            row3_TongThu.Font.Bold = true;
            row3_TongChi.Font.Bold = true;
            row3_SoDu.Font.Bold = true;
            //Màu Chữ
            row1_TieuDe_QLChiTieu.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Red);
            rowAF_oTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            rowHM_oTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            row3_TongThu.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Red);
            row3_TongChi.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Red);
            row3_SoDu.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Red);
            //Kẻ Khung
            int x = dgvThuThang.RowCount;
            int y = dgvChiThang.RowCount;
            BorderAround(xlworksheet.get_Range("A3", "F" + (x+2)));
            BorderAround(xlworksheet.get_Range("H3", "M" + (y+2)));
            BorderAround(xlworksheet.get_Range("O3", "P5"));

            //Lưu file xuống ổ cứng
            xlworkbook.SaveAs(saveExcelFile);
            xlworkbook.Close(true, misValue, misValue);
            xlapp.Quit();
            reObject(xlworksheet);
            reObject(xlworkbook);
            reObject(xlapp);
            MessageBox.Show("Thành công");
            //Mở file sau khi xuất thành công
            System.Diagnostics.Process.Start(saveExcelFile);
        }

        private void reObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Lỗi");
            }
            finally
            {
                GC.Collect();
            }
        }

        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
    }
}
