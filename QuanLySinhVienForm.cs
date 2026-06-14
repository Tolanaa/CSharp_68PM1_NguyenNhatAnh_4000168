using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class QuanLySinhVienForm : Form
    {
        private int currentPage = 1;
        private int pageSize = 20;
        private string searchKeyword = "";
        private string filterLop = "";
        private List<Tbl_sinhviens> _data = new List<Tbl_sinhviens>();

        public QuanLySinhVienForm(string filterClass = "")
        {
            InitializeComponent();

            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;

            filterLop = filterClass;

            if (!string.IsNullOrEmpty(filterLop))
                this.Text = "Danh sách sinh viên lớp " + filterLop;

            LoadLopHocCombo();
            LoadData();
        }
        private void LoadLopHocCombo()
        {
            List<Tbl_lophoc> lops = DatabaseHelper.GetAllLop();
            cboLop.Items.Clear();
            foreach (Tbl_lophoc l in lops)
                cboLop.Items.Add(string.Format("{0} \u2013 {1}", l.Malop, l.Tenlop));
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
        }

        private void LoadData()
        {
            _data = DatabaseHelper.GetAllSV(searchKeyword, filterLop);

            int totalRecords = _data.Count;
            int totalPages = Math.Max(1, (int)Math.Ceiling((double)totalRecords / pageSize));
            if (currentPage > totalPages) currentPage = totalPages;

            int skip = (currentPage - 1) * pageSize;
            int take = Math.Min(pageSize, totalRecords - skip);
            List<Tbl_sinhviens> page = _data.GetRange(skip, take);

            dgvSinhVien.DataSource = null;
            dgvSinhVien.DataSource = page;

            if (dgvSinhVien.Columns["Tbl_lophoc"] != null)
                dgvSinhVien.Columns["Tbl_lophoc"].Visible = false;

            dgvSinhVien.Columns["Id"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["Hoten"].HeaderText = "Họ và Tên";
            dgvSinhVien.Columns["Gioitinh"].HeaderText = "Giới Tính";
            dgvSinhVien.Columns["Ngaysinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["Malop"].HeaderText = "Lớp";

            lblPage.Text = string.Format("Trang {0}/{1}  |  {2} bản ghi", currentPage, totalPages, totalRecords);
        }

        private void ClearForm()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            cboGioiTinh.SelectedIndex = 0;
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            txtMaSV.Text = row.Cells["Id"].Value != null ? row.Cells["Id"].Value.ToString() : "";
            txtHoTen.Text = row.Cells["Hoten"].Value != null ? row.Cells["Hoten"].Value.ToString() : "";

            if (row.Cells["Ngaysinh"].Value != null && row.Cells["Ngaysinh"].Value != DBNull.Value)
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngaysinh"].Value);

            cboGioiTinh.Text = row.Cells["Gioitinh"].Value != null ? row.Cells["Gioitinh"].Value.ToString() : "";

            string maLop = row.Cells["Malop"].Value != null ? row.Cells["Malop"].Value.ToString() : "";

            foreach (object item in cboLop.Items)
            {
                if (item.ToString().StartsWith(maLop))
                {
                    cboLop.SelectedItem = item;
                    break;
                }
            }
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;
            DataGridViewRow row = dgvSinhVien.CurrentRow;

            txtMaSV.Text = row.Cells["Id"].Value != null ? row.Cells["Id"].Value.ToString() : "";
            txtHoTen.Text = row.Cells["Hoten"].Value != null ? row.Cells["Hoten"].Value.ToString() : "";

            if (row.Cells["Ngaysinh"].Value != null && row.Cells["Ngaysinh"].Value != DBNull.Value)
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngaysinh"].Value);

            cboGioiTinh.Text = row.Cells["Gioitinh"].Value != null ? row.Cells["Gioitinh"].Value.ToString() : "";

            string maLop = row.Cells["Malop"].Value != null ? row.Cells["Malop"].Value.ToString() : "";
            foreach (object item in cboLop.Items)
                if (item.ToString().StartsWith(maLop)) { cboLop.SelectedItem = item; break; }
        }

        private string GetMaLop()
        {
            if (cboLop.SelectedItem == null) return "";
            string[] parts = cboLop.SelectedItem.ToString().Split('\u2013');
            return parts[0].Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Nhập Họ và Tên!");
                return;
            }
            try
            {
                DatabaseHelper.ThemSV(txtHoTen.Text.Trim(), cboGioiTinh.Text, dtpNgaySinh.Value.Date, GetMaLop());
                MessageBox.Show("Thêm thành công!");
                ClearForm();
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)  //nút sửa sinh viên
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Chọn sinh viên cần sửa!");
                return;
            }
            try
            {
                DatabaseHelper.SuaSV(int.Parse(txtMaSV.Text), txtHoTen.Text.Trim(), cboGioiTinh.Text, dtpNgaySinh.Value.Date, GetMaLop());
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); } 
        }

        // cho đến đây là hết ạ hẹ hẹ, em lỡ làm trước r nên h em thêm cmt thui ạ

        private void btnXoa_Click(object sender, EventArgs e)  // nút xóa sinh viên
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Chọn sinh viên cần xóa!");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DatabaseHelper.XoaSV(int.Parse(txtMaSV.Text));
                    MessageBox.Show("Xóa thành công!");
                    ClearForm();
                    LoadData();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        //ở đây e cx xog r ạ
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            searchKeyword = "";
            filterLop = "";
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

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchKeyword = txtTimKiem.Text.Trim();
                currentPage = 1;
                LoadData();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e) { currentPage = 1; LoadData(); }
        private void btnPrev_Click(object sender, EventArgs e) { if (currentPage > 1) { currentPage--; LoadData(); } }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = Math.Max(1, (int)Math.Ceiling((double)_data.Count / pageSize));

            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = Math.Max(1, (int)Math.Ceiling((double)_data.Count / pageSize));
            LoadData();
        }
    }
}