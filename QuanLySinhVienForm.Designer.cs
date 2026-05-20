namespace QuanLySinhVien
{
    partial class QuanLySinhVienForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.Text = "Quản lý Sinh Viên";
            this.Size = new System.Drawing.Size(1200, 750);
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // ── LEFT PANEL ──────────────────────────────────────────
            var panelLeft = new System.Windows.Forms.Panel();
            panelLeft.Location = new System.Drawing.Point(10, 10);
            panelLeft.Size = new System.Drawing.Size(410, 680);
            panelLeft.BackColor = System.Drawing.Color.LightGray;

            this.lblThongTin.Text = "Thông tin sinh viên";
            this.lblThongTin.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            this.lblThongTin.Location = new System.Drawing.Point(10, 10);
            this.lblThongTin.Size = new System.Drawing.Size(200, 25);

            this.lblMaSV.Text = "Mã sinh viên:";
            this.lblMaSV.Location = new System.Drawing.Point(10, 50);
            this.lblMaSV.Size = new System.Drawing.Size(120, 20);

            this.txtMaSV.Location = new System.Drawing.Point(10, 72);
            this.txtMaSV.Size = new System.Drawing.Size(380, 23);
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.BackColor = System.Drawing.Color.White;

            this.lblHoTen.Text = "Họ và tên:";
            this.lblHoTen.Location = new System.Drawing.Point(10, 110);
            this.lblHoTen.Size = new System.Drawing.Size(120, 20);

            this.txtHoTen.Location = new System.Drawing.Point(10, 132);
            this.txtHoTen.Size = new System.Drawing.Size(380, 23);
            this.txtHoTen.BackColor = System.Drawing.Color.White;

            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Location = new System.Drawing.Point(10, 170);
            this.lblNgaySinh.Size = new System.Drawing.Size(120, 20);

            this.dtpNgaySinh.Location = new System.Drawing.Point(10, 192);
            this.dtpNgaySinh.Size = new System.Drawing.Size(380, 23);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Location = new System.Drawing.Point(10, 230);
            this.lblGioiTinh.Size = new System.Drawing.Size(120, 20);

            this.cboGioiTinh.Location = new System.Drawing.Point(10, 252);
            this.cboGioiTinh.Size = new System.Drawing.Size(380, 23);
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            this.cboGioiTinh.SelectedIndex = 0;

            this.lblLop.Text = "Lớp:";
            this.lblLop.Location = new System.Drawing.Point(10, 290);
            this.lblLop.Size = new System.Drawing.Size(120, 20);

            this.cboLop.Location = new System.Drawing.Point(10, 312);
            this.cboLop.Size = new System.Drawing.Size(380, 23);
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Buttons
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(10, 540);
            this.btnThem.Size = new System.Drawing.Size(185, 45);
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(205, 540);
            this.btnSua.Size = new System.Drawing.Size(185, 45);
            this.btnSua.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(10, 595);
            this.btnXoa.Size = new System.Drawing.Size(185, 45);
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(205, 595);
            this.btnLamMoi.Size = new System.Drawing.Size(185, 45);
            this.btnLamMoi.BackColor = System.Drawing.Color.DimGray;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            panelLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblThongTin, lblMaSV, txtMaSV, lblHoTen, txtHoTen,
                lblNgaySinh, dtpNgaySinh, lblGioiTinh, cboGioiTinh,
                lblLop, cboLop, btnThem, btnSua, btnXoa, btnLamMoi
            });

            // ── RIGHT PANEL ─────────────────────────────────────────
            this.lblTimKiem.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";
            this.lblTimKiem.Location = new System.Drawing.Point(430, 15);
            this.lblTimKiem.Size = new System.Drawing.Size(280, 20);

            this.txtTimKiem.Location = new System.Drawing.Point(430, 38);
            this.txtTimKiem.Size = new System.Drawing.Size(300, 23);

            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new System.Drawing.Point(740, 35);
            this.btnTim.Size = new System.Drawing.Size(80, 28);
            this.btnTim.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            this.dgvSinhVien.Location = new System.Drawing.Point(430, 75);
            this.dgvSinhVien.Size = new System.Drawing.Size(740, 580);
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.dgvSinhVien_SelectionChanged);

            this.btnFirst.Text = "<<";
            this.btnFirst.Location = new System.Drawing.Point(430, 665);
            this.btnFirst.Size = new System.Drawing.Size(45, 30);
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);

            this.btnPrev.Text = "<";
            this.btnPrev.Location = new System.Drawing.Point(480, 665);
            this.btnPrev.Size = new System.Drawing.Size(45, 30);
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);

            this.lblPage.Text = "Trang 1/1  |  0 bản ghi";
            this.lblPage.Location = new System.Drawing.Point(535, 670);
            this.lblPage.Size = new System.Drawing.Size(280, 20);
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnNext.Text = ">";
            this.btnNext.Location = new System.Drawing.Point(870, 665);
            this.btnNext.Size = new System.Drawing.Size(45, 30);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            this.btnLast.Text = ">>";
            this.btnLast.Location = new System.Drawing.Point(920, 665);
            this.btnLast.Size = new System.Drawing.Size(45, 30);
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                panelLeft,
                lblTimKiem, txtTimKiem, btnTim,
                dgvSinhVien,
                btnFirst, btnPrev, lblPage, btnNext, btnLast
            });
            this.ResumeLayout(false);
        }
    }
}