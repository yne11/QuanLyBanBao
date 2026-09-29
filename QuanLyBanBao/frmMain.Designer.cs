namespace QuanLyBanBao
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuBánBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inPhiếuBánBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.thốngKêBáoCáoToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátChươngTrìnhToolStripMenuItem});
            this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Image = Properties.Resources.icon_exit;
            this.thoátChươngTrìnhToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.thoátChươngTrìnhToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q";
            this.thoátChươngTrìnhToolStripMenuItem.ShowShortcutKeys = true;
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "&Thoát chương trình";
            this.thoátChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátChươngTrìnhToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýBáoToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.danhMụcToolStripMenuItem.Text = "&Danh mục";
            // 
            // quảnLýBáoToolStripMenuItem
            // 
            this.quảnLýBáoToolStripMenuItem.Name = "quảnLýBáoToolStripMenuItem";
            this.quảnLýBáoToolStripMenuItem.Image = Properties.Resources.icon_newspaper;
            this.quảnLýBáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.quảnLýBáoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+B";
            this.quảnLýBáoToolStripMenuItem.ShowShortcutKeys = true;
            this.quảnLýBáoToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.quảnLýBáoToolStripMenuItem.Text = "&Quản lý báo";
            this.quảnLýBáoToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBáoToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Image = Properties.Resources.icon_customer;
            this.quảnLýKháchHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.quảnLýKháchHàngToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+K";
            this.quảnLýKháchHàngToolStripMenuItem.ShowShortcutKeys = true;
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "&Quản lý khách hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuBánBáoToolStripMenuItem,
            this.danhSáchPhiếuBánToolStripMenuItem,
            this.inPhiếuBánBáoToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.nghiệpVụToolStripMenuItem.Text = "&Nghiệp vụ";
            // 
            // lậpPhiếuBánBáoToolStripMenuItem
            // 
            this.lậpPhiếuBánBáoToolStripMenuItem.Name = "lậpPhiếuBánBáoToolStripMenuItem";
            this.lậpPhiếuBánBáoToolStripMenuItem.Image = Properties.Resources.icon_new;
            this.lậpPhiếuBánBáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.lậpPhiếuBánBáoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.lậpPhiếuBánBáoToolStripMenuItem.ShowShortcutKeys = true;
            this.lậpPhiếuBánBáoToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.lậpPhiếuBánBáoToolStripMenuItem.Text = "&Lập phiếu bán báo";
            this.lậpPhiếuBánBáoToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuBánBáoToolStripMenuItem_Click);
            // 
            // danhSáchPhiếuBánToolStripMenuItem
            // 
            this.danhSáchPhiếuBánToolStripMenuItem.Name = "danhSáchPhiếuBánToolStripMenuItem";
            this.danhSáchPhiếuBánToolStripMenuItem.Image = Properties.Resources.icon_list;
            this.danhSáchPhiếuBánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.danhSáchPhiếuBánToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+L";
            this.danhSáchPhiếuBánToolStripMenuItem.ShowShortcutKeys = true;
            this.danhSáchPhiếuBánToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.danhSáchPhiếuBánToolStripMenuItem.Text = "&Danh sách phiếu bán";
            this.danhSáchPhiếuBánToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuBánToolStripMenuItem_Click);
            // 
            // inPhiếuBánBáoToolStripMenuItem
            // 
            this.inPhiếuBánBáoToolStripMenuItem.Name = "inPhiếuBánBáoToolStripMenuItem";
            this.inPhiếuBánBáoToolStripMenuItem.Image = Properties.Resources.icon_print;
            this.inPhiếuBánBáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.inPhiếuBánBáoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.inPhiếuBánBáoToolStripMenuItem.ShowShortcutKeys = true;
            this.inPhiếuBánBáoToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.inPhiếuBánBáoToolStripMenuItem.Text = "&In phiếu bán báo";
            this.inPhiếuBánBáoToolStripMenuItem.Click += new System.EventHandler(this.inPhiếuBánBáoToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Image = Properties.Resources.icon_search;
            this.tìmKiếmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmKiếmToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.tìmKiếmToolStripMenuItem.ShowShortcutKeys = true;
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.tìmKiếmToolStripMenuItem.Text = "&Tìm kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            this.thốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêDoanhThuToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.thốngKêBáoCáoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            this.thốngKêBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.thốngKêBáoCáoToolStripMenuItem.Text = "&Thống kê - Báo cáo";
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Image = Properties.Resources.icon_chart;
            this.thốngKêDoanhThuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.thốngKêDoanhThuToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+T";
            this.thốngKêDoanhThuToolStripMenuItem.ShowShortcutKeys = true;
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê &doanh thu";
            this.thốngKêDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.thốngKêDoanhThuToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Image = Properties.Resources.icon_report;
            this.báoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.báoCáoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.báoCáoToolStripMenuItem.ShowShortcutKeys = true;
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.báoCáoToolStripMenuItem.Text = "&Báo cáo tổng hợp";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vềChươngTrìnhToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.trợGiúpToolStripMenuItem.Image = Properties.Resources.icon_help;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.trợGiúpToolStripMenuItem.Text = "Trợ &giúp";
            // 
            // vềChươngTrìnhToolStripMenuItem
            // 
            this.vềChươngTrìnhToolStripMenuItem.Name = "vềChươngTrìnhToolStripMenuItem";
            this.vềChươngTrìnhToolStripMenuItem.Image = Properties.Resources.icon_about;
            this.vềChươngTrìnhToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.vềChươngTrìnhToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.vềChươngTrìnhToolStripMenuItem.ShowShortcutKeys = true;
            this.vềChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.vềChươngTrìnhToolStripMenuItem.Text = "&Về chương trình";
            this.vềChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.vềChươngTrìnhToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.lblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 32);
            this.statusStrip1.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(171, 25);
            this.lblUser.Text = "Người dùng: Admin";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(878, 25);
            this.lblDate.Spring = true;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ BÁN BÁO";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuBánBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inPhiếuBánBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vềChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}