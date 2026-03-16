using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    public partial class frmSanPham : Form
    {
        private string duongDanAnh = string.Empty;
        public frmSanPham()
        {
            InitializeComponent();
        }


        private void ClearAnhHienTai()
        {
            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }
        }
        private List<string> LayDanhSachNguonAnh(string giaTriAnh)
        {
            List<string> danhSach = new List<string>();

            if (string.IsNullOrWhiteSpace(giaTriAnh))
            {
                return danhSach;
            }

            string giaTri = giaTriAnh.Trim();
            danhSach.Add(giaTri);

            string tenFile = Path.GetFileName(giaTri);
            string thuMucChay = Application.StartupPath;
            string[] thuMucThu =
            {
                thuMucChay,
                Path.Combine(thuMucChay, "Images"),
                Path.Combine(thuMucChay, "images"),
                Path.Combine(thuMucChay, "img"),
                Path.GetFullPath(Path.Combine(thuMucChay, "..", "..")),
                Path.GetFullPath(Path.Combine(thuMucChay, "..", "..", "Images")),
                Path.GetFullPath(Path.Combine(thuMucChay, "..", "..", "images")),
                Path.GetFullPath(Path.Combine(thuMucChay, "..", "..", "img"))
            };

            foreach (string thuMuc in thuMucThu)
            {
                if (string.IsNullOrWhiteSpace(thuMuc) || string.IsNullOrWhiteSpace(tenFile))
                {
                    continue;
                }

                string duongDanDayDu = Path.Combine(thuMuc, tenFile);
                if (!danhSach.Contains(duongDanDayDu))
                {
                    danhSach.Add(duongDanDayDu);
                }
            }

            string imageBaseUrl = ConfigurationManager.AppSettings["ImageBaseUrl"];
            if (!string.IsNullOrWhiteSpace(imageBaseUrl) && !string.IsNullOrWhiteSpace(tenFile))
            {
                string url = imageBaseUrl.TrimEnd('/') + "/" + Uri.EscapeDataString(tenFile);
                if (!danhSach.Contains(url))
                {
                    danhSach.Add(url);
                }
            }

            return danhSach;
        }

        private bool LaUrl(string giaTri)
        {
            Uri uri;
            return Uri.TryCreate(giaTri, UriKind.Absolute, out uri)
                   && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
        }

        private bool ThuTaiAnh(string duongDan, bool hienThiThongBao)
        {
            ClearAnhHienTai();

            List<string> danhSachNguon = LayDanhSachNguonAnh(duongDan);
            if (danhSachNguon.Count == 0)
            {
                return false;
            }

            Exception loiCuoi = null;

            foreach (string nguon in danhSachNguon)
            {
                try
                {
                    if (LaUrl(nguon))
                    {
                        using (WebClient wc = new WebClient())
                        using (Stream stream = wc.OpenRead(nguon))
                        {
                            if (stream == null)
                            {
                                continue;
                            }

                            using (Image img = Image.FromStream(stream))
                            {
                                picAnh.Image = new Bitmap(img);
                            }
                        }

                        return true;
                    }

                    if (!File.Exists(nguon))
                    {
                        continue;
                    }

                    using (FileStream fs = new FileStream(nguon, FileMode.Open, FileAccess.Read))
                    using (Image img = Image.FromStream(fs))
                    {
                        picAnh.Image = new Bitmap(img);
                    }

                    return true;
                }
                catch (Exception ex) when (ex is OutOfMemoryException || ex is ArgumentException || ex is IOException || ex is WebException)
                {
                    loiCuoi = ex;
                }
            }

            if (hienThiThongBao)
            {
                string thongBao = "Không thể tải ảnh. Vui lòng kiểm tra đường dẫn ảnh trong CSDL hoặc cấu hình ImageBaseUrl trong App.config.";

                if (loiCuoi is OutOfMemoryException)
                {
                    thongBao = "File đã chọn không phải ảnh hợp lệ.";
                }
                else if (loiCuoi is IOException)
                {
                    thongBao = "Không thể truy cập file ảnh.";
                }
                else if (loiCuoi is WebException)
                {
                    thongBao = "Không thể tải ảnh từ đường dẫn web.";
                }

                MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }

        void LoadSanPham()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = @"SELECT MaSP,TenSP,DonViTinh,SoDK,ThanhPhan,CongDung,
                           HDSD,Gia,Anh,SLTon,MaLSP,MaNCC
                           FROM SanPham";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvSanPham.DataSource = dt;
        }

        void LoadLoaiSP()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = "SELECT MaLSP, TenLSP FROM LoaiSanPham";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbLoaiSP.DataSource = dt;
            cbLoaiSP.DisplayMember = "TenLSP";
            cbLoaiSP.ValueMember = "MaLSP";
        }

        void LoadNCC()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = "SELECT MaNCC, TenNCC FROM NhaCungCap";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbNCC.DataSource = dt;
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
           
            LoadSanPham();
            LoadLoaiSP();
            LoadNCC();

            txtMaSP.ReadOnly = true;
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txtSoDK.Text = row.Cells["SoDK"].Value.ToString();
                txtThanhPhan.Text = row.Cells["ThanhPhan"].Value.ToString();
                txtCongDung.Text = row.Cells["CongDung"].Value.ToString();
                txtHDSD.Text = row.Cells["HDSD"].Value.ToString();
                txtGia.Text = row.Cells["Gia"].Value.ToString();
                txtSLTon.Text = row.Cells["SLTon"].Value.ToString();

                cbLoaiSP.SelectedValue = row.Cells["MaLSP"].Value;

                cbNCC.SelectedValue = row.Cells["MaNCC"].Value;

                object giaTriAnh = row.Cells["Anh"].Value;
                duongDanAnh = giaTriAnh == DBNull.Value ? string.Empty : Convert.ToString(giaTriAnh);

                if (!ThuTaiAnh(duongDanAnh, false))
                {
                    duongDanAnh = string.Empty;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO SanPham
            (TenSP,DonViTinh,SoDK,ThanhPhan,CongDung,HDSD,Gia,Anh,SLTon,MaLSP,MaNCC)
            VALUES
            (@TenSP,@DonViTinh,@SoDK,@ThanhPhan,@CongDung,@HDSD,@Gia,@Anh,@SLTon,@MaLSP,@MaNCC)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("@DonViTinh", txtDonViTinh.Text);
            cmd.Parameters.AddWithValue("@SoDK", txtSoDK.Text);
            cmd.Parameters.AddWithValue("@ThanhPhan", txtThanhPhan.Text);
            cmd.Parameters.AddWithValue("@CongDung", txtCongDung.Text);
            cmd.Parameters.AddWithValue("@HDSD", txtHDSD.Text);
            cmd.Parameters.AddWithValue("@Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("@Anh", string.IsNullOrWhiteSpace(duongDanAnh) ? (object)DBNull.Value : duongDanAnh);
            cmd.Parameters.AddWithValue("@SLTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("@MaLSP", cbLoaiSP.SelectedValue);
            cmd.Parameters.AddWithValue("@MaNCC", cbNCC.SelectedValue);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadSanPham();

            MessageBox.Show("Thêm sản phẩm thành công");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = @"UPDATE SanPham
            SET TenSP=@TenSP,
                DonViTinh=@DonViTinh,
                SoDK=@SoDK,
                ThanhPhan=@ThanhPhan,
                CongDung=@CongDung,
                HDSD=@HDSD,
                Gia=@Gia,
                Anh=@Anh,
                SLTon=@SLTon,
                MaLSP=@MaLSP,
                MaNCC=@MaNCC
            WHERE MaSP=@MaSP";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("@DonViTinh", txtDonViTinh.Text);
            cmd.Parameters.AddWithValue("@SoDK", txtSoDK.Text);
            cmd.Parameters.AddWithValue("@ThanhPhan", txtThanhPhan.Text);
            cmd.Parameters.AddWithValue("@CongDung", txtCongDung.Text);
            cmd.Parameters.AddWithValue("@HDSD", txtHDSD.Text);
            cmd.Parameters.AddWithValue("@Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("@Anh", string.IsNullOrWhiteSpace(duongDanAnh) ? (object)DBNull.Value : duongDanAnh);
            cmd.Parameters.AddWithValue("@SLTon", txtSLTon.Text);
            cmd.Parameters.AddWithValue("@MaLSP", cbLoaiSP.SelectedValue);
            cmd.Parameters.AddWithValue("@MaNCC", cbNCC.SelectedValue);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadSanPham();

            MessageBox.Show("Cập nhật thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = "DELETE FROM SanPham WHERE MaSP=@MaSP";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadSanPham();

            MessageBox.Show("Xóa sản phẩm thành công");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonViTinh.Clear();
            txtSoDK.Clear();
            txtThanhPhan.Clear();
            txtCongDung.Clear();
            txtHDSD.Clear();
            txtGia.Clear();
            txtSLTon.Clear();

            picAnh.Image = null;
            duongDanAnh = string.Empty;
            ClearAnhHienTai();

            cbLoaiSP.SelectedIndex = 0;
            cbNCC.SelectedIndex = 0;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh sản phẩm";
            ofd.Filter = "File ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ThuTaiAnh(ofd.FileName, true))
                {
                    duongDanAnh = ofd.FileName;
                }
                else
                {
                    duongDanAnh = string.Empty;
                }
            }
        }
    }
}