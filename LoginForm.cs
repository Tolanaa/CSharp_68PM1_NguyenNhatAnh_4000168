using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DatabaseHelper.InitDatabase();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // Tài khoản mặc định: admin / 1234
            if (user == "admin" && pass == "1234")
            {
                var main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}