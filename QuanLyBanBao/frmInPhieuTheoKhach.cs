using System;
using System.Data;
using System.Windows.Forms;
using QuanLyBanBao.Class;

namespace QuanLyBanBao
{
    public partial class frmInPhieuTheoKhach : Form
    {
        private string maKH;
        private string tenKH;

        public frmInPhieuTheoKhach(string _maKH)
        {
            InitializeComponent();
            maKH = _maKH;
        }

        private void frmInPhieuTheoKhach_Load(object sender, EventArgs e)
        {
            LoadThongTinKhachHang();
            LoadDanhSachPhieu();
        }

        private void LoadThongTinKhachHang()
        {
            string sql = $"SELECT TenKH FROM KhachHang WHERE MaKH = '{maKH}'";
            object result = Functions.GetFieldValue(sql);
            tenKH = result != null ? result.ToString() : "Khách lẻ";
            lblKhachHang.Text = $"Khách hàng: {tenKH} ({maKH})";
        }

        private void LoadDanhSachPhieu()
        {
            string sql = $@"
                SELECT SoPhieu, NgayLap, TongTien
                FROM PhieuBan
                WHERE MaKH = '{maKH}'
                ORDER BY NgayLap DESC";

            DataTable dt = Functions.GetDataToTable(sql);

            // QUAN TRỌNG: XÓA HẾT CỘT CŨ ĐỂ TRÁNH NHÂN ĐÔI
            dgvPhieu.Columns.Clear();

            dgvPhieu.DataSource = dt;

            // Đặt lại tiêu đề cột
            dgvPhieu.Columns["SoPhieu"].HeaderText = "Số phiếu";
            dgvPhieu.Columns["NgayLap"].HeaderText = "Ngày bán";
            dgvPhieu.Columns["TongTien"].HeaderText = "Tổng tiền";

            dgvPhieu.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPhieu.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow != null)
            {
                string soPhieu = dgvPhieu.CurrentRow.Cells["SoPhieu"].Value.ToString();
                frmInPhieu f = new frmInPhieu(soPhieu);
                f.ShowDialog();
            }
        }

        private void dgvPhieu_DoubleClick(object sender, EventArgs e)
        {
            btnInPhieu_Click(sender, e);
        }

        private void btnInTatCa_Click(object sender, EventArgs e)
        {
            if (dgvPhieu.Rows.Count == 0)
            {
                MessageBox.Show("Khách hàng này chưa có phiếu nào!", "Thông báo");
                return;
            }

            foreach (DataGridViewRow row in dgvPhieu.Rows)
            {
                string soPhieu = row.Cells["SoPhieu"].Value.ToString();
                frmInPhieu f = new frmInPhieu(soPhieu);
                f.Show();
            }

            MessageBox.Show($"Đã mở {dgvPhieu.Rows.Count} phiếu để in!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}