namespace QLDuocPham_WinForms
{
    partial class frmDonHang
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlTopGrid = new System.Windows.Forms.Panel();
            this.lblDonHangTitle = new System.Windows.Forms.Label();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.pnlBottomGrid = new System.Windows.Forms.Panel();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlTopGrid.SuspendLayout();
            this.pnlBottomGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
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
            this.lblTitle.Text = "🛒  Quản lý Đơn hàng";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 220);
            this.lblSubTitle.Location = new System.Drawing.Point(18, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text = "Nhấn vào một đơn hàng để xem chi tiết";
            this.pnlTopGrid.BackColor = System.Drawing.Color.White;
            this.pnlTopGrid.Location = new System.Drawing.Point(16, 76);
            this.pnlTopGrid.Name = "pnlTopGrid";
            this.pnlTopGrid.Size = new System.Drawing.Size(940, 230);
            this.pnlTopGrid.Controls.Add(this.lblDonHangTitle);
            this.pnlTopGrid.Controls.Add(this.dgvDonHang);

            this.lblDonHangTitle.AutoSize = true;
            this.lblDonHangTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDonHangTitle.ForeColor = System.Drawing.Color.FromArgb(30, 40, 55);
            this.lblDonHangTitle.Location = new System.Drawing.Point(12, 10);
            this.lblDonHangTitle.Name = "lblDonHangTitle";
            this.lblDonHangTitle.Text = "Danh sách đơn hàng";

            this.dgvDonHang.Location = new System.Drawing.Point(0, 38);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.Size = new System.Drawing.Size(940, 192);
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.RowHeadersVisible = false;
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.AllowUserToDeleteRows = false;
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonHang.TabIndex = 0;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);

            this.pnlBottomGrid.BackColor = System.Drawing.Color.White;
            this.pnlBottomGrid.Location = new System.Drawing.Point(16, 318);
            this.pnlBottomGrid.Name = "pnlBottomGrid";
            this.pnlBottomGrid.Size = new System.Drawing.Size(940, 220);
            this.pnlBottomGrid.Controls.Add(this.lblChiTiet);
            this.pnlBottomGrid.Controls.Add(this.dgvChiTietDonHang);

            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChiTiet.ForeColor = System.Drawing.Color.FromArgb(30, 40, 55);
            this.lblChiTiet.Location = new System.Drawing.Point(12, 10);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Text = "Chi tiết đơn hàng";

            this.dgvChiTietDonHang.Location = new System.Drawing.Point(0, 38);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(940, 182);
            this.dgvChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonHang.RowHeadersVisible = false;
            this.dgvChiTietDonHang.AllowUserToAddRows = false;
            this.dgvChiTietDonHang.AllowUserToDeleteRows = false;
            this.dgvChiTietDonHang.ReadOnly = true;
            this.dgvChiTietDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietDonHang.TabIndex = 1;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(972, 554);
            this.Controls.Add(this.pnlBottomGrid);
            this.Controls.Add(this.pnlTopGrid);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn hàng";
            this.Load += new System.EventHandler(this.frmDonHang_Load);
            this.pnlHeader.ResumeLayout(false); this.pnlHeader.PerformLayout();
            this.pnlTopGrid.ResumeLayout(false); this.pnlTopGrid.PerformLayout();
            this.pnlBottomGrid.ResumeLayout(false); this.pnlBottomGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlTopGrid;
        private System.Windows.Forms.Label lblDonHangTitle;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Panel pnlBottomGrid;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
    }
}