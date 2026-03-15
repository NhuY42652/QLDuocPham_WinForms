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
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }
        void LoadDonHang()
        {
            SqlConnection conn = Database.GetConnection();

            string sql = @"SELECT DonHang.MaDH,
                          KhachHang.TenKH,
                          DonHang.NgayDat,
                          DonHang.TongTien,
                          DonHang.HTThanhToan,
                          DonHang.TinhTrang
                   FROM DonHang
                   JOIN KhachHang
                   ON DonHang.MaKH = KhachHang.MaKH";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvDonHang.DataSource = dt;
        }
        void LoadChiTietDonHang(string maDH)
        {
            SqlConnection conn = Database.GetConnection();

            string sql = @"SELECT SanPham.TenSP,
                          ChiTietDonHang.SoLuong,
                          ChiTietDonHang.DonGia
                   FROM ChiTietDonHang
                   JOIN SanPham
                   ON ChiTietDonHang.MaSP = SanPham.MaSP
                   WHERE ChiTietDonHang.MaDH = @MaDH";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@MaDH", maDH);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvChiTietDonHang.DataSource = dt;
        }
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            LoadDonHang();
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maDH = dgvDonHang.Rows[e.RowIndex].Cells["MaDH"].Value.ToString();

                LoadChiTietDonHang(maDH);
            }
        }
    }
}
