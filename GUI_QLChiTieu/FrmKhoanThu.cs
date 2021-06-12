using BUS_QLChiTieu;
using DTO_QLChiTieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLChiTieu
{
    public partial class FrmKhoanThu : Form
    {
        public FrmKhoanThu()
        {
            InitializeComponent();
        }

        BUS_KhoanThu busKhoanThu = new BUS_KhoanThu();
        string stremail = FrmMain.mail;

        private void LoadGridView_KhoanThu()
        {
            dgvKhoanThu.DataSource = busKhoanThu.getKhoanThu();
            dgvKhoanThu.Columns[0].HeaderText = "Mã Khoản Thu";
            dgvKhoanThu.Columns[1].Visible = false;
            dgvKhoanThu.Columns[2].HeaderText = "Tên Khoản Thu";
            dgvKhoanThu.Columns[3].HeaderText = "Ngày Thu";
            dgvKhoanThu.Columns[4].HeaderText = "Số Tiền";
            dgvKhoanThu.Columns[5].HeaderText = "Mô Tả";
        }

        private void ResetValues()
        {
            txtMaKT.Text = null;
            txtKhoanThu.Text = null;
            dtpkNgayThu.Value = DateTime.Today;
            txtSoTien.Text = null;
            txtMoTa.Text = null;

            txtMaKT.Enabled = false;
            txtKhoanThu.Enabled = false;
            dtpkNgayThu.Enabled = false;
            txtSoTien.Enabled = false;
            txtMoTa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void FrmKhoanThu_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_KhoanThu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKT.Text = null;
            txtKhoanThu.Text = null;
            dtpkNgayThu.Value = DateTime.Today;
            txtSoTien.Text = null;
            txtMoTa.Text = null;

            txtMaKT.Enabled = false;
            txtKhoanThu.Enabled = true;
            dtpkNgayThu.Enabled = true;
            txtSoTien.Enabled = true;
            txtMoTa.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtKhoanThu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float soTienThu;
            bool isfloatThu = float.TryParse(txtSoTien.Text.Trim().ToString(), out soTienThu);

            if (txtKhoanThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khoản thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhoanThu.Focus();
                return;
            }
            else if (txtSoTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTien.Focus();
                return;
            }
            else if (!isfloatThu || float.Parse(txtSoTien.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTien.Focus();
                return;
            }
            else
            {
                DTO_KhoanThu kt = new DTO_KhoanThu(txtKhoanThu.Text, dtpkNgayThu.Value, float.Parse(txtSoTien.Text), txtMoTa.Text, stremail);
                if (busKhoanThu.InsertKhoanThu(kt))
                {
                    MessageBox.Show("Thêm khoản thu thành công");
                    ResetValues();
                    LoadGridView_KhoanThu();
                }
                else
                {
                    MessageBox.Show("Thêm khoản thu không thành công");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float soTienThu;
            bool isfloatThu = float.TryParse(txtSoTien.Text.Trim().ToString(), out soTienThu);

            if (txtKhoanThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khoản thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhoanThu.Focus();
                return;
            }
            else if (!isfloatThu || float.Parse(txtSoTien.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTien.Focus();
                return;
            }
            else
            {
                DTO_KhoanThu kt = new DTO_KhoanThu(txtMaKT.Text, txtKhoanThu.Text, dtpkNgayThu.Value, float.Parse(txtSoTien.Text), txtMoTa.Text);
                if (busKhoanThu.UpdateKhoanThu(kt))
                {
                    MessageBox.Show("Sửa thành công");
                    ResetValues();
                    LoadGridView_KhoanThu();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKT = txtMaKT.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa ?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busKhoanThu.DeleteKhoanThu(maKT))
                {
                    MessageBox.Show("Xóa thành công");
                    ResetValues();
                    LoadGridView_KhoanThu();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void dgvKhoanThu_Click(object sender, EventArgs e)
        {
            if (dgvKhoanThu.Rows.Count > 1)
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtKhoanThu.Enabled = true;
                dtpkNgayThu.Enabled = true;
                txtSoTien.Enabled = true;
                txtMoTa.Enabled = true;

                txtMaKT.Text = dgvKhoanThu.CurrentRow.Cells["MaKT"].Value.ToString();
                txtKhoanThu.Text = dgvKhoanThu.CurrentRow.Cells["TenKT"].Value.ToString();
                dtpkNgayThu.Value = Convert.ToDateTime(dgvKhoanThu.CurrentRow.Cells["NgayThu"].Value);
                txtSoTien.Text = dgvKhoanThu.CurrentRow.Cells["SoTien"].Value.ToString();
                txtMoTa.Text = dgvKhoanThu.CurrentRow.Cells["MoTa"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
