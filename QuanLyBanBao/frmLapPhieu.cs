using System;
using System.Data;
using System.Windows.Forms;
using QuanLyBanBao.Class;

namespace QuanLyBanBao
{
    public partial class frmLapPhieu : Form
    {
        private DataTable tblChiTiet;
        private decimal tongTien = 0;

        public frmLapPhieu()
        {
            InitializeComponent();
        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            dtpNgayBan.Value = DateTime.Today;
            LoadKhachHang();
            LoadBao(); // ← ĐÃ HIỆN CẢ LOẠI BÁO (BÁO GIẤY / BÁO ĐIỆN TỬ)
            KhoiTaoBangChiTiet();
            txtSoTo.Text = "1";
        }

        private void LoadKhachHang()
        {
            string sql = "SELECT MaKH, TenKH FROM KhachHang ORDER BY TenKH";
            DataTable dt = Functions.GetDataToTable(sql);
            cboKhachHang.DataSource = dt;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.SelectedIndex = -1;
        }

        // ← SIÊU HAY: HIỆN THỊ TÊN BÁO + LOẠI BÁO ĐỂ KHÔNG NHẦM GIÁ!
        private void LoadBao()
        {
            string sql = @"
                SELECT MaBao, 
                       TenBao + ' (' + LoaiBao + ')' AS TenHienThi, 
                       GiaBan
                FROM Bao 
                ORDER BY TenBao";

            DataTable dt = Functions.GetDataToTable(sql);
            cboBao.DataSource = dt;
            cboBao.DisplayMember = "TenHienThi";  // ← HIỆN CẢ LOẠI BÁO!
            cboBao.ValueMember = "MaBao";
            cboBao.SelectedIndex = -1;
        }

        private void KhoiTaoBangChiTiet()
        {
            tblChiTiet = new DataTable();
            tblChiTiet.Columns.Add("MaBao", typeof(string));
            tblChiTiet.Columns.Add("TenBao", typeof(string));
            tblChiTiet.Columns.Add("SoLuong", typeof(int));
            tblChiTiet.Columns.Add("DonGia", typeof(decimal));
            tblChiTiet.Columns.Add("ThanhTien", typeof(decimal));

            dgvPhieu.Columns.Clear();
            dgvPhieu.DataSource = tblChiTiet;

            dgvPhieu.Columns["MaBao"].HeaderText = "Mã báo";
            dgvPhieu.Columns["TenBao"].HeaderText = "Tên báo";
            dgvPhieu.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvPhieu.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvPhieu.Columns["ThanhTien"].HeaderText = "Thành tiền";

            dgvPhieu.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvPhieu.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboBao.SelectedValue == null || string.IsNullOrWhiteSpace(txtSoTo.Text))
            {
                MessageBox.Show("Chọn báo và nhập số tờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maBao = cboBao.SelectedValue.ToString();
            string tenBao = cboBao.Text; // Đã có (Báo giấy) hoặc (Báo điện tử)
            decimal donGia = Convert.ToDecimal(((DataRowView)cboBao.SelectedItem)["GiaBan"]);
            int soLuong = int.Parse(txtSoTo.Text);
            decimal thanhTien = donGia * soLuong;

            // Kiểm tra trùng báo
            foreach (DataRow row in tblChiTiet.Rows)
            {
                if (row["MaBao"].ToString() == maBao)
                {
                    row["SoLuong"] = (int)row["SoLuong"] + soLuong;
                    row["ThanhTien"] = (decimal)row["ThanhTien"] + thanhTien;
                    CapNhatTongTien();
                    return;
                }
            }

            // Thêm mới
            DataRow newRow = tblChiTiet.NewRow();
            newRow["MaBao"] = maBao;
            newRow["TenBao"] = tenBao;
            newRow["SoLuong"] = soLuong;
            newRow["DonGia"] = donGia;
            newRow["ThanhTien"] = thanhTien;
            tblChiTiet.Rows.Add(newRow);

            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            tongTien = 0;
            foreach (DataRow row in tblChiTiet.Rows)
                tongTien += Convert.ToDecimal(row["ThanhTien"]);
            lblTongTien.Text = "Tổng tiền: " + Functions.FormatMoney(tongTien);
        }

        private void dgvPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dgvPhieu.Rows[e.RowIndex].Selected = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow != null)
            {
                if (MessageBox.Show("Xóa báo này khỏi phiếu?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvPhieu.Rows.RemoveAt(dgvPhieu.CurrentRow.Index);
                    CapNhatTongTien();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tblChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có báo nào!", "Thông báo");
                return;
            }

            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Chọn khách hàng!", "Thông báo");
                return;
            }

            string soPhieu = Functions.CreateKey("PhieuBan");
            string maKH = cboKhachHang.SelectedValue.ToString();
            string ngayLap = dtpNgayBan.Value.ToString("yyyy-MM-dd");

            string sqlPhieu = $"INSERT INTO PhieuBan (SoPhieu, NgayLap, MaKH, TongTien) VALUES ('{soPhieu}', '{ngayLap}', '{maKH}', {tongTien})";
            Functions.RunSQL(sqlPhieu);

            foreach (DataRow row in tblChiTiet.Rows)
            {
                string maBao = row["MaBao"].ToString();
                int sl = Convert.ToInt32(row["SoLuong"]);
                decimal dg = Convert.ToDecimal(row["DonGia"]);

                string sqlCT = $"INSERT INTO ChiTietPhieuBan VALUES ('{soPhieu}', '{maBao}', {sl}, {dg})";
                Functions.RunSQL(sqlCT);

                // Trừ tồn kho (chỉ trừ báo giấy)
                if (dg > 0)
                {
                    string sqlTon = $"UPDATE Bao SET SoLuongTon = SoLuongTon - {sl} WHERE MaBao = '{maBao}'";
                    Functions.RunSQL(sqlTon);
                }
            }

            MessageBox.Show($"Lập phiếu thành công!\nSố phiếu: {soPhieu}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tblChiTiet.Clear();
            cboKhachHang.SelectedIndex = -1;
            cboBao.SelectedIndex = -1;
            txtSoTo.Text = "1";
            CapNhatTongTien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.OnlyNumber(e);
        }
    }
}