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
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.flpButtons.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1084, 64);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💊  Quản lý Sản phẩm";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblSubTitle.Location = new System.Drawing.Point(18, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(234, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Quản lý toàn bộ danh mục sản phẩm dược";
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.White;
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
            this.panelInput.Controls.Add(this.flpButtons);
            this.panelInput.Location = new System.Drawing.Point(0, 70);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1084, 228);
            this.panelInput.TabIndex = 1;
            // 
            // lblMaSP
            // 
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblMaSP.Location = new System.Drawing.Point(10, 10);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(84, 28);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã SP:";
            this.lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaSP.Location = new System.Drawing.Point(100, 15);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(190, 24);
            this.txtMaSP.TabIndex = 0;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblTenSP.Location = new System.Drawing.Point(10, 50);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(84, 28);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên SP:";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.White;
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenSP.Location = new System.Drawing.Point(100, 55);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(190, 24);
            this.txtTenSP.TabIndex = 1;
            // 
            // lblDonVi
            // 
            this.lblDonVi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblDonVi.Location = new System.Drawing.Point(10, 90);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(84, 28);
            this.lblDonVi.TabIndex = 2;
            this.lblDonVi.Text = "Đơn vị:";
            this.lblDonVi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.White;
            this.txtDonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonViTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDonViTinh.Location = new System.Drawing.Point(100, 95);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(190, 24);
            this.txtDonViTinh.TabIndex = 2;
            // 
            // lblSoDK
            // 
            this.lblSoDK.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSoDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblSoDK.Location = new System.Drawing.Point(10, 130);
            this.lblSoDK.Name = "lblSoDK";
            this.lblSoDK.Size = new System.Drawing.Size(84, 28);
            this.lblSoDK.TabIndex = 3;
            this.lblSoDK.Text = "Số đăng ký:";
            this.lblSoDK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSoDK
            // 
            this.txtSoDK.BackColor = System.Drawing.Color.White;
            this.txtSoDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDK.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSoDK.Location = new System.Drawing.Point(100, 135);
            this.txtSoDK.Name = "txtSoDK";
            this.txtSoDK.Size = new System.Drawing.Size(190, 24);
            this.txtSoDK.TabIndex = 3;
            // 
            // lblThanhPhan
            // 
            this.lblThanhPhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThanhPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblThanhPhan.Location = new System.Drawing.Point(300, 10);
            this.lblThanhPhan.Name = "lblThanhPhan";
            this.lblThanhPhan.Size = new System.Drawing.Size(86, 28);
            this.lblThanhPhan.TabIndex = 4;
            this.lblThanhPhan.Text = "Thành phần:";
            this.lblThanhPhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtThanhPhan
            // 
            this.txtThanhPhan.BackColor = System.Drawing.Color.White;
            this.txtThanhPhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhPhan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtThanhPhan.Location = new System.Drawing.Point(392, 15);
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Size = new System.Drawing.Size(190, 24);
            this.txtThanhPhan.TabIndex = 4;
            // 
            // lblCongDung
            // 
            this.lblCongDung.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCongDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblCongDung.Location = new System.Drawing.Point(300, 50);
            this.lblCongDung.Name = "lblCongDung";
            this.lblCongDung.Size = new System.Drawing.Size(86, 28);
            this.lblCongDung.TabIndex = 5;
            this.lblCongDung.Text = "Công dụng:";
            this.lblCongDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCongDung
            // 
            this.txtCongDung.BackColor = System.Drawing.Color.White;
            this.txtCongDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCongDung.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCongDung.Location = new System.Drawing.Point(392, 55);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(190, 24);
            this.txtCongDung.TabIndex = 5;
            // 
            // lblHDSD
            // 
            this.lblHDSD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHDSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblHDSD.Location = new System.Drawing.Point(300, 90);
            this.lblHDSD.Name = "lblHDSD";
            this.lblHDSD.Size = new System.Drawing.Size(86, 28);
            this.lblHDSD.TabIndex = 6;
            this.lblHDSD.Text = "HDSD:";
            this.lblHDSD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHDSD
            // 
            this.txtHDSD.BackColor = System.Drawing.Color.White;
            this.txtHDSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHDSD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHDSD.Location = new System.Drawing.Point(392, 95);
            this.txtHDSD.Name = "txtHDSD";
            this.txtHDSD.Size = new System.Drawing.Size(190, 24);
            this.txtHDSD.TabIndex = 6;
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblGia.Location = new System.Drawing.Point(300, 130);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(86, 28);
            this.lblGia.TabIndex = 7;
            this.lblGia.Text = "Giá:";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGia.Location = new System.Drawing.Point(392, 135);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(190, 24);
            this.txtGia.TabIndex = 7;
            // 
            // lblSLTon
            // 
            this.lblSLTon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSLTon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblSLTon.Location = new System.Drawing.Point(599, 10);
            this.lblSLTon.Name = "lblSLTon";
            this.lblSLTon.Size = new System.Drawing.Size(59, 28);
            this.lblSLTon.TabIndex = 8;
            this.lblSLTon.Text = "SL tồn:";
            this.lblSLTon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSLTon
            // 
            this.txtSLTon.BackColor = System.Drawing.Color.White;
            this.txtSLTon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSLTon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSLTon.Location = new System.Drawing.Point(664, 15);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(180, 24);
            this.txtSLTon.TabIndex = 8;
            // 
            // lblLoai
            // 
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblLoai.Location = new System.Drawing.Point(599, 50);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(59, 28);
            this.lblLoai.TabIndex = 9;
            this.lblLoai.Text = "Loại SP:";
            this.lblLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.BackColor = System.Drawing.Color.White;
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbLoaiSP.Location = new System.Drawing.Point(664, 55);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(180, 25);
            this.cbLoaiSP.TabIndex = 9;
            // 
            // lblNCC
            // 
            this.lblNCC.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblNCC.Location = new System.Drawing.Point(602, 90);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(56, 28);
            this.lblNCC.TabIndex = 10;
            this.lblNCC.Text = "NCC:";
            this.lblNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbNCC
            // 
            this.cbNCC.BackColor = System.Drawing.Color.White;
            this.cbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNCC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbNCC.Location = new System.Drawing.Point(664, 95);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(180, 25);
            this.cbNCC.TabIndex = 10;
            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(899, 15);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(150, 150);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 11;
            this.picAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(931, 182);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(80, 28);
            this.btnChonAnh.TabIndex = 12;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnThem);
            this.flpButtons.Controls.Add(this.btnSua);
            this.flpButtons.Controls.Add(this.btnXoa);
            this.flpButtons.Controls.Add(this.btnLamMoi);
            this.flpButtons.Location = new System.Drawing.Point(319, 182);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(442, 40);
            this.flpButtons.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "＋ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(108, 0);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✎ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(216, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "✕ Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(324, 0);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(0);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "↺ Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.dgvSanPham);
            this.pnlGrid.Location = new System.Drawing.Point(0, 304);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1084, 307);
            this.pnlGrid.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.lblGridTitle.Location = new System.Drawing.Point(14, 10);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(153, 20);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(12, 38);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1060, 257);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.flpButtons.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvSanPham;
    }
}