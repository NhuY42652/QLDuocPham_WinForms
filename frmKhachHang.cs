using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        void LoadKhachHang()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = "SELECT MaKH, TenKH, SDT, DiaChi FROM KhachHang";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvKhachHang.DataSource = dt;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            txtMaKH.ReadOnly = true;
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO KhachHang
                           (TenKH, SDT, DiaChi)
                           VALUES(@Ten,@SDT,@DiaChi)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ten", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadKhachHang();

            MessageBox.Show("Thêm khách hàng thành công");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = @"UPDATE KhachHang
                           SET TenKH=@Ten,
                               SDT=@SDT,
                               DiaChi=@DiaChi
                           WHERE MaKH=@Ma";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ma", txtMaKH.Text);
            cmd.Parameters.AddWithValue("@Ten", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadKhachHang();

            MessageBox.Show("Cập nhật thành công");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = "DELETE FROM KhachHang WHERE MaKH=@Ma";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ma", txtMaKH.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadKhachHang();

            MessageBox.Show("Xóa thành công");
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
    }
}