namespace QuanLyBanBao
{
    partial class frmBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBaoBanChay = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTopBao = new System.Windows.Forms.ComboBox();
            this.lblTongSoLuong = new System.Windows.Forms.Label();
            this.dgvBaoBanChay = new System.Windows.Forms.DataGridView();
            this.colMaBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTopKH = new System.Windows.Forms.ComboBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.tabBaoBanChay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoBanChay)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblTieuDe);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1286, 107);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(390, 27);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(507, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÁO CÁO TỔNG HỢP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Location = new System.Drawing.Point(26, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1234, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn khoảng thời gian báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày:";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = Properties.Resources.icon_report;  // ICON BÁO CÁO
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.Location = new System.Drawing.Point(1029, 33);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(180, 53);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "Xem báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(424, 40);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(153, 26);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(129, 40);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(153, 26);
            this.dtpTuNgay.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDoanhThu);
            this.tabControl.Controls.Add(this.tabBaoBanChay);
            this.tabControl.Controls.Add(this.tabKhachHang);
            this.tabControl.Location = new System.Drawing.Point(26, 267);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1234, 640);
            this.tabControl.TabIndex = 2;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 29);
            this.tabDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDoanhThu.Size = new System.Drawing.Size(1226, 607);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(13, 547);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(332, 38);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "TỔNG DOANH THU: 0 ₫";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.ColumnHeadersHeight = 34;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNgay,
            this.colDoanhThu});
            this.dgvDoanhThu.Location = new System.Drawing.Point(13, 13);
            this.dgvDoanhThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersWidth = 62;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1196, 520);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // colNgay
            // 
            this.colNgay.HeaderText = "Ngày";
            this.colNgay.MinimumWidth = 8;
            this.colNgay.Name = "colNgay";
            this.colNgay.ReadOnly = true;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.HeaderText = "Doanh thu";
            this.colDoanhThu.MinimumWidth = 8;
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.ReadOnly = true;
            // 
            // tabBaoBanChay
            // 
            this.tabBaoBanChay.Controls.Add(this.label3);
            this.tabBaoBanChay.Controls.Add(this.cboTopBao);
            this.tabBaoBanChay.Controls.Add(this.lblTongSoLuong);
            this.tabBaoBanChay.Controls.Add(this.dgvBaoBanChay);
            this.tabBaoBanChay.Location = new System.Drawing.Point(4, 29);
            this.tabBaoBanChay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBaoBanChay.Name = "tabBaoBanChay";
            this.tabBaoBanChay.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBaoBanChay.Size = new System.Drawing.Size(1226, 607);
            this.tabBaoBanChay.TabIndex = 1;
            this.tabBaoBanChay.Text = "Báo bán chạy";
            this.tabBaoBanChay.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hiển thị:";
            // 
            // cboTopBao
            // 
            this.cboTopBao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTopBao.FormattingEnabled = true;
            this.cboTopBao.Items.AddRange(new object[] {
            "Tất cả",
            "Top 5",
            "Top 10",
            "Top 20"});
            this.cboTopBao.Location = new System.Drawing.Point(103, 13);
            this.cboTopBao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTopBao.Name = "cboTopBao";
            this.cboTopBao.Size = new System.Drawing.Size(127, 28);
            this.cboTopBao.TabIndex = 3;
            this.cboTopBao.SelectedIndexChanged += new System.EventHandler(this.cboTopBao_SelectedIndexChanged);
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.AutoSize = true;
            this.lblTongSoLuong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongSoLuong.ForeColor = System.Drawing.Color.Blue;
            this.lblTongSoLuong.Location = new System.Drawing.Point(13, 547);
            this.lblTongSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(386, 38);
            this.lblTongSoLuong.TabIndex = 4;
            this.lblTongSoLuong.Text = "TỔNG SỐ LƯỢNG BÁN: 0 tờ";
            // 
            // dgvBaoBanChay
            // 
            this.dgvBaoBanChay.AllowUserToAddRows = false;
            this.dgvBaoBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoBanChay.ColumnHeadersHeight = 34;
            this.dgvBaoBanChay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBao,
            this.colTenBao,
            this.colSoLuong,
            this.colThanhTien});
            this.dgvBaoBanChay.Location = new System.Drawing.Point(13, 67);
            this.dgvBaoBanChay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBaoBanChay.Name = "dgvBaoBanChay";
            this.dgvBaoBanChay.ReadOnly = true;
            this.dgvBaoBanChay.RowHeadersWidth = 62;
            this.dgvBaoBanChay.Size = new System.Drawing.Size(1196, 467);
            this.dgvBaoBanChay.TabIndex = 0;
            // 
            // colMaBao
            // 
            this.colMaBao.HeaderText = "Mã báo";
            this.colMaBao.MinimumWidth = 8;
            this.colMaBao.Name = "colMaBao";
            this.colMaBao.ReadOnly = true;
            // 
            // colTenBao
            // 
            this.colTenBao.FillWeight = 200F;
            this.colTenBao.HeaderText = "Tên báo";
            this.colTenBao.MinimumWidth = 8;
            this.colTenBao.Name = "colTenBao";
            this.colTenBao.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 8;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.label4);
            this.tabKhachHang.Controls.Add(this.cboTopKH);
            this.tabKhachHang.Controls.Add(this.dgvKhachHang);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 29);
            this.tabKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Size = new System.Drawing.Size(1226, 607);
            this.tabKhachHang.TabIndex = 2;
            this.tabKhachHang.Text = "Khách hàng mua nhiều";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hiển thị:";
            // 
            // cboTopKH
            // 
            this.cboTopKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTopKH.FormattingEnabled = true;
            this.cboTopKH.Items.AddRange(new object[] {
            "Tất cả",
            "Top 5",
            "Top 10",
            "Top 20"});
            this.cboTopKH.Location = new System.Drawing.Point(103, 13);
            this.cboTopKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTopKH.Name = "cboTopKH";
            this.cboTopKH.Size = new System.Drawing.Size(127, 28);
            this.cboTopKH.TabIndex = 2;
            this.cboTopKH.SelectedIndexChanged += new System.EventHandler(this.cboTopKH_SelectedIndexChanged);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeight = 34;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colSoPhieu,
            this.colTongTien});
            this.dgvKhachHang.Location = new System.Drawing.Point(13, 67);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 62;
            this.dgvKhachHang.Size = new System.Drawing.Size(1196, 520);
            this.dgvKhachHang.TabIndex = 0;
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "Mã KH";
            this.colMaKH.MinimumWidth = 8;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.ReadOnly = true;
            // 
            // colTenKH
            // 
            this.colTenKH.FillWeight = 200F;
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.MinimumWidth = 8;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            // 
            // colSoPhieu
            // 
            this.colSoPhieu.HeaderText = "Số phiếu";
            this.colSoPhieu.MinimumWidth = 8;
            this.colSoPhieu.Name = "colSoPhieu";
            this.colSoPhieu.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.MinimumWidth = 8;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // btnDong
            // 
            this.btnDong.Image = Properties.Resources.icon_close;  // ICON ĐÓNG
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.Location = new System.Drawing.Point(1106, 933);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(154, 53);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 1000);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tổng hợp";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            this.tabDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.tabBaoBanChay.ResumeLayout(false);
            this.tabBaoBanChay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoBanChay)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabBaoBanChay;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.DataGridView dgvBaoBanChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Label lblTongSoLuong;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cboTopBao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTopKH;
        private System.Windows.Forms.Label label4;
    }
}