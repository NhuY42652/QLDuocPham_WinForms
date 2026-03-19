namespace QLDuocPham_WinForms
{
    partial class frmXuatNhapKhoChiNhanh
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlPhieu = new System.Windows.Forms.Panel();
            this.lblChiNhanh = new System.Windows.Forms.Label();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhieu = new System.Windows.Forms.Label();
            this.cbLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgayGiaoDich = new System.Windows.Forms.DateTimePicker();
            this.lblNguoiXuat = new System.Windows.Forms.Label();
            this.txtNguoiXuat = new System.Windows.Forms.TextBox();
            this.lblNguoiNhan = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.lblKhoNguon = new System.Windows.Forms.Label();
            this.txtKhoNguon = new System.Windows.Forms.TextBox();
            this.lblNoiNhan = new System.Windows.Forms.Label();
            this.txtNoiNhan = new System.Windows.Forms.TextBox();
            this.lblGhiChuPhieu = new System.Windows.Forms.Label();
            this.txtGhiChuPhieu = new System.Windows.Forms.TextBox();
            this.flpActionsPhieu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpThemSanPham = new System.Windows.Forms.GroupBox();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.lblGhiChuChiTiet = new System.Windows.Forms.Label();
            this.txtGhiChuChiTiet = new System.Windows.Forms.TextBox();
            this.dgvChiTietTam = new System.Windows.Forms.DataGridView();
            this.pnlDanhSachPhieu = new System.Windows.Forms.Panel();
            this.lblDanhSachPhieu = new System.Windows.Forms.Label();
            this.dgvDanhSachPhieu = new System.Windows.Forms.DataGridView();
            this.pnlChiTietPhieu = new System.Windows.Forms.Panel();
            this.lblChiTietPhieu = new System.Windows.Forms.Label();
            this.dgvChiTietPhieuDaLuu = new System.Windows.Forms.DataGridView();
            this.btnXuatPdf = new System.Windows.Forms.Button();
            this.pnlTonKho = new System.Windows.Forms.Panel();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlPhieu.SuspendLayout();
            this.flpActionsPhieu.SuspendLayout();
            this.grpThemSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).BeginInit();
            this.pnlDanhSachPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieu)).BeginInit();
            this.pnlChiTietPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuDaLuu)).BeginInit();
            this.pnlTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1067, 64);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏪  Xuất nhập kho Chi nhánh";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblSubTitle.Location = new System.Drawing.Point(18, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(299, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Lập phiếu xuất nhập kho và theo dõi tồn kho chi nhánh";
            // 
            // pnlPhieu
            // 
            this.pnlPhieu.BackColor = System.Drawing.Color.White;
            this.pnlPhieu.Controls.Add(this.lblChiNhanh);
            this.pnlPhieu.Controls.Add(this.cbChiNhanh);
            this.pnlPhieu.Controls.Add(this.lblLoaiPhieu);
            this.pnlPhieu.Controls.Add(this.cbLoaiPhieu);
            this.pnlPhieu.Controls.Add(this.lblNgay);
            this.pnlPhieu.Controls.Add(this.dtNgayGiaoDich);
            this.pnlPhieu.Controls.Add(this.lblNguoiXuat);
            this.pnlPhieu.Controls.Add(this.txtNguoiXuat);
            this.pnlPhieu.Controls.Add(this.lblNguoiNhan);
            this.pnlPhieu.Controls.Add(this.txtNguoiNhan);
            this.pnlPhieu.Controls.Add(this.lblKhoNguon);
            this.pnlPhieu.Controls.Add(this.txtKhoNguon);
            this.pnlPhieu.Controls.Add(this.lblNoiNhan);
            this.pnlPhieu.Controls.Add(this.txtNoiNhan);
            this.pnlPhieu.Controls.Add(this.lblGhiChuPhieu);
            this.pnlPhieu.Controls.Add(this.txtGhiChuPhieu);
            this.pnlPhieu.Controls.Add(this.flpActionsPhieu);
            this.pnlPhieu.Location = new System.Drawing.Point(0, 70);
            this.pnlPhieu.Name = "pnlPhieu";
            this.pnlPhieu.Size = new System.Drawing.Size(1067, 140);
            this.pnlPhieu.TabIndex = 5;
            // 
            // lblChiNhanh
            // 
            this.lblChiNhanh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblChiNhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblChiNhanh.Location = new System.Drawing.Point(10, 10);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(82, 28);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh:";
            this.lblChiNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChiNhanh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(98, 15);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(220, 25);
            this.cbChiNhanh.TabIndex = 0;
            // 
            // lblLoaiPhieu
            // 
            this.lblLoaiPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLoaiPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblLoaiPhieu.Location = new System.Drawing.Point(672, 10);
            this.lblLoaiPhieu.Name = "lblLoaiPhieu";
            this.lblLoaiPhieu.Size = new System.Drawing.Size(82, 28);
            this.lblLoaiPhieu.TabIndex = 1;
            this.lblLoaiPhieu.Text = "Loại phiếu:";
            this.lblLoaiPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbLoaiPhieu
            // 
            this.cbLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoaiPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbLoaiPhieu.FormattingEnabled = true;
            this.cbLoaiPhieu.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.cbLoaiPhieu.Location = new System.Drawing.Point(765, 15);
            this.cbLoaiPhieu.Name = "cbLoaiPhieu";
            this.cbLoaiPhieu.Size = new System.Drawing.Size(143, 25);
            this.cbLoaiPhieu.TabIndex = 1;
            // 
            // lblNgay
            // 
            this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblNgay.Location = new System.Drawing.Point(674, 50);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(80, 28);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "Ngày/giờ:";
            this.lblNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtNgayGiaoDich
            // 
            this.dtNgayGiaoDich.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtNgayGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtNgayGiaoDich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayGiaoDich.Location = new System.Drawing.Point(765, 55);
            this.dtNgayGiaoDich.Name = "dtNgayGiaoDich";
            this.dtNgayGiaoDich.Size = new System.Drawing.Size(143, 24);
            this.dtNgayGiaoDich.TabIndex = 2;
            // 
            // lblNguoiXuat
            // 
            this.lblNguoiXuat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNguoiXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblNguoiXuat.Location = new System.Drawing.Point(340, 50);
            this.lblNguoiXuat.Name = "lblNguoiXuat";
            this.lblNguoiXuat.Size = new System.Drawing.Size(82, 28);
            this.lblNguoiXuat.TabIndex = 3;
            this.lblNguoiXuat.Text = "Người giao:";
            this.lblNguoiXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNguoiXuat
            // 
            this.txtNguoiXuat.BackColor = System.Drawing.Color.White;
            this.txtNguoiXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNguoiXuat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNguoiXuat.Location = new System.Drawing.Point(428, 55);
            this.txtNguoiXuat.Name = "txtNguoiXuat";
            this.txtNguoiXuat.Size = new System.Drawing.Size(219, 24);
            this.txtNguoiXuat.TabIndex = 3;
            // 
            // lblNguoiNhan
            // 
            this.lblNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNguoiNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblNguoiNhan.Location = new System.Drawing.Point(3, 90);
            this.lblNguoiNhan.Name = "lblNguoiNhan";
            this.lblNguoiNhan.Size = new System.Drawing.Size(89, 28);
            this.lblNguoiNhan.TabIndex = 4;
            this.lblNguoiNhan.Text = "Người nhận:";
            this.lblNguoiNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.BackColor = System.Drawing.Color.White;
            this.txtNguoiNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNguoiNhan.Location = new System.Drawing.Point(98, 95);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(219, 24);
            this.txtNguoiNhan.TabIndex = 4;
            // 
            // lblKhoNguon
            // 
            this.lblKhoNguon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKhoNguon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblKhoNguon.Location = new System.Drawing.Point(10, 50);
            this.lblKhoNguon.Name = "lblKhoNguon";
            this.lblKhoNguon.Size = new System.Drawing.Size(82, 28);
            this.lblKhoNguon.TabIndex = 5;
            this.lblKhoNguon.Text = "Lấy từ kho:";
            this.lblKhoNguon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKhoNguon
            // 
            this.txtKhoNguon.BackColor = System.Drawing.Color.White;
            this.txtKhoNguon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhoNguon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKhoNguon.Location = new System.Drawing.Point(97, 55);
            this.txtKhoNguon.Name = "txtKhoNguon";
            this.txtKhoNguon.Size = new System.Drawing.Size(220, 24);
            this.txtKhoNguon.TabIndex = 5;
            // 
            // lblNoiNhan
            // 
            this.lblNoiNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNoiNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblNoiNhan.Location = new System.Drawing.Point(330, 90);
            this.lblNoiNhan.Name = "lblNoiNhan";
            this.lblNoiNhan.Size = new System.Drawing.Size(92, 28);
            this.lblNoiNhan.TabIndex = 6;
            this.lblNoiNhan.Text = "Nơi nhận:";
            this.lblNoiNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNoiNhan
            // 
            this.txtNoiNhan.BackColor = System.Drawing.Color.White;
            this.txtNoiNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNoiNhan.Location = new System.Drawing.Point(427, 95);
            this.txtNoiNhan.Name = "txtNoiNhan";
            this.txtNoiNhan.Size = new System.Drawing.Size(220, 24);
            this.txtNoiNhan.TabIndex = 6;
            // 
            // lblGhiChuPhieu
            // 
            this.lblGhiChuPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGhiChuPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblGhiChuPhieu.Location = new System.Drawing.Point(686, 90);
            this.lblGhiChuPhieu.Name = "lblGhiChuPhieu";
            this.lblGhiChuPhieu.Size = new System.Drawing.Size(68, 28);
            this.lblGhiChuPhieu.TabIndex = 7;
            this.lblGhiChuPhieu.Text = "Ghi chú:";
            this.lblGhiChuPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGhiChuPhieu
            // 
            this.txtGhiChuPhieu.BackColor = System.Drawing.Color.White;
            this.txtGhiChuPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChuPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGhiChuPhieu.Location = new System.Drawing.Point(763, 95);
            this.txtGhiChuPhieu.Name = "txtGhiChuPhieu";
            this.txtGhiChuPhieu.Size = new System.Drawing.Size(145, 24);
            this.txtGhiChuPhieu.TabIndex = 7;
            // 
            // flpActionsPhieu
            // 
            this.flpActionsPhieu.Controls.Add(this.btnLuuPhieu);
            this.flpActionsPhieu.Controls.Add(this.btnLamMoi);
            this.flpActionsPhieu.Location = new System.Drawing.Point(955, 29);
            this.flpActionsPhieu.Name = "flpActionsPhieu";
            this.flpActionsPhieu.Size = new System.Drawing.Size(100, 75);
            this.flpActionsPhieu.TabIndex = 8;
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnLuuPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuPhieu.FlatAppearance.BorderSize = 0;
            this.btnLuuPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLuuPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieu.Location = new System.Drawing.Point(0, 0);
            this.btnLuuPhieu.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(86, 34);
            this.btnLuuPhieu.TabIndex = 0;
            this.btnLuuPhieu.Text = "💾 Lưu";
            this.btnLuuPhieu.UseVisualStyleBackColor = false;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(0, 34);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(86, 34);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "↺ Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpThemSanPham
            // 
            this.grpThemSanPham.BackColor = System.Drawing.Color.White;
            this.grpThemSanPham.Controls.Add(this.lblSanPham);
            this.grpThemSanPham.Controls.Add(this.cbSanPham);
            this.grpThemSanPham.Controls.Add(this.lblSoLuong);
            this.grpThemSanPham.Controls.Add(this.numSoLuong);
            this.grpThemSanPham.Controls.Add(this.btnThemSanPham);
            this.grpThemSanPham.Controls.Add(this.btnXoaSanPham);
            this.grpThemSanPham.Controls.Add(this.lblGhiChuChiTiet);
            this.grpThemSanPham.Controls.Add(this.txtGhiChuChiTiet);
            this.grpThemSanPham.Controls.Add(this.dgvChiTietTam);
            this.grpThemSanPham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpThemSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.grpThemSanPham.Location = new System.Drawing.Point(0, 216);
            this.grpThemSanPham.Name = "grpThemSanPham";
            this.grpThemSanPham.Size = new System.Drawing.Size(1067, 210);
            this.grpThemSanPham.TabIndex = 4;
            this.grpThemSanPham.TabStop = false;
            this.grpThemSanPham.Text = "Chi tiết phiếu đang lập";
            // 
            // lblSanPham
            // 
            this.lblSanPham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblSanPham.Location = new System.Drawing.Point(10, 25);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(80, 28);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Sản phẩm:";
            this.lblSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSanPham
            // 
            this.cbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSanPham.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(96, 30);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(511, 25);
            this.cbSanPham.TabIndex = 0;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblSoLuong.Location = new System.Drawing.Point(638, 25);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(70, 28);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số lượng:";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numSoLuong.Location = new System.Drawing.Point(724, 30);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(90, 24);
            this.numSoLuong.TabIndex = 1;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThemSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSanPham.FlatAppearance.BorderSize = 0;
            this.btnThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSanPham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThemSanPham.ForeColor = System.Drawing.Color.White;
            this.btnThemSanPham.Location = new System.Drawing.Point(875, 19);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(166, 34);
            this.btnThemSanPham.TabIndex = 2;
            this.btnThemSanPham.Text = "＋ Thêm vào phiếu";
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSanPham.FlatAppearance.BorderSize = 0;
            this.btnXoaSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoaSanPham.ForeColor = System.Drawing.Color.White;
            this.btnXoaSanPham.Location = new System.Drawing.Point(875, 59);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(166, 34);
            this.btnXoaSanPham.TabIndex = 3;
            this.btnXoaSanPham.Text = "✕ Xóa dòng đang chọn";
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // lblGhiChuChiTiet
            // 
            this.lblGhiChuChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGhiChuChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblGhiChuChiTiet.Location = new System.Drawing.Point(10, 65);
            this.lblGhiChuChiTiet.Name = "lblGhiChuChiTiet";
            this.lblGhiChuChiTiet.Size = new System.Drawing.Size(80, 28);
            this.lblGhiChuChiTiet.TabIndex = 4;
            this.lblGhiChuChiTiet.Text = "Ghi chú:";
            this.lblGhiChuChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGhiChuChiTiet
            // 
            this.txtGhiChuChiTiet.BackColor = System.Drawing.Color.White;
            this.txtGhiChuChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChuChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGhiChuChiTiet.Location = new System.Drawing.Point(96, 70);
            this.txtGhiChuChiTiet.Name = "txtGhiChuChiTiet";
            this.txtGhiChuChiTiet.Size = new System.Drawing.Size(511, 24);
            this.txtGhiChuChiTiet.TabIndex = 2;
            // 
            // dgvChiTietTam
            // 
            this.dgvChiTietTam.AllowUserToAddRows = false;
            this.dgvChiTietTam.AllowUserToDeleteRows = false;
            this.dgvChiTietTam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietTam.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietTam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietTam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietTam.Location = new System.Drawing.Point(18, 106);
            this.dgvChiTietTam.MultiSelect = false;
            this.dgvChiTietTam.Name = "dgvChiTietTam";
            this.dgvChiTietTam.ReadOnly = true;
            this.dgvChiTietTam.RowHeadersVisible = false;
            this.dgvChiTietTam.RowHeadersWidth = 51;
            this.dgvChiTietTam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietTam.Size = new System.Drawing.Size(1037, 98);
            this.dgvChiTietTam.TabIndex = 3;
            // 
            // pnlDanhSachPhieu
            // 
            this.pnlDanhSachPhieu.BackColor = System.Drawing.Color.White;
            this.pnlDanhSachPhieu.Controls.Add(this.lblDanhSachPhieu);
            this.pnlDanhSachPhieu.Controls.Add(this.dgvDanhSachPhieu);
            this.pnlDanhSachPhieu.Location = new System.Drawing.Point(0, 426);
            this.pnlDanhSachPhieu.Name = "pnlDanhSachPhieu";
            this.pnlDanhSachPhieu.Size = new System.Drawing.Size(1067, 190);
            this.pnlDanhSachPhieu.TabIndex = 3;
            // 
            // lblDanhSachPhieu
            // 
            this.lblDanhSachPhieu.AutoSize = true;
            this.lblDanhSachPhieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDanhSachPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.lblDanhSachPhieu.Location = new System.Drawing.Point(14, 10);
            this.lblDanhSachPhieu.Name = "lblDanhSachPhieu";
            this.lblDanhSachPhieu.Size = new System.Drawing.Size(172, 20);
            this.lblDanhSachPhieu.TabIndex = 0;
            this.lblDanhSachPhieu.Text = "Danh sách phiếu đã lưu";
            // 
            // dgvDanhSachPhieu
            // 
            this.dgvDanhSachPhieu.AllowUserToAddRows = false;
            this.dgvDanhSachPhieu.AllowUserToDeleteRows = false;
            this.dgvDanhSachPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachPhieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieu.Location = new System.Drawing.Point(18, 38);
            this.dgvDanhSachPhieu.MultiSelect = false;
            this.dgvDanhSachPhieu.Name = "dgvDanhSachPhieu";
            this.dgvDanhSachPhieu.ReadOnly = true;
            this.dgvDanhSachPhieu.RowHeadersVisible = false;
            this.dgvDanhSachPhieu.RowHeadersWidth = 51;
            this.dgvDanhSachPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieu.Size = new System.Drawing.Size(1031, 140);
            this.dgvDanhSachPhieu.TabIndex = 0;
            this.dgvDanhSachPhieu.SelectionChanged += new System.EventHandler(this.dgvDanhSachPhieu_SelectionChanged);
            // 
            // pnlChiTietPhieu
            // 
            this.pnlChiTietPhieu.BackColor = System.Drawing.Color.White;
            this.pnlChiTietPhieu.Controls.Add(this.lblChiTietPhieu);
            this.pnlChiTietPhieu.Controls.Add(this.btnXuatPdf);
            this.pnlChiTietPhieu.Controls.Add(this.dgvChiTietPhieuDaLuu);
            this.pnlChiTietPhieu.Location = new System.Drawing.Point(0, 622);
            this.pnlChiTietPhieu.Name = "pnlChiTietPhieu";
            this.pnlChiTietPhieu.Size = new System.Drawing.Size(1067, 182);
            this.pnlChiTietPhieu.TabIndex = 2;
            // 
            // lblChiTietPhieu
            // 
            this.lblChiTietPhieu.AutoSize = true;
            this.lblChiTietPhieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChiTietPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.lblChiTietPhieu.Location = new System.Drawing.Point(14, 10);
            this.lblChiTietPhieu.Name = "lblChiTietPhieu";
            this.lblChiTietPhieu.Size = new System.Drawing.Size(179, 20);
            this.lblChiTietPhieu.TabIndex = 0;
            this.lblChiTietPhieu.Text = "Chi tiết phiếu đang chọn";
            // 
            // dgvChiTietPhieuDaLuu
            // 
            this.dgvChiTietPhieuDaLuu.AllowUserToAddRows = false;
            this.dgvChiTietPhieuDaLuu.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuDaLuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieuDaLuu.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPhieuDaLuu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietPhieuDaLuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuDaLuu.Location = new System.Drawing.Point(18, 49);
            this.dgvChiTietPhieuDaLuu.Name = "dgvChiTietPhieuDaLuu";
            this.dgvChiTietPhieuDaLuu.ReadOnly = true;
            this.dgvChiTietPhieuDaLuu.RowHeadersVisible = false;
            this.dgvChiTietPhieuDaLuu.RowHeadersWidth = 51;
            this.dgvChiTietPhieuDaLuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPhieuDaLuu.Size = new System.Drawing.Size(1037, 122);
            this.dgvChiTietPhieuDaLuu.TabIndex = 0;
            // 
            // btnXuatPdf
            // 
            this.btnXuatPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnXuatPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatPdf.FlatAppearance.BorderSize = 0;
            this.btnXuatPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatPdf.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXuatPdf.ForeColor = System.Drawing.Color.White;
            this.btnXuatPdf.Location = new System.Drawing.Point(927, 3);
            this.btnXuatPdf.Name = "btnXuatPdf";
            this.btnXuatPdf.Size = new System.Drawing.Size(137, 40);
            this.btnXuatPdf.TabIndex = 1;
            this.btnXuatPdf.Text = "📄 In / Xuất PDF";
            this.btnXuatPdf.UseVisualStyleBackColor = false;
            this.btnXuatPdf.Click += new System.EventHandler(this.btnXuatPdf_Click);
            // 
            // pnlTonKho
            // 
            this.pnlTonKho.BackColor = System.Drawing.Color.White;
            this.pnlTonKho.Controls.Add(this.lblTonKho);
            this.pnlTonKho.Controls.Add(this.dgvTonKho);
            this.pnlTonKho.Location = new System.Drawing.Point(0, 810);
            this.pnlTonKho.Name = "pnlTonKho";
            this.pnlTonKho.Size = new System.Drawing.Size(1067, 205);
            this.pnlTonKho.TabIndex = 0;
            // 
            // lblTonKho
            // 
            this.lblTonKho.AutoSize = true;
            this.lblTonKho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTonKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.lblTonKho.Location = new System.Drawing.Point(14, 10);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(174, 20);
            this.lblTonKho.TabIndex = 0;
            this.lblTonKho.Text = "Tồn kho theo chi nhánh";
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AllowUserToAddRows = false;
            this.dgvTonKho.AllowUserToDeleteRows = false;
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvTonKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Location = new System.Drawing.Point(22, 33);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.ReadOnly = true;
            this.dgvTonKho.RowHeadersVisible = false;
            this.dgvTonKho.RowHeadersWidth = 51;
            this.dgvTonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTonKho.Size = new System.Drawing.Size(1033, 160);
            this.dgvTonKho.TabIndex = 0;
            // 
            // frmXuatNhapKhoChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1084, 845);
            this.Controls.Add(this.pnlTonKho);
            this.Controls.Add(this.pnlChiTietPhieu);
            this.Controls.Add(this.pnlDanhSachPhieu);
            this.Controls.Add(this.grpThemSanPham);
            this.Controls.Add(this.pnlPhieu);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmXuatNhapKhoChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xuất nhập kho chi nhánh";
            this.Load += new System.EventHandler(this.frmXuatNhapKhoChiNhanh_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlPhieu.ResumeLayout(false);
            this.pnlPhieu.PerformLayout();
            this.flpActionsPhieu.ResumeLayout(false);
            this.grpThemSanPham.ResumeLayout(false);
            this.grpThemSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).EndInit();
            this.pnlDanhSachPhieu.ResumeLayout(false);
            this.pnlDanhSachPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieu)).EndInit();
            this.pnlChiTietPhieu.ResumeLayout(false);
            this.pnlChiTietPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuDaLuu)).EndInit();
            this.pnlTonKho.ResumeLayout(false);
            this.pnlTonKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlPhieu;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label lblLoaiPhieu;
        private System.Windows.Forms.ComboBox cbLoaiPhieu;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgayGiaoDich;
        private System.Windows.Forms.Label lblNguoiXuat;
        private System.Windows.Forms.TextBox txtNguoiXuat;
        private System.Windows.Forms.Label lblNguoiNhan;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.Label lblKhoNguon;
        private System.Windows.Forms.TextBox txtKhoNguon;
        private System.Windows.Forms.Label lblNoiNhan;
        private System.Windows.Forms.TextBox txtNoiNhan;
        private System.Windows.Forms.Label lblGhiChuPhieu;
        private System.Windows.Forms.TextBox txtGhiChuPhieu;
        private System.Windows.Forms.FlowLayoutPanel flpActionsPhieu;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpThemSanPham;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Label lblGhiChuChiTiet;
        private System.Windows.Forms.TextBox txtGhiChuChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTietTam;
        private System.Windows.Forms.Panel pnlDanhSachPhieu;
        private System.Windows.Forms.Label lblDanhSachPhieu;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieu;
        private System.Windows.Forms.Panel pnlChiTietPhieu;
        private System.Windows.Forms.Label lblChiTietPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuDaLuu;
        private System.Windows.Forms.Button btnXuatPdf;
        private System.Windows.Forms.Panel pnlTonKho;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.DataGridView dgvTonKho;
    }
}