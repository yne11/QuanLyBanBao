using System;
using System.Data;
using System.Windows.Forms;
using QuanLyBanBao.Class;

namespace QuanLyBanBao
{
    public partial class frmBaoCao : Form
    {
        private DataTable dtDoanhThu, dtBao, dtKH;

        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
            BaoCao();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCao();
        }

        private void BaoCao()
        {
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd");

            // 1. Doanh thu
            string sqlDoanhThu = $@"
                SELECT CONVERT(date, NgayLap) AS Ngay, SUM(TongTien) AS DoanhThu
                FROM PhieuBan
                WHERE NgayLap BETWEEN '{tuNgay}' AND '{denNgay}'
                GROUP BY CONVERT(date, NgayLap)
                ORDER BY Ngay";

            dtDoanhThu = Functions.GetDataToTable(sqlDoanhThu);
            HienThiDoanhThu();

            // 2. Báo bán chạy
            string sqlBao = $@"
                SELECT b.MaBao, b.TenBao, SUM(ct.SoLuong) AS SoLuong, SUM(ct.ThanhTien) AS ThanhTien
                FROM ChiTietPhieuBan ct
                JOIN Bao b ON ct.MaBao = b.MaBao
                JOIN PhieuBan p ON ct.SoPhieu = p.SoPhieu
                WHERE p.NgayLap BETWEEN '{tuNgay}' AND '{denNgay}'
                GROUP BY b.MaBao, b.TenBao
                ORDER BY SoLuong DESC";

            dtBao = Functions.GetDataToTable(sqlBao);
            HienThiBao();

            // 3. Khách hàng
            string sqlKH = $@"
                SELECT p.MaKH, ISNULL(k.TenKH, N'Khách lẻ') AS TenKH, COUNT(p.SoPhieu) AS SoPhieu, SUM(p.TongTien) AS TongTien
                FROM PhieuBan p
                LEFT JOIN KhachHang k ON p.MaKH = k.MaKH
                WHERE p.NgayLap BETWEEN '{tuNgay}' AND '{denNgay}'
                GROUP BY p.MaKH, k.TenKH
                ORDER BY TongTien DESC";

            dtKH = Functions.GetDataToTable(sqlKH);
            HienThiKhachHang();
        }

        private void HienThiDoanhThu()
        {
            dgvDoanhThu.Rows.Clear();
            decimal tong = 0;
            foreach (DataRow row in dtDoanhThu.Rows)
            {
                string ngay = Convert.ToDateTime(row["Ngay"]).ToString("dd/MM/yyyy");
                decimal dt = Convert.ToDecimal(row["DoanhThu"]);
                dgvDoanhThu.Rows.Add(ngay, Functions.FormatMoney(dt));
                tong += dt;
            }
            lblTongDoanhThu.Text = "TỔNG DOANH THU: " + Functions.FormatMoney(tong);
        }

        private void HienThiBao()
        {
            int top = GetTopValue(cboTopBao.SelectedItem?.ToString());
            dgvBaoBanChay.Rows.Clear();
            int tongSL = 0;
            int count = 0;

            foreach (DataRow row in dtBao.Rows)
            {
                if (top > 0 && count >= top) break;
                dgvBaoBanChay.Rows.Add(
                    row["MaBao"],
                    row["TenBao"],
                    row["SoLuong"],
                    Functions.FormatMoney(Convert.ToDecimal(row["ThanhTien"]))
                );
                tongSL += Convert.ToInt32(row["SoLuong"]);
                count++;
            }
            lblTongSoLuong.Text = $"TỔNG SỐ LƯỢNG BÁN: {tongSL} tờ";
        }

        private void HienThiKhachHang()
        {
            int top = GetTopValue(cboTopKH.SelectedItem?.ToString());
            dgvKhachHang.Rows.Clear();
            int count = 0;

            foreach (DataRow row in dtKH.Rows)
            {
                if (top > 0 && count >= top) break;
                dgvKhachHang.Rows.Add(
                    row["MaKH"],
                    row["TenKH"],
                    row["SoPhieu"],
                    Functions.FormatMoney(Convert.ToDecimal(row["TongTien"]))
                );
                count++;
            }
        }

        private int GetTopValue(string text)
        {
            if (text == "Tất cả") return 0;
            if (text == "Top 5") return 5;
            if (text == "Top 10") return 10;
            if (text == "Top 20") return 20;
            return 10; // mặc định
        }

        private void cboTopBao_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiBao();
        }

        private void cboTopKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiKhachHang();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}