namespace QLDuocPham_WinForms
{
    partial class frmXuatNhapKhoChiNhanh
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
            this.grpThemSanPham = new System.Windows.Forms.GroupBox();
            this.lblGhiChuChiTiet = new System.Windows.Forms.Label();
            this.txtGhiChuChiTiet = new System.Windows.Forms.TextBox();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dgvChiTietTam = new System.Windows.Forms.DataGridView();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblDanhSachPhieu = new System.Windows.Forms.Label();
            this.dgvDanhSachPhieu = new System.Windows.Forms.DataGridView();
            this.lblChiTietPhieu = new System.Windows.Forms.Label();
            this.dgvChiTietPhieuDaLuu = new System.Windows.Forms.DataGridView();
            this.btnXuatPdf = new System.Windows.Forms.Button();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.grpThemSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuDaLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.SuspendLayout();
            //
            // lblChiNhanh
            //
            this.lblChiNhanh.AutoSize = true;
            this.lblChiNhanh.Location = new System.Drawing.Point(20, 19);
            this.lblChiNhanh.Name = "lblChiNhanh";
            this.lblChiNhanh.Size = new System.Drawing.Size(64, 13);
            this.lblChiNhanh.TabIndex = 0;
            this.lblChiNhanh.Text = "Chi nhánh";
            //
            // cbChiNhanh
            //
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(101, 16);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(249, 21);
            this.cbChiNhanh.TabIndex = 1;
            //
            // lblLoaiPhieu
            //
            this.lblLoaiPhieu.AutoSize = true;
            this.lblLoaiPhieu.Location = new System.Drawing.Point(375, 19);
            this.lblLoaiPhieu.Name = "lblLoaiPhieu";
            this.lblLoaiPhieu.Size = new System.Drawing.Size(58, 13);
            this.lblLoaiPhieu.TabIndex = 2;
            this.lblLoaiPhieu.Text = "Loại phiếu";
            //
            // cbLoaiPhieu
            //
            this.cbLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhieu.FormattingEnabled = true;
            this.cbLoaiPhieu.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.cbLoaiPhieu.Location = new System.Drawing.Point(439, 16);
            this.cbLoaiPhieu.Name = "cbLoaiPhieu";
            this.cbLoaiPhieu.Size = new System.Drawing.Size(89, 21);
            this.cbLoaiPhieu.TabIndex = 3;
            //
            // lblNgay
            //
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(548, 19);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(58, 13);
            this.lblNgay.TabIndex = 4;
            this.lblNgay.Text = "Ngày/giờ";
            //
            // dtNgayGiaoDich
            //
            this.dtNgayGiaoDich.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtNgayGiaoDich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayGiaoDich.Location = new System.Drawing.Point(612, 16);
            this.dtNgayGiaoDich.Name = "dtNgayGiaoDich";
            this.dtNgayGiaoDich.Size = new System.Drawing.Size(150, 20);
            this.dtNgayGiaoDich.TabIndex = 5;
            //
            // lblNguoiXuat
            //
            this.lblNguoiXuat.AutoSize = true;
            this.lblNguoiXuat.Location = new System.Drawing.Point(20, 50);
            this.lblNguoiXuat.Name = "lblNguoiXuat";
            this.lblNguoiXuat.Size = new System.Drawing.Size(64, 13);
            this.lblNguoiXuat.TabIndex = 6;
            this.lblNguoiXuat.Text = "Người giao";
            //
            // txtNguoiXuat
            //
            this.txtNguoiXuat.Location = new System.Drawing.Point(101, 47);
            this.txtNguoiXuat.Name = "txtNguoiXuat";
            this.txtNguoiXuat.Size = new System.Drawing.Size(249, 20);
            this.txtNguoiXuat.TabIndex = 7;
            //
            // lblNguoiNhan
            //
            this.lblNguoiNhan.AutoSize = true;
            this.lblNguoiNhan.Location = new System.Drawing.Point(375, 50);
            this.lblNguoiNhan.Name = "lblNguoiNhan";
            this.lblNguoiNhan.Size = new System.Drawing.Size(62, 13);
            this.lblNguoiNhan.TabIndex = 8;
            this.lblNguoiNhan.Text = "Người nhận";
            //
            // txtNguoiNhan
            //
            this.txtNguoiNhan.Location = new System.Drawing.Point(439, 47);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(323, 20);
            this.txtNguoiNhan.TabIndex = 9;
            //
            // lblKhoNguon
            //
            this.lblKhoNguon.AutoSize = true;
            this.lblKhoNguon.Location = new System.Drawing.Point(20, 81);
            this.lblKhoNguon.Name = "lblKhoNguon";
            this.lblKhoNguon.Size = new System.Drawing.Size(57, 13);
            this.lblKhoNguon.TabIndex = 10;
            this.lblKhoNguon.Text = "Lấy từ kho";
            //
            // txtKhoNguon
            //
            this.txtKhoNguon.Location = new System.Drawing.Point(101, 78);
            this.txtKhoNguon.Name = "txtKhoNguon";
            this.txtKhoNguon.Size = new System.Drawing.Size(249, 20);
            this.txtKhoNguon.TabIndex = 11;
            //
            // lblNoiNhan
            //
            this.lblNoiNhan.AutoSize = true;
            this.lblNoiNhan.Location = new System.Drawing.Point(375, 81);
            this.lblNoiNhan.Name = "lblNoiNhan";
            this.lblNoiNhan.Size = new System.Drawing.Size(49, 13);
            this.lblNoiNhan.TabIndex = 12;
            this.lblNoiNhan.Text = "Nơi nhận";
            //
            // txtNoiNhan
            //
            this.txtNoiNhan.Location = new System.Drawing.Point(439, 78);
            this.txtNoiNhan.Name = "txtNoiNhan";
            this.txtNoiNhan.Size = new System.Drawing.Size(323, 20);
            this.txtNoiNhan.TabIndex = 13;
            //
            // lblGhiChuPhieu
            //
            this.lblGhiChuPhieu.AutoSize = true;
            this.lblGhiChuPhieu.Location = new System.Drawing.Point(20, 112);
            this.lblGhiChuPhieu.Name = "lblGhiChuPhieu";
            this.lblGhiChuPhieu.Size = new System.Drawing.Size(74, 13);
            this.lblGhiChuPhieu.TabIndex = 14;
            this.lblGhiChuPhieu.Text = "Ghi chú phiếu";
            //
            // txtGhiChuPhieu
            //
            this.txtGhiChuPhieu.Location = new System.Drawing.Point(101, 109);
            this.txtGhiChuPhieu.Name = "txtGhiChuPhieu";
            this.txtGhiChuPhieu.Size = new System.Drawing.Size(661, 20);
            this.txtGhiChuPhieu.TabIndex = 15;
            //
            // grpThemSanPham
            //
            this.grpThemSanPham.Controls.Add(this.lblGhiChuChiTiet);
            this.grpThemSanPham.Controls.Add(this.txtGhiChuChiTiet);
            this.grpThemSanPham.Controls.Add(this.btnXoaSanPham);
            this.grpThemSanPham.Controls.Add(this.btnThemSanPham);
            this.grpThemSanPham.Controls.Add(this.lblSanPham);
            this.grpThemSanPham.Controls.Add(this.cbSanPham);
            this.grpThemSanPham.Controls.Add(this.lblSoLuong);
            this.grpThemSanPham.Controls.Add(this.numSoLuong);
            this.grpThemSanPham.Controls.Add(this.dgvChiTietTam);
            this.grpThemSanPham.Location = new System.Drawing.Point(23, 144);
            this.grpThemSanPham.Name = "grpThemSanPham";
            this.grpThemSanPham.Size = new System.Drawing.Size(995, 214);
            this.grpThemSanPham.TabIndex = 16;
            this.grpThemSanPham.TabStop = false;
            this.grpThemSanPham.Text = "Chi tiết phiếu đang lập";
            //
            // lblGhiChuChiTiet
            //
            this.lblGhiChuChiTiet.AutoSize = true;
            this.lblGhiChuChiTiet.Location = new System.Drawing.Point(16, 57);
            this.lblGhiChuChiTiet.Name = "lblGhiChuChiTiet";
            this.lblGhiChuChiTiet.Size = new System.Drawing.Size(81, 13);
            this.lblGhiChuChiTiet.TabIndex = 4;
            this.lblGhiChuChiTiet.Text = "Ghi chú chi tiết";
            //
            // txtGhiChuChiTiet
            //
            this.txtGhiChuChiTiet.Location = new System.Drawing.Point(104, 54);
            this.txtGhiChuChiTiet.Name = "txtGhiChuChiTiet";
            this.txtGhiChuChiTiet.Size = new System.Drawing.Size(546, 20);
            this.txtGhiChuChiTiet.TabIndex = 5;
            //
            // btnXoaSanPham
            //
            this.btnXoaSanPham.Location = new System.Drawing.Point(810, 23);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(163, 24);
            this.btnXoaSanPham.TabIndex = 7;
            this.btnXoaSanPham.Text = "Xóa sản phẩm đang chọn";
            this.btnXoaSanPham.UseVisualStyleBackColor = true;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            //
            // btnThemSanPham
            //
            this.btnThemSanPham.Location = new System.Drawing.Point(656, 23);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(148, 51);
            this.btnThemSanPham.TabIndex = 6;
            this.btnThemSanPham.Text = "Thêm sản phẩm vào phiếu";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            //
            // lblSanPham
            //
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Location = new System.Drawing.Point(16, 28);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(58, 13);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Sản phẩm";
            //
            // cbSanPham
            //
            this.cbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(104, 24);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(382, 21);
            this.cbSanPham.TabIndex = 1;
            //
            // lblSoLuong
            //
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(503, 28);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(53, 13);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng";
            //
            // numSoLuong
            //
            this.numSoLuong.Location = new System.Drawing.Point(562, 25);
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
            this.numSoLuong.Size = new System.Drawing.Size(88, 20);
            this.numSoLuong.TabIndex = 3;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // dgvChiTietTam
            //
            this.dgvChiTietTam.AllowUserToAddRows = false;
            this.dgvChiTietTam.AllowUserToDeleteRows = false;
            this.dgvChiTietTam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietTam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietTam.Location = new System.Drawing.Point(19, 88);
            this.dgvChiTietTam.MultiSelect = false;
            this.dgvChiTietTam.Name = "dgvChiTietTam";
            this.dgvChiTietTam.ReadOnly = true;
            this.dgvChiTietTam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietTam.Size = new System.Drawing.Size(954, 110);
            this.dgvChiTietTam.TabIndex = 8;
            //
            // btnLuuPhieu
            //
            this.btnLuuPhieu.Location = new System.Drawing.Point(787, 16);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(112, 51);
            this.btnLuuPhieu.TabIndex = 17;
            this.btnLuuPhieu.Text = "Lưu phiếu nhiều sản phẩm";
            this.btnLuuPhieu.UseVisualStyleBackColor = true;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Location = new System.Drawing.Point(905, 16);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(113, 24);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            //
            // lblDanhSachPhieu
            //
            this.lblDanhSachPhieu.AutoSize = true;
            this.lblDanhSachPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDanhSachPhieu.Location = new System.Drawing.Point(20, 372);
            this.lblDanhSachPhieu.Name = "lblDanhSachPhieu";
            this.lblDanhSachPhieu.Size = new System.Drawing.Size(181, 16);
            this.lblDanhSachPhieu.TabIndex = 19;
            this.lblDanhSachPhieu.Text = "Danh sách phiếu đã lưu";
            //
            // dgvDanhSachPhieu
            //
            this.dgvDanhSachPhieu.AllowUserToAddRows = false;
            this.dgvDanhSachPhieu.AllowUserToDeleteRows = false;
            this.dgvDanhSachPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieu.Location = new System.Drawing.Point(23, 391);
            this.dgvDanhSachPhieu.MultiSelect = false;
            this.dgvDanhSachPhieu.Name = "dgvDanhSachPhieu";
            this.dgvDanhSachPhieu.ReadOnly = true;
            this.dgvDanhSachPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieu.Size = new System.Drawing.Size(995, 156);
            this.dgvDanhSachPhieu.TabIndex = 20;
            this.dgvDanhSachPhieu.SelectionChanged += new System.EventHandler(this.dgvDanhSachPhieu_SelectionChanged);
            //
            // lblChiTietPhieu
            //
            this.lblChiTietPhieu.AutoSize = true;
            this.lblChiTietPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChiTietPhieu.Location = new System.Drawing.Point(20, 557);
            this.lblChiTietPhieu.Name = "lblChiTietPhieu";
            this.lblChiTietPhieu.Size = new System.Drawing.Size(208, 16);
            this.lblChiTietPhieu.TabIndex = 21;
            this.lblChiTietPhieu.Text = "Chi tiết phiếu đang được chọn";
            //
            // dgvChiTietPhieuDaLuu
            //
            this.dgvChiTietPhieuDaLuu.AllowUserToAddRows = false;
            this.dgvChiTietPhieuDaLuu.AllowUserToDeleteRows = false;
            this.dgvChiTietPhieuDaLuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieuDaLuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuDaLuu.Location = new System.Drawing.Point(23, 576);
            this.dgvChiTietPhieuDaLuu.Name = "dgvChiTietPhieuDaLuu";
            this.dgvChiTietPhieuDaLuu.ReadOnly = true;
            this.dgvChiTietPhieuDaLuu.Size = new System.Drawing.Size(864, 136);
            this.dgvChiTietPhieuDaLuu.TabIndex = 22;
            //
            // btnXuatPdf
            //
            this.btnXuatPdf.Location = new System.Drawing.Point(893, 576);
            this.btnXuatPdf.Name = "btnXuatPdf";
            this.btnXuatPdf.Size = new System.Drawing.Size(125, 42);
            this.btnXuatPdf.TabIndex = 23;
            this.btnXuatPdf.Text = "In / Xuất PDF phiếu đang chọn";
            this.btnXuatPdf.UseVisualStyleBackColor = true;
            this.btnXuatPdf.Click += new System.EventHandler(this.btnXuatPdf_Click);
            //
            // lblTonKho
            //
            this.lblTonKho.AutoSize = true;
            this.lblTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTonKho.Location = new System.Drawing.Point(20, 724);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(151, 16);
            this.lblTonKho.TabIndex = 24;
            this.lblTonKho.Text = "Tồn kho theo chi nhánh";
            //
            // dgvTonKho
            //
            this.dgvTonKho.AllowUserToAddRows = false;
            this.dgvTonKho.AllowUserToDeleteRows = false;
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonKho.Location = new System.Drawing.Point(23, 743);
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.ReadOnly = true;
            this.dgvTonKho.Size = new System.Drawing.Size(995, 144);
            this.dgvTonKho.TabIndex = 25;
            //
            // frmXuatNhapKhoChiNhanh
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 906);
            this.Controls.Add(this.dgvTonKho);
            this.Controls.Add(this.lblTonKho);
            this.Controls.Add(this.btnXuatPdf);
            this.Controls.Add(this.dgvChiTietPhieuDaLuu);
            this.Controls.Add(this.lblChiTietPhieu);
            this.Controls.Add(this.dgvDanhSachPhieu);
            this.Controls.Add(this.lblDanhSachPhieu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuuPhieu);
            this.Controls.Add(this.grpThemSanPham);
            this.Controls.Add(this.txtGhiChuPhieu);
            this.Controls.Add(this.lblGhiChuPhieu);
            this.Controls.Add(this.txtNoiNhan);
            this.Controls.Add(this.lblNoiNhan);
            this.Controls.Add(this.txtKhoNguon);
            this.Controls.Add(this.lblKhoNguon);
            this.Controls.Add(this.txtNguoiNhan);
            this.Controls.Add(this.lblNguoiNhan);
            this.Controls.Add(this.txtNguoiXuat);
            this.Controls.Add(this.lblNguoiXuat);
            this.Controls.Add(this.dtNgayGiaoDich);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.cbLoaiPhieu);
            this.Controls.Add(this.lblLoaiPhieu);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.lblChiNhanh);
            this.Name = "frmXuatNhapKhoChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xuất nhập kho chi nhánh";
            this.Load += new System.EventHandler(this.frmXuatNhapKhoChiNhanh_Load);
            this.grpThemSanPham.ResumeLayout(false);
            this.grpThemSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuDaLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.GroupBox grpThemSanPham;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.DataGridView dgvChiTietTam;
        private System.Windows.Forms.Label lblGhiChuChiTiet;
        private System.Windows.Forms.TextBox txtGhiChuChiTiet;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblDanhSachPhieu;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieu;
        private System.Windows.Forms.Label lblChiTietPhieu;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuDaLuu;
        private System.Windows.Forms.Button btnXuatPdf;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.DataGridView dgvTonKho;
    }
}
