using QuanLyBanBao.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanBao
{
    public partial class frmDanhSachPhieu : Form
    {
        private DataTable tblPhieu;

        public frmDanhSachPhieu()
        {
            InitializeComponent();
        }

        private void frmDanhSachPhieu_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpDenNgay.Value = DateTime.Now;
            LoadKhachHangCombo();
            LoadDataGridView();
        }

        private void LoadKhachHangCombo()
        {
            string sql = "SELECT MaKH, TenKH FROM KhachHang ORDER BY TenKH";
            DataTable dt = Functions.GetDataToTable(sql);
            cboKhachHang.DataSource = dt;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.SelectedIndex = -1; // không chọn gì
        }

        private void LoadDataGridView()
        {
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd");

            string sql = @"
        SELECT p.SoPhieu, 
               p.NgayLap, 
               ISNULL(k.TenKH, N'Khách lẻ') AS TenKH, 
               p.TongTien
        FROM PhieuBan p
        LEFT JOIN KhachHang k ON p.MaKH = k.MaKH
        WHERE CAST(p.NgayLap AS DATE) BETWEEN '" + tuNgay + @"' AND '" + denNgay + @"'";

            if (!string.IsNullOrWhiteSpace(txtSoPhieu.Text))
                sql += " AND p.SoPhieu LIKE '%" + txtSoPhieu.Text.Trim() + "%'";

            if (cboKhachHang.SelectedValue != null)
                sql += " AND p.MaKH = '" + cboKhachHang.SelectedValue.ToString() + "'";

            sql += " ORDER BY p.NgayLap DESC, p.SoPhieu DESC";

            try
            {
                tblPhieu = Functions.GetDataToTable(sql);
                dgvPhieu.DataSource = tblPhieu;

                // Đặt lại tiêu đề cột
                if (dgvPhieu.Columns["SoPhieu"] != null) dgvPhieu.Columns["SoPhieu"].HeaderText = "Số phiếu";
                if (dgvPhieu.Columns["NgayLap"] != null)
                {
                    dgvPhieu.Columns["NgayLap"].HeaderText = "Ngày lập";
                    dgvPhieu.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (dgvPhieu.Columns["TenKH"] != null) dgvPhieu.Columns["TenKH"].HeaderText = "Khách hàng";
                if (dgvPhieu.Columns["TongTien"] != null)
                {
                    dgvPhieu.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgvPhieu.Columns["TongTien"].DefaultCellStyle.Format = "N0";
                }

                // Tính tổng doanh thu
                decimal tong = 0;
                foreach (DataRow row in tblPhieu.Rows)
                {
                    if (decimal.TryParse(row["TongTien"].ToString(), out decimal tien))
                        tong += tien;
                }
                lblTongDoanhThu.Text = Functions.FormatMoney(tong);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu phiếu bán:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSoPhieu.Text = "";
            cboKhachHang.SelectedIndex = -1;
            dtpTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpDenNgay.Value = DateTime.Now;
            LoadDataGridView();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow != null)
            {
                string soPhieu = dgvPhieu.CurrentRow.Cells["SoPhieu"].Value.ToString();
                frmChiTietPhieu f = new frmChiTietPhieu(soPhieu);
                f.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu bán cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPhieu = dgvPhieu.CurrentRow.Cells["SoPhieu"].Value.ToString();
            string ngayLap = Convert.ToDateTime(dgvPhieu.CurrentRow.Cells["NgayLap"].Value).ToString("dd/MM/yyyy");
            string tenKH = dgvPhieu.CurrentRow.Cells["TenKH"].Value.ToString();
            string tongTien = Functions.FormatMoney(Convert.ToDecimal(dgvPhieu.CurrentRow.Cells["TongTien"].Value));

            // BƯỚC 1: KIỂM TRA XEM PHIẾU NÀY CÓ CHI TIẾT KHÔNG
            string sqlCheck = $"SELECT COUNT(*) FROM ChiTietPhieuBan WHERE SoPhieu = '{soPhieu}'";
            int countChiTiet = Convert.ToInt32(Functions.GetFieldValue(sqlCheck));

            string thongBao = $"Bạn có chắc chắn muốn xóa phiếu bán:\n\n" +
                              $"Số phiếu: {soPhieu}\n" +
                              $"Ngày lập: {ngayLap}\n" +
                              $"Khách hàng: {tenKH}\n" +
                              $"Tổng tiền: {tongTien}\n\n";

            if (countChiTiet > 0)
            {
                thongBao += $"⚠️ Phiếu này có {countChiTiet} chi tiết bán báo.\n" +
                            $"Việc xóa sẽ làm mất vĩnh viễn dữ liệu chi tiết và ảnh hưởng đến báo cáo doanh thu!\n\n" +
                            $"Bạn vẫn muốn tiếp tục?";
            }
            else
            {
                thongBao += $"Phiếu này chưa có chi tiết bán hàng.\nBạn vẫn muốn xóa?";
            }

            if (MessageBox.Show(thongBao, "XÁC NHẬN XÓA PHIẾU BÁN",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                return;
            }

            // BƯỚC 2: XÓA AN TOÀN BẰNG THAM SỐ (TRÁNH SQL INJECTION)
            try
            {
                // Xóa chi tiết trước
                string sqlDeleteChiTiet = "DELETE FROM ChiTietPhieuBan WHERE SoPhieu = @SoPhieu";
                SqlParameter[] param1 = { new SqlParameter("@SoPhieu", soPhieu) };
                Functions.RunSQLWithParams(sqlDeleteChiTiet, param1);

                // Xóa phiếu chính
                string sqlDeletePhieu = "DELETE FROM PhieuBan WHERE SoPhieu = @SoPhieu";
                SqlParameter[] param2 = { new SqlParameter("@SoPhieu", soPhieu) };
                Functions.RunSQLWithParams(sqlDeletePhieu, param2);

                MessageBox.Show($"Xóa phiếu {soPhieu} thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGridView(); // Cập nhật lại danh sách và tổng doanh thu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa phiếu bán:\n{ex.Message}", "Lỗi hệ thống",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnXemChiTiet.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}