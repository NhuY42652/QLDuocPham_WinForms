using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    public partial class frmSanPham : Form
    {
       
        public frmSanPham()
        {
            InitializeComponent();
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

            cbLoaiSP.SelectedIndex = 0;
            cbNCC.SelectedIndex = 0;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
           
        }
    }
}
