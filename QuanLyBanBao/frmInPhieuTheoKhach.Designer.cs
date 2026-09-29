namespace QuanLyBanBao
{
    partial class frmInPhieuTheoKhach
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
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.btnInTatCa = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblTieuDe);
            this.panelHeader.Controls.Add(this.lblKhachHang);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1157, 133);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(106, 20);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(945, 60);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "DANH SÁCH PHIẾU BÁN CỦA KHÁCH HÀNG";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblKhachHang.ForeColor = System.Drawing.Color.Yellow;
            this.lblKhachHang.Location = new System.Drawing.Point(26, 87);
            this.lblKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(536, 38);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Khách hàng: NGUYỄN VĂN AN (KH001)";
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(26, 160);
            this.dgvPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersVisible = false;
            this.dgvPhieu.RowHeadersWidth = 62;
            this.dgvPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu.Size = new System.Drawing.Size(1106, 398);
            this.dgvPhieu.TabIndex = 1;
            this.dgvPhieu.DoubleClick += new System.EventHandler(this.dgvPhieu_DoubleClick);
            // 
            // btnInTatCa
            // 
            this.btnInTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInTatCa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInTatCa.ForeColor = System.Drawing.Color.White;
            this.btnInTatCa.Image = global::QuanLyBanBao.Properties.Resources.icon_print_all;
            this.btnInTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInTatCa.Location = new System.Drawing.Point(25, 578);
            this.btnInTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnInTatCa.Name = "btnInTatCa";
            this.btnInTatCa.Size = new System.Drawing.Size(231, 67);
            this.btnInTatCa.TabIndex = 2;
            this.btnInTatCa.Text = "IN TẤT CẢ PHIẾU";
            this.btnInTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInTatCa.UseVisualStyleBackColor = false;
            this.btnInTatCa.Click += new System.EventHandler(this.btnInTatCa_Click);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.Color.Navy;
            this.btnInPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInPhieu.ForeColor = System.Drawing.Color.White;
            this.btnInPhieu.Image = global::QuanLyBanBao.Properties.Resources.icon_print;
            this.btnInPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInPhieu.Location = new System.Drawing.Point(264, 578);
            this.btnInPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInPhieu.Size = new System.Drawing.Size(236, 67);
            this.btnInPhieu.TabIndex = 3;
            this.btnInPhieu.Text = "IN PHIẾU NÀY";
            this.btnInPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInPhieu.UseVisualStyleBackColor = false;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLyBanBao.Properties.Resources.icon_close;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(938, 578);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(167, 67);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmInPhieuTheoKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 662);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.btnInTatCa);
            this.Controls.Add(this.dgvPhieu);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmInPhieuTheoKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In phiếu theo khách hàng";
            this.Load += new System.EventHandler(this.frmInPhieuTheoKhach_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.Button btnInTatCa;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnDong;
    }
}