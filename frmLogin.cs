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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = Database.GetConnection();
            conn.Open();

            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@user AND MatKhau=@pass";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

            int count = (int)cmd.ExecuteScalar();

            if (count == 1)
            {
                frmMain f = new frmMain();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }

            conn.Close();
        }
    }
}
