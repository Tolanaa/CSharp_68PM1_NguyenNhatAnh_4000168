using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuSinhVien_Click(object sender, EventArgs e)
        {
            OpenChild(new QuanLySinhVienForm());
        }

        private void menuLopHoc_Click(object sender, EventArgs e)
        {
            OpenChild(new QuanLyLopHocForm());
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        private void OpenChild(Form frm)
        {
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}