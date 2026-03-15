using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        void LoadDanhMuc()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = "SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbDanhMuc.DataSource = dt;
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "MaDanhMuc";
        }
        void LoadLoaiSP()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = @"SELECT MaLSP, TenLSP, MaDanhMuc
                   FROM LoaiSanPham";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvLoaiSP.DataSource = dt;
        }
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSP();
            LoadDanhMuc();

            txtMaLSP.ReadOnly = true;
        }

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiSP.Rows[e.RowIndex];

                txtMaLSP.Text = row.Cells["MaLSP"].Value.ToString();
                txtTenLSP.Text = row.Cells["TenLSP"].Value.ToString();

                cbDanhMuc.SelectedValue = row.Cells["MaDanhMuc"].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = "INSERT INTO LoaiSanPham(TenLSP,MaDanhMuc) VALUES(@TenLSP,@MaDanhMuc)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@TenLSP", txtTenLSP.Text);
            cmd.Parameters.AddWithValue("@MaDanhMuc", cbDanhMuc.SelectedValue);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadLoaiSP();

            MessageBox.Show("Thêm thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = @"UPDATE LoaiSanPham
                   SET TenLSP=@TenLSP,
                       MaDanhMuc=@MaDanhMuc
                   WHERE MaLSP=@MaLSP";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaLSP", txtMaLSP.Text);
            cmd.Parameters.AddWithValue("@TenLSP", txtTenLSP.Text);
            cmd.Parameters.AddWithValue("@MaDanhMuc", cbDanhMuc.SelectedValue);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadLoaiSP();

            MessageBox.Show("Cập nhật thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = "DELETE FROM LoaiSanPham WHERE MaLSP=@MaLSP";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaLSP", txtMaLSP.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadLoaiSP();

            MessageBox.Show("Xóa thành công");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLSP.Clear();
            txtTenLSP.Clear();
            cbDanhMuc.SelectedIndex = 0;
        }
    }
}
