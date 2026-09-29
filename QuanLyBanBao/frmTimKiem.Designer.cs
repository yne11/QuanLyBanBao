namespace QuanLyBanBao
{
    partial class frmTimKiem
    {
        private System.ComponentModel.IContainer components = null;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBao = new System.Windows.Forms.TabPage();
            this.txtTimBao = new System.Windows.Forms.TextBox();
            this.btnTimBao = new System.Windows.Forms.Button();
            this.dgvBao = new System.Windows.Forms.DataGridView();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.tabPhieu = new System.Windows.Forms.TabPage();
            this.txtTimPhieu = new System.Windows.Forms.TextBox();
            this.btnTimPhieu = new System.Windows.Forms.Button();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.tabPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblTieuDe);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 80);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(208, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(485, 60);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "TÌM KIẾM THÔNG TIN";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBao);
            this.tabControl.Controls.Add(this.tabKhachHang);
            this.tabControl.Controls.Add(this.tabPhieu);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 80);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(900, 590);
            this.tabControl.TabIndex = 1;
            // 
            // tabBao
            // 
            this.tabBao.Controls.Add(this.txtTimBao);
            this.tabBao.Controls.Add(this.btnTimBao);
            this.tabBao.Controls.Add(this.dgvBao);
            this.tabBao.Location = new System.Drawing.Point(4, 29);
            this.tabBao.Name = "tabBao";
            this.tabBao.Size = new System.Drawing.Size(892, 557);
            this.tabBao.TabIndex = 0;
            this.tabBao.Text = "Tìm báo";
            // 
            // txtTimBao
            // 
            this.txtTimBao.ForeColor = System.Drawing.Color.Gray;
            this.txtTimBao.Location = new System.Drawing.Point(30, 30);
            this.txtTimBao.Name = "txtTimBao";
            this.txtTimBao.Size = new System.Drawing.Size(400, 26);
            this.txtTimBao.TabIndex = 0;
            this.txtTimBao.Text = "Nhập mã hoặc tên báo...";
            // 
            // btnTimBao
            // 
            this.btnTimBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTimBao.ForeColor = System.Drawing.Color.White;
            this.btnTimBao.Image = global::QuanLyBanBao.Properties.Resources.icon_search;
            this.btnTimBao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimBao.Location = new System.Drawing.Point(449, 20);
            this.btnTimBao.Name = "btnTimBao";
            this.btnTimBao.Size = new System.Drawing.Size(144, 46);
            this.btnTimBao.TabIndex = 1;
            this.btnTimBao.Text = "Tìm kiếm";
            this.btnTimBao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimBao.UseVisualStyleBackColor = false;
            this.btnTimBao.Click += new System.EventHandler(this.btnTimBao_Click);
            // 
            // dgvBao
            // 
            this.dgvBao.AllowUserToAddRows = false;
            this.dgvBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBao.ColumnHeadersHeight = 34;
            this.dgvBao.Location = new System.Drawing.Point(30, 80);
            this.dgvBao.Name = "dgvBao";
            this.dgvBao.ReadOnly = true;
            this.dgvBao.RowHeadersWidth = 62;
            this.dgvBao.Size = new System.Drawing.Size(840, 380);
            this.dgvBao.TabIndex = 2;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.txtTimKH);
            this.tabKhachHang.Controls.Add(this.btnTimKH);
            this.tabKhachHang.Controls.Add(this.dgvKhachHang);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 29);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Size = new System.Drawing.Size(892, 557);
            this.tabKhachHang.TabIndex = 1;
            this.tabKhachHang.Text = "Tìm khách hàng";
            // 
            // txtTimKH
            // 
            this.txtTimKH.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKH.Location = new System.Drawing.Point(30, 30);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(400, 26);
            this.txtTimKH.TabIndex = 0;
            this.txtTimKH.Text = "Nhập tên hoặc số điện thoại...";
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTimKH.ForeColor = System.Drawing.Color.White;
            this.btnTimKH.Image = global::QuanLyBanBao.Properties.Resources.icon_search;
            this.btnTimKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKH.Location = new System.Drawing.Point(450, 28);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(100, 32);
            this.btnTimKH.TabIndex = 1;
            this.btnTimKH.Text = "Tìm kiếm";
            this.btnTimKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKH.UseVisualStyleBackColor = false;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeight = 34;
            this.dgvKhachHang.Location = new System.Drawing.Point(30, 80);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 62;
            this.dgvKhachHang.Size = new System.Drawing.Size(840, 380);
            this.dgvKhachHang.TabIndex = 2;
            // 
            // tabPhieu
            // 
            this.tabPhieu.Controls.Add(this.txtTimPhieu);
            this.tabPhieu.Controls.Add(this.btnTimPhieu);
            this.tabPhieu.Controls.Add(this.dgvPhieu);
            this.tabPhieu.Location = new System.Drawing.Point(4, 29);
            this.tabPhieu.Name = "tabPhieu";
            this.tabPhieu.Size = new System.Drawing.Size(892, 557);
            this.tabPhieu.TabIndex = 2;
            this.tabPhieu.Text = "Tìm phiếu bán";
            // 
            // txtTimPhieu
            // 
            this.txtTimPhieu.ForeColor = System.Drawing.Color.Gray;
            this.txtTimPhieu.Location = new System.Drawing.Point(30, 30);
            this.txtTimPhieu.Name = "txtTimPhieu";
            this.txtTimPhieu.Size = new System.Drawing.Size(400, 26);
            this.txtTimPhieu.TabIndex = 0;
            this.txtTimPhieu.Text = "Nhập số phiếu hoặc tên khách...";
            // 
            // btnTimPhieu
            // 
            this.btnTimPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTimPhieu.ForeColor = System.Drawing.Color.White;
            this.btnTimPhieu.Image = global::QuanLyBanBao.Properties.Resources.icon_search;
            this.btnTimPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimPhieu.Location = new System.Drawing.Point(450, 28);
            this.btnTimPhieu.Name = "btnTimPhieu";
            this.btnTimPhieu.Size = new System.Drawing.Size(100, 32);
            this.btnTimPhieu.TabIndex = 1;
            this.btnTimPhieu.Text = "Tìm kiếm";
            this.btnTimPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimPhieu.UseVisualStyleBackColor = false;
            this.btnTimPhieu.Click += new System.EventHandler(this.btnTimPhieu_Click);
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.ColumnHeadersHeight = 34;
            this.dgvPhieu.Location = new System.Drawing.Point(30, 80);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersWidth = 62;
            this.dgvPhieu.Size = new System.Drawing.Size(840, 380);
            this.dgvPhieu.TabIndex = 2;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLyBanBao.Properties.Resources.icon_close;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(780, 620);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 40);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmTimKiem
            // 
            this.ClientSize = new System.Drawing.Size(900, 670);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm thông tin";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabBao.ResumeLayout(false);
            this.tabBao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBao)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.tabPhieu.ResumeLayout(false);
            this.tabPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBao;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.TabPage tabPhieu;
        private System.Windows.Forms.TextBox txtTimBao;
        private System.Windows.Forms.Button btnTimBao;
        private System.Windows.Forms.DataGridView dgvBao;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtTimPhieu;
        private System.Windows.Forms.Button btnTimPhieu;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.Button btnDong;
    }
}