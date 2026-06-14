using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class QuanLyLopHocForm : Form
    {
        private int currentPage = 1;
        private int pageSize = 20;
        private string searchKeyword = "";
        private List<Tbl_lophoc> _data = new List<Tbl_lophoc>();

        public QuanLyLopHocForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            _data = DatabaseHelper.GetAllLop(searchKeyword);

            int totalRecords = _data.Count;
            int totalPages = Math.Max(1, (int)Math.Ceiling((double)totalRecords / pageSize));
            if (currentPage > totalPages) currentPage = totalPages;

            int skip = (currentPage - 1) * pageSize;
            int take = Math.Min(pageSize, totalRecords - skip);
            List<Tbl_lophoc> page = _data.GetRange(skip, take);

            dgvLopHoc.DataSource = null;
            dgvLopHoc.DataSource = page;

            if (dgvLopHoc.Columns["Tbl_sinhviens"] != null)
                dgvLopHoc.Columns["Tbl_sinhviens"].Visible = false;

            dgvLopHoc.Columns["Id"].HeaderText = "Mã ID";
            dgvLopHoc.Columns["Malop"].HeaderText = "Mã lớp";
            dgvLopHoc.Columns["Tenlop"].HeaderText = "Tên lớp";
            dgvLopHoc.Columns["Ghichu"].HeaderText = "Ghi chú";

            lblPage.Text = string.Format("Trang {0}/{1}  |  {2} bản ghi", currentPage, totalPages, totalRecords);
        }

        private void ClearForm()
        {
            txtMaID.Text = "";
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtGhiChu.Text = "";
        }

        private void dgvLopHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLopHoc.CurrentRow == null) return;
            DataGridViewRow row = dgvLopHoc.CurrentRow;
            txtMaID.Text = row.Cells["Id"].Value != null ? row.Cells["Id"].Value.ToString() : "";
            txtMaLop.Text = row.Cells["Malop"].Value != null ? row.Cells["Malop"].Value.ToString() : "";
            txtTenLop.Text = row.Cells["Tenlop"].Value != null ? row.Cells["Tenlop"].Value.ToString() : "";
            txtGhiChu.Text = row.Cells["Ghichu"].Value != null ? row.Cells["Ghichu"].Value.ToString() : "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text) || string.IsNullOrEmpty(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp và Tên lớp!");
                return;
            }
            try
            {
                DatabaseHelper.ThemLop(txtMaLop.Text.Trim(), txtTenLop.Text.Trim(), txtGhiChu.Text.Trim());
                MessageBox.Show("Thêm thành công!");
                ClearForm();
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text))
            {
                MessageBox.Show("Chọn lớp cần sửa!");
                return;
            }
            try
            {
                DatabaseHelper.SuaLop(int.Parse(txtMaID.Text), txtMaLop.Text.Trim(), txtTenLop.Text.Trim(), txtGhiChu.Text.Trim());
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text))
            {
                MessageBox.Show("Chọn lớp cần xóa!");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.XoaLop(int.Parse(txtMaID.Text));
                    MessageBox.Show("Xóa thành công!");
                    ClearForm();
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            searchKeyword = "";
            txtTimKiem.Text = "";
            currentPage = 1;
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            searchKeyword = txtTimKiem.Text.Trim();
            currentPage = 1;
            LoadData();
        }

        private void btnXemSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Chọn lớp trước!");
                return;
            }
            QuanLySinhVienForm frm = new QuanLySinhVienForm(txtMaLop.Text);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }



        private void btnFirst_Click(object sender, EventArgs e) { currentPage = 1; LoadData(); }
        private void btnPrev_Click(object sender, EventArgs e) { if (currentPage > 1) { currentPage--; LoadData(); } }
        private void btnNext_Click(object sender, EventArgs e) { currentPage++; LoadData(); }
        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = Math.Max(1, (int)Math.Ceiling((double)_data.Count / pageSize));
            LoadData();
        }
    }
}