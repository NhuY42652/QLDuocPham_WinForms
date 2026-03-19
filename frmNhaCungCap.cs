using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        void LoadNCC()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = "SELECT * FROM NhaCungCap";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvNhaCungCap.DataSource = dt;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNCC();
            txtMaNCC.ReadOnly = true;
        }
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];

                txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = row.Cells["SDT"].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = "INSERT INTO NhaCungCap(TenNCC,DiaChi,SDT) VALUES(@Ten,@DiaChi,@SDT)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ten", txtTenNCC.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT", txtDienThoai.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadNCC();

            MessageBox.Show("Thêm nhà cung cấp thành công");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = @"UPDATE NhaCungCap
                           SET TenNCC=@Ten,
                               DiaChi=@DiaChi,
                               SDT=@SDT
                           WHERE MaNCC=@Ma";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ma", txtMaNCC.Text);
            cmd.Parameters.AddWithValue("@Ten", txtTenNCC.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@SDT", txtDienThoai.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadNCC();

            MessageBox.Show("Cập nhật thành công");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = "DELETE FROM NhaCungCap WHERE MaNCC=@Ma";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ma", txtMaNCC.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadNCC();

            MessageBox.Show("Xóa thành công");
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
        }

        
    }
}