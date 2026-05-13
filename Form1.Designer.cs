namespace DangNhap
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel      pnlHeader;
        private System.Windows.Forms.Label      lblTieuDe;
        private System.Windows.Forms.Label      lblPhuDe;
        private System.Windows.Forms.Panel      pnlOrangeLine;
        private System.Windows.Forms.Panel      pnlBody;
        private System.Windows.Forms.Label      lblTenDangNhap;
        private System.Windows.Forms.TextBox    txtTenDangNhap;
        private System.Windows.Forms.Label      lblMatKhau;
        private System.Windows.Forms.TextBox    txtMatKhau;
        private System.Windows.Forms.Button     btnDangNhap;
        private System.Windows.Forms.Button     btnHuy;
        private System.Windows.Forms.Label      lblFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader      = new System.Windows.Forms.Panel();
            this.lblTieuDe      = new System.Windows.Forms.Label();
            this.lblPhuDe       = new System.Windows.Forms.Label();
            this.pnlOrangeLine  = new System.Windows.Forms.Panel();
            this.pnlBody        = new System.Windows.Forms.Panel();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau     = new System.Windows.Forms.Label();
            this.txtMatKhau     = new System.Windows.Forms.TextBox();
            this.btnDangNhap    = new System.Windows.Forms.Button();
            this.btnHuy         = new System.Windows.Forms.Button();
            this.lblFooter      = new System.Windows.Forms.Label();

            // ── FORM ────────────────────────────────────────────────
            this.Text            = "Đăng Nhập Hệ Thống";
            this.ClientSize      = new System.Drawing.Size(400, 480);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.BackColor       = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font            = new System.Drawing.Font("Segoe UI", 9F);

            // ── HEADER ──────────────────────────────────────────────
            this.pnlHeader.Location  = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size      = new System.Drawing.Size(400, 115);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);

            this.lblTieuDe.Text      = "HỆ THỐNG QUẢN LÝ";
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Size      = new System.Drawing.Size(380, 50);
            this.lblTieuDe.Location  = new System.Drawing.Point(10, 18);
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblPhuDe.Text      = "Vui lòng đăng nhập để tiếp tục";
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.lblPhuDe.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblPhuDe.Size      = new System.Drawing.Size(380, 28);
            this.lblPhuDe.Location  = new System.Drawing.Point(10, 72);
            this.lblPhuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblPhuDe);

            // ── ORANGE LINE ─────────────────────────────────────────
            this.pnlOrangeLine.Location  = new System.Drawing.Point(0, 115);
            this.pnlOrangeLine.Size      = new System.Drawing.Size(400, 4);
            this.pnlOrangeLine.BackColor = System.Drawing.Color.FromArgb(255, 140, 0);

            // ── BODY PANEL ──────────────────────────────────────────
            this.pnlBody.Location    = new System.Drawing.Point(25, 140);
            this.pnlBody.Size        = new System.Drawing.Size(350, 280);
            this.pnlBody.BackColor   = System.Drawing.Color.White;
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Label: Tên đăng nhập
            this.lblTenDangNhap.Text      = "Tên đăng nhập (Email sinh viên):";
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblTenDangNhap.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.AutoSize  = true;
            this.lblTenDangNhap.Location  = new System.Drawing.Point(20, 25);

            // TextBox: Tên đăng nhập
            this.txtTenDangNhap.Location    = new System.Drawing.Point(20, 50);
            this.txtTenDangNhap.Size        = new System.Drawing.Size(308, 22);
            this.txtTenDangNhap.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.BackColor   = System.Drawing.Color.FromArgb(248, 250, 255);
            this.txtTenDangNhap.Text        = "Nhập email sinh viên...";
            this.txtTenDangNhap.ForeColor   = System.Drawing.Color.Gray;
            this.txtTenDangNhap.Enter      += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtTenDangNhap.Leave      += new System.EventHandler(this.txtTenDangNhap_Leave);

            // Label: Mật khẩu
            this.lblMatKhau.Text      = "Mật khẩu (MSSV):";
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblMatKhau.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.AutoSize  = true;
            this.lblMatKhau.Location  = new System.Drawing.Point(20, 100);

            // TextBox: Mật khẩu
            this.txtMatKhau.Location    = new System.Drawing.Point(20, 125);
            this.txtMatKhau.Size        = new System.Drawing.Size(308, 22);
            this.txtMatKhau.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.BackColor   = System.Drawing.Color.FromArgb(248, 250, 255);
            this.txtMatKhau.Text        = "Nhập MSSV...";
            this.txtMatKhau.ForeColor   = System.Drawing.Color.Gray;
            // KHÔNG đặt PasswordChar ở đây — xử lý qua Enter/Leave event
            this.txtMatKhau.Enter      += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave      += new System.EventHandler(this.txtMatKhau_Leave);
            this.txtMatKhau.KeyDown    += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);

            // Button: Đăng Nhập
            this.btnDangNhap.Text      = "ĐĂNG NHẬP";
            this.btnDangNhap.Location  = new System.Drawing.Point(20, 195);
            this.btnDangNhap.Size      = new System.Drawing.Size(140, 38);
            this.btnDangNhap.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(30, 80, 162);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Click    += new System.EventHandler(this.btnDangNhap_Click);

            // Button: Hủy
            this.btnHuy.Text      = "HỦY";
            this.btnHuy.Location  = new System.Drawing.Point(188, 195);
            this.btnHuy.Size      = new System.Drawing.Size(140, 38);
            this.btnHuy.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Click    += new System.EventHandler(this.btnHuy_Click);

            this.pnlBody.Controls.Add(this.lblTenDangNhap);
            this.pnlBody.Controls.Add(this.txtTenDangNhap);
            this.pnlBody.Controls.Add(this.lblMatKhau);
            this.pnlBody.Controls.Add(this.txtMatKhau);
            this.pnlBody.Controls.Add(this.btnDangNhap);
            this.pnlBody.Controls.Add(this.btnHuy);

            // Footer
            this.lblFooter.Text      = "© 2024 - Luong Xuan Hieu - MSSV: 6868";
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblFooter.Font      = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblFooter.Size      = new System.Drawing.Size(380, 22);
            this.lblFooter.Location  = new System.Drawing.Point(10, 445);
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── ADD TO FORM ─────────────────────────────────────────
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlOrangeLine);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.lblFooter);
        }
    }
}
