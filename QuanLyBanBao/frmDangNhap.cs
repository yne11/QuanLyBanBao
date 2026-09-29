using System;
using System.Windows.Forms;

namespace QuanLyBanBao
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (user == "admin" && pass == "123")
            {
                MessageBox.Show("Đăng nhập thành công!\nChào mừng bạn đến với Hệ thống Quản lý Bán Báo!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frmMain fMain = new frmMain();
                fMain.ShowDialog();
                Application.Exit();
            }
            else
            {
                // KHÔNG GỢI Ý MẬT KHẨU NỮA → CHUYÊN NGHIỆP HƠN!
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!\nVui lòng thử lại.",
                    "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                txtPass.SelectAll();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // HÀM MỚI: HIỆN / ẨN MẬT KHẨU KHI TÍCH CHECKBOX
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtPass.PasswordChar = '\0'; // hiện chữ thường
            }
            else
            {
                txtPass.PasswordChar = '*'; // ẩn bằng dấu *
            }
        }
    }
}