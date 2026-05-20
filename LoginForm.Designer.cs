namespace QuanLySinhVien
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDangNhap;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form
            this.Text = "Đăng Nhập";
            this.Size = new System.Drawing.Size(350, 250);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // lblTitle
            this.lblTitle.Text = "QUẢN LÝ SINH VIÊN";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Size = new System.Drawing.Size(230, 30);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblUser
            this.lblUser.Text = "Tên đăng nhập:";
            this.lblUser.Location = new System.Drawing.Point(30, 70);
            this.lblUser.Size = new System.Drawing.Size(120, 23);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(160, 67);
            this.txtUsername.Size = new System.Drawing.Size(140, 23);

            // lblPass
            this.lblPass.Text = "Mật khẩu:";
            this.lblPass.Location = new System.Drawing.Point(30, 110);
            this.lblPass.Size = new System.Drawing.Size(120, 23);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(160, 107);
            this.txtPassword.Size = new System.Drawing.Size(140, 23);
            this.txtPassword.PasswordChar = '*';

            // btnDangNhap
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Location = new System.Drawing.Point(110, 155);
            this.btnDangNhap.Size = new System.Drawing.Size(120, 35);
            this.btnDangNhap.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblUser, txtUsername, lblPass, txtPassword, btnDangNhap
            });
            this.ResumeLayout(false);
        }
    }
}