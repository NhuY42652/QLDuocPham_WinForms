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
    public partial class frmNhanVien : Form
    {
        private readonly DataGridView dgvNhanVien = new DataGridView();
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
            Size = new Size(980, 620);
            BackColor = Color.FromArgb(245, 247, 250);

            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 64,
                BackColor = Color.FromArgb(26, 58, 92)
            };
            Label title = new Label
            {
                AutoSize = true,
                Location = new Point(18, 10),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Text = "🧑‍💼 Quản lý nhân viên"
            };
            Label sub = new Label
            {
                AutoSize = true,
                Location = new Point(18, 36),
                ForeColor = Color.FromArgb(180, 200, 220),
                Font = new Font("Segoe UI", 8.5F),
                Text = "Thêm / sửa / xóa nhân viên"
            };
            header.Controls.Add(title);
            header.Controls.Add(sub);
            Controls.Add(header);

            dgvNhanVien.Dock = DockStyle.Top;
            dgvNhanVien.Height = 320;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            Controls.Add(dgvNhanVien);

            pnlEditor.Dock = DockStyle.Fill;
            pnlEditor.Padding = new Padding(12);
            pnlEditor.BackColor = Color.White;
            Controls.Add(pnlEditor);

            flpButtons.Dock = DockStyle.Bottom;
            flpButtons.Height = 52;
            flpButtons.Padding = new Padding(0, 10, 0, 0);
            pnlEditor.Controls.Add(flpButtons);

            SetupButton(btnThem, "＋ Thêm", Color.FromArgb(39, 174, 96), btnThem_Click);
            SetupButton(btnSua, "✎ Sửa", Color.FromArgb(46, 134, 222), btnSua_Click);
            SetupButton(btnXoa, "✕ Xóa", Color.FromArgb(231, 76, 60), btnXoa_Click);
            SetupButton(btnLamMoi, "↻ Làm mới", Color.FromArgb(100, 116, 139), btnLamMoi_Click);
            flpButtons.Controls.Add(btnThem);
            flpButtons.Controls.Add(btnSua);
            flpButtons.Controls.Add(btnXoa);
            flpButtons.Controls.Add(btnLamMoi);

            Load += frmNhanVien_Load;
        }

        private static void SetupButton(Button btn, string text, Color backColor, EventHandler handler)
        {
            btn.Text = text;
            btn.Width = 110;
            btn.Height = 34;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Click += handler;
            btn.Margin = new Padding(0, 0, 8, 0);
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
            Label lblGuide = new Label
            {
                Text = "Thông tin nhân viên",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(26, 58, 92),
                AutoSize = true,
                Location = new Point(0, 0)
            };
            pnlEditor.Controls.Add(lblGuide);

            int x = 0;
            int y = 32;
            const int labelWidth = 120;
            const int inputWidth = 250;
            const int rowHeight = 34;
            const int gapX = 24;
            const int gapY = 10;
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
                    Size = new Size(inputWidth, 28),
                    Location = new Point(x + labelWidth + 8, y),
                    Font = new Font("Segoe UI", 9.5F),
                    BorderStyle = BorderStyle.FixedSingle
                };

                if (dc.ColumnName.Equals(_pkColumn, StringComparison.OrdinalIgnoreCase))
                {
                    txt.ReadOnly = true;
                    txt.BackColor = Color.FromArgb(245, 247, 250);
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
            foreach (var ctl in _editControls.Values)
            {
                ctl.Text = string.Empty;
            }
        }
    }
}
