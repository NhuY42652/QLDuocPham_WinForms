using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    public partial class frmNhanVien : Form
    {
        private readonly DataGridView dgvNhanVien = new DataGridView();
        private readonly Panel pnlCard = new Panel();
        private readonly Panel pnlGrid = new Panel();
        private readonly Panel pnlEditor = new Panel();
        private readonly FlowLayoutPanel flpButtons = new FlowLayoutPanel();
        private readonly Button btnThem = new Button();
        private readonly Button btnSua = new Button();
        private readonly Button btnXoa = new Button();
        private readonly Button btnLamMoi = new Button();

        private readonly Dictionary<string, Control> _editControls = new Dictionary<string, Control>();
        private readonly List<DataColumn> _orderedColumns = new List<DataColumn>();
        private DataTable _table;
        private string _pkColumn;

        public frmNhanVien()
        {
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            Text = "Quản lý nhân viên";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(700, 560);
            MinimumSize = new Size(700, 560);
            BackColor = Color.FromArgb(245, 247, 250);

            Panel pnlHeader = new Panel
            {
                BackColor = Color.FromArgb(26, 58, 92),
                Dock = DockStyle.Top,
                Height = 64
            };
            Label lblTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(18, 10),
                Text = "🧑‍💼  Quản lý Nhân viên"
            };
            Label lblSubTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Color.FromArgb(180, 200, 220),
                Location = new Point(18, 36),
                Text = "Thêm, chỉnh sửa và xoá thông tin nhân viên"
            };
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubTitle);
            Controls.Add(pnlHeader);

            pnlCard.BackColor = Color.White;
            pnlCard.Location = new Point(0, 70);
            pnlCard.Size = new Size(684, 170);
            Controls.Add(pnlCard);

            pnlEditor.Location = new Point(10, 10);
            pnlEditor.Size = new Size(396, 150);
            pnlEditor.BackColor = Color.White;
            pnlCard.Controls.Add(pnlEditor);

            flpButtons.Location = new Point(420, 20);
            flpButtons.Size = new Size(222, 87);
            pnlCard.Controls.Add(flpButtons);

            SetupButton(btnThem, "＋ Thêm", Color.FromArgb(39, 174, 96), btnThem_Click);
            SetupButton(btnSua, "✎ Sửa", Color.FromArgb(46, 134, 222), btnSua_Click);
            SetupButton(btnXoa, "✕ Xóa", Color.FromArgb(231, 76, 60), btnXoa_Click);
            SetupButton(btnLamMoi, "↺ Làm mới", Color.FromArgb(100, 116, 139), btnLamMoi_Click, true);
            flpButtons.Controls.Add(btnThem);
            flpButtons.Controls.Add(btnSua);
            flpButtons.Controls.Add(btnXoa);
            flpButtons.Controls.Add(btnLamMoi);

            pnlGrid.BackColor = Color.White;
            pnlGrid.Location = new Point(0, 246);
            pnlGrid.Size = new Size(684, 265);
            Controls.Add(pnlGrid);

            Label lblGridTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(26, 58, 92),
                Location = new Point(12, 9),
                Text = "Danh sách nhân viên"
            };
            pnlGrid.Controls.Add(lblGridTitle);

            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 58, 92);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNhanVien.GridColor = Color.FromArgb(230, 235, 241);
            dgvNhanVien.Location = new Point(12, 38);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowTemplate.Height = 28;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(660, 214);
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            pnlGrid.Controls.Add(dgvNhanVien);

            Load += frmNhanVien_Load;
        }

        private static void SetupButton(Button btn, string text, Color backColor, EventHandler handler, bool isLast = false)
        {
            btn.BackColor = backColor;
            btn.Cursor = Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.Size = new Size(100, 40);
            btn.Margin = isLast ? new Padding(0) : new Padding(0, 0, 8, 0);
            btn.Text = text;
            btn.UseVisualStyleBackColor = false;
            btn.Click += handler;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            using (SqlConnection conn = Database.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", conn))
            {
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                _table = new DataTable();
                da.Fill(_table);
                dgvNhanVien.DataSource = _table;

                _pkColumn = _table.PrimaryKey.Length > 0 ? _table.PrimaryKey[0].ColumnName : _table.Columns[0].ColumnName;

                if (_editControls.Count == 0)
                {
                    BuildEditorFromTable();
                }

                ClearInputs();
            }
        }

        private void BuildEditorFromTable()
        {            
            int x = 0;
            int y = 0;
            const int labelWidth = 110;
            const int inputWidth = 82;
            const int rowHeight = 34;
            const int gapX = 10;
            const int gapY = 6;
            int col = 0;

            _orderedColumns.Clear();
            foreach (DataColumn dc in _table.Columns)
            {
                _orderedColumns.Add(dc);

                Label lbl = new Label
                {
                    Text = dc.ColumnName + ":",
                    TextAlign = ContentAlignment.MiddleRight,
                    Size = new Size(labelWidth, 28),
                    Location = new Point(x, y),
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(100, 115, 132)
                };

                TextBox txt = new TextBox
                {
                    Name = "txt" + dc.ColumnName,
                    Size = new Size(inputWidth, 24),
                    Location = new Point(x + labelWidth + 6, y + 2),
                    Font = new Font("Segoe UI", 9.5F),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                if (dc.ColumnName.Equals(_pkColumn, StringComparison.OrdinalIgnoreCase))
                {
                    txt.ReadOnly = true;
                    txt.BackColor = Color.FromArgb(240, 244, 250);
                }

                pnlEditor.Controls.Add(lbl);
                pnlEditor.Controls.Add(txt);
                _editControls[dc.ColumnName] = txt;

                col++;
                if (col == 2)
                {
                    col = 0;
                    x = 0;
                    y += rowHeight + gapY;
                }
                else
                {
                    x += labelWidth + inputWidth + gapX;
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvNhanVien.Rows[e.RowIndex].IsNewRow) return;
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            foreach (DataColumn dc in _orderedColumns)
            {
                if (!_editControls.ContainsKey(dc.ColumnName)) continue;
                string value = row.Cells[dc.ColumnName].Value == null || row.Cells[dc.ColumnName].Value == DBNull.Value
                    ? string.Empty
                    : row.Cells[dc.ColumnName].Value.ToString();
                _editControls[dc.ColumnName].Text = value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataColumn> insertCols = _orderedColumns.Where(c => !c.AutoIncrement).ToList();
                string colNames = string.Join(",", insertCols.Select(c => c.ColumnName));
                string colParams = string.Join(",", insertCols.Select(c => "@" + c.ColumnName));

                string sql = "INSERT INTO NhanVien(" + colNames + ") VALUES(" + colParams + ")";

                using (SqlConnection conn = Database.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    foreach (DataColumn dc in insertCols)
                    {
                        string txt = _editControls[dc.ColumnName].Text.Trim();
                        cmd.Parameters.AddWithValue("@" + dc.ColumnName, string.IsNullOrWhiteSpace(txt) ? (object)DBNull.Value : txt);
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm nhân viên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_editControls.ContainsKey(_pkColumn) || string.IsNullOrWhiteSpace(_editControls[_pkColumn].Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                List<DataColumn> updateCols = _orderedColumns.Where(c => !c.ColumnName.Equals(_pkColumn, StringComparison.OrdinalIgnoreCase)).ToList();
                string setClause = string.Join(",", updateCols.Select(c => c.ColumnName + "=@" + c.ColumnName));
                string sql = "UPDATE NhanVien SET " + setClause + " WHERE " + _pkColumn + "=@PK";

                using (SqlConnection conn = Database.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    foreach (DataColumn dc in updateCols)
                    {
                        string txt = _editControls[dc.ColumnName].Text.Trim();
                        cmd.Parameters.AddWithValue("@" + dc.ColumnName, string.IsNullOrWhiteSpace(txt) ? (object)DBNull.Value : txt);
                    }

                    cmd.Parameters.AddWithValue("@PK", _editControls[_pkColumn].Text.Trim());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật nhân viên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_editControls.ContainsKey(_pkColumn) || string.IsNullOrWhiteSpace(_editControls[_pkColumn].Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                string sql = "DELETE FROM NhanVien WHERE " + _pkColumn + "=@PK";
                using (SqlConnection conn = Database.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@PK", _editControls[_pkColumn].Text.Trim());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Xóa nhân viên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            foreach (Control ctl in _editControls.Values)
            {
                ctl.Text = string.Empty;
            }
        }
    }
}
