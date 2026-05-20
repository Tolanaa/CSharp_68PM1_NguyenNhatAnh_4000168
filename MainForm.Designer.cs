namespace QuanLySinhVien
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                menuSinhVien, menuLopHoc, menuDangXuat
            });

            // items
            this.menuSinhVien.Text = "Quản lý Sinh Viên";
            this.menuSinhVien.Click += new System.EventHandler(this.menuSinhVien_Click);

            this.menuLopHoc.Text = "Quản lý Lớp Học";
            this.menuLopHoc.Click += new System.EventHandler(this.menuLopHoc_Click);

            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.ForeColor = System.Drawing.Color.Red;
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);

            // Form
            this.Text = "Quản Lý Sinh Viên";
            this.IsMdiContainer = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenuStrip = this.menuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}