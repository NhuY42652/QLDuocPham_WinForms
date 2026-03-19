namespace QLDuocPham_WinForms
{
    partial class frmThongKeDoanhThu
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
            this.pnlFilter = new System.Windows.Forms.Panel();
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
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnXuatPdf = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblTongDon = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNamTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamQuy)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.pnlSummary.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(684, 64);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊  Thống kê Doanh thu";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblSubTitle.Location = new System.Drawing.Point(18, 36);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(232, 15);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Thống kê theo ngày, tháng, quý hoặc năm";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.btnXuatPdf);
            this.pnlFilter.Controls.Add(this.btnThongKe);
            this.pnlFilter.Controls.Add(this.lblKieu);
            this.pnlFilter.Controls.Add(this.cbKieuThongKe);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Controls.Add(this.dtTuNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.dtDenNgay);
            this.pnlFilter.Controls.Add(this.lblThang);
            this.pnlFilter.Controls.Add(this.dtChonThang);
            this.pnlFilter.Controls.Add(this.lblNamTu);
            this.pnlFilter.Controls.Add(this.numNamTu);
            this.pnlFilter.Controls.Add(this.lblNamDen);
            this.pnlFilter.Controls.Add(this.numNamDen);
            this.pnlFilter.Controls.Add(this.lblQuy);
            this.pnlFilter.Controls.Add(this.cbQuy);
            this.pnlFilter.Controls.Add(this.lblNamQuy);
            this.pnlFilter.Controls.Add(this.numNamQuy);
            this.pnlFilter.Controls.Add(this.flpButtons);
            this.pnlFilter.Location = new System.Drawing.Point(0, 70);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(684, 80);
            this.pnlFilter.TabIndex = 2;
            // 
            // lblKieu
            // 
            this.lblKieu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblKieu.Location = new System.Drawing.Point(10, 10);
            this.lblKieu.Name = "lblKieu";
            this.lblKieu.Size = new System.Drawing.Size(100, 28);
            this.lblKieu.TabIndex = 0;
            this.lblKieu.Text = "Kiểu thống kê:";
            this.lblKieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbKieuThongKe
            // 
            this.cbKieuThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKieuThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKieuThongKe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbKieuThongKe.FormattingEnabled = true;
            this.cbKieuThongKe.Items.AddRange(new object[] {
            "Theo ngày",
            "Theo tháng",
            "Theo quý",
            "Theo năm"});
            this.cbKieuThongKe.Location = new System.Drawing.Point(120, 15);
            this.cbKieuThongKe.Name = "cbKieuThongKe";
            this.cbKieuThongKe.Size = new System.Drawing.Size(146, 25);
            this.cbKieuThongKe.TabIndex = 0;
            this.cbKieuThongKe.SelectedIndexChanged += new System.EventHandler(this.cbKieuThongKe_SelectedIndexChanged);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblTuNgay.Location = new System.Drawing.Point(307, 10);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(66, 28);
            this.lblTuNgay.TabIndex = 1;
            this.lblTuNgay.Text = "Từ ngày:";
            this.lblTuNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTuNgay.Location = new System.Drawing.Point(386, 12);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(110, 24);
            this.dtTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblDenNgay.Location = new System.Drawing.Point(301, 38);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(72, 28);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            this.lblDenNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenNgay.Location = new System.Drawing.Point(386, 42);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(110, 24);
            this.dtDenNgay.TabIndex = 2;
            // 
            // lblThang
            // 
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblThang.Location = new System.Drawing.Point(307, 10);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(66, 28);
            this.lblThang.TabIndex = 3;
            this.lblThang.Text = "Tháng:";
            this.lblThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblThang.Visible = false;
            // 
            // dtChonThang
            // 
            this.dtChonThang.CustomFormat = "MM/yyyy";
            this.dtChonThang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtChonThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtChonThang.Location = new System.Drawing.Point(386, 11);
            this.dtChonThang.Name = "dtChonThang";
            this.dtChonThang.ShowUpDown = true;
            this.dtChonThang.Size = new System.Drawing.Size(110, 24);
            this.dtChonThang.TabIndex = 3;
            this.dtChonThang.Visible = false;
            // 
            // lblNamTu
            // 
            this.lblNamTu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNamTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblNamTu.Location = new System.Drawing.Point(307, 10);
            this.lblNamTu.Name = "lblNamTu";
            this.lblNamTu.Size = new System.Drawing.Size(66, 28);
            this.lblNamTu.TabIndex = 4;
            this.lblNamTu.Text = "Từ năm:";
            this.lblNamTu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNamTu.Visible = false;
            // 
            // numNamTu
            // 
            this.numNamTu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numNamTu.Location = new System.Drawing.Point(386, 11);
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
            this.numNamTu.Size = new System.Drawing.Size(110, 24);
            this.numNamTu.TabIndex = 4;
            this.numNamTu.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numNamTu.Visible = false;
            // 
            // lblNamDen
            // 
            this.lblNamDen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNamDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblNamDen.Location = new System.Drawing.Point(301, 38);
            this.lblNamDen.Name = "lblNamDen";
            this.lblNamDen.Size = new System.Drawing.Size(72, 28);
            this.lblNamDen.TabIndex = 5;
            this.lblNamDen.Text = "Đến năm:";
            this.lblNamDen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNamDen.Visible = false;
            // 
            // numNamDen
            // 
            this.numNamDen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numNamDen.Location = new System.Drawing.Point(386, 42);
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
            this.numNamDen.Size = new System.Drawing.Size(110, 24);
            this.numNamDen.TabIndex = 5;
            this.numNamDen.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numNamDen.Visible = false;
            // 
            // lblQuy
            // 
            this.lblQuy.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblQuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblQuy.Location = new System.Drawing.Point(307, 10);
            this.lblQuy.Name = "lblQuy";
            this.lblQuy.Size = new System.Drawing.Size(66, 28);
            this.lblQuy.TabIndex = 6;
            this.lblQuy.Text = "Quý:";
            this.lblQuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuy.Visible = false;
            // 
            // cbQuy
            // 
            this.cbQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbQuy.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbQuy.FormattingEnabled = true;
            this.cbQuy.Items.AddRange(new object[] {
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
            this.cbQuy.Location = new System.Drawing.Point(386, 11);
            this.cbQuy.Name = "cbQuy";
            this.cbQuy.Size = new System.Drawing.Size(110, 25);
            this.cbQuy.TabIndex = 6;
            this.cbQuy.Visible = false;
            // 
            // lblNamQuy
            // 
            this.lblNamQuy.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNamQuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.lblNamQuy.Location = new System.Drawing.Point(301, 38);
            this.lblNamQuy.Name = "lblNamQuy";
            this.lblNamQuy.Size = new System.Drawing.Size(72, 28);
            this.lblNamQuy.TabIndex = 7;
            this.lblNamQuy.Text = "Năm:";
            this.lblNamQuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNamQuy.Visible = false;
            // 
            // numNamQuy
            // 
            this.numNamQuy.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numNamQuy.Location = new System.Drawing.Point(386, 42);
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
            this.numNamQuy.Size = new System.Drawing.Size(110, 24);
            this.numNamQuy.TabIndex = 7;
            this.numNamQuy.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numNamQuy.Visible = false;
            // 
            // flpButtons
            // 
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpButtons.Location = new System.Drawing.Point(542, 39);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(110, 35);
            this.flpButtons.TabIndex = 8;
            this.flpButtons.WrapContents = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(542, 4);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(110, 34);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "🔍 Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXuatPdf
            // 
            this.btnXuatPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnXuatPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatPdf.FlatAppearance.BorderSize = 0;
            this.btnXuatPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatPdf.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXuatPdf.ForeColor = System.Drawing.Color.White;
            this.btnXuatPdf.Location = new System.Drawing.Point(542, 39);
            this.btnXuatPdf.Margin = new System.Windows.Forms.Padding(0);
            this.btnXuatPdf.Name = "btnXuatPdf";
            this.btnXuatPdf.Size = new System.Drawing.Size(110, 34);
            this.btnXuatPdf.TabIndex = 1;
            this.btnXuatPdf.Text = "📄 Xuất PDF";
            this.btnXuatPdf.UseVisualStyleBackColor = false;
            this.btnXuatPdf.Click += new System.EventHandler(this.btnXuatPdf_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.lblGridTitle);
            this.pnlGrid.Controls.Add(this.dgvThongKe);
            this.pnlGrid.Location = new System.Drawing.Point(0, 156);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(684, 300);
            this.pnlGrid.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.lblGridTitle.Location = new System.Drawing.Point(14, 10);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(129, 20);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Kết quả thống kê";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(18, 38);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(654, 245);
            this.dgvThongKe.TabIndex = 0;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.Controls.Add(this.lblTongDon);
            this.pnlSummary.Controls.Add(this.lblTongDoanhThu);
            this.pnlSummary.Location = new System.Drawing.Point(0, 462);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(684, 48);
            this.pnlSummary.TabIndex = 0;
            // 
            // lblTongDon
            // 
            this.lblTongDon.AutoSize = true;
            this.lblTongDon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTongDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lblTongDon.Location = new System.Drawing.Point(15, 14);
            this.lblTongDon.Name = "lblTongDon";
            this.lblTongDon.Size = new System.Drawing.Size(83, 17);
            this.lblTongDon.TabIndex = 0;
            this.lblTongDon.Text = "Tổng đơn: 0";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(307, 14);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(135, 17);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "Tổng doanh thu: 0 đ";
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNamTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNamQuy)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlFilter;
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
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnXuatPdf;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblTongDon;
        private System.Windows.Forms.Label lblTongDoanhThu;
    }
}