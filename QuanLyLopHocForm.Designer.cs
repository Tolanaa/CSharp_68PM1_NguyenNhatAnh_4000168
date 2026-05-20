namespace QuanLySinhVien
{
    partial class QuanLyLopHocForm
    {
        private System.ComponentModel.IContainer components = null;

        // Left panel controls
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblMaID;
        private System.Windows.Forms.TextBox txtMaID;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXemSV;

        // Right panel controls
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvLopHoc;
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
            this.lblMaID = new System.Windows.Forms.Label();
            this.txtMaID = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXemSV = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form
            this.Text = "Quản lý Lớp Học";
            this.Size = new System.Drawing.Size(1200, 750);
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // ── LEFT PANEL ──────────────────────────────────────────
            var panelLeft = new System.Windows.Forms.Panel();
            panelLeft.Location = new System.Drawing.Point(10, 10);
            panelLeft.Size = new System.Drawing.Size(410, 680);
            panelLeft.BackColor = System.Drawing.Color.LightGray;

            this.lblThongTin.Text = "Thông tin lớp học";
            this.lblThongTin.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            this.lblThongTin.Location = new System.Drawing.Point(10, 10);
            this.lblThongTin.Size = new System.Drawing.Size(200, 25);

            this.lblMaID.Text = "Mã ID:";
            this.lblMaID.Location = new System.Drawing.Point(10, 50);
            this.lblMaID.Size = new System.Drawing.Size(80, 20);

            this.txtMaID.Location = new System.Drawing.Point(10, 72);
            this.txtMaID.Size = new System.Drawing.Size(380, 23);
            this.txtMaID.ReadOnly = true;
            this.txtMaID.BackColor = System.Drawing.Color.White;

            this.lblMaLop.Text = "Mã lớp:";
            this.lblMaLop.Location = new System.Drawing.Point(10, 110);
            this.lblMaLop.Size = new System.Drawing.Size(80, 20);

            this.txtMaLop.Location = new System.Drawing.Point(10, 132);
            this.txtMaLop.Size = new System.Drawing.Size(380, 23);
            this.txtMaLop.BackColor = System.Drawing.Color.White;

            this.lblTenLop.Text = "Tên lớp:";
            this.lblTenLop.Location = new System.Drawing.Point(10, 170);
            this.lblTenLop.Size = new System.Drawing.Size(80, 20);

            this.txtTenLop.Location = new System.Drawing.Point(10, 192);
            this.txtTenLop.Size = new System.Drawing.Size(380, 23);
            this.txtTenLop.BackColor = System.Drawing.Color.White;

            this.lblGhiChu.Text = "Ghi chú:";
            this.lblGhiChu.Location = new System.Drawing.Point(10, 230);
            this.lblGhiChu.Size = new System.Drawing.Size(80, 20);

            this.txtGhiChu.Location = new System.Drawing.Point(10, 252);
            this.txtGhiChu.Size = new System.Drawing.Size(380, 23);
            this.txtGhiChu.BackColor = System.Drawing.Color.White;

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

            this.btnXemSV.Text = "Xem danh sách sinh viên";
            this.btnXemSV.Location = new System.Drawing.Point(10, 640);
            this.btnXemSV.Size = new System.Drawing.Size(380, 35);
            this.btnXemSV.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXemSV.ForeColor = System.Drawing.Color.White;
            this.btnXemSV.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnXemSV.Click += new System.EventHandler(this.btnXemSV_Click);

            panelLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblThongTin, lblMaID, txtMaID, lblMaLop, txtMaLop,
                lblTenLop, txtTenLop, lblGhiChu, txtGhiChu,
                btnThem, btnSua, btnXoa, btnLamMoi, btnXemSV
            });

            // ── RIGHT PANEL ─────────────────────────────────────────
            this.lblTimKiem.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";
            this.lblTimKiem.Location = new System.Drawing.Point(430, 15);
            this.lblTimKiem.Size = new System.Drawing.Size(300, 20);

            this.txtTimKiem.Location = new System.Drawing.Point(430, 38);
            this.txtTimKiem.Size = new System.Drawing.Size(300, 23);

            this.btnTim.Text = "Tìm";
            this.btnTim.Location = new System.Drawing.Point(740, 35);
            this.btnTim.Size = new System.Drawing.Size(80, 28);
            this.btnTim.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            this.dgvLopHoc.Location = new System.Drawing.Point(430, 75);
            this.dgvLopHoc.Size = new System.Drawing.Size(740, 580);
            this.dgvLopHoc.ReadOnly = true;
            this.dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHoc.AllowUserToAddRows = false;
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.SelectionChanged += new System.EventHandler(this.dgvLopHoc_SelectionChanged);

            // Paging buttons
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
                dgvLopHoc,
                btnFirst, btnPrev, lblPage, btnNext, btnLast
            });
            this.ResumeLayout(false);
        }
    }
}