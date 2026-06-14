using System;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class Form1 : Form
    {
        // ============================================================
        // Thông tin sinh viên - THAY ĐỔI theo thông tin của bạn
        // ============================================================
        private const string EMAIL_SINHVIEN = "6868@student.edu.vn"; // email sinh viên
        private const string MSSV = "6868";                           // mật khẩu = MSSV
        // ============================================================

        public Form1()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện bấm nút Đăng Nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (tenDangNhap == EMAIL_SINHVIEN && matKhau == MSSV)
            {
                MessageBox.Show(
                    "Đăng nhập thành công!\nChào mừng bạn đã đăng nhập vào hệ thống.",
                    "Thành Công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Đăng nhập thất bại!\nTên đăng nhập hoặc mật khẩu không đúng.",
                    "Thất Bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Xử lý sự kiện bấm nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Focus();
        }

        // Cho phép nhấn Enter để đăng nhập
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        // Giả lập PlaceholderText cho VS2012 (không có sẵn)
        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Nhập email sinh viên...")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Text = "Nhập email sinh viên...";
                txtTenDangNhap.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập MSSV...")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = System.Drawing.Color.Black;
                txtMatKhau.PasswordChar = '●';
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.Text = "Nhập MSSV...";
                txtMatKhau.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
