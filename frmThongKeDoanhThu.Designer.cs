namespace QLDuocPham_WinForms
{
    partial class frmThongKeDoanhThu
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
            this.lblKieu = new System.Windows.Forms.Label();
            this.cbKieuThongKe = new System.Windows.Forms.ComboBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblThang = new System.Windows.Forms.Label();
            this.dtChonThang = new System.Windows.Forms.DateTimePicker();
            this.lblNamTu = new System.Windows.Forms.Label();
            this.numNamTu = new System.Windows.Forms.NumericUpDown();
            this.lblNamDen = new System.Windows.Forms.Label();
            this.numNamDen = new System.Windows.Forms.NumericUpDown();
            this.lblQuy = new System.Windows.Forms.Label();
            this.cbQuy = new System.Windows.Forms.ComboBox();
            this.lblNamQuy = new System.Windows.Forms.Label();
            this.numNamQuy = new System.Windows.Forms.NumericUpDown();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnXuatPdf = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.lblTongDon = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNamTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKieu
            // 
            this.lblKieu.AutoSize = true;
            this.lblKieu.Location = new System.Drawing.Point(24, 21);
            this.lblKieu.Name = "lblKieu";
            this.lblKieu.Size = new System.Drawing.Size(81, 13);
            this.lblKieu.TabIndex = 0;
            this.lblKieu.Text = "Kiểu thống kê";
            // 
            // cbKieuThongKe
            // 
            this.cbKieuThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKieuThongKe.FormattingEnabled = true;
            this.cbKieuThongKe.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tháng",
            "Theo quý",
            "Theo năm"});
            this.cbKieuThongKe.Location = new System.Drawing.Point(111, 18);
            this.cbKieuThongKe.Name = "cbKieuThongKe";
            this.cbKieuThongKe.Size = new System.Drawing.Size(173, 21);
            this.cbKieuThongKe.TabIndex = 1;
            this.cbKieuThongKe.SelectedIndexChanged += new System.EventHandler(this.cbKieuThongKe_SelectedIndexChanged);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(307, 21);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(45, 13);
            this.lblTuNgay.TabIndex = 2;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTuNgay.Location = new System.Drawing.Point(358, 18);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(98, 20);
            this.dtTuNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(474, 21);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(52, 13);
            this.lblDenNgay.TabIndex = 4;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenNgay.Location = new System.Drawing.Point(532, 18);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(98, 20);
            this.dtDenNgay.TabIndex = 5;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(307, 21);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(40, 13);
            this.lblThang.TabIndex = 10;
            this.lblThang.Text = "Tháng";
            // 
            // dtChonThang
            // 
            this.dtChonThang.CustomFormat = "MM/yyyy";
            this.dtChonThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtChonThang.Location = new System.Drawing.Point(358, 18);
            this.dtChonThang.Name = "dtChonThang";
            this.dtChonThang.ShowUpDown = true;
            this.dtChonThang.Size = new System.Drawing.Size(98, 20);
            this.dtChonThang.TabIndex = 11;
            // 
            // lblNamTu
            // 
            this.lblNamTu.AutoSize = true;
            this.lblNamTu.Location = new System.Drawing.Point(307, 21);
            this.lblNamTu.Name = "lblNamTu";
            this.lblNamTu.Size = new System.Drawing.Size(45, 13);
            this.lblNamTu.TabIndex = 12;
            this.lblNamTu.Text = "Từ năm";
            // 
            // numNamTu
            // 
            this.numNamTu.Location = new System.Drawing.Point(358, 18);
            this.numNamTu.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numNamTu.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNamTu.Name = "numNamTu";
            this.numNamTu.Size = new System.Drawing.Size(98, 20);
            this.numNamTu.TabIndex = 13;
            this.numNamTu.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblNamDen
            // 
            this.lblNamDen.AutoSize = true;
            this.lblNamDen.Location = new System.Drawing.Point(474, 21);
            this.lblNamDen.Name = "lblNamDen";
            this.lblNamDen.Size = new System.Drawing.Size(52, 13);
            this.lblNamDen.TabIndex = 14;
            this.lblNamDen.Text = "Đến năm";
            // 
            // numNamDen
            // 
            this.numNamDen.Location = new System.Drawing.Point(532, 18);
            this.numNamDen.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numNamDen.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNamDen.Name = "numNamDen";
            this.numNamDen.Size = new System.Drawing.Size(98, 20);
            this.numNamDen.TabIndex = 15;
            this.numNamDen.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblQuy
            // 
            this.lblQuy.AutoSize = true;
            this.lblQuy.Location = new System.Drawing.Point(307, 21);
            this.lblQuy.Name = "lblQuy";
            this.lblQuy.Size = new System.Drawing.Size(26, 13);
            this.lblQuy.TabIndex = 16;
            this.lblQuy.Text = "Quý";
            // 
            // cbQuy
            // 
            this.cbQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuy.FormattingEnabled = true;
            this.cbQuy.Items.AddRange(new object[] {
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
            this.cbQuy.Location = new System.Drawing.Point(358, 18);
            this.cbQuy.Name = "cbQuy";
            this.cbQuy.Size = new System.Drawing.Size(98, 21);
            this.cbQuy.TabIndex = 17;
            // 
            // lblNamQuy
            // 
            this.lblNamQuy.AutoSize = true;
            this.lblNamQuy.Location = new System.Drawing.Point(487, 21);
            this.lblNamQuy.Name = "lblNamQuy";
            this.lblNamQuy.Size = new System.Drawing.Size(29, 13);
            this.lblNamQuy.TabIndex = 18;
            this.lblNamQuy.Text = "Năm";
            // 
            // numNamQuy
            // 
            this.numNamQuy.Location = new System.Drawing.Point(532, 18);
            this.numNamQuy.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numNamQuy.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNamQuy.Name = "numNamQuy";
            this.numNamQuy.Size = new System.Drawing.Size(98, 20);
            this.numNamQuy.TabIndex = 19;
            this.numNamQuy.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(648, 16);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(116, 24);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXuatPdf
            // 
            this.btnXuatPdf.Location = new System.Drawing.Point(648, 44);
            this.btnXuatPdf.Name = "btnXuatPdf";
            this.btnXuatPdf.Size = new System.Drawing.Size(116, 24);
            this.btnXuatPdf.TabIndex = 20;
            this.btnXuatPdf.Text = "Xuất PDF";
            this.btnXuatPdf.UseVisualStyleBackColor = true;
            this.btnXuatPdf.Click += new System.EventHandler(this.btnXuatPdf_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(27, 62);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.Size = new System.Drawing.Size(737, 340);
            this.dgvThongKe.TabIndex = 7;
            // 
            // lblTongDon
            // 
            this.lblTongDon.AutoSize = true;
            this.lblTongDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTongDon.Location = new System.Drawing.Point(24, 418);
            this.lblTongDon.Name = "lblTongDon";
            this.lblTongDon.Size = new System.Drawing.Size(78, 16);
            this.lblTongDon.TabIndex = 8;
            this.lblTongDon.Text = "Tổng đơn:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.Location = new System.Drawing.Point(250, 418);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(118, 16);
            this.lblTongDoanhThu.TabIndex = 9;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 454);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.lblTongDon);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.btnXuatPdf);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.numNamQuy);
            this.Controls.Add(this.lblNamQuy);
            this.Controls.Add(this.cbQuy);
            this.Controls.Add(this.lblQuy);
            this.Controls.Add(this.numNamDen);
            this.Controls.Add(this.lblNamDen);
            this.Controls.Add(this.numNamTu);
            this.Controls.Add(this.lblNamTu);
            this.Controls.Add(this.dtChonThang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.cbKieuThongKe);
            this.Controls.Add(this.lblKieu);
            this.Name = "frmThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNamTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKieu;
        private System.Windows.Forms.ComboBox cbKieuThongKe;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.DateTimePicker dtChonThang;
        private System.Windows.Forms.Label lblNamTu;
        private System.Windows.Forms.NumericUpDown numNamTu;
        private System.Windows.Forms.Label lblNamDen;
        private System.Windows.Forms.NumericUpDown numNamDen;
        private System.Windows.Forms.Label lblQuy;
        private System.Windows.Forms.ComboBox cbQuy;
        private System.Windows.Forms.Label lblNamQuy;
        private System.Windows.Forms.NumericUpDown numNamQuy;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnXuatPdf;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label lblTongDon;
        private System.Windows.Forms.Label lblTongDoanhThu;
    }
}
