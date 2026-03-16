namespace QLDuocPham_WinForms
{
    partial class frmMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblMenuSep = new System.Windows.Forms.Label();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnLoai = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblDashSub = new System.Windows.Forms.Label();
            this.panelSP = new System.Windows.Forms.Panel();
            this.lblSPTitle = new System.Windows.Forms.Label();
            this.lblTongSP = new System.Windows.Forms.Label();
            this.panelNCC = new System.Windows.Forms.Panel();
            this.lblNCCTitle = new System.Windows.Forms.Label();
            this.lblTongNCC = new System.Windows.Forms.Label();
            this.panelLoai = new System.Windows.Forms.Panel();
            this.lblLoaiTitle = new System.Windows.Forms.Label();
            this.lblTongLoai = new System.Windows.Forms.Label();
            this.panelDanhMuc = new System.Windows.Forms.Panel();
            this.lblDanhMucTitle = new System.Windows.Forms.Label();
            this.lblTongDanhMuc = new System.Windows.Forms.Label();
            this.panelKhachHang = new System.Windows.Forms.Panel();
            this.lblKhachHangTitle = new System.Windows.Forms.Label();
            this.lblTongKH = new System.Windows.Forms.Label();
            this.panelDonHang = new System.Windows.Forms.Panel();
            this.lblDonHangTitle = new System.Windows.Forms.Label();
            this.lblTongDonHang = new System.Windows.Forms.Label();
            this.panelTon = new System.Windows.Forms.Panel();
            this.lblTonTitle = new System.Windows.Forms.Label();
            this.lblTonKho = new System.Windows.Forms.Label();

            this.panelMenu.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelSP.SuspendLayout();
            this.panelNCC.SuspendLayout();
            this.panelLoai.SuspendLayout();
            this.panelDanhMuc.SuspendLayout();
            this.panelKhachHang.SuspendLayout();
            this.panelDonHang.SuspendLayout();
            this.panelTon.SuspendLayout();
            this.SuspendLayout();

            // ── SIDEBAR ───────────────────────────────────────────────────────
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Width = 220;
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Controls.Add(this.lblSystem);
            this.panelMenu.Controls.Add(this.lblMenuSep);
            this.panelMenu.Controls.Add(this.btnSanPham);
            this.panelMenu.Controls.Add(this.btnNCC);
            this.panelMenu.Controls.Add(this.btnLoai);
            this.panelMenu.Controls.Add(this.btnDanhMuc);
            this.panelMenu.Controls.Add(this.btnKhachHang);
            this.panelMenu.Controls.Add(this.btnDonHang);
            this.panelMenu.Controls.Add(this.btnThoat);

            this.lblSystem.AutoSize = false;
            this.lblSystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSystem.ForeColor = System.Drawing.Color.White;
            this.lblSystem.Location = new System.Drawing.Point(14, 16);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(192, 44);
            this.lblSystem.Text = "QL Dược Phẩm";
            this.lblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblMenuSep.AutoSize = true;
            this.lblMenuSep.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblMenuSep.ForeColor = System.Drawing.Color.FromArgb(100, 140, 180);
            this.lblMenuSep.Location = new System.Drawing.Point(16, 70);
            this.lblMenuSep.Name = "lblMenuSep";
            this.lblMenuSep.Text = "QUẢN LÝ";

            // btnSanPham
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSanPham.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220);
            this.btnSanPham.Location = new System.Drawing.Point(0, 92);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnSanPham.Size = new System.Drawing.Size(220, 42);
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);

            // btnNCC
            this.btnNCC.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNCC.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220);
            this.btnNCC.Location = new System.Drawing.Point(0, 136);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnNCC.Size = new System.Drawing.Size(220, 42);
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.UseVisualStyleBackColor = false;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);

            // btnLoai
            this.btnLoai.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.btnLoai.FlatAppearance.BorderSize = 0;
            this.btnLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLoai.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220);
            this.btnLoai.Location = new System.Drawing.Point(0, 180);
            this.btnLoai.Name = "btnLoai";
            this.btnLoai.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnLoai.Size = new System.Drawing.Size(220, 42);
            this.btnLoai.Text = "Loại sản phẩm";
            this.btnLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoai.UseVisualStyleBackColor = false;
            this.btnLoai.Click += new System.EventHandler(this.btnLoai_Click);

            // btnDanhMuc
            this.btnDanhMuc.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDanhMuc.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220);
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 224);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(220, 42);
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);

            // btnKhachHang
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220);
            this.btnKhachHang.Location = new System.Drawing.Point(0, 268);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(220, 42);
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);

            // btnDonHang
            this.btnDonHang.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.btnDonHang.FlatAppearance.BorderSize = 0;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDonHang.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220);
            this.btnDonHang.Location = new System.Drawing.Point(0, 312);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnDonHang.Size = new System.Drawing.Size(220, 42);
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.UseVisualStyleBackColor = false;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);

            // btnThoat
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnThoat.Location = new System.Drawing.Point(0, 532);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(220, 42);
            this.btnThoat.Text = "Đăng xuất";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // ── DASHBOARD ─────────────────────────────────────────────────────
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Controls.Add(this.lblDashboard);
            this.panelDashboard.Controls.Add(this.lblDashSub);
            this.panelDashboard.Controls.Add(this.panelSP);
            this.panelDashboard.Controls.Add(this.panelNCC);
            this.panelDashboard.Controls.Add(this.panelLoai);
            this.panelDashboard.Controls.Add(this.panelDanhMuc);
            this.panelDashboard.Controls.Add(this.panelKhachHang);
            this.panelDashboard.Controls.Add(this.panelDonHang);
            this.panelDashboard.Controls.Add(this.panelTon);

            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblDashboard.Location = new System.Drawing.Point(28, 26);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Text = "Dashboard";

            this.lblDashSub.AutoSize = true;
            this.lblDashSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDashSub.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblDashSub.Location = new System.Drawing.Point(30, 62);
            this.lblDashSub.Name = "lblDashSub";
            this.lblDashSub.Text = "Tổng quan hệ thống quản lý dược phẩm";

            // ── CARDS (210x110) — Row1 y=96, Row2 y=218, Cols x=28,248,468,688
            // panelSP
            this.panelSP.BackColor = System.Drawing.Color.White;
            this.panelSP.Location = new System.Drawing.Point(28, 96);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(210, 110);
            this.panelSP.Controls.Add(this.lblSPTitle);
            this.panelSP.Controls.Add(this.lblTongSP);

            this.lblSPTitle.AutoSize = false;
            this.lblSPTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSPTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblSPTitle.Location = new System.Drawing.Point(16, 18);
            this.lblSPTitle.Name = "lblSPTitle";
            this.lblSPTitle.Size = new System.Drawing.Size(178, 20);
            this.lblSPTitle.Text = "Sản phẩm";

            this.lblTongSP.AutoSize = false;
            this.lblTongSP.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTongSP.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTongSP.Location = new System.Drawing.Point(14, 42);
            this.lblTongSP.Name = "lblTongSP";
            this.lblTongSP.Size = new System.Drawing.Size(178, 54);
            this.lblTongSP.Text = "0";

            // panelNCC
            this.panelNCC.BackColor = System.Drawing.Color.White;
            this.panelNCC.Location = new System.Drawing.Point(248, 96);
            this.panelNCC.Name = "panelNCC";
            this.panelNCC.Size = new System.Drawing.Size(210, 110);
            this.panelNCC.Controls.Add(this.lblNCCTitle);
            this.panelNCC.Controls.Add(this.lblTongNCC);

            this.lblNCCTitle.AutoSize = false;
            this.lblNCCTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNCCTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblNCCTitle.Location = new System.Drawing.Point(16, 18);
            this.lblNCCTitle.Name = "lblNCCTitle";
            this.lblNCCTitle.Size = new System.Drawing.Size(178, 20);
            this.lblNCCTitle.Text = "Nhà cung cấp";

            this.lblTongNCC.AutoSize = false;
            this.lblTongNCC.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTongNCC.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTongNCC.Location = new System.Drawing.Point(14, 42);
            this.lblTongNCC.Name = "lblTongNCC";
            this.lblTongNCC.Size = new System.Drawing.Size(178, 54);
            this.lblTongNCC.Text = "0";

            // panelLoai
            this.panelLoai.BackColor = System.Drawing.Color.White;
            this.panelLoai.Location = new System.Drawing.Point(468, 96);
            this.panelLoai.Name = "panelLoai";
            this.panelLoai.Size = new System.Drawing.Size(210, 110);
            this.panelLoai.Controls.Add(this.lblLoaiTitle);
            this.panelLoai.Controls.Add(this.lblTongLoai);

            this.lblLoaiTitle.AutoSize = false;
            this.lblLoaiTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblLoaiTitle.Location = new System.Drawing.Point(16, 18);
            this.lblLoaiTitle.Name = "lblLoaiTitle";
            this.lblLoaiTitle.Size = new System.Drawing.Size(178, 20);
            this.lblLoaiTitle.Text = "Loại sản phẩm";

            this.lblTongLoai.AutoSize = false;
            this.lblTongLoai.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTongLoai.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTongLoai.Location = new System.Drawing.Point(14, 42);
            this.lblTongLoai.Name = "lblTongLoai";
            this.lblTongLoai.Size = new System.Drawing.Size(178, 54);
            this.lblTongLoai.Text = "0";

            // panelDanhMuc
            this.panelDanhMuc.BackColor = System.Drawing.Color.White;
            this.panelDanhMuc.Location = new System.Drawing.Point(688, 96);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(210, 110);
            this.panelDanhMuc.Controls.Add(this.lblDanhMucTitle);
            this.panelDanhMuc.Controls.Add(this.lblTongDanhMuc);

            this.lblDanhMucTitle.AutoSize = false;
            this.lblDanhMucTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDanhMucTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblDanhMucTitle.Location = new System.Drawing.Point(16, 18);
            this.lblDanhMucTitle.Name = "lblDanhMucTitle";
            this.lblDanhMucTitle.Size = new System.Drawing.Size(178, 20);
            this.lblDanhMucTitle.Text = "Danh mục";

            this.lblTongDanhMuc.AutoSize = false;
            this.lblTongDanhMuc.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTongDanhMuc.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTongDanhMuc.Location = new System.Drawing.Point(14, 42);
            this.lblTongDanhMuc.Name = "lblTongDanhMuc";
            this.lblTongDanhMuc.Size = new System.Drawing.Size(178, 54);
            this.lblTongDanhMuc.Text = "0";

            // panelKhachHang
            this.panelKhachHang.BackColor = System.Drawing.Color.White;
            this.panelKhachHang.Location = new System.Drawing.Point(28, 218);
            this.panelKhachHang.Name = "panelKhachHang";
            this.panelKhachHang.Size = new System.Drawing.Size(210, 110);
            this.panelKhachHang.Controls.Add(this.lblKhachHangTitle);
            this.panelKhachHang.Controls.Add(this.lblTongKH);

            this.lblKhachHangTitle.AutoSize = false;
            this.lblKhachHangTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhachHangTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblKhachHangTitle.Location = new System.Drawing.Point(16, 18);
            this.lblKhachHangTitle.Name = "lblKhachHangTitle";
            this.lblKhachHangTitle.Size = new System.Drawing.Size(178, 20);
            this.lblKhachHangTitle.Text = "Khách hàng";

            this.lblTongKH.AutoSize = false;
            this.lblTongKH.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTongKH.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTongKH.Location = new System.Drawing.Point(14, 42);
            this.lblTongKH.Name = "lblTongKH";
            this.lblTongKH.Size = new System.Drawing.Size(178, 54);
            this.lblTongKH.Text = "0";

            // panelDonHang
            this.panelDonHang.BackColor = System.Drawing.Color.White;
            this.panelDonHang.Location = new System.Drawing.Point(248, 218);
            this.panelDonHang.Name = "panelDonHang";
            this.panelDonHang.Size = new System.Drawing.Size(210, 110);
            this.panelDonHang.Controls.Add(this.lblDonHangTitle);
            this.panelDonHang.Controls.Add(this.lblTongDonHang);

            this.lblDonHangTitle.AutoSize = false;
            this.lblDonHangTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDonHangTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblDonHangTitle.Location = new System.Drawing.Point(16, 18);
            this.lblDonHangTitle.Name = "lblDonHangTitle";
            this.lblDonHangTitle.Size = new System.Drawing.Size(178, 20);
            this.lblDonHangTitle.Text = "Đơn hàng";

            this.lblTongDonHang.AutoSize = false;
            this.lblTongDonHang.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTongDonHang.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTongDonHang.Location = new System.Drawing.Point(14, 42);
            this.lblTongDonHang.Name = "lblTongDonHang";
            this.lblTongDonHang.Size = new System.Drawing.Size(178, 54);
            this.lblTongDonHang.Text = "0";

            // panelTon
            this.panelTon.BackColor = System.Drawing.Color.White;
            this.panelTon.Location = new System.Drawing.Point(468, 218);
            this.panelTon.Name = "panelTon";
            this.panelTon.Size = new System.Drawing.Size(210, 110);
            this.panelTon.Controls.Add(this.lblTonTitle);
            this.panelTon.Controls.Add(this.lblTonKho);

            this.lblTonTitle.AutoSize = false;
            this.lblTonTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTonTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 145);
            this.lblTonTitle.Location = new System.Drawing.Point(16, 18);
            this.lblTonTitle.Name = "lblTonTitle";
            this.lblTonTitle.Size = new System.Drawing.Size(178, 20);
            this.lblTonTitle.Text = "Tồn kho";

            this.lblTonKho.AutoSize = false;
            this.lblTonKho.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTonKho.ForeColor = System.Drawing.Color.FromArgb(26, 58, 92);
            this.lblTonKho.Location = new System.Drawing.Point(14, 42);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(178, 54);
            this.lblTonKho.Text = "0";

            // ── FORM ──────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý dược phẩm";
            this.Load += new System.EventHandler(this.frmMain_Load);

            this.panelSP.ResumeLayout(false);
            this.panelNCC.ResumeLayout(false);
            this.panelLoai.ResumeLayout(false);
            this.panelDanhMuc.ResumeLayout(false);
            this.panelKhachHang.ResumeLayout(false);
            this.panelDonHang.ResumeLayout(false);
            this.panelTon.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblMenuSep;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnLoai;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblDashSub;
        private System.Windows.Forms.Panel panelSP;
        private System.Windows.Forms.Label lblSPTitle;
        private System.Windows.Forms.Label lblTongSP;
        private System.Windows.Forms.Panel panelNCC;
        private System.Windows.Forms.Label lblNCCTitle;
        private System.Windows.Forms.Label lblTongNCC;
        private System.Windows.Forms.Panel panelLoai;
        private System.Windows.Forms.Label lblLoaiTitle;
        private System.Windows.Forms.Label lblTongLoai;
        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Label lblDanhMucTitle;
        private System.Windows.Forms.Label lblTongDanhMuc;
        private System.Windows.Forms.Panel panelKhachHang;
        private System.Windows.Forms.Label lblKhachHangTitle;
        private System.Windows.Forms.Label lblTongKH;
        private System.Windows.Forms.Panel panelDonHang;
        private System.Windows.Forms.Label lblDonHangTitle;
        private System.Windows.Forms.Label lblTongDonHang;
        private System.Windows.Forms.Panel panelTon;
        private System.Windows.Forms.Label lblTonTitle;
        private System.Windows.Forms.Label lblTonKho;
    }
}