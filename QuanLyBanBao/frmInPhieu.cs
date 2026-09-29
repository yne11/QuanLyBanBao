using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using QuanLyBanBao.Class;

namespace QuanLyBanBao
{
    public partial class frmInPhieu : Form
    {
        private string soPhieu;

        public frmInPhieu(string _soPhieu)
        {
            InitializeComponent();
            soPhieu = _soPhieu;
        }

        private void frmInPhieu_Load(object sender, EventArgs e)
        {
            this.Text = "PHIẾU BÁN BÁO - " + soPhieu;
            lblSoPhieu.Text = "Số phiếu: " + soPhieu;
            LoadDuLieuPhieu();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void LoadDuLieuPhieu()
        {
            string sql = $@"
                SELECT p.NgayLap, ISNULL(k.TenKH, N'Khách lẻ') AS TenKH, p.TongTien
                FROM PhieuBan p
                LEFT JOIN KhachHang k ON p.MaKH = k.MaKH
                WHERE p.SoPhieu = '{soPhieu}'";

            DataTable dt = Functions.GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                lblNgay.Text = "Ngày bán: " + Convert.ToDateTime(dt.Rows[0]["NgayLap"]).ToString("dd/MM/yyyy");
                lblKhachHang.Text = "Khách hàng: " + dt.Rows[0]["TenKH"].ToString();
                lblTongTien.Text = "TỔNG TIỀN: " + Functions.FormatMoney(Convert.ToDecimal(dt.Rows[0]["TongTien"]));
            }

            string sqlCT = $@"
                SELECT b.MaBao, b.TenBao, ct.SoLuong, ct.DonGia, ct.ThanhTien
                FROM ChiTietPhieuBan ct
                JOIN Bao b ON ct.MaBao = b.MaBao
                WHERE ct.SoPhieu = '{soPhieu}'
                ORDER BY b.TenBao";

            DataTable dtCT = Functions.GetDataToTable(sqlCT);

            // XÓA CỘT CŨ ĐỂ TRÁNH NHÂN ĐÔI
            dgvChiTiet.Columns.Clear();

            dgvChiTiet.DataSource = dtCT;

            // Đặt lại tiêu đề cột
            dgvChiTiet.Columns["MaBao"].HeaderText = "Mã báo";
            dgvChiTiet.Columns["TenBao"].HeaderText = "Tên báo";
            dgvChiTiet.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thành tiền";

            dgvChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontBold = new Font("Times New Roman", 14, FontStyle.Bold);
            Font fontNormal = new Font("Times New Roman", 12);
            int y = 50;

            g.DrawString("CỬA HÀNG BÁN BÁO ABC", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 250, y);
            y += 50;
            g.DrawString("PHIẾU BÁN BÁO", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, 320, y);
            y += 60;

            g.DrawString($"Số phiếu: {soPhieu}", fontBold, Brushes.Black, 100, y);
            g.DrawString(lblNgay.Text.Replace("Ngày bán: ", ""), fontBold, Brushes.Black, 500, y);
            y += 40;
            g.DrawString(lblKhachHang.Text, fontBold, Brushes.Black, 100, y);
            y += 60;

            // In bảng
            g.DrawString("STT", fontBold, Brushes.Black, 100, y);
            g.DrawString("Tên báo", fontBold, Brushes.Black, 200, y);
            g.DrawString("SL", fontBold, Brushes.Black, 500, y);
            g.DrawString("Đơn giá", fontBold, Brushes.Black, 580, y);
            g.DrawString("Thành tiền", fontBold, Brushes.Black, 680, y);
            y += 30;
            g.DrawLine(Pens.Black, 100, y, 780, y);
            y += 10;

            int stt = 1;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                g.DrawString(stt.ToString(), fontNormal, Brushes.Black, 110, y);
                g.DrawString(row.Cells["TenBao"].Value.ToString(), fontNormal, Brushes.Black, 200, y);
                g.DrawString(row.Cells["SoLuong"].Value.ToString(), fontNormal, Brushes.Black, 510, y);
                g.DrawString(Convert.ToDecimal(row.Cells["DonGia"].Value).ToString("N0"), fontNormal, Brushes.Black, 590, y);
                g.DrawString(Convert.ToDecimal(row.Cells["ThanhTien"].Value).ToString("N0"), fontNormal, Brushes.Black, 690, y);
                y += 30;
                stt++;
            }

            y += 20;
            g.DrawLine(Pens.Black, 500, y, 780, y);
            y += 10;
            g.DrawString("TỔNG TIỀN:", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Red, 500, y);
            g.DrawString(lblTongTien.Text.Replace("TỔNG TIỀN: ", ""), new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Red, 650, y);
            y += 60;
            g.DrawString("Xin cảm ơn quý khách!", fontBold, Brushes.Black, 300, y);
        }
    }
}