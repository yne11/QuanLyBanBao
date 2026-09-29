using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using QuanLyBanBao.Class;

namespace QuanLyBanBao
{
    public partial class frmChiTietPhieu : Form
    {
        private readonly string soPhieu;

        public frmChiTietPhieu()
        {
            InitializeComponent();
        }

        public frmChiTietPhieu(string _soPhieu) : this()
        {
            soPhieu = _soPhieu;
        }

        private void frmChiTietPhieu_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(soPhieu))
            {
                MessageBox.Show("Không xác định được số phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.Text = "CHI TIẾT PHIẾU - " + soPhieu;
            lblSoPhieu.Text = soPhieu;
            LoadThongTinPhieu();
            LoadChiTiet();

            // ← DÒNG QUAN TRỌNG NHẤT – GÁN SỰ KIỆN IN ĐỂ CÓ XEM TRƯỚC!
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void LoadThongTinPhieu()
        {
            string sql = $@"
                SELECT p.NgayLap, ISNULL(k.TenKH, N'Khách lẻ') AS TenKH, p.TongTien
                FROM PhieuBan p
                LEFT JOIN KhachHang k ON p.MaKH = k.MaKH
                WHERE p.SoPhieu = '{soPhieu}'";

            DataTable dt = Functions.GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                lblNgayLap.Text = Convert.ToDateTime(dt.Rows[0]["NgayLap"]).ToString("dd/MM/yyyy");
                lblKhachHang.Text = dt.Rows[0]["TenKH"].ToString();
                lblTongTien.Text = Functions.FormatMoney(Convert.ToDecimal(dt.Rows[0]["TongTien"]));
            }
        }

        private void LoadChiTiet()
        {
            string sql = $@"
                SELECT b.MaBao, b.TenBao, ct.SoLuong, ct.DonGia, ct.ThanhTien
                FROM ChiTietPhieuBan ct
                JOIN Bao b ON ct.MaBao = b.MaBao
                WHERE ct.SoPhieu = '{soPhieu}'
                ORDER BY b.TenBao";

            DataTable dt = Functions.GetDataToTable(sql);
            dgvChiTiet.DataSource = dt;

            // Đặt tiêu đề cột đẹp
            dgvChiTiet.Columns["MaBao"].HeaderText = "Mã báo";
            dgvChiTiet.Columns["TenBao"].HeaderText = "Tên báo";
            dgvChiTiet.Columns["SoLuong"].HeaderText = "SL";
            dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thành tiền";

            dgvChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontBold = new Font("Times New Roman", 12, FontStyle.Bold);
            Font fontNormal = new Font("Times New Roman", 11);
            int y = 50;

            g.DrawString("CỬA HÀNG BÁN BÁO ABC", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, 200, y);
            y += 50;
            g.DrawString("ĐC: 123 Trần Hưng Đạo, Q.1, TP.HCM", fontNormal, Brushes.Black, 200, y);
            y += 40;
            g.DrawString("PHIẾU BÁN BÁO", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, 300, y);
            y += 60;

            g.DrawString($"Số phiếu: {soPhieu}", fontBold, Brushes.Black, 100, y);
            g.DrawString($"Ngày: {lblNgayLap.Text}", fontBold, Brushes.Black, 500, y);
            y += 40;
            g.DrawString($"Khách hàng: {lblKhachHang.Text}", fontBold, Brushes.Black, 100, y);
            y += 50;

            g.DrawString("STT", fontBold, Brushes.Black, 100, y);
            g.DrawString("Tên báo", fontBold, Brushes.Black, 180, y);
            g.DrawString("SL", fontBold, Brushes.Black, 480, y);
            g.DrawString("Đơn giá", fontBold, Brushes.Black, 550, y);
            g.DrawString("Thành tiền", fontBold, Brushes.Black, 680, y);
            y += 30;
            g.DrawLine(Pens.Black, 100, y, 780, y);
            y += 10;

            int stt = 1;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.IsNewRow) continue;
                g.DrawString(stt.ToString(), fontNormal, Brushes.Black, 110, y);
                g.DrawString(row.Cells["TenBao"].Value.ToString(), fontNormal, Brushes.Black, 180, y);
                g.DrawString(row.Cells["SoLuong"].Value.ToString(), fontNormal, Brushes.Black, 490, y);
                g.DrawString(Convert.ToDecimal(row.Cells["DonGia"].Value).ToString("N0"), fontNormal, Brushes.Black, 560, y);
                g.DrawString(Convert.ToDecimal(row.Cells["ThanhTien"].Value).ToString("N0"), fontNormal, Brushes.Black, 690, y);
                y += 28;
                stt++;
            }

            y += 20;
            g.DrawLine(Pens.Black, 500, y, 780, y);
            y += 10;
            g.DrawString("TỔNG TIỀN:", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Red, 500, y);
            g.DrawString(lblTongTien.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Red, 650, y);
            y += 60;
            g.DrawString("Xin cảm ơn quý khách!", fontBold, Brushes.Black, 300, y);
        }
    }
}