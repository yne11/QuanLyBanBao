using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanBao
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();

            this.Text = "HỆ THỐNG QUẢN LÝ BÁN BÁO";
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            this.BackColor = Color.FromArgb(240, 248, 255);

            lblUser.Text = "Người dùng: Admin";
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer1.Start();

            // Hình nền đẹp cho phần trống
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient client)
                {
                    client.BackgroundImage = Properties.Resources.bg_main; // tên hình bạn đã thêm
                    client.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // ═══════════════════ HÀM MỞ FORM CON ĐÃ FIX 100% LỖI CHỮ TRẮNG ═══════════════════
        private void OpenChildForm(Form childForm, string title)
        {
            // Nếu đã mở rồi → đưa lên trên
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == childForm.GetType())
                {
                    f.Activate();
                    return;
                }
            }

            childForm.MdiParent = this;
            childForm.Text = title;

            // QUAN TRỌNG NHẤT: BẬT LẠI ForeColor ĐEN & BackColor TRẮNG
            childForm.ForeColor = Color.Black;
            childForm.BackColor = Color.White;

            // Dùng Dock.Fill + bỏ viền → đẹp như phần mềm thật, KHÔNG bị trắng chữ nữa
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.StartPosition = FormStartPosition.CenterScreen;

            childForm.Show();

            // Khi đóng form con → hiện lại hình nền đẹp
            childForm.FormClosed += (s, ev) =>
            {
                if (this.MdiChildren.Length == 0)
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is MdiClient client)
                        {
                            client.BackgroundImage = Properties.Resources.bg_main;
                            client.BackgroundImageLayout = ImageLayout.Zoom;
                        }
                    }
                }
            };
        }
        // ════════════════════════════════════════════════════════════════════════════

        // ==================== MENU CLICK ====================
        private void quảnLýBáoToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenChildForm(new frmBao(), "Quản lý báo");

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenChildForm(new frmKhachHang(), "Quản lý khách hàng");

        private void lậpPhiếuBánBáoToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenChildForm(new frmLapPhieu(), "Lập phiếu bán báo");

        private void danhSáchPhiếuBánToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenChildForm(new frmDanhSachPhieu(), "Danh sách phiếu bán báo");

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenChildForm(new frmTimKiem(), "Tìm kiếm thông tin");

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenChildForm(new frmThongKe(), "Thống kê doanh thu");

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
            => OpenChildForm(new frmBaoCao(), "Báo cáo tổng hợp");

        private void inPhiếuBánBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmChonKhachHangIn().ShowDialog();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void vềChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HỆ THỐNG QUẢN LÝ BÁN BÁO\n\nPhiên bản: 1.0\nMôn Lập trình Giao diện người dùng\n" +
                "Sinh viên thực hiện: [Nhóm 8: Mãi đỉnh]\nNgô Tuấn Anh\nPhạm Hải Dương\nLê Gia Lể\nLê Hữu Tài",
                "Thông tin phần mềm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}