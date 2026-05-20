using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class QuanLySinhVienForm : Form
    {
        private int currentPage = 1;
        private int pageSize = 20;
        private int totalRecords = 0;
        private string searchKeyword = "";
        private string filterLop = "";

        public QuanLySinhVienForm(string filterClass = "")
        {
            InitializeComponent();
            filterLop = filterClass;
            LoadLopHocCombo();
            LoadData();
        }

        private void LoadLopHocCombo()
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT MaLop, TenLop FROM LopHoc ORDER BY MaLop");
            cboLop.Items.Clear();
            foreach (DataRow r in dt.Rows)
                cboLop.Items.Add(string.Format("{0} – {1}", r["MaLop"], r["TenLop"]));
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
        }

        private string BuildWhere()
        {
            string w = "";
            var conditions = new System.Collections.Generic.List<string>();

            if (!string.IsNullOrEmpty(filterLop))
                conditions.Add(string.Format("MaLop='{0}'", filterLop));

            if (!string.IsNullOrEmpty(searchKeyword))
                conditions.Add(string.Format(
                    "(HoVaTen LIKE '%{0}%' OR CAST(MaSV AS TEXT) LIKE '%{0}%' OR MaLop LIKE '%{0}%')",
                    searchKeyword));

            if (conditions.Count > 0)
                w = " WHERE " + string.Join(" AND ", conditions.ToArray());
            return w;
        }

        private void LoadData()
        {
            string where = BuildWhere();
            totalRecords = Convert.ToInt32(new SQLiteCommand(
                "SELECT COUNT(*) FROM SinhVien" + where,
                DatabaseHelper.GetConnection()).ExecuteScalar());

            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (totalPages == 0) totalPages = 1;
            if (currentPage > totalPages) currentPage = totalPages;

            int offset = (currentPage - 1) * pageSize;
            string sql = string.Format(
                "SELECT MaSV, HoVaTen, GioiTinh, NgaySinh, MaLop FROM SinhVien{0} LIMIT {1} OFFSET {2}",
                where, pageSize, offset);

            dgvSinhVien.DataSource = DatabaseHelper.ExecuteQuery(sql);
            dgvSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["HoVaTen"].HeaderText = "Họ và Tên";
            dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["MaLop"].HeaderText = "Lớp";

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

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null) return;
            var row = dgvSinhVien.CurrentRow;
            txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = row.Cells["HoVaTen"].Value.ToString();

            string ns = row.Cells["NgaySinh"].Value.ToString();
            DateTime dt;
            if (DateTime.TryParse(ns, out dt)) dtpNgaySinh.Value = dt;

            cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();

            string maLop = row.Cells["MaLop"].Value.ToString();
            foreach (var item in cboLop.Items)
                if (item.ToString().StartsWith(maLop))
                { cboLop.SelectedItem = item; break; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            { MessageBox.Show("Nhập Họ và Tên!"); return; }

            string maLop = cboLop.SelectedItem.ToString().Split('–')[0].Trim();
            string sql = "INSERT INTO SinhVien (HoVaTen, NgaySinh, GioiTinh, MaLop) VALUES (@ht, @ns, @gt, @ml)";
            var p = new SQLiteParameter[] {
                new SQLiteParameter("@ht", txtHoTen.Text),
                new SQLiteParameter("@ns", dtpNgaySinh.Value.ToString("dd/MM/yyyy")),
                new SQLiteParameter("@gt", cboGioiTinh.Text),
                new SQLiteParameter("@ml", maLop)
            };
            DatabaseHelper.ExecuteNonQuery(sql, p);
            MessageBox.Show("Thêm thành công!");
            ClearForm(); LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text)) { MessageBox.Show("Chọn sinh viên cần sửa!"); return; }
            string maLop = cboLop.SelectedItem.ToString().Split('–')[0].Trim();
            string sql = "UPDATE SinhVien SET HoVaTen=@ht, NgaySinh=@ns, GioiTinh=@gt, MaLop=@ml WHERE MaSV=@id";
            var p = new SQLiteParameter[] {
                new SQLiteParameter("@ht", txtHoTen.Text),
                new SQLiteParameter("@ns", dtpNgaySinh.Value.ToString("dd/MM/yyyy")),
                new SQLiteParameter("@gt", cboGioiTinh.Text),
                new SQLiteParameter("@ml", maLop),
                new SQLiteParameter("@id", txtMaSV.Text)
            };
            DatabaseHelper.ExecuteNonQuery(sql, p);
            MessageBox.Show("Sửa thành công!");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text)) { MessageBox.Show("Chọn sinh viên cần xóa!"); return; }
            if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteNonQuery("DELETE FROM SinhVien WHERE MaSV=@id",
                    new[] { new SQLiteParameter("@id", txtMaSV.Text) });
                MessageBox.Show("Xóa thành công!");
                ClearForm(); LoadData();
            }
        }

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

        private void btnFirst_Click(object sender, EventArgs e) { currentPage = 1; LoadData(); }
        private void btnPrev_Click(object sender, EventArgs e) { if (currentPage > 1) { currentPage--; LoadData(); } }
        private void btnNext_Click(object sender, EventArgs e) { currentPage++; LoadData(); }
        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (currentPage < 1) currentPage = 1;
            LoadData();
        }
    }
}