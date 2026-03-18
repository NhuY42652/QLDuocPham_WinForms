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
            this.Hide();
            frmSanPham f = new frmSanPham();
            f.ShowDialog();
            this.Show();
            LoadDashboard(); 
        }
        private void btnLoai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoaiSanPham f = new frmLoaiSanPham();
            f.ShowDialog();
            this.Show();
            LoadDashboard();
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDanhMuc f = new frmDanhMuc();
            f.ShowDialog();
            this.Show();
            LoadDashboard();
        }
        private void btnNCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
            this.Show();
            LoadDashboard();
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
            this.Show();
            LoadDashboard();
        }
        private void btnDonHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDonHang f = new frmDonHang();
            f.ShowDialog();
            this.Show();
            LoadDashboard();
        }
        private void btnXuatNhapKho_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXuatNhapKhoChiNhanh f = new frmXuatNhapKhoChiNhanh();
            f.ShowDialog();
            this.Show();
            LoadDashboard();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void LoadDashboard()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    lblTongSP.Text = Convert.ToString(new SqlCommand("SELECT COUNT(*) FROM SanPham", conn).ExecuteScalar());
                    lblTongNCC.Text = Convert.ToString(new SqlCommand("SELECT COUNT(*) FROM NhaCungCap", conn).ExecuteScalar());
                    lblTongLoai.Text = Convert.ToString(new SqlCommand("SELECT COUNT(*) FROM LoaiSanPham", conn).ExecuteScalar());
                    lblTongDanhMuc.Text = Convert.ToString(new SqlCommand("SELECT COUNT(*) FROM DanhMuc", conn).ExecuteScalar());
                    lblTongKH.Text = Convert.ToString(new SqlCommand("SELECT COUNT(*) FROM KhachHang", conn).ExecuteScalar());
                    lblTongDonHang.Text = Convert.ToString(new SqlCommand("SELECT COUNT(*) FROM DonHang", conn).ExecuteScalar());
                    lblTonKho.Text = Convert.ToString(new SqlCommand("SELECT ISNULL(SUM(SLTon),0) FROM SanPham", conn).ExecuteScalar());
                }
            }
            catch (SqlException)
            {
                lblTongSP.Text = "0";
                lblTongNCC.Text = "0";
                lblTongLoai.Text = "0";
                lblTongDanhMuc.Text = "0";
                lblTongKH.Text = "0";
                lblTongDonHang.Text = "0";
                lblTonKho.Text = "0";

                MessageBox.Show("Không thể tải dữ liệu tổng quan. Vui lòng kiểm tra kết nối cơ sở dữ liệu.",
                                "Lỗi kết nối",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }        
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDashboard();

            btnNCC.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnLoai.FlatAppearance.BorderSize = 0;
        }
        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKeDoanhThu f = new frmThongKeDoanhThu();
            f.ShowDialog();
            this.Show();
            LoadDashboard();
        }
    }
}
