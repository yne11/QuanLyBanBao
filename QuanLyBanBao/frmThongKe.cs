using System;
using System.Data;
using System.Windows.Forms;
using QuanLyBanBao.Class;

namespace QuanLyBanBao
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpDenNgay.Value = DateTime.Now;
            ThongKeDoanhThu();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeDoanhThu();
        }

        private void ThongKeDoanhThu()
        {
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd");

            string groupBy = "CONVERT(date, NgayLap)";
            string displayFormat = "dd/MM/yyyy";

            if (radioThang.Checked)
            {
                groupBy = "FORMAT(NgayLap, 'MM/yyyy')";
                displayFormat = "MM/yyyy";
            }
            else if (radioNam.Checked)
            {
                groupBy = "YEAR(NgayLap)";
                displayFormat = "yyyy";
            }

            string sql = $@"
        SELECT 
            {groupBy} AS Nhom,
            ISNULL(SUM(TongTien), 0) AS DoanhThu
        FROM PhieuBan
        WHERE NgayLap BETWEEN '{tuNgay}' AND '{denNgay}'
        GROUP BY {groupBy}
        ORDER BY MIN(NgayLap)";

            DataTable dt = Functions.GetDataToTable(sql);

            dgvThongKe.Rows.Clear();
            decimal tong = 0;

            foreach (DataRow row in dt.Rows)
            {
                string nhom = row["Nhom"].ToString(); // Là string (ngày hoặc tháng hoặc năm)
                decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);

                // Không cần Convert.ToDateTime nữa → tránh lỗi
                dgvThongKe.Rows.Add(nhom, Functions.FormatMoney(doanhThu));
                tong += doanhThu;
            }

            lblTongDoanhThu.Text = "TỔNG DOANH THU: " + Functions.FormatMoney(tong);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}