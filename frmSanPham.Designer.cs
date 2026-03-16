namespace QLDuocPham_WinForms
{
    partial class frmSanPham
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblSoDK = new System.Windows.Forms.Label();
            this.txtSoDK = new System.Windows.Forms.TextBox();
            this.lblThanhPhan = new System.Windows.Forms.Label();
            this.txtThanhPhan = new System.Windows.Forms.TextBox();
            this.lblCongDung = new System.Windows.Forms.Label();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.lblHDSD = new System.Windows.Forms.Label();
            this.txtHDSD = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblSLTon = new System.Windows.Forms.Label();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
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
            this.lblTitle.Text = "💊  Quản lý Sản phẩm";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220);
            this.lblSubTitle.Location = new System.Drawing.Point(18, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text = "Quản lý toàn bộ danh mục sản phẩm dược";
            this.panelInput.BackColor = System.Drawing.Color.White;
            this.panelInput.Location = new System.Drawing.Point(16, 76);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1140, 220);
            this.panelInput.Controls.Add(this.lblMaSP);
            this.panelInput.Controls.Add(this.txtMaSP);
            this.panelInput.Controls.Add(this.lblTenSP);
            this.panelInput.Controls.Add(this.txtTenSP);
            this.panelInput.Controls.Add(this.lblDonVi);
            this.panelInput.Controls.Add(this.txtDonViTinh);
            this.panelInput.Controls.Add(this.lblSoDK);
            this.panelInput.Controls.Add(this.txtSoDK);
            this.panelInput.Controls.Add(this.lblThanhPhan);
            this.panelInput.Controls.Add(this.txtThanhPhan);
            this.panelInput.Controls.Add(this.lblCongDung);
            this.panelInput.Controls.Add(this.txtCongDung);
            this.panelInput.Controls.Add(this.lblHDSD);
            this.panelInput.Controls.Add(this.txtHDSD);
            this.panelInput.Controls.Add(this.lblGia);
            this.panelInput.Controls.Add(this.txtGia);
            this.panelInput.Controls.Add(this.lblSLTon);
            this.panelInput.Controls.Add(this.txtSLTon);
            this.panelInput.Controls.Add(this.lblLoai);
            this.panelInput.Controls.Add(this.cbLoaiSP);
            this.panelInput.Controls.Add(this.lblNCC);
            this.panelInput.Controls.Add(this.cbNCC);
            this.panelInput.Controls.Add(this.picAnh);
            this.panelInput.Controls.Add(this.btnChonAnh);
            this.panelInput.Controls.Add(this.btnThem);
            this.panelInput.Controls.Add(this.btnSua);
            this.panelInput.Controls.Add(this.btnXoa);
            this.panelInput.Controls.Add(this.btnLamMoi);

            // ── COL 1 (lbl x=10, txt x=106) ──────────────────────────────────
            this.lblMaSP.AutoSize = false;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMaSP.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblMaSP.Location = new System.Drawing.Point(10, 17);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(90, 24);
            this.lblMaSP.Text = "Mã SP:";
            this.lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtMaSP.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaSP.Location = new System.Drawing.Point(106, 14);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(185, 25);
            this.txtMaSP.TabIndex = 0;

            this.lblTenSP.AutoSize = false;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblTenSP.Location = new System.Drawing.Point(10, 55);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(90, 24);
            this.lblTenSP.Text = "Tên SP:";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtTenSP.BackColor = System.Drawing.Color.White;
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenSP.Location = new System.Drawing.Point(106, 52);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(185, 25);
            this.txtTenSP.TabIndex = 1;

            this.lblDonVi.AutoSize = false;
            this.lblDonVi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDonVi.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblDonVi.Location = new System.Drawing.Point(10, 93);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(90, 24);
            this.lblDonVi.Text = "Đơn vị:";
            this.lblDonVi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtDonViTinh.BackColor = System.Drawing.Color.White;
            this.txtDonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonViTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDonViTinh.Location = new System.Drawing.Point(106, 90);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(185, 25);
            this.txtDonViTinh.TabIndex = 2;

            this.lblSoDK.AutoSize = false;
            this.lblSoDK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSoDK.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblSoDK.Location = new System.Drawing.Point(10, 131);
            this.lblSoDK.Name = "lblSoDK";
            this.lblSoDK.Size = new System.Drawing.Size(90, 24);
            this.lblSoDK.Text = "Số đăng ký:";
            this.lblSoDK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtSoDK.BackColor = System.Drawing.Color.White;
            this.txtSoDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDK.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSoDK.Location = new System.Drawing.Point(106, 128);
            this.txtSoDK.Name = "txtSoDK";
            this.txtSoDK.Size = new System.Drawing.Size(185, 25);
            this.txtSoDK.TabIndex = 3;

            // ── COL 2 (lbl x=308, txt x=404) ─────────────────────────────────
            this.lblThanhPhan.AutoSize = false;
            this.lblThanhPhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThanhPhan.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblThanhPhan.Location = new System.Drawing.Point(308, 17);
            this.lblThanhPhan.Name = "lblThanhPhan";
            this.lblThanhPhan.Size = new System.Drawing.Size(90, 24);
            this.lblThanhPhan.Text = "Thành phần:";
            this.lblThanhPhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtThanhPhan.BackColor = System.Drawing.Color.White;
            this.txtThanhPhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhPhan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtThanhPhan.Location = new System.Drawing.Point(404, 14);
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Size = new System.Drawing.Size(185, 25);
            this.txtThanhPhan.TabIndex = 4;

            this.lblCongDung.AutoSize = false;
            this.lblCongDung.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCongDung.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblCongDung.Location = new System.Drawing.Point(308, 55);
            this.lblCongDung.Name = "lblCongDung";
            this.lblCongDung.Size = new System.Drawing.Size(90, 24);
            this.lblCongDung.Text = "Công dụng:";
            this.lblCongDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtCongDung.BackColor = System.Drawing.Color.White;
            this.txtCongDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCongDung.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCongDung.Location = new System.Drawing.Point(404, 52);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(185, 25);
            this.txtCongDung.TabIndex = 5;

            this.lblHDSD.AutoSize = false;
            this.lblHDSD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHDSD.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblHDSD.Location = new System.Drawing.Point(308, 93);
            this.lblHDSD.Name = "lblHDSD";
            this.lblHDSD.Size = new System.Drawing.Size(90, 24);
            this.lblHDSD.Text = "HDSD:";
            this.lblHDSD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtHDSD.BackColor = System.Drawing.Color.White;
            this.txtHDSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHDSD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHDSD.Location = new System.Drawing.Point(404, 90);
            this.txtHDSD.Name = "txtHDSD";
            this.txtHDSD.Size = new System.Drawing.Size(185, 25);
            this.txtHDSD.TabIndex = 6;

            this.lblGia.AutoSize = false;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblGia.Location = new System.Drawing.Point(308, 131);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(90, 24);
            this.lblGia.Text = "Giá:";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGia.Location = new System.Drawing.Point(404, 128);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(185, 25);
            this.txtGia.TabIndex = 7;

            // ── COL 3 (lbl x=606, txt/cb x=700) ──────────────────────────────
            this.lblSLTon.AutoSize = false;
            this.lblSLTon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSLTon.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblSLTon.Location = new System.Drawing.Point(606, 17);
            this.lblSLTon.Name = "lblSLTon";
            this.lblSLTon.Size = new System.Drawing.Size(88, 24);
            this.lblSLTon.Text = "SL tồn:";
            this.lblSLTon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.txtSLTon.BackColor = System.Drawing.Color.White;
            this.txtSLTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSLTon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSLTon.Location = new System.Drawing.Point(700, 14);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(180, 25);
            this.txtSLTon.TabIndex = 8;

            this.lblLoai.AutoSize = false;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLoai.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblLoai.Location = new System.Drawing.Point(606, 55);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(88, 24);
            this.lblLoai.Text = "Loại SP:";
            this.lblLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.cbLoaiSP.BackColor = System.Drawing.Color.White;
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbLoaiSP.Location = new System.Drawing.Point(700, 52);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(180, 25);
            this.cbLoaiSP.TabIndex = 9;

            this.lblNCC.AutoSize = false;
            this.lblNCC.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNCC.ForeColor = System.Drawing.Color.FromArgb(100, 115, 132);
            this.lblNCC.Location = new System.Drawing.Point(606, 93);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(88, 24);
            this.lblNCC.Text = "NCC:";
            this.lblNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.cbNCC.BackColor = System.Drawing.Color.White;
            this.cbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNCC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbNCC.Location = new System.Drawing.Point(700, 90);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(180, 25);
            this.cbNCC.TabIndex = 10;

            // ── Image ─────────────────────────────────────────────────────────
            this.picAnh.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(912, 14);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(120, 120);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabStop = false;

            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(936, 142);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(80, 28);
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);

            // ── Action buttons (row y=174) ─────────────────────────────────────

            this.btnThem.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(106, 174);
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
            this.btnSua.Location = new System.Drawing.Point(226, 174);
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
            this.btnXoa.Location = new System.Drawing.Point(346, 174);
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
            this.btnLamMoi.Location = new System.Drawing.Point(466, 174);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 34);
            this.btnLamMoi.Text = "↺ Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);


            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(16, 308);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1140, 280);
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.dgvSanPham);

            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(30, 40, 55);
            this.lblGridTitle.Location = new System.Drawing.Point(12, 10);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Text = "Danh sách sản phẩm";

            this.dgvSanPham.Location = new System.Drawing.Point(0, 38);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(1140, 242);
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1172, 604);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.pnlHeader.ResumeLayout(false); this.pnlHeader.PerformLayout();
            this.panelInput.ResumeLayout(false); this.panelInput.PerformLayout();
            this.pnlGrid.ResumeLayout(false); this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lblSoDK;
        private System.Windows.Forms.TextBox txtSoDK;
        private System.Windows.Forms.Label lblThanhPhan;
        private System.Windows.Forms.TextBox txtThanhPhan;
        private System.Windows.Forms.Label lblCongDung;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.Label lblHDSD;
        private System.Windows.Forms.TextBox txtHDSD;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblSLTon;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvSanPham;
    }
}