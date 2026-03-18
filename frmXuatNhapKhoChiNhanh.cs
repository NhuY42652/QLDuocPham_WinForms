using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    public partial class frmXuatNhapKhoChiNhanh : Form
    {
        private readonly DataTable _dtChiTietTam = new DataTable();

        public frmXuatNhapKhoChiNhanh()
        {
            InitializeComponent();
            KhoiTaoBangChiTietTam();
        }

        private void frmXuatNhapKhoChiNhanh_Load(object sender, EventArgs e)
        {
            try
            {
                LoadChiNhanh();
                LoadSanPham();
                cbLoaiPhieu.SelectedIndex = 0;
                dtNgayGiaoDich.Value = DateTime.Now;
                dgvChiTietTam.DataSource = _dtChiTietTam;
                CauHinhLuoiTam();
                LoadDanhSachPhieu();
                LoadTonKho();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Thiếu cấu trúc CSDL mới cho phiếu nhiều sản phẩm. Vui lòng chạy lại script scripts/20260317_branch_inventory.sql.",
                    "Thiếu cấu trúc CSDL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void KhoiTaoBangChiTietTam()
        {
            _dtChiTietTam.Columns.Add("MaSP", typeof(int));
            _dtChiTietTam.Columns.Add("Tên sản phẩm", typeof(string));
            _dtChiTietTam.Columns.Add("Đơn vị tính", typeof(string));
            _dtChiTietTam.Columns.Add("Giá", typeof(decimal));
            _dtChiTietTam.Columns.Add("Số lượng", typeof(int));
            _dtChiTietTam.Columns.Add("Thành tiền", typeof(decimal), "[Giá] * [Số lượng]");
            _dtChiTietTam.Columns.Add("Ghi chú", typeof(string));
        }

        private void LoadChiNhanh()
        {
            using (SqlConnection conn = Database.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT MaCN, TenCN FROM ChiNhanh ORDER BY TenCN", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbChiNhanh.DataSource = dt;
                cbChiNhanh.DisplayMember = "TenCN";
                cbChiNhanh.ValueMember = "MaCN";
            }
        }

        private void LoadSanPham()
        {
            using (SqlConnection conn = Database.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT MaSP, TenSP, DonViTinh, Gia FROM SanPham ORDER BY TenSP",
                conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbSanPham.DataSource = dt;
                cbSanPham.DisplayMember = "TenSP";
                cbSanPham.ValueMember = "MaSP";
            }
        }

        private void LoadTonKho()
        {
            using (SqlConnection conn = Database.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT tk.MaCN, cn.TenCN AS [Chi nhánh], tk.MaSP, sp.TenSP AS [Sản phẩm], tk.SoLuongTon AS [Số lượng tồn]
                  FROM TonKhoChiNhanh tk
                  JOIN ChiNhanh cn ON tk.MaCN = cn.MaCN
                  JOIN SanPham sp ON tk.MaSP = sp.MaSP
                  ORDER BY cn.TenCN, sp.TenSP", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTonKho.DataSource = dt;
            }
        }

        private void CauHinhLuoiTam()
        {
            if (dgvChiTietTam.Columns["MaSP"] != null)
            {
                dgvChiTietTam.Columns["MaSP"].Visible = false;
            }
        }

        private void LoadDanhSachPhieu()
        {
            using (SqlConnection conn = Database.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT p.MaPhieu AS [Mã phiếu],
                         FORMAT(p.NgayGiaoDich, 'dd/MM/yyyy HH:mm') AS [Ngày giờ],
                         CASE WHEN p.LoaiPhieu = 'N' THEN N'Nhập' ELSE N'Xuất' END AS [Loại phiếu],
                         cn.TenCN AS [Chi nhánh],
                         p.NguoiXuat AS [Người giao],
                         p.NguoiNhan AS [Người nhận],
                         p.NoiNhan AS [Nơi nhận],
                         p.KhoNguon AS [Lấy từ kho],
                         COUNT(ct.MaSP) AS [Số mặt hàng],
                         ISNULL(SUM(ct.SoLuong), 0) AS [Tổng số lượng],
                         ISNULL(SUM(ct.SoLuong * ct.DonGia), 0) AS [Tổng tiền],
                         p.GhiChu AS [Ghi chú]
                  FROM PhieuXuatNhapChiNhanh p
                  JOIN ChiNhanh cn ON p.MaCN = cn.MaCN
                  LEFT JOIN ChiTietPhieuXuatNhapChiNhanh ct ON p.MaPhieu = ct.MaPhieu
                  GROUP BY p.MaPhieu, p.NgayGiaoDich, p.LoaiPhieu, cn.TenCN, p.NguoiXuat, p.NguoiNhan, p.NoiNhan, p.KhoNguon, p.GhiChu
                  ORDER BY p.NgayGiaoDich DESC, p.MaPhieu DESC", conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDanhSachPhieu.DataSource = dt;
            }

            if (dgvDanhSachPhieu.Rows.Count > 0)
            {
                dgvDanhSachPhieu.Rows[0].Selected = true;
                LoadChiTietPhieuDaChon();
            }
            else
            {
                dgvChiTietPhieuDaLuu.DataSource = null;
            }
        }

        private void LoadChiTietPhieuDaChon()
        {
            if (dgvDanhSachPhieu.CurrentRow == null)
            {
                dgvChiTietPhieuDaLuu.DataSource = null;
                return;
            }

            long maPhieu = Convert.ToInt64(dgvDanhSachPhieu.CurrentRow.Cells["Mã phiếu"].Value);
            using (SqlConnection conn = Database.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT ROW_NUMBER() OVER (ORDER BY sp.TenSP) AS [STT],
                         sp.TenSP AS [Tên sản phẩm],
                         ct.SoLuong AS [Số lượng],
                         sp.DonViTinh AS [Đơn vị tính],
                         ct.DonGia AS [Giá],
                         ct.SoLuong * ct.DonGia AS [Thành tiền],
                         ct.GhiChu AS [Ghi chú]
                  FROM ChiTietPhieuXuatNhapChiNhanh ct
                  JOIN SanPham sp ON ct.MaSP = sp.MaSP
                  WHERE ct.MaPhieu = @MaPhieu
                  ORDER BY sp.TenSP", conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@MaPhieu", maPhieu);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvChiTietPhieuDaLuu.DataSource = dt;
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (cbSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRowView sanPham = cbSanPham.SelectedItem as DataRowView;
            if (sanPham == null)
            {
                return;
            }

            int maSP = Convert.ToInt32(sanPham["MaSP"]);
            DataRow rowTonTai = null;
            foreach (DataRow row in _dtChiTietTam.Rows)
            {
                if (Convert.ToInt32(row["MaSP"]) == maSP)
                {
                    rowTonTai = row;
                    break;
                }
            }

            if (rowTonTai == null)
            {
                DataRow rowMoi = _dtChiTietTam.NewRow();
                rowMoi["MaSP"] = maSP;
                rowMoi["Tên sản phẩm"] = sanPham["TenSP"].ToString();
                rowMoi["Đơn vị tính"] = sanPham["DonViTinh"] == DBNull.Value ? string.Empty : sanPham["DonViTinh"].ToString();
                rowMoi["Giá"] = sanPham["Gia"] == DBNull.Value ? 0m : Convert.ToDecimal(sanPham["Gia"]);
                rowMoi["Số lượng"] = Convert.ToInt32(numSoLuong.Value);
                rowMoi["Ghi chú"] = txtGhiChuChiTiet.Text.Trim();
                _dtChiTietTam.Rows.Add(rowMoi);
            }
            else
            {
                rowTonTai["Số lượng"] = Convert.ToInt32(rowTonTai["Số lượng"]) + Convert.ToInt32(numSoLuong.Value);
                if (!string.IsNullOrWhiteSpace(txtGhiChuChiTiet.Text))
                {
                    rowTonTai["Ghi chú"] = txtGhiChuChiTiet.Text.Trim();
                }
            }

            txtGhiChuChiTiet.Clear();
            numSoLuong.Value = 1;
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvChiTietTam.CurrentRow == null)
            {
                return;
            }

            dgvChiTietTam.Rows.RemoveAt(dgvChiTietTam.CurrentRow.Index);
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (cbChiNhanh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_dtChiTietTam.Rows.Count == 0)
            {
                MessageBox.Show("Một phiếu phải có ít nhất 1 sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiXuat.Text)
                || string.IsNullOrWhiteSpace(txtNguoiNhan.Text)
                || string.IsNullOrWhiteSpace(txtNoiNhan.Text)
                || string.IsNullOrWhiteSpace(txtKhoNguon.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đủ Người xuất, Người nhận, Nơi nhận và Kho nguồn.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string maCN = cbChiNhanh.SelectedValue.ToString();
            string loaiPhieu = cbLoaiPhieu.Text == "Nhập" ? "N" : "X";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();

                try
                {
                    long maPhieu = TaoPhieu(conn, tx, maCN, loaiPhieu);

                    foreach (DataRow row in _dtChiTietTam.Rows)
                    {
                        int maSP = Convert.ToInt32(row["MaSP"]);
                        int soLuong = Convert.ToInt32(row["Số lượng"]);
                        decimal donGia = Convert.ToDecimal(row["Giá"]);
                        string ghiChu = row["Ghi chú"] == DBNull.Value ? string.Empty : row["Ghi chú"].ToString();

                        using (SqlCommand cmd = new SqlCommand(
                            @"INSERT INTO ChiTietPhieuXuatNhapChiNhanh(MaPhieu, MaSP, SoLuong, DonGia, GhiChu)
                              VALUES(@MaPhieu, @MaSP, @SoLuong, @DonGia, @GhiChu)", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                            cmd.Parameters.AddWithValue("@MaSP", maSP);
                            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmd.Parameters.AddWithValue("@DonGia", donGia);
                            cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrWhiteSpace(ghiChu) ? (object)DBNull.Value : ghiChu);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand(
                            @"IF EXISTS (SELECT 1 FROM TonKhoChiNhanh WHERE MaCN=@MaCN AND MaSP=@MaSP)
                                  UPDATE TonKhoChiNhanh
                                  SET SoLuongTon = SoLuongTon + CASE WHEN @Loai='N' THEN @SoLuong ELSE -@SoLuong END
                                  WHERE MaCN=@MaCN AND MaSP=@MaSP
                              ELSE
                                  INSERT INTO TonKhoChiNhanh(MaCN, MaSP, SoLuongTon)
                                  VALUES(@MaCN, @MaSP, CASE WHEN @Loai='N' THEN @SoLuong ELSE -@SoLuong END)", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@MaCN", maCN);
                            cmd.Parameters.AddWithValue("@MaSP", maSP);
                            cmd.Parameters.AddWithValue("@Loai", loaiPhieu);
                            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand(
                            "SELECT SoLuongTon FROM TonKhoChiNhanh WHERE MaCN=@MaCN AND MaSP=@MaSP", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@MaCN", maCN);
                            cmd.Parameters.AddWithValue("@MaSP", maSP);
                            int tonMoi = Convert.ToInt32(cmd.ExecuteScalar());
                            if (tonMoi < 0)
                            {
                                throw new InvalidOperationException("Tồn kho chi nhánh không đủ để xuất cho một trong các sản phẩm.");
                            }
                        }
                    }

                    tx.Commit();
                    MessageBox.Show("Lưu phiếu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetPhieuNhap();
                    LoadDanhSachPhieu();
                    LoadTonKho();
                }
                catch (InvalidOperationException ex)
                {
                    tx.Rollback();
                    MessageBox.Show(ex.Message, "Không thể lưu phiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (SqlException)
                {
                    tx.Rollback();
                    MessageBox.Show(
                        "Lỗi CSDL khi lưu phiếu nhiều sản phẩm. Vui lòng kiểm tra lại script cập nhật.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private long TaoPhieu(SqlConnection conn, SqlTransaction tx, string maCN, string loaiPhieu)
        {
            using (SqlCommand cmd = new SqlCommand(
                @"INSERT INTO PhieuXuatNhapChiNhanh
                    (MaCN, NgayGiaoDich, LoaiPhieu, NguoiXuat, NguoiNhan, NoiNhan, KhoNguon, GhiChu)
                  VALUES
                    (@MaCN, @Ngay, @Loai, @NguoiXuat, @NguoiNhan, @NoiNhan, @KhoNguon, @GhiChu);
                  SELECT CAST(SCOPE_IDENTITY() AS BIGINT);", conn, tx))
            {
                cmd.Parameters.AddWithValue("@MaCN", maCN);
                cmd.Parameters.AddWithValue("@Ngay", dtNgayGiaoDich.Value);
                cmd.Parameters.AddWithValue("@Loai", loaiPhieu);
                cmd.Parameters.AddWithValue("@NguoiXuat", txtNguoiXuat.Text.Trim());
                cmd.Parameters.AddWithValue("@NguoiNhan", txtNguoiNhan.Text.Trim());
                cmd.Parameters.AddWithValue("@NoiNhan", txtNoiNhan.Text.Trim());
                cmd.Parameters.AddWithValue("@KhoNguon", txtKhoNguon.Text.Trim());
                cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrWhiteSpace(txtGhiChuPhieu.Text) ? (object)DBNull.Value : txtGhiChuPhieu.Text.Trim());
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }

        private void ResetPhieuNhap()
        {
            _dtChiTietTam.Rows.Clear();
            txtNguoiXuat.Clear();
            txtNguoiNhan.Clear();
            txtNoiNhan.Clear();
            txtKhoNguon.Clear();
            txtGhiChuPhieu.Clear();
            txtGhiChuChiTiet.Clear();
            numSoLuong.Value = 1;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetPhieuNhap();
            LoadDanhSachPhieu();
            LoadTonKho();
        }

        private void dgvDanhSachPhieu_SelectionChanged(object sender, EventArgs e)
        {
            LoadChiTietPhieuDaChon();
        }

        private void btnXuatPdf_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachPhieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu cần in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvChiTietPhieuDaLuu.Rows.Count == 0)
            {
                MessageBox.Show("Phiếu đang chọn chưa có chi tiết để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string loaiPhieu = dgvDanhSachPhieu.CurrentRow.Cells["Loại phiếu"].Value.ToString();
            string tenChiNhanh = dgvDanhSachPhieu.CurrentRow.Cells["Chi nhánh"].Value.ToString();
            string nguoiGiao = dgvDanhSachPhieu.CurrentRow.Cells["Người giao"].Value.ToString();
            string xuatTai = dgvDanhSachPhieu.CurrentRow.Cells["Lấy từ kho"].Value.ToString();
            string nhapTai = dgvDanhSachPhieu.CurrentRow.Cells["Nơi nhận"].Value.ToString();
            DateTime ngayLap = DateTime.ParseExact(
                dgvDanhSachPhieu.CurrentRow.Cells["Ngày giờ"].Value.ToString(),
                "dd/MM/yyyy HH:mm",
                System.Globalization.CultureInfo.InvariantCulture);
            string ghiChu = dgvDanhSachPhieu.CurrentRow.Cells["Ghi chú"].Value == null
                ? string.Empty
                : dgvDanhSachPhieu.CurrentRow.Cells["Ghi chú"].Value.ToString();

            PdfExportHelper.ExportInventoryReportPdf(
                this,
                dgvChiTietPhieuDaLuu,
                loaiPhieu,
                tenChiNhanh,
                ngayLap,
                nguoiGiao,
                xuatTai,
                nhapTai,
                ghiChu);
        }
    }
}
