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
    public partial class FrmKhoanChi : Form
    {
        public FrmKhoanChi()
        {
            InitializeComponent();
        }

        BUS_KhoanChi busKhoanChi = new BUS_KhoanChi();
        string stremail = FrmMain.mail;

        private void LoadGridView_KhoanChi()
        {
            dgvKhoanChi.DataSource = busKhoanChi.getKhoanChi();
            dgvKhoanChi.Columns[0].HeaderText = "Mã Khoản Chi";
            dgvKhoanChi.Columns[1].Visible = false;
            dgvKhoanChi.Columns[2].HeaderText = "Tên Khoản Chi";
            dgvKhoanChi.Columns[3].HeaderText = "Ngày Chi";
            dgvKhoanChi.Columns[4].HeaderText = "Số Tiền";
            dgvKhoanChi.Columns[5].HeaderText = "Mô Tả";
        }

        private void ResetValues()
        {
            txtMaKC.Text = null;
            txtKhoanChi.Text = null;
            dtpkNgayChi.Value = DateTime.Today;
            txtSoTien.Text = null;
            txtMoTa.Text = null;

            txtMaKC.Enabled = false;
            txtKhoanChi.Enabled = false;
            dtpkNgayChi.Enabled = false;
            txtSoTien.Enabled = false;
            txtMoTa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void FrmKhoanChi_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_KhoanChi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKC.Text = null;
            txtKhoanChi.Text = null;
            dtpkNgayChi.Value = DateTime.Today;
            txtSoTien.Text = null;
            txtMoTa.Text = null;

            txtMaKC.Enabled = false;
            txtKhoanChi.Enabled = true;
            dtpkNgayChi.Enabled = true;
            txtSoTien.Enabled = true;
            txtMoTa.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtKhoanChi.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float soTienChi;
            bool isfloatChi = float.TryParse(txtSoTien.Text.Trim().ToString(), out soTienChi);

            if (txtKhoanChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khoản chi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhoanChi.Focus();
                return;
            }
            else if (txtSoTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTien.Focus();
                return;
            }
            else if (!isfloatChi || float.Parse(txtSoTien.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTien.Focus();
                return;
            }
            else
            {
                DTO_KhoanChi kc = new DTO_KhoanChi(txtKhoanChi.Text, dtpkNgayChi.Value, float.Parse(txtSoTien.Text), txtMoTa.Text, stremail);
                if (busKhoanChi.InsertKhoanChi(kc))
                {
                    MessageBox.Show("Thêm khoản chi thành công");
                    ResetValues();
                    LoadGridView_KhoanChi();
                }
                else
                {
                    MessageBox.Show("Thêm khoản chi không thành công");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float soTienChi;
            bool isfloatChi = float.TryParse(txtSoTien.Text.Trim().ToString(), out soTienChi);

            if (txtKhoanChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khoản chi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhoanChi.Focus();
                return;
            }
            else if (!isfloatChi || float.Parse(txtSoTien.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTien.Focus();
                return;
            }
            else
            {
                DTO_KhoanChi kc = new DTO_KhoanChi(txtMaKC.Text, txtKhoanChi.Text, dtpkNgayChi.Value, float.Parse(txtSoTien.Text), txtMoTa.Text);
                if (busKhoanChi.UpdateKhoanChi(kc))
                {
                    MessageBox.Show("Sửa thành công");
                    ResetValues();
                    LoadGridView_KhoanChi();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKC = txtMaKC.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busKhoanChi.DeleteKhoanChi(maKC))
                {
                    MessageBox.Show("Xóa thành công");
                    ResetValues();
                    LoadGridView_KhoanChi();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void dgvKhoanChi_Click(object sender, EventArgs e)
        {
            if (dgvKhoanChi.Rows.Count > 1)
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtKhoanChi.Enabled = true;
                dtpkNgayChi.Enabled = true;
                txtSoTien.Enabled = true;
                txtMoTa.Enabled = true;

                txtMaKC.Text = dgvKhoanChi.CurrentRow.Cells["MaKC"].Value.ToString();
                txtKhoanChi.Text = dgvKhoanChi.CurrentRow.Cells["TenKC"].Value.ToString();
                dtpkNgayChi.Value = Convert.ToDateTime(dgvKhoanChi.CurrentRow.Cells["NgayChi"].Value);
                txtSoTien.Text = dgvKhoanChi.CurrentRow.Cells["SoTien"].Value.ToString();
                txtMoTa.Text = dgvKhoanChi.CurrentRow.Cells["MoTa"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
