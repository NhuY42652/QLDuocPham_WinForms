namespace QLDuocPham_WinForms
{
    partial class frmSanPham
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblNCC = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.lblSLTon = new System.Windows.Forms.Label();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblHDSD = new System.Windows.Forms.Label();
            this.lblCongDung = new System.Windows.Forms.Label();
            this.lblThanhPhan = new System.Windows.Forms.Label();
            this.txtHDSD = new System.Windows.Forms.TextBox();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.txtThanhPhan = new System.Windows.Forms.TextBox();
            this.lblSoDK = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtSoDK = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(430, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.btnLamMoi);
            this.panelInput.Controls.Add(this.btnChonAnh);
            this.panelInput.Controls.Add(this.btnXoa);
            this.panelInput.Controls.Add(this.picAnh);
            this.panelInput.Controls.Add(this.btnSua);
            this.panelInput.Controls.Add(this.lblNCC);
            this.panelInput.Controls.Add(this.btnThem);
            this.panelInput.Controls.Add(this.cbNCC);
            this.panelInput.Controls.Add(this.lblLoai);
            this.panelInput.Controls.Add(this.cbLoaiSP);
            this.panelInput.Controls.Add(this.lblSLTon);
            this.panelInput.Controls.Add(this.txtSLTon);
            this.panelInput.Controls.Add(this.lblGia);
            this.panelInput.Controls.Add(this.txtGia);
            this.panelInput.Controls.Add(this.lblHDSD);
            this.panelInput.Controls.Add(this.lblCongDung);
            this.panelInput.Controls.Add(this.lblThanhPhan);
            this.panelInput.Controls.Add(this.txtHDSD);
            this.panelInput.Controls.Add(this.txtCongDung);
            this.panelInput.Controls.Add(this.txtThanhPhan);
            this.panelInput.Controls.Add(this.lblSoDK);
            this.panelInput.Controls.Add(this.lblDonVi);
            this.panelInput.Controls.Add(this.lblTenSP);
            this.panelInput.Controls.Add(this.lblMaSP);
            this.panelInput.Controls.Add(this.txtSoDK);
            this.panelInput.Controls.Add(this.txtDonViTinh);
            this.panelInput.Controls.Add(this.txtTenSP);
            this.panelInput.Controls.Add(this.txtMaSP);
            this.panelInput.Location = new System.Drawing.Point(50, 80);
            this.panelInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1100, 260);
            this.panelInput.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(567, 201);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 31;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(960, 170);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(80, 30);
            this.btnChonAnh.TabIndex = 26;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(417, 201);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(820, 140);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(100, 100);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 25;
            this.picAnh.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(266, 201);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.Location = new System.Drawing.Point(750, 105);
            this.lblNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(89, 17);
            this.lblNCC.TabIndex = 24;
            this.lblNCC.Text = "Nhà cung cấp";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(135, 201);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbNCC
            // 
            this.cbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(842, 102);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(200, 25);
            this.cbNCC.TabIndex = 23;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(750, 65);
            this.lblLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(50, 17);
            this.lblLoai.TabIndex = 22;
            this.lblLoai.Text = "Loại SP";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(842, 57);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(200, 25);
            this.cbLoaiSP.TabIndex = 21;
            // 
            // lblSLTon
            // 
            this.lblSLTon.AutoSize = true;
            this.lblSLTon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLTon.Location = new System.Drawing.Point(750, 25);
            this.lblSLTon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSLTon.Name = "lblSLTon";
            this.lblSLTon.Size = new System.Drawing.Size(84, 17);
            this.lblSLTon.TabIndex = 20;
            this.lblSLTon.Text = "Số lượng tồn";
            // 
            // txtSLTon
            // 
            this.txtSLTon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTon.Location = new System.Drawing.Point(842, 22);
            this.txtSLTon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(200, 25);
            this.txtSLTon.TabIndex = 19;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(360, 145);
            this.lblGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(27, 17);
            this.lblGia.TabIndex = 18;
            this.lblGia.Text = "Giá";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(460, 140);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(200, 25);
            this.txtGia.TabIndex = 17;
            // 
            // lblHDSD
            // 
            this.lblHDSD.AutoSize = true;
            this.lblHDSD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDSD.Location = new System.Drawing.Point(360, 105);
            this.lblHDSD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHDSD.Name = "lblHDSD";
            this.lblHDSD.Size = new System.Drawing.Size(42, 17);
            this.lblHDSD.TabIndex = 16;
            this.lblHDSD.Text = "HDSD";
            // 
            // lblCongDung
            // 
            this.lblCongDung.AutoSize = true;
            this.lblCongDung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongDung.Location = new System.Drawing.Point(360, 65);
            this.lblCongDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCongDung.Name = "lblCongDung";
            this.lblCongDung.Size = new System.Drawing.Size(73, 17);
            this.lblCongDung.TabIndex = 15;
            this.lblCongDung.Text = "Công dụng";
            // 
            // lblThanhPhan
            // 
            this.lblThanhPhan.AutoSize = true;
            this.lblThanhPhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhPhan.Location = new System.Drawing.Point(360, 25);
            this.lblThanhPhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhPhan.Name = "lblThanhPhan";
            this.lblThanhPhan.Size = new System.Drawing.Size(76, 17);
            this.lblThanhPhan.TabIndex = 14;
            this.lblThanhPhan.Text = "Thành phần";
            // 
            // txtHDSD
            // 
            this.txtHDSD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHDSD.Location = new System.Drawing.Point(460, 100);
            this.txtHDSD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHDSD.Name = "txtHDSD";
            this.txtHDSD.Size = new System.Drawing.Size(200, 25);
            this.txtHDSD.TabIndex = 13;
            // 
            // txtCongDung
            // 
            this.txtCongDung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongDung.Location = new System.Drawing.Point(460, 60);
            this.txtCongDung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(200, 25);
            this.txtCongDung.TabIndex = 12;
            // 
            // txtThanhPhan
            // 
            this.txtThanhPhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhPhan.Location = new System.Drawing.Point(460, 20);
            this.txtThanhPhan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Size = new System.Drawing.Size(200, 25);
            this.txtThanhPhan.TabIndex = 11;
            // 
            // lblSoDK
            // 
            this.lblSoDK.AutoSize = true;
            this.lblSoDK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDK.Location = new System.Drawing.Point(30, 145);
            this.lblSoDK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDK.Name = "lblSoDK";
            this.lblSoDK.Size = new System.Drawing.Size(73, 17);
            this.lblSoDK.TabIndex = 6;
            this.lblSoDK.Text = "Số đăng ký";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonVi.Location = new System.Drawing.Point(30, 105);
            this.lblDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(70, 17);
            this.lblDonVi.TabIndex = 5;
            this.lblDonVi.Text = "Đơn vị tính";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(30, 65);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(89, 17);
            this.lblTenSP.TabIndex = 4;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(30, 25);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(45, 17);
            this.lblMaSP.TabIndex = 2;
            this.lblMaSP.Text = "Mã SP";
            // 
            // txtSoDK
            // 
            this.txtSoDK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDK.Location = new System.Drawing.Point(120, 140);
            this.txtSoDK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoDK.Name = "txtSoDK";
            this.txtSoDK.Size = new System.Drawing.Size(200, 25);
            this.txtSoDK.TabIndex = 3;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(120, 100);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(200, 25);
            this.txtDonViTinh.TabIndex = 2;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(120, 60);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(200, 25);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(120, 20);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(200, 25);
            this.txtMaSP.TabIndex = 0;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(50, 361);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(1100, 276);
            this.dgvSanPham.TabIndex = 2;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtSoDK;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblSoDK;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblHDSD;
        private System.Windows.Forms.Label lblCongDung;
        private System.Windows.Forms.Label lblThanhPhan;
        private System.Windows.Forms.TextBox txtHDSD;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.TextBox txtThanhPhan;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label lblSLTon;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}