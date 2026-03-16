using System.Drawing;
using System.Windows.Forms;

namespace QLDuocPham_WinForms
{
    /// <summary>
    /// Runtime theme helpers. NOT used inside InitializeComponent / Designer files.
    /// Call ApplyTheme() from each form's Load event or constructor after InitializeComponent().
    /// </summary>
    public static class UITheme
    {
        // Palette
        public static readonly Color PrimaryDark = Color.FromArgb(26, 58, 92);
        public static readonly Color PrimaryMid = Color.FromArgb(30, 80, 130);
        public static readonly Color Accent = Color.FromArgb(46, 134, 222);
        public static readonly Color Success = Color.FromArgb(39, 174, 96);
        public static readonly Color Danger = Color.FromArgb(231, 76, 60);
        public static readonly Color Warning = Color.FromArgb(243, 156, 18);
        public static readonly Color BgPage = Color.FromArgb(245, 247, 250);
        public static readonly Color BgCard = Color.White;
        public static readonly Color BgSidebar = Color.FromArgb(26, 58, 92);
        public static readonly Color BgSidebarItem = Color.FromArgb(22, 48, 78);
        public static readonly Color TextPrimary = Color.FromArgb(30, 40, 55);
        public static readonly Color TextSecondary = Color.FromArgb(100, 115, 132);
        public static readonly Color TextOnDark = Color.White;
        public static readonly Color TextOnDarkSub = Color.FromArgb(180, 200, 220);
        public static readonly Color BorderLight = Color.FromArgb(220, 228, 238);
        public static readonly Color InputReadOnly = Color.FromArgb(240, 244, 250);

        // Fonts
        public static readonly Font FontTitle = new Font("Segoe UI", 18f, FontStyle.Bold);
        public static readonly Font FontSection = new Font("Segoe UI", 11f, FontStyle.Bold);
        public static readonly Font FontLabel = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        public static readonly Font FontInput = new Font("Segoe UI", 9.5f, FontStyle.Regular);
        public static readonly Font FontBtn = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        public static readonly Font FontSmall = new Font("Segoe UI", 8.5f, FontStyle.Regular);
        public static readonly Font FontSidebar = new Font("Segoe UI", 10f, FontStyle.Regular);
        public static readonly Font FontSidebarH = new Font("Segoe UI", 11f, FontStyle.Bold);

        /// <summary>Style a DataGridView at runtime.</summary>
        public static void StyleGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = BgCard;
            dgv.GridColor = BorderLight;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Font = FontSmall;
            dgv.RowTemplate.Height = 28;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryDark;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 249, 255);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 255);
            dgv.DefaultCellStyle.SelectionForeColor = TextPrimary;
            dgv.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
        }

        /// <summary>Style a sidebar nav button at runtime.</summary>
        public static void StyleSidebarButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = BgSidebar;
            btn.ForeColor = TextOnDarkSub;
            btn.Font = FontSidebar;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = BgSidebarItem;
            btn.FlatAppearance.MouseDownBackColor = PrimaryMid;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(12, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
        }

        /// <summary>Add a colored left accent bar to a card panel.</summary>
        public static void AddAccentBar(Panel card, Color accent)
        {
            var bar = new Panel { BackColor = accent, Location = new Point(0, 0), Size = new Size(4, card.Height) };
            card.Controls.Add(bar);
            bar.BringToFront();
        }
    }
}