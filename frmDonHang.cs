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
        private ComboBox cbTinhTrang;
        private Button btnCapNhatTinhTrang;

        public frmDonHang()
        {
            InitializeComponent();
            KhoiTaoKhuVucCapNhatTinhTrang();
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

        private void KhoiTaoKhuVucCapNhatTinhTrang()
        {
            Label lblTinhTrang = new Label
            {
                Text = "Trạng thái:",
                Location = new Point(330, 12),
                Size = new Size(75, 24),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 115, 132),
                TextAlign = ContentAlignment.MiddleRight
            };

            cbTinhTrang = new ComboBox
            {
                Location = new Point(412, 10),
                Size = new Size(150, 23),
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5F)
            };
            cbTinhTrang.Items.AddRange(new object[]
            {
                "Chờ xác nhận",
                "Đã xác nhận",
                "Đang giao",
                "Hoàn thành",
                "Đã hủy"
            });

            btnCapNhatTinhTrang = new Button
            {
                Text = "✔ Cập nhật",
                Location = new Point(570, 8),
                Size = new Size(102, 27),
                BackColor = Color.FromArgb(46, 134, 222),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnCapNhatTinhTrang.FlatAppearance.BorderSize = 0;
            btnCapNhatTinhTrang.Click += btnCapNhatTinhTrang_Click;

            pnlTopGrid.Controls.Add(lblTinhTrang);
            pnlTopGrid.Controls.Add(cbTinhTrang);
            pnlTopGrid.Controls.Add(btnCapNhatTinhTrang);

            dgvDonHang.Location = new Point(18, 43);
            dgvDonHang.Size = new Size(654, 170);
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

                object tinhTrang = dgvDonHang.Rows[e.RowIndex].Cells["TinhTrang"].Value;
                if (tinhTrang != null)
                {
                    cbTinhTrang.Text = tinhTrang.ToString();
                }

                LoadChiTietDonHang(maDH);
            }
        }
    
    
        private void btnCapNhatTinhTrang_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbTinhTrang.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maDH = dgvDonHang.CurrentRow.Cells["MaDH"].Value.ToString();
            string tinhTrang = cbTinhTrang.Text;

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE DonHang SET TinhTrang=@TinhTrang WHERE MaDH=@MaDH", conn))
                {
                    cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                    cmd.Parameters.AddWithValue("@MaDH", maDH);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật trạng thái đơn hàng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDonHang();
        }
    }
}