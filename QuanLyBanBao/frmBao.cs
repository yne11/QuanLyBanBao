using System;
using System.Data;
using System.Windows.Forms;
using QuanLyBanBao.Class;
using System.Data.SqlClient;

namespace QuanLyBanBao
{
    public partial class frmBao : Form
    {
        private DataTable tblBao;

        public frmBao()
        {
            InitializeComponent();
        }

        private void frmBao_Load(object sender, EventArgs e)
        {
            txtMaBao.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            LoadDataGridView();
            cboLoaiBao.SelectedIndex = 0;
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT MaBao, TenBao, LoaiBao, GiaBan, SoLuongTon FROM Bao ORDER BY MaBao";
            tblBao = Functions.GetDataToTable(sql);
            dgvBao.DataSource = tblBao;

            dgvBao.Columns["MaBao"].HeaderText = "Mã báo";
            dgvBao.Columns["TenBao"].HeaderText = "Tên báo";
            dgvBao.Columns["LoaiBao"].HeaderText = "Loại báo";
            dgvBao.Columns["GiaBan"].HeaderText = "Giá bán (₫)";
            dgvBao.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";

            dgvBao.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
            dgvBao.AllowUserToAddRows = false;
            dgvBao.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtMaBao.Text = "";
            txtTenBao.Text = "";
            cboLoaiBao.SelectedIndex = 0;
            txtGiaBan.Text = "0";
            txtSoLuongTon.Text = "0";
            txtTenBao.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ResetValues();
            txtMaBao.Text = Functions.CreateKey("Bao"); // B0001, B0002...
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaBao.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn báo cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"UPDATE Bao SET TenBao = @TenBao, LoaiBao = @LoaiBao, 
                          GiaBan = @GiaBan, SoLuongTon = @SoLuongTon WHERE MaBao = @MaBao";

            SqlParameter[] parameters =
            {
                new SqlParameter("@TenBao", txtTenBao.Text.Trim()),
                new SqlParameter("@LoaiBao", cboLoaiBao.SelectedItem.ToString()),
                new SqlParameter("@GiaBan", decimal.Parse(txtGiaBan.Text.Replace(",", ""))),
                new SqlParameter("@SoLuongTon", int.Parse(txtSoLuongTon.Text)),
                new SqlParameter("@MaBao", txtMaBao.Text.Trim())
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
            if (string.IsNullOrWhiteSpace(txtMaBao.Text))
            {
                MessageBox.Show("Vui lòng chọn báo cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // BƯỚC 1: KIỂM TRA XEM BÁO NÀY ĐÃ ĐƯỢC BÁN CHƯA (CÓ TRONG CHI TIẾT PHIẾU BÁN)
            string sqlCheck = "SELECT COUNT(*) FROM ChiTietPhieuBan WHERE MaBao = @MaBao";
            SqlParameter[] paramCheck = { new SqlParameter("@MaBao", txtMaBao.Text.Trim()) };

            object result = Functions.GetFieldValue(sqlCheck, paramCheck); // Mình sẽ thêm overload này dưới đây
            int count = result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);

            if (count > 0)
            {
                MessageBox.Show(
                    "Không thể xóa báo này!\n\n" +
                    $"Báo \"{txtTenBao.Text}\" (Mã: {txtMaBao.Text}) đã được bán trong {count} phiếu bán hàng.\n" +
                    "Theo quy định, không được xóa báo đã phát sinh nghiệp vụ bán hàng để đảm bảo tính toàn vẹn dữ liệu.",
                    "Cảnh báo xóa",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // BƯỚC 2: NẾU CHƯA BÁN → HỎI XÁC NHẬN VÀ XÓA BÌNH THƯỜNG
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa báo:\n\n{txtTenBao.Text} (Mã: {txtMaBao.Text})?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "DELETE FROM Bao WHERE MaBao = @MaBao";
                SqlParameter[] parameters = { new SqlParameter("@MaBao", txtMaBao.Text.Trim()) };

                if (Functions.RunSQLWithParams(sqlDelete, parameters))
                {
                    MessageBox.Show("Xóa báo thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                    ResetValues();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaBao.Text) && !string.IsNullOrWhiteSpace(txtTenBao.Text))
            {
                // Đang thêm mới → Lưu
                string sql = @"INSERT INTO Bao (MaBao, TenBao, LoaiBao, GiaBan, SoLuongTon) 
                               VALUES (@MaBao, @TenBao, @LoaiBao, @GiaBan, @SoLuongTon)";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaBao", txtMaBao.Text.Trim()),
                    new SqlParameter("@TenBao", txtTenBao.Text.Trim()),
                    new SqlParameter("@LoaiBao", cboLoaiBao.SelectedItem.ToString()),
                    new SqlParameter("@GiaBan", decimal.Parse(txtGiaBan.Text.Replace(",", ""))),
                    new SqlParameter("@SoLuongTon", int.Parse(txtSoLuongTon.Text))
                };

                if (Functions.RunSQLWithParams(sql, parameters))
                {
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView();
                    ResetValues();
                }
            }
            else
            {
                ResetValues();
            }
        }

        private void dgvBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBao.Rows[e.RowIndex];
                txtMaBao.Text = row.Cells["MaBao"].Value.ToString();
                txtTenBao.Text = row.Cells["TenBao"].Value.ToString();
                cboLoaiBao.Text = row.Cells["LoaiBao"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Bao WHERE 1=1";
            if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
                sql += $" AND (MaBao LIKE '%{txtTimKiem.Text.Trim()}%' OR TenBao LIKE N'%{txtTimKiem.Text.Trim()}%')";

            dgvBao.DataSource = Functions.GetDataToTable(sql);
        }

        // Chỉ cho nhập số
        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.OnlyNumber(e);
        }

        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.OnlyNumber(e);
        }
    }
}