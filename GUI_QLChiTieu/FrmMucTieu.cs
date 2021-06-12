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
    public partial class FrmMucTieu : Form
    {
        public FrmMucTieu()
        {
            InitializeComponent();
        }

        BUS_MucTieu busMucTieu = new BUS_MucTieu();
        string stremail = FrmMain.mail;

        private void LoadGridView_MucTieu()
        {
            dgvMucTieu.DataSource = busMucTieu.getMucTieu();
            dgvMucTieu.Columns[0].HeaderText = "Mã Mục Tiêu";
            dgvMucTieu.Columns[1].Visible = false;
            dgvMucTieu.Columns[2].HeaderText = "Mục Tiêu Ngày";
            dgvMucTieu.Columns[3].HeaderText = "Mục Tiêu Tháng";
            dgvMucTieu.Columns[4].HeaderText = "Ngày";
            dgvMucTieu.Columns[5].HeaderText = "Mô Tả";
        }

        public void ResetValues()
        {
            txtMaMT.Text = null;
            txtMTNgay.Text = null;
            txtMTThang.Text = null;
            dtpkNgay.Value = DateTime.Today;
            txtMoTa.Text = null;
            txtMaMT.Enabled = false;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void FrmMucTieu_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_MucTieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float soTienNgay;
            bool isfloatNgay = float.TryParse(txtMTNgay.Text.Trim().ToString(), out soTienNgay);
            float soTienThang;
            bool isfloatThang = float.TryParse(txtMTThang.Text.Trim().ToString(), out soTienThang);

            if (txtMTNgay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mục tiêu ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMTNgay.Focus();
                return;
            }
            else if (!isfloatNgay || float.Parse(txtMTNgay.Text) <0)
            {
                MessageBox.Show("Mục tiêu ngày phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMTNgay.Focus();
                return;
            }
            else if (txtMTThang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mục tiêu tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMTThang.Focus();
                return;
            }
            else if (!isfloatThang || float.Parse(txtMTThang.Text) < 0)
            {
                MessageBox.Show("Mục tiêu tháng phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMTThang.Focus();
                return;
            }
            else
            {
                DTO_MucTieu mt = new DTO_MucTieu(float.Parse(txtMTNgay.Text), float.Parse(txtMTThang.Text), dtpkNgay.Value, txtMoTa.Text, stremail);
                if (busMucTieu.InsertMucTieu(mt))
                {
                    MessageBox.Show("Thêm mục tiêu thành công");
                    ResetValues();
                    LoadGridView_MucTieu();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float soTienNgay;
            bool isfloatNgay = float.TryParse(txtMTNgay.Text.Trim().ToString(), out soTienNgay);
            float soTienThang;
            bool isfloatThang = float.TryParse(txtMTThang.Text.Trim().ToString(), out soTienThang);

            if (!isfloatNgay || float.Parse(txtMTNgay.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập mục tiêu ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMTNgay.Focus();
                return;
            }
            else if (!isfloatThang || float.Parse(txtMTThang.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập mục tiêu tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMTThang.Focus();
                return;
            }
            else
            {
                DTO_MucTieu mt = new DTO_MucTieu(txtMaMT.Text, float.Parse(txtMTNgay.Text), float.Parse(txtMTThang.Text), dtpkNgay.Value, txtMoTa.Text);
                if (busMucTieu.InsertMucTieu(mt))
                {
                    MessageBox.Show("Sửa thành công");
                    ResetValues();
                    LoadGridView_MucTieu();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMT = txtMaMT.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa ?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busMucTieu.DeleteMucTieu(maMT))
                {
                    MessageBox.Show("Xóa thành công");
                    ResetValues();
                    LoadGridView_MucTieu();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void dgvMucTieu_Click(object sender, EventArgs e)
        {
            if (dgvMucTieu.Rows.Count > 1)
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                txtMaMT.Text = dgvMucTieu.CurrentRow.Cells["MaMT"].Value.ToString();
                txtMTNgay.Text = dgvMucTieu.CurrentRow.Cells["MTNgay"].Value.ToString();
                txtMTThang.Text = dgvMucTieu.CurrentRow.Cells["MTThang"].Value.ToString();
                dtpkNgay.Value = Convert.ToDateTime(dgvMucTieu.CurrentRow.Cells["Ngay"].Value);
                txtMoTa.Text = dgvMucTieu.CurrentRow.Cells["MoTa"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
