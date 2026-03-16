namespace QLDuocPham_WinForms
{
    partial class frmLoaiSanPham
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblMaLSP = new System.Windows.Forms.Label();
            this.txtMaLSP = new System.Windows.Forms.TextBox();
            this.lblTenLSP = new System.Windows.Forms.Label();
            this.txtTenLSP = new System.Windows.Forms.TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            this.SuspendLayout();

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 64;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubTitle);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "📋  Quản lý Loại sản phẩm";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220);
            this.lblSubTitle.Location = new System.Drawing.Point(18, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text = "Phân loại sản phẩm theo danh mục";
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(16, 76);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(780, 148);
            this.pnlCard.Controls.Add(this.lblMaLSP);
            this.pnlCard.Controls.Add(this.txtMaLSP);
            this.pnlCard.Controls.Add(this.lblTenLSP);
            this.pnlCard.Controls.Add(this.txtTenLSP);
            this.pnlCard.Controls.Add(this.lblDanhMuc);
            this.pnlCard.Controls.Add(this.cbDanhMuc);
            this.pnlCard.Controls.Add(this.btnThem);
            this.pnlCard.Controls.Add(this.btnSua);
            this.pnlCard.Controls.Add(this.btnXoa);
            this.pnlCard.Controls.Add(this.btnLamMoi);

            this.lblMaLSP.AutoSize = false;
            this.lblMaLSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMaLSP.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblMaLSP.Location = new System.Drawing.Point(16, 19);
            this.lblMaLSP.Name = "lblMaLSP";
            this.lblMaLSP.Size = new System.Drawing.Size(118, 28);
            this.lblMaLSP.Text = "Mã loại:";
            this.lblMaLSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtMaLSP.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.txtMaLSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLSP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaLSP.Location = new System.Drawing.Point(145, 16);
            this.txtMaLSP.Name = "txtMaLSP";
            this.txtMaLSP.ReadOnly = true;
            this.txtMaLSP.Size = new System.Drawing.Size(220, 28);
            this.txtMaLSP.TabIndex = 0;

            this.lblTenLSP.AutoSize = false;
            this.lblTenLSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenLSP.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblTenLSP.Location = new System.Drawing.Point(16, 57);
            this.lblTenLSP.Name = "lblTenLSP";
            this.lblTenLSP.Size = new System.Drawing.Size(118, 28);
            this.lblTenLSP.Text = "Tên loại:";
            this.lblTenLSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtTenLSP.BackColor = System.Drawing.Color.White;
            this.txtTenLSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLSP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenLSP.Location = new System.Drawing.Point(145, 54);
            this.txtTenLSP.Name = "txtTenLSP";
            this.txtTenLSP.ReadOnly = false;
            this.txtTenLSP.Size = new System.Drawing.Size(220, 28);
            this.txtTenLSP.TabIndex = 1;

            this.lblDanhMuc.AutoSize = false;
            this.lblDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDanhMuc.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblDanhMuc.Location = new System.Drawing.Point(16, 95);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(118, 28);
            this.lblDanhMuc.Text = "Danh mục:";
            this.lblDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.cbDanhMuc.BackColor = System.Drawing.Color.White;
            this.cbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbDanhMuc.Location = new System.Drawing.Point(145, 92);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(220, 28);
            this.cbDanhMuc.TabIndex = 2;

            this.btnThem.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(420, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 34);
            this.btnThem.Text = "＋ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(46, 134, 222);
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(540, 16);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 34);
            this.btnSua.Text = "✎ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(420, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 34);
            this.btnXoa.Text = "✕ Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(540, 60);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 34);
            this.btnLamMoi.Text = "↺ Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(16, 236);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(780, 260);
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.dgvLoaiSP);

            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(30, 40, 55);
            this.lblGridTitle.Location = new System.Drawing.Point(12, 10);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Text = "Danh sách loại sản phẩm";

            this.dgvLoaiSP.Location = new System.Drawing.Point(0, 38);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.Size = new System.Drawing.Size(780, 222);
            this.dgvLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.RowHeadersVisible = false;
            this.dgvLoaiSP.AllowUserToAddRows = false;
            this.dgvLoaiSP.AllowUserToDeleteRows = false;
            this.dgvLoaiSP.ReadOnly = true;
            this.dgvLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiSP.TabIndex = 0;
            this.dgvLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSP_CellClick);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(812, 512);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.pnlHeader.ResumeLayout(false); this.pnlHeader.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false); this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblMaLSP;
        private System.Windows.Forms.TextBox txtMaLSP;
        private System.Windows.Forms.Label lblTenLSP;
        private System.Windows.Forms.TextBox txtTenLSP;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
    }
}