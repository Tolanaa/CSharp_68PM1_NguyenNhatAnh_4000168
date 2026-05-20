using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class QuanLyLopHocForm : Form
    {
        private int currentPage = 1;
        private int pageSize = 20;
        private int totalRecords = 0;
        private string searchKeyword = "";

        public QuanLyLopHocForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string where = string.IsNullOrEmpty(searchKeyword) ? "" :
                string.Format(" WHERE CAST(MaID AS TEXT) LIKE '%{0}%' OR MaLop LIKE '%{0}%' OR TenLop LIKE '%{0}%'", searchKeyword);

            string countSql = "SELECT COUNT(*) FROM LopHoc" + where;
            totalRecords = Convert.ToInt32(new SQLiteCommand(countSql,
                DatabaseHelper.GetConnection()).ExecuteScalar());

            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (totalPages == 0) totalPages = 1;
            if (currentPage > totalPages) currentPage = totalPages;

            int offset = (currentPage - 1) * pageSize;
            string sql = string.Format("SELECT MaID, MaLop, TenLop, GhiChu FROM LopHoc{0} LIMIT {1} OFFSET {2}",
                where, pageSize, offset);

            dgvLopHoc.DataSource = DatabaseHelper.ExecuteQuery(sql);
            dgvLopHoc.Columns["MaID"].HeaderText = "Mã ID";
            dgvLopHoc.Columns["MaLop"].HeaderText = "Mã lớp";
            dgvLopHoc.Columns["TenLop"].HeaderText = "Tên lớp";
            dgvLopHoc.Columns["GhiChu"].HeaderText = "Ghi chú";

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
            var row = dgvLopHoc.CurrentRow;
            txtMaID.Text = row.Cells["MaID"].Value.ToString();
            txtMaLop.Text = row.Cells["MaLop"].Value.ToString();
            txtTenLop.Text = row.Cells["TenLop"].Value.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value != DBNull.Value
                ? row.Cells["GhiChu"].Value.ToString() : "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text) || string.IsNullOrEmpty(txtTenLop.Text))
            { MessageBox.Show("Vui lòng nhập Mã lớp và Tên lớp!"); return; }

            string sql = "INSERT INTO LopHoc (MaLop, TenLop, GhiChu) VALUES (@ml, @tl, @gc)";
            var p = new SQLiteParameter[] {
                new SQLiteParameter("@ml", txtMaLop.Text),
                new SQLiteParameter("@tl", txtTenLop.Text),
                new SQLiteParameter("@gc", txtGhiChu.Text)
            };
            DatabaseHelper.ExecuteNonQuery(sql, p);
            MessageBox.Show("Thêm thành công!");
            ClearForm(); LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text)) { MessageBox.Show("Chọn lớp cần sửa!"); return; }

            string sql = "UPDATE LopHoc SET MaLop=@ml, TenLop=@tl, GhiChu=@gc WHERE MaID=@id";
            var p = new SQLiteParameter[] {
                new SQLiteParameter("@ml", txtMaLop.Text),
                new SQLiteParameter("@tl", txtTenLop.Text),
                new SQLiteParameter("@gc", txtGhiChu.Text),
                new SQLiteParameter("@id", txtMaID.Text)
            };
            DatabaseHelper.ExecuteNonQuery(sql, p);
            MessageBox.Show("Sửa thành công!");
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text)) { MessageBox.Show("Chọn lớp cần xóa!"); return; }
            if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteNonQuery("DELETE FROM LopHoc WHERE MaID=@id",
                    new[] { new SQLiteParameter("@id", txtMaID.Text) });
                MessageBox.Show("Xóa thành công!");
                ClearForm(); LoadData();
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
            if (string.IsNullOrEmpty(txtMaLop.Text)) { MessageBox.Show("Chọn lớp trước!"); return; }
            var frm = new QuanLySinhVienForm(txtMaLop.Text);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        // Phân trang
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