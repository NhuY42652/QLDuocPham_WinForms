using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace QLDuocPham_WinForms
{
    internal static class PdfExportHelper
    {
        public static void ExportRevenueReportPdf(Form owner, DataGridView dgv, string kieuThongKe, DateTime tuNgay, DateTime denNgay)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show(owner, "Không có dữ liệu để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> lines = new List<string>
                {
                "BÁO CÁO DOANH THU",
                "Kiểu thống kê: " + kieuThongKe,
                "Từ ngày: " + tuNgay.ToString("dd/MM/yyyy") + " - Đến ngày: " + denNgay.ToString("dd/MM/yyyy"),
                new string('-', 95)
            };

            lines.AddRange(BuildTableFromGrid(dgv));
            InNoiDung(owner, lines, "In báo cáo doanh thu");
        }

        public static void ExportInventoryReportPdf(
            Form owner,
            DataGridView dgv,
            string loaiPhieu,
            string tenChiNhanh,
            DateTime ngayLap,
            string nguoiGiao,
            string xuatTai,
            string nhapTai,
            string ghiChuPhieu)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show(owner, "Không có dữ liệu để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> lines = new List<string>
            {
                loaiPhieu == "Nhập" ? "PHIẾU NHẬP KHO" : "PHIẾU XUẤT KHO",
                "Chi nhánh: " + tenChiNhanh,
                "Ngày lập: " + ngayLap.ToString("dd/MM/yyyy HH:mm"),
                "Người giao: " + nguoiGiao,
                "Xuất tại: " + xuatTai + " | Nhập tại: " + nhapTai,
                "Ghi chú: " + (string.IsNullOrWhiteSpace(ghiChuPhieu) ? "-" : ghiChuPhieu),
                new string('-', 95)
            };
            lines.AddRange(BuildTableFromGrid(dgv));
            InNoiDung(owner, lines, "In phiếu xuất/nhập kho");
        }

        private static List<string> BuildTableFromGrid(DataGridView dgv)
        {
            List<string> lines = new List<string>();
            List<string> headers = new List<string>();

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                {
                    headers.Add(col.HeaderText);
                }
            }

            lines.Add(string.Join(" | ", headers));
            lines.Add(new string('-', 95));

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                List<string> values = new List<string>();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (!col.Visible) continue;
                    object val = row.Cells[col.Index].Value;
                    values.Add(val == null ? string.Empty : val.ToString());
                }
                lines.Add(string.Join(" | ", values));
            }

            return lines;
        }

        private static void InNoiDung(Form owner, List<string> lines, string title)
        {
            PrintDocument doc = new PrintDocument();
            int currentIndex = 0;
            Font font = new Font("Consolas", 10F, FontStyle.Regular);

            doc.DocumentName = title;
            doc.PrintPage += (sender, e) =>
            {
                float y = e.MarginBounds.Top;
                float lineHeight = font.GetHeight(e.Graphics) + 2;

                while (currentIndex < lines.Count)
                {
                    if (y + lineHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    e.Graphics.DrawString(lines[currentIndex], font, Brushes.Black, e.MarginBounds.Left, y);
                    y += lineHeight;
                    currentIndex++;
                }

                e.HasMorePages = false;
            };

            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = doc;
                preview.Width = 1200;
                preview.Height = 800;
                preview.StartPosition = FormStartPosition.CenterParent;
                preview.ShowDialog(owner);
            }
        }
    }
}