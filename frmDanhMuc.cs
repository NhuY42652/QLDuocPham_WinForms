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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }
        void LoadMenu()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = "SELECT MaMenu, TenMenu FROM Menu";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbMenu.DataSource = dt;
            cbMenu.DisplayMember = "TenMenu";
            cbMenu.ValueMember = "MaMenu";
        }
        void LoadDanhMuc()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = @"SELECT MaDanhMuc, TenDanhMuc, MaMenu
                   FROM DanhMuc";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvDanhMuc.DataSource = dt;
        }
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadMenu();
        }
        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];

                txtMaDanhMuc.Text = row.Cells["MaDanhMuc"].Value.ToString();
                txtTenDanhMuc.Text = row.Cells["TenDanhMuc"].Value.ToString();

                cbMenu.SelectedValue = row.Cells["MaMenu"].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = "INSERT INTO DanhMuc(TenDanhMuc,MaMenu) VALUES(@Ten,@MaMenu)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ten", txtTenDanhMuc.Text);
            cmd.Parameters.AddWithValue("@MaMenu", cbMenu.SelectedValue);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadDanhMuc();

            MessageBox.Show("Thêm danh mục thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = @"UPDATE DanhMuc
                   SET TenDanhMuc=@Ten,
                       MaMenu=@MaMenu
                   WHERE MaDanhMuc=@Ma";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ma", txtMaDanhMuc.Text);
            cmd.Parameters.AddWithValue("@Ten", txtTenDanhMuc.Text);
            cmd.Parameters.AddWithValue("@MaMenu", cbMenu.SelectedValue);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadDanhMuc();

            MessageBox.Show("Cập nhật thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = "DELETE FROM DanhMuc WHERE MaDanhMuc=@Ma";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ma", txtMaDanhMuc.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadDanhMuc();

            MessageBox.Show("Xóa thành công");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            cbMenu.SelectedIndex = 0;
        }
    }
}
