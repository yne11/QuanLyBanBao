using System;
using System.Data;
using System.Windows.Forms;
using QuanLyBanBao.Class;
using System.Data.SqlClient;

namespace QuanLyBanBao
{
    public partial class frmKhachHang : Form
    {
        private DataTable tblKH;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT MaKH, TenKH, DiaChi, DienThoai, Email FROM KhachHang ORDER BY MaKH";
            tblKH = Functions.GetDataToTable(sql);
            dgvKhachHang.DataSource = tblKH;

            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvKhachHang.Columns["Email"].HeaderText = "Email";

            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtTenKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ResetValues();
            txtMaKH.Text = Functions.CreateKey("KhachHang"); // KH009, KH010...
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaKH.Text) && !string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                // Đang thêm mới → Lưu
                string sql = @"INSERT INTO KhachHang (MaKH, TenKH, DiaChi, DienThoai, Email) 
                               VALUES (@MaKH, @TenKH, @DiaChi, @DienThoai, @Email)";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaKH", txtMaKH.Text.Trim()),
                    new SqlParameter("@TenKH", txtTenKH.Text.Trim()),
                    new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                    new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim())
                };

                if (Functions.RunSQLWithParams(sql, parameters))
                {
                    MessageBox.Show("Thêm mới khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                    ResetValues();
                }
            }
            else
            {
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"UPDATE KhachHang SET TenKH = @TenKH, DiaChi = @DiaChi, 
                          DienThoai = @DienThoai, Email = @Email WHERE MaKH = @MaKH";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenKH", txtTenKH.Text.Trim()),
                new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()),
                new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()),
                new SqlParameter("@Email", txtEmail.Text.Trim()),
                new SqlParameter("@MaKH", txtMaKH.Text.Trim())
            };

            if (Functions.RunSQLWithParams(sql, parameters))
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
                ResetValues();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = txtMaKH.Text.Trim();

            // BƯỚC 1: KIỂM TRA KHÁCH HÀNG NÀY ĐÃ CÓ PHIẾU BÁN CHƯA
            string sqlCheck = $"SELECT COUNT(*) FROM PhieuBan WHERE MaKH = '{maKH}'";
            int count = Convert.ToInt32(Functions.GetFieldValue(sqlCheck));

            if (count > 0)
            {
                MessageBox.Show(
                    "Không thể xóa khách hàng này!\n\n" +
                    $"Khách hàng \"{txtTenKH.Text}\" (Mã: {maKH}) đã lập {count} phiếu bán báo.\n" +
                    "Theo quy định, không được xóa khách hàng đã phát sinh nghiệp vụ bán hàng để đảm bảo tính toàn vẹn dữ liệu và lịch sử doanh thu.",
                    "Cảnh báo xóa khách hàng",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // BƯỚC 2: NẾU CHƯA CÓ PHIẾU → HỎI XÁC NHẬN VÀ XÓA
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng:\n\n{txtTenKH.Text}\nMã KH: {maKH}\nĐịa chỉ: {txtDiaChi.Text}\nĐiện thoại: {txtDienThoai.Text}",
                "Xác nhận xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                SqlParameter[] parameters = { new SqlParameter("@MaKH", maKH) };

                if (Functions.RunSQLWithParams(sqlDelete, parameters))
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                    ResetValues();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM KhachHang WHERE 1=1";
            if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
                sql += $" AND (MaKH LIKE '%{txtTimKiem.Text.Trim()}%' OR TenKH LIKE N'%{txtTimKiem.Text.Trim()}%' OR DienThoai LIKE '%{txtTimKiem.Text.Trim()}%')";

            dgvKhachHang.DataSource = Functions.GetDataToTable(sql);
        }

        // Chỉ cho nhập số ở ô điện thoại
        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.OnlyNumber(e);
        }
    }
}