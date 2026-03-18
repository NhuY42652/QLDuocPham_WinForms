using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    internal static class PdfExportHelper
    {
        public static void ExportRevenueReportPdf(Form owner, DataGridView dgv, string kieuThongKe, DateTime tuNgay, DateTime denNgay)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show(owner, "Không có dữ liệu để xuất PDF.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "bao_cao_doanh_thu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (sfd.ShowDialog(owner) != DialogResult.OK)
                {
                    return;
                }

                List<string> lines = BuildRevenueTemplateLines(dgv, kieuThongKe, tuNgay, denNgay);
                File.WriteAllBytes(sfd.FileName, BuildSimplePdf(lines));
                MessageBox.Show(owner, "Xuất PDF thành công:\n" + sfd.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                MessageBox.Show(owner, "Không có dữ liệu để xuất PDF.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "phieu_" + (loaiPhieu == "Nhập" ? "nhap" : "xuat") + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (sfd.ShowDialog(owner) != DialogResult.OK)
                {
                    return;
                }

                List<string> lines = BuildInventoryTemplateLines(dgv, loaiPhieu, tenChiNhanh, ngayLap, nguoiGiao, xuatTai, nhapTai, ghiChuPhieu);
                File.WriteAllBytes(sfd.FileName, BuildSimplePdf(lines));
                MessageBox.Show(owner, "Xuất PDF thành công:\n" + sfd.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static List<string> BuildInventoryTemplateLines(
            DataGridView dgv,
            string loaiPhieu,
            string tenChiNhanh,
            DateTime ngayLap,
            string nguoiGiao,
            string xuatTai,
            string nhapTai,
            string ghiChuPhieu)
        {
            string tieuDe = loaiPhieu == "Nhập" ? "PHIEU NHAP KHO" : "PHIEU XUAT KHO";

            List<string> lines = new List<string>
            {
                "TEN HE THONG NHA THUOC",
                "Ten chi nhanh: " + SafeText(tenChiNhanh),
                string.Empty,
                Center(tieuDe, 110),
                Center("Ngay/thang/nam: " + ngayLap.ToString("dd/MM/yyyy"), 110),
                string.Empty,
                "Ho ten nguoi giao: " + SafeText(nguoiGiao),
                "Xuat tai: " + SafeText(xuatTai) + "    Nhap tai: " + SafeText(nhapTai),
                string.Empty
            };

            int[] widths = { 4, 24, 10, 12, 12, 14, 20 };
            string[] headers = { "STT", "Ten san pham", "So luong", "Don vi tinh", "Gia", "Thanh tien", "Ghi chu" };

            lines.Add(MakeRow(headers, widths));
            lines.Add(MakeSeparator(widths));

            decimal tongTien = 0;
            decimal tongSoLuong = 0;
            int stt = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                stt++;

                string tenSp = CellValue(row, "Tên sản phẩm");
                decimal soLuong = ToDecimal(CellValue(row, "Số lượng"));
                string donViTinh = CellValue(row, "Đơn vị tính");
                decimal gia = ToDecimal(CellValue(row, "Giá"));
                decimal thanhTien = ToDecimal(CellValue(row, "Thành tiền"));
                if (thanhTien <= 0)
                {
                    thanhTien = soLuong * gia;
                }
                string ghiChu = CellValue(row, "Ghi chú");

                tongSoLuong += soLuong;
                tongTien += thanhTien;

                string[] values =
                {
                    stt.ToString(CultureInfo.InvariantCulture),
                    tenSp,
                    soLuong.ToString("N0", CultureInfo.InvariantCulture),
                    donViTinh,
                    gia.ToString("N0", CultureInfo.InvariantCulture),
                    thanhTien.ToString("N0", CultureInfo.InvariantCulture),
                    ghiChu
                };

                lines.Add(MakeRow(values, widths));
            }

            if (stt == 0)
            {
                lines.Add("(Khong co du lieu chi tiet de in)");
            }

            lines.Add(MakeSeparator(widths));
            lines.Add("Tong so luong " + SafeText(loaiPhieu.ToLowerInvariant()) + ": " + tongSoLuong.ToString("N0", CultureInfo.InvariantCulture));
            lines.Add("Tong tien: " + tongTien.ToString("N0", CultureInfo.InvariantCulture));
            lines.Add("Ly do " + SafeText(loaiPhieu.ToLowerInvariant()) + " kho: " + SafeText(ghiChuPhieu));
            lines.Add(string.Empty);
            lines.Add(Center("Ngay, thang, nam", 110));
            lines.Add(string.Empty);
            lines.Add("Nguoi giao" + new string(' ', 70) + "Nguoi nhan");

            return lines;
        }

        private static List<string> BuildRevenueTemplateLines(DataGridView dgv, string kieuThongKe, DateTime tuNgay, DateTime denNgay)
        {
            string tieuDe;
            switch (kieuThongKe)
            {
                case "Theo ngày":
                    tieuDe = "BAO CAO DOANH THU NGAY";
                    break;
                case "Theo tháng":
                    tieuDe = "BAO CAO DOANH THU THANG";
                    break;
                case "Theo quý":
                    tieuDe = "BAO CAO DOANH THU QUY";
                    break;
                case "Theo năm":
                    tieuDe = "BAO CAO DOANH THU NAM";
                    break;
                default:
                    tieuDe = "BAO CAO DOANH THU";
                    break;
            }

            List<string> lines = new List<string>
            {
                "TEN HE THONG NHA THUOC",
                "Ten chi nhanh: Tong hop",
                string.Empty,
                Center(tieuDe, 110),
                Center("Tu ngay " + tuNgay.ToString("dd/MM/yyyy") + " den ngay " + denNgay.ToString("dd/MM/yyyy"), 110),
                string.Empty
            };

            int[] widths = { 4, 24, 14, 14, 18 };
            string[] headers = { "STT", "Thoi gian", "So luong ban", "So luong don", "Tong" };

            lines.Add(MakeRow(headers, widths));
            lines.Add(MakeSeparator(widths));

            decimal tongDoanhThu = 0;
            int stt = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                stt++;
                string moc = CellValue(row, "Mốc thời gian");
                string soDon = CellValue(row, "Số đơn");
                decimal tong = ToDecimal(CellValue(row, "Doanh thu"));
                tongDoanhThu += tong;

                string[] values =
                {
                    stt.ToString(CultureInfo.InvariantCulture),
                    moc,
                    "-",
                    soDon,
                    tong.ToString("N0", CultureInfo.InvariantCulture)
                };

                lines.Add(MakeRow(values, widths));
            }

            if (stt == 0)
            {
                lines.Add("(Khong co du lieu doanh thu de in)");
            }

            lines.Add(MakeSeparator(widths));
            lines.Add("Tong doanh thu: " + tongDoanhThu.ToString("N0", CultureInfo.InvariantCulture));
            lines.Add(string.Empty);
            lines.Add(Center("Ngay, thang, nam", 110));
            lines.Add(string.Empty);
            lines.Add("Nguoi lap ban" + new string(' ', 72) + "Ke toan");

            return lines;
        }

        private static string MakeSeparator(int[] widths)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('+');
            for (int i = 0; i < widths.Length; i++)
            {
                sb.Append(new string('-', widths[i] + 2)).Append('+');
            }
            return sb.ToString();
        }

        private static string MakeRow(string[] values, int[] widths)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('|');
            for (int i = 0; i < widths.Length; i++)
            {
                string value = i < values.Length ? SafeText(values[i]) : string.Empty;
                if (value.Length > widths[i])
                {
                    value = value.Substring(0, widths[i] - 1) + "~";
                }

                sb.Append(' ').Append(value.PadRight(widths[i])).Append(' ').Append('|');
            }
            return sb.ToString();
        }

        private static string SafeText(string text)
        {
            return ToAscii(text ?? string.Empty).Replace('\n', ' ').Replace('\r', ' ');
        }

        private static string CellValue(DataGridViewRow row, string columnName)
        {
            DataGridViewColumn target = null;
            foreach (DataGridViewColumn col in row.DataGridView.Columns)
            {
                if (string.Equals(col.Name, columnName, StringComparison.OrdinalIgnoreCase)
                    || string.Equals(col.HeaderText, columnName, StringComparison.OrdinalIgnoreCase))
                {
                    target = col;
                    break;
                }
            }

            if (target == null)
            {
                return string.Empty;
            }

            object value = row.Cells[target.Index].Value;
            return value == null || value == DBNull.Value ? string.Empty : value.ToString();
        }

        private static decimal ToDecimal(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            decimal value;
            string cleaned = text.Replace(",", string.Empty).Trim();
            if (decimal.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
            {
                return value;
            }

            if (decimal.TryParse(text, NumberStyles.Any, CultureInfo.CurrentCulture, out value))
            {
                return value;
            }

            return 0;
        }

        private static string Center(string text, int width)
        {
            string input = SafeText(text);
            if (input.Length >= width)
            {
                return input;
            }

            int left = (width - input.Length) / 2;
            return new string(' ', left) + input;
        }

        private static byte[] BuildSimplePdf(List<string> rawLines)
        {
            const int linesPerPage = 48;
            List<List<string>> pages = new List<List<string>>();

            for (int i = 0; i < rawLines.Count; i += linesPerPage)
            {
                pages.Add(rawLines.GetRange(i, Math.Min(linesPerPage, rawLines.Count - i)));
            }

            int fontObjNum = 3 + (pages.Count * 2);
            List<string> objects = new List<string>
            {
                "<< /Type /Catalog /Pages 2 0 R >>"
            };

            StringBuilder kidsBuilder = new StringBuilder();
            for (int i = 0; i < pages.Count; i++)
            {
                int pageObjNum = 4 + (i * 2);
                kidsBuilder.Append(pageObjNum).Append(" 0 R ");
            }

            objects.Add("<< /Type /Pages /Kids [" + kidsBuilder.ToString().TrimEnd() + "] /Count " + pages.Count + " >>");

            for (int i = 0; i < pages.Count; i++)
            {
                int contentObjNum = 3 + (i * 2);

                StringBuilder content = new StringBuilder();
                content.Append("BT\n/F1 10 Tf\n30 805 Td\n");

                for (int lineIndex = 0; lineIndex < pages[i].Count; lineIndex++)
                {
                    string line = pages[i][lineIndex];
                    if (lineIndex == 0)
                    {
                        content.Append("(").Append(EscapePdfText(line)).Append(") Tj\n");
                    }
                    else
                    {
                        content.Append("0 -16 Td\n(").Append(EscapePdfText(line)).Append(") Tj\n");
                    }
                }

                content.Append("ET");

                string stream = content.ToString();
                int length = Encoding.ASCII.GetByteCount(stream);
                objects.Add("<< /Length " + length + " >>\nstream\n" + stream + "\nendstream");
                objects.Add("<< /Type /Page /Parent 2 0 R /MediaBox [0 0 595 842] /Resources << /Font << /F1 " + fontObjNum + " 0 R >> >> /Contents " + contentObjNum + " 0 R >>");
            }

            objects.Add("<< /Type /Font /Subtype /Type1 /BaseFont /Courier >>");

            return BuildPdfDocument(objects);
        }

        private static byte[] BuildPdfDocument(List<string> objects)
        {
            using (MemoryStream ms = new MemoryStream())
            using (StreamWriter writer = new StreamWriter(ms, new UTF8Encoding(false), 1024, true))
            {
                writer.NewLine = "\n";
                writer.Write("%PDF-1.4\n");
                writer.Flush();

                List<long> offsets = new List<long> { 0 };
                for (int i = 0; i < objects.Count; i++)
                {
                    offsets.Add(ms.Position);
                    writer.Write((i + 1).ToString(CultureInfo.InvariantCulture));
                    writer.Write(" 0 obj\n");
                    writer.Write(objects[i]);
                    writer.Write("\nendobj\n");
                    writer.Flush();
                }

                long xrefPos = ms.Position;
                writer.Write("xref\n");
                writer.Write("0 " + (objects.Count + 1).ToString(CultureInfo.InvariantCulture) + "\n");
                writer.Write("0000000000 65535 f \n");
                for (int i = 1; i < offsets.Count; i++)
                {
                    writer.Write(offsets[i].ToString("D10", CultureInfo.InvariantCulture));
                    writer.Write(" 00000 n \n");
                }

                writer.Write("trailer\n");
                writer.Write("<< /Size " + (objects.Count + 1).ToString(CultureInfo.InvariantCulture) + " /Root 1 0 R >>\n");
                writer.Write("startxref\n");
                writer.Write(xrefPos.ToString(CultureInfo.InvariantCulture));
                writer.Write("\n%%EOF");
                writer.Flush();

                return ms.ToArray();
            }
        }

        private static string EscapePdfText(string input)
        {
            return input.Replace("\\", "\\\\").Replace("(", "\\(").Replace(")", "\\)");
        }

        private static string ToAscii(string input)
        {
            string normalized = (input ?? string.Empty).Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < normalized.Length; i++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(normalized[i]);
                if (uc == UnicodeCategory.NonSpacingMark)
                {
                    continue;
                }

                char c = normalized[i];
                if (c == 'đ') c = 'd';
                if (c == 'Đ') c = 'D';
                if (c < 32 || c > 126)
                {
                    c = '?';
                }

                sb.Append(c);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
