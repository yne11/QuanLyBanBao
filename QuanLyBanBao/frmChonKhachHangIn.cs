using System;
using System.Data;
using System.Windows.Forms;
using QuanLyBanBao.Class;

namespace QuanLyBanBao
{
    public partial class frmChonKhachHangIn : Form
    {
        private DataTable tblKH;

        public frmChonKhachHangIn()
        {
            InitializeComponent();
        }

        private void frmChonKhachHangIn_Load(object sender, EventArgs e)
        {
            LoadDuLieuKhachHang();

            // Hiệu ứng gợi ý tìm kiếm
            txtTimKiem.GotFocus += (s, args) =>
            {
                if (txtTimKiem.Text == "Nhập tên hoặc số điện thoại...")
                {
                    txtTimKiem.Text = "";
                    txtTimKiem.ForeColor = System.Drawing.Color.Black;
                }
            };

            txtTimKiem.LostFocus += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    txtTimKiem.Text = "Nhập tên hoặc số điện thoại...";
                    txtTimKiem.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void LoadDuLieuKhachHang()
        {
            string sql = "SELECT MaKH, TenKH, DiaChi, DienThoai FROM KhachHang ORDER BY TenKH";
            tblKH = Functions.GetDataToTable(sql);

            // XÓA HẾT CỘT CŨ ĐỂ TRÁNH BỊ NHÂN ĐÔI
            dgvKhachHang.Columns.Clear();

            dgvKhachHang.DataSource = tblKH;

            // Đặt lại tiêu đề cột đẹp
            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["DienThoai"].HeaderText = "Điện thoại";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (tuKhoa == "Nhập tên hoặc số điện thoại...") tuKhoa = "";

            string sql = "SELECT MaKH, TenKH, DiaChi, DienThoai FROM KhachHang WHERE 1=1";
            if (!string.IsNullOrEmpty(tuKhoa))
                sql += $" AND (TenKH LIKE N'%{tuKhoa}%' OR DienThoai LIKE '%{tuKhoa}%')";

            sql += " ORDER BY TenKH";

            tblKH = Functions.GetDataToTable(sql);
            dgvKhachHang.Columns.Clear();
            dgvKhachHang.DataSource = tblKH;

            // Đặt lại tiêu đề
            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["DienThoai"].HeaderText = "Điện thoại";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = dgvKhachHang.CurrentRow.Cells[0].Value.ToString(); // Dùng index 0 = MaKH

            frmInPhieuTheoKhach f = new frmInPhieuTheoKhach(maKH);
            f.ShowDialog();
            this.Close();
        }

        private void dgvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            btnChon_Click(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}