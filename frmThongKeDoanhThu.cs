using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            cbKieuThongKe.SelectedIndex = 0;
            dtTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtDenNgay.Value = DateTime.Today;
            dtChonThang.Value = DateTime.Today;
            numNamTu.Value = DateTime.Today.Year;
            numNamDen.Value = DateTime.Today.Year;
            cbQuy.SelectedIndex = 0;
            numNamQuy.Value = DateTime.Today.Year;
            CapNhatDieuKienLoc();
            LoadThongKe();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void btnXuatPdf_Click(object sender, EventArgs e)
        {
            DateTime tuNgay;
            DateTime denNgay;
            if (!TryGetKhoangThoiGian(out tuNgay, out denNgay))
            {
                return;
            }

            PdfExportHelper.ExportRevenueReportPdf(this, dgvThongKe, cbKieuThongKe.Text, tuNgay, denNgay);
        }

        private void cbKieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatDieuKienLoc();
        }

        private void CapNhatDieuKienLoc()
        {
            bool laTheoNgay = cbKieuThongKe.Text == "Theo ngày";
            bool laTheoThang = cbKieuThongKe.Text == "Theo tháng";
            bool laTheoNam = cbKieuThongKe.Text == "Theo năm";
            bool laTheoQuy = cbKieuThongKe.Text == "Theo quý";

            lblTuNgay.Visible = laTheoNgay;
            dtTuNgay.Visible = laTheoNgay;
            lblDenNgay.Visible = laTheoNgay;
            dtDenNgay.Visible = laTheoNgay;

            lblThang.Visible = laTheoThang;
            dtChonThang.Visible = laTheoThang;

            lblNamTu.Visible = laTheoNam;
            numNamTu.Visible = laTheoNam;
            lblNamDen.Visible = laTheoNam;
            numNamDen.Visible = laTheoNam;

            lblQuy.Visible = laTheoQuy;
            cbQuy.Visible = laTheoQuy;
            lblNamQuy.Visible = laTheoQuy;
            numNamQuy.Visible = laTheoQuy;
        }

        private void LoadThongKe()
        {
            string kieu = cbKieuThongKe.Text;
            DateTime tuNgay;
            DateTime denNgay;
            string mocThoiGian;

            if (!TryGetKhoangThoiGian(out tuNgay, out denNgay))
            {
                return;
            }

            switch (kieu)
            {
                case "Theo tháng":
                    mocThoiGian = tuNgay.ToString("MM/yyyy");
                    break;
                case "Theo năm":
                    mocThoiGian = string.Format("{0} - {1}", numNamTu.Value, numNamDen.Value);
                    break;
                case "Theo quý":
                    int quy = cbQuy.SelectedIndex + 1;
                    int namQuy = (int)numNamQuy.Value;
                    mocThoiGian = string.Format("Quý {0}/{1}", quy, namQuy);
                    break;
                case "Theo ngày":
                default:
                    mocThoiGian = string.Format("{0:dd/MM/yyyy} - {1:dd/MM/yyyy}", tuNgay, dtDenNgay.Value.Date);
                    break;
            }

            string sql = @"SELECT @MocThoiGian AS [Mốc thời gian],
                                  COUNT(*) AS [Số đơn],
                                  ISNULL(SUM(TongTien),0) AS [Doanh thu]
                           FROM DonHang
                           WHERE NgayDat >= @TuNgay AND NgayDat <= @DenNgay;";

            using (SqlConnection conn = Database.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@MocThoiGian", mocThoiGian);
                da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
                da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvThongKe.DataSource = dt;

                decimal tongDoanhThu = 0;
                int tongDon = 0;
                foreach (DataRow row in dt.Rows)
                {
                    tongDon += Convert.ToInt32(row["Số đơn"]);
                    tongDoanhThu += Convert.ToDecimal(row["Doanh thu"]);
                }

                lblTongDon.Text = "Tổng đơn: " + tongDon;
                lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0") + " VNĐ";
            }
        }

        private bool TryGetKhoangThoiGian(out DateTime tuNgay, out DateTime denNgay)
        {
            string kieu = cbKieuThongKe.Text;

            switch (kieu)
            {
                case "Theo tháng":
                    tuNgay = new DateTime(dtChonThang.Value.Year, dtChonThang.Value.Month, 1);
                    denNgay = tuNgay.AddMonths(1).AddTicks(-1);
                    return true;
                case "Theo năm":
                    if (numNamTu.Value > numNamDen.Value)
                    {
                        MessageBox.Show("Năm bắt đầu phải nhỏ hơn hoặc bằng năm kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tuNgay = DateTime.MinValue;
                        denNgay = DateTime.MinValue;
                        return false;
                    }
                    tuNgay = new DateTime((int)numNamTu.Value, 1, 1);
                    denNgay = new DateTime((int)numNamDen.Value, 12, 31, 23, 59, 59, 997);
                    return true;
                case "Theo quý":
                    int quy = cbQuy.SelectedIndex + 1;
                    int namQuy = (int)numNamQuy.Value;
                    int thangBatDau = ((quy - 1) * 3) + 1;
                    tuNgay = new DateTime(namQuy, thangBatDau, 1);
                    denNgay = tuNgay.AddMonths(3).AddTicks(-1);
                    return true;
                case "Theo ngày":
                default:
                    tuNgay = dtTuNgay.Value.Date;
                    denNgay = dtDenNgay.Value.Date.AddDays(1).AddTicks(-1);
                    if (tuNgay > denNgay)
                    {
                        MessageBox.Show("Từ ngày phải nhỏ hơn hoặc bằng đến ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    return true;
            }
        }
    }
}
