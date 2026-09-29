using QuanLyBanBao.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanBao
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            LoadBao();
            LoadKhachHang();
            LoadPhieu();

            // Hiệu ứng gợi ý tìm kiếm (chạy ngon mọi .NET)
            SetupPlaceholder(txtTimBao, "Nhập mã hoặc tên báo...");
            SetupPlaceholder(txtTimKH, "Nhập mã hoặc tên khách hàng...");
            SetupPlaceholder(txtTimPhieu, "Nhập số phiếu hoặc tên khách...");
        }

        private void SetupPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.GotFocus += (s, args) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.LostFocus += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        private void LoadBao()
        {
            string sql = "SELECT MaBao, TenBao, LoaiBao, GiaBan, SoLuongTon FROM Bao ORDER BY TenBao";
            DataTable dt = Functions.GetDataToTable(sql);
            dgvBao.DataSource = dt;
            dgvBao.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
        }

        private void LoadKhachHang()
        {
            string sql = "SELECT MaKH, TenKH, DiaChi, DienThoai, Email FROM KhachHang ORDER BY TenKH";
            DataTable dt = Functions.GetDataToTable(sql);
            dgvKhachHang.DataSource = dt;
        }

        private void LoadPhieu()
        {
            string sql = @"
                SELECT p.SoPhieu, p.NgayLap, ISNULL(k.TenKH, N'Khách lẻ') AS TenKH, p.TongTien
                FROM PhieuBan p
                LEFT JOIN KhachHang k ON p.MaKH = k.MaKH
                ORDER BY p.NgayLap DESC";
            DataTable dt = Functions.GetDataToTable(sql);
            dgvPhieu.DataSource = dt;
            dgvPhieu.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPhieu.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }

        private void btnTimBao_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimBao.Text.Trim();
            if (tuKhoa == "Nhập mã hoặc tên báo...") tuKhoa = "";

            string sql = "SELECT MaBao, TenBao, LoaiBao, GiaBan, SoLuongTon FROM Bao WHERE 1=1";
            if (!string.IsNullOrEmpty(tuKhoa))
                sql += $" AND (MaBao LIKE '%{tuKhoa}%' OR TenBao LIKE N'%{tuKhoa}%')";

            dgvBao.DataSource = Functions.GetDataToTable(sql);
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKH.Text.Trim();
            if (tuKhoa == "Nhập mã hoặc tên khách hàng...") tuKhoa = "";

            string sql = "SELECT MaKH, TenKH, DiaChi, DienThoai, Email FROM KhachHang WHERE 1=1";

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                // TÌM THEO MÃ KH, TÊN KH, HOẶC SỐ ĐIỆN THOẠI – SIÊU CHUẨN!
                sql += $" AND (MaKH LIKE '%{tuKhoa}%' OR TenKH LIKE N'%{tuKhoa}%' OR DienThoai LIKE '%{tuKhoa}%')";
            }

            sql += " ORDER BY TenKH";

            DataTable dt = Functions.GetDataToTable(sql);
            dgvKhachHang.DataSource = dt;
        }

        private void btnTimPhieu_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimPhieu.Text.Trim();
            if (tuKhoa == "Nhập số phiếu hoặc tên khách...") tuKhoa = "";
            string sql = @"
                SELECT p.SoPhieu, p.NgayLap, ISNULL(k.TenKH, N'Khách lẻ') AS TenKH, p.TongTien
                FROM PhieuBan p
                LEFT JOIN KhachHang k ON p.MaKH = k.MaKH
                WHERE 1=1";
            if (!string.IsNullOrEmpty(tuKhoa))
                sql += $" AND (p.SoPhieu LIKE '%{tuKhoa}%' OR k.TenKH LIKE N'%{tuKhoa}%')";

            sql += " ORDER BY p.NgayLap DESC";
            dgvPhieu.DataSource = Functions.GetDataToTable(sql);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}