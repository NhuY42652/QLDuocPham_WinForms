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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.ShowDialog();

            LoadDashboard(); 
        }
        private void btnLoai_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham f = new frmLoaiSanPham();
            f.ShowDialog();

            LoadDashboard();
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhMuc f = new frmDanhMuc();
            f.ShowDialog();

            LoadDashboard();
        }
        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();

            LoadDashboard();
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();

            LoadDashboard();
        }
        private void btnDonHang_Click(object sender, EventArgs e)
        {
            frmDonHang f = new frmDonHang();
            f.ShowDialog();

            LoadDashboard();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void LoadDashboard()
        {
            SqlConnection conn = Database.GetConnection();
            conn.Open();

            lblTongSP.Text = new SqlCommand("SELECT COUNT(*) FROM SanPham", conn).ExecuteScalar().ToString();

            lblTongNCC.Text = new SqlCommand("SELECT COUNT(*) FROM NhaCungCap", conn).ExecuteScalar().ToString();

            lblTongLoai.Text = new SqlCommand("SELECT COUNT(*) FROM LoaiSanPham", conn).ExecuteScalar().ToString();

            lblTongDanhMuc.Text = new SqlCommand("SELECT COUNT(*) FROM DanhMuc", conn).ExecuteScalar().ToString();

            lblTongKH.Text = new SqlCommand("SELECT COUNT(*) FROM KhachHang", conn).ExecuteScalar().ToString();

            lblTongDonHang.Text = new SqlCommand("SELECT COUNT(*) FROM DonHang", conn).ExecuteScalar().ToString();

            lblTonKho.Text = new SqlCommand("SELECT ISNULL(SUM(SLTon),0) FROM SanPham", conn).ExecuteScalar().ToString();

            conn.Close();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDashboard();

            btnNCC.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnLoai.FlatAppearance.BorderSize = 0;
        }       
    }
}
