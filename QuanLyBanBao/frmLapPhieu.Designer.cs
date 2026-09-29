namespace QuanLyBanBao
{
    partial class frmLapPhieu
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoTo = new System.Windows.Forms.TextBox();
            this.lblSoTo = new System.Windows.Forms.Label();
            this.cboBao = new System.Windows.Forms.ComboBox();
            this.lblBao = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.lblTieuDe);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1113, 80);
            this.panelTop.TabIndex = 4;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(306, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(501, 65);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LẬP PHIẾU BÁN BÁO";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblKhachHang);
            this.panelInfo.Controls.Add(this.cboKhachHang);
            this.panelInfo.Controls.Add(this.lblNgayBan);
            this.panelInfo.Controls.Add(this.dtpNgayBan);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 80);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelInfo.Size = new System.Drawing.Size(1113, 80);
            this.panelInfo.TabIndex = 3;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKhachHang.Location = new System.Drawing.Point(0, 25);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(98, 20);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Location = new System.Drawing.Point(120, 22);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(400, 28);
            this.cboKhachHang.TabIndex = 1;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNgayBan.Location = new System.Drawing.Point(580, 25);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(80, 20);
            this.lblNgayBan.TabIndex = 2;
            this.lblNgayBan.Text = "Ngày bán:";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(670, 22);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(130, 26);
            this.dtpNgayBan.TabIndex = 3;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.lblTongTien);
            this.panelAdd.Controls.Add(this.btnThem);
            this.panelAdd.Controls.Add(this.txtSoTo);
            this.panelAdd.Controls.Add(this.lblSoTo);
            this.panelAdd.Controls.Add(this.cboBao);
            this.panelAdd.Controls.Add(this.lblBao);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdd.Location = new System.Drawing.Point(0, 160);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelAdd.Size = new System.Drawing.Size(1113, 80);
            this.panelAdd.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(860, 25);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(201, 38);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::QuanLyBanBao.Properties.Resources.icon_add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(710, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 40);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm báo";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoTo
            // 
            this.txtSoTo.Location = new System.Drawing.Point(590, 22);
            this.txtSoTo.Name = "txtSoTo";
            this.txtSoTo.Size = new System.Drawing.Size(100, 26);
            this.txtSoTo.TabIndex = 2;
            this.txtSoTo.Text = "1";
            this.txtSoTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSoTo
            // 
            this.lblSoTo.AutoSize = true;
            this.lblSoTo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoTo.Location = new System.Drawing.Point(530, 25);
            this.lblSoTo.Name = "lblSoTo";
            this.lblSoTo.Size = new System.Drawing.Size(51, 20);
            this.lblSoTo.TabIndex = 3;
            this.lblSoTo.Text = "Số tờ:";
            // 
            // cboBao
            // 
            this.cboBao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBao.Location = new System.Drawing.Point(120, 22);
            this.cboBao.Name = "cboBao";
            this.cboBao.Size = new System.Drawing.Size(380, 28);
            this.cboBao.TabIndex = 4;
            // 
            // lblBao
            // 
            this.lblBao.AutoSize = true;
            this.lblBao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBao.Location = new System.Drawing.Point(0, 25);
            this.lblBao.Name = "lblBao";
            this.lblBao.Size = new System.Drawing.Size(82, 20);
            this.lblBao.TabIndex = 5;
            this.lblBao.Text = "Chọn báo:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnLamMoi);
            this.panelButtons.Controls.Add(this.btnThoat);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 520);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelButtons.Size = new System.Drawing.Size(1113, 90);
            this.panelButtons.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::QuanLyBanBao.Properties.Resources.icon_save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(0, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 60);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu phiếu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::QuanLyBanBao.Properties.Resources.icon_delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(180, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 60);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa báo";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLamMoi.Image = global::QuanLyBanBao.Properties.Resources.icon_refresh;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(360, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(160, 60);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::QuanLyBanBao.Properties.Resources.icon_close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(876, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(160, 60);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AllowUserToAddRows = false;
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.ColumnHeadersHeight = 34;
            this.dgvPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieu.Location = new System.Drawing.Point(0, 240);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersVisible = false;
            this.dgvPhieu.RowHeadersWidth = 62;
            this.dgvPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu.Size = new System.Drawing.Size(1113, 280);
            this.dgvPhieu.TabIndex = 0;
            // 
            // frmLapPhieu
            // 
            this.ClientSize = new System.Drawing.Size(1113, 610);
            this.Controls.Add(this.dgvPhieu);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLapPhieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu bán báo";
            this.Load += new System.EventHandler(this.frmLapPhieu_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label lblBao;
        private System.Windows.Forms.ComboBox cboBao;
        private System.Windows.Forms.Label lblSoTo;
        private System.Windows.Forms.TextBox txtSoTo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvPhieu;
    }
}