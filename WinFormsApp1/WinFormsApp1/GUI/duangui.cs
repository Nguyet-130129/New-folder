using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinFormsApp1.BUS;
using WinFormsApp1.DTO;
using WinFormsApp1.DAO;

namespace WinFormsApp1.GUI
{
    public partial class duangui : UserControl
    {
        static duanbus duAnBUS = new duanbus();
        duandto duAnDTO = new duandto();
        List<duandto> duAns = duAnBUS.GetDuAn();

        private void LoadDataToGUI()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Check", typeof(bool));
            dt.Columns.Add("Ma Du An", typeof(string));
            dt.Columns.Add("Ten Du An", typeof(string));
            dt.Columns.Add("Mo Ta", typeof(string));
            dt.Columns.Add("Ngay Bat Dau", typeof(string));
            dt.Columns.Add("Ngay Ket Thuc", typeof(string));
            dt.Columns.Add("Quan Ly Du An", typeof(string));
            dt.Columns.Add("Phong Ban Phu Trach", typeof(string));
            dt.Columns.Add("Trang Thai", typeof(string));

            foreach (duandto duAn in duAns)
            {
                dt.Rows.Add(false, duAn.MaDuAn, duAn.TenDuAn, duAn.MoTa, duAn.NgayBatDau.ToString("dd/MM/yyyy"),
                    duAn.NgayKetThuc.ToString("dd/MM/yyyy"), duAn.QuanLyDuAn, duAn.PhongBanPhuTrach, duAn.TrangThai);
            }
            dataGridView1.DataSource = dt;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public duangui()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel4.Width = button1.Width;
            panel4.Left = button1.Left;
            button1.ForeColor = Color.Green;
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            txtMoTa = new TextBox();
            txtTenDuAn = new TextBox();
            txtMaDuAn = new TextBox();
            txtQuanLyDuAn = new TextBox();
            txtPhongBanPhuTrach = new TextBox();
            cboTrangThai = new ComboBox();
            dtpNgayBatDau = new DateTimePicker();
            dtpNgayKetThuc = new DateTimePicker();
            lblMoTa = new Label();
            lblTenDuAn = new Label();
            lblMaDuAn = new Label();
            lblQuanLyDuAn = new Label();
            lblPhongBanPhuTrach = new Label();
            lblTrangThai = new Label();
            lblNgayBatDau = new Label();
            lblNgayKetThuc = new Label();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            btnDelete = new Button();
            btnImport = new Button();
            btnExport = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1581, 951);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(1581, 840);
            panel5.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtMoTa);
            panel7.Controls.Add(txtTenDuAn);
            panel7.Controls.Add(txtMaDuAn);
            panel7.Controls.Add(txtQuanLyDuAn);
            panel7.Controls.Add(txtPhongBanPhuTrach);
            panel7.Controls.Add(cboTrangThai);
            panel7.Controls.Add(dtpNgayBatDau);
            panel7.Controls.Add(dtpNgayKetThuc);
            panel7.Controls.Add(lblMoTa);
            panel7.Controls.Add(lblTenDuAn);
            panel7.Controls.Add(lblMaDuAn);
            panel7.Controls.Add(lblQuanLyDuAn);
            panel7.Controls.Add(lblPhongBanPhuTrach);
            panel7.Controls.Add(lblTrangThai);
            panel7.Controls.Add(lblNgayBatDau);
            panel7.Controls.Add(lblNgayKetThuc);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 405);
            panel7.Name = "panel7";
            panel7.Size = new Size(1581, 435);
            panel7.TabIndex = 1;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(150, 100);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(300, 100);
            txtMoTa.TabIndex = 2;
            // 
            // txtTenDuAn
            // 
            txtTenDuAn.Location = new Point(150, 60);
            txtTenDuAn.Name = "txtTenDuAn";
            txtTenDuAn.Size = new Size(300, 23);
            txtTenDuAn.TabIndex = 1;
            // 
            // txtMaDuAn
            // 
            txtMaDuAn.Location = new Point(150, 20);
            txtMaDuAn.Name = "txtMaDuAn";
            txtMaDuAn.Size = new Size(300, 23);
            txtMaDuAn.TabIndex = 0;
            // 
            // txtQuanLyDuAn
            // 
            txtQuanLyDuAn.Location = new Point(650, 20);
            txtQuanLyDuAn.Name = "txtQuanLyDuAn";
            txtQuanLyDuAn.Size = new Size(300, 23);
            txtQuanLyDuAn.TabIndex = 5;
            // 
            // txtPhongBanPhuTrach
            // 
            txtPhongBanPhuTrach.Location = new Point(650, 60);
            txtPhongBanPhuTrach.Name = "txtPhongBanPhuTrach";
            txtPhongBanPhuTrach.Size = new Size(300, 23);
            txtPhongBanPhuTrach.TabIndex = 6;
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Chưa bắt đầu", "Đang thực hiện", "Hoàn thành", "Tạm dừng", "Hủy bỏ" });
            cboTrangThai.Location = new Point(650, 100);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(300, 23);
            cboTrangThai.TabIndex = 7;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Location = new Point(150, 220);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(300, 23);
            dtpNgayBatDau.TabIndex = 3;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Location = new Point(150, 260);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(300, 23);
            dtpNgayKetThuc.TabIndex = 4;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(20, 100);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(38, 15);
            lblMoTa.TabIndex = 0;
            lblMoTa.Text = "Mô tả:";
            // 
            // lblTenDuAn
            // 
            lblTenDuAn.AutoSize = true;
            lblTenDuAn.Location = new Point(20, 60);
            lblTenDuAn.Name = "lblTenDuAn";
            lblTenDuAn.Size = new Size(61, 15);
            lblTenDuAn.TabIndex = 0;
            lblTenDuAn.Text = "Tên dự án:";
            // 
            // lblMaDuAn
            // 
            lblMaDuAn.AutoSize = true;
            lblMaDuAn.Location = new Point(20, 20);
            lblMaDuAn.Name = "lblMaDuAn";
            lblMaDuAn.Size = new Size(60, 15);
            lblMaDuAn.TabIndex = 0;
            lblMaDuAn.Text = "Mã dự án:";
            // 
            // lblQuanLyDuAn
            // 
            lblQuanLyDuAn.AutoSize = true;
            lblQuanLyDuAn.Location = new Point(520, 20);
            lblQuanLyDuAn.Name = "lblQuanLyDuAn";
            lblQuanLyDuAn.Size = new Size(81, 15);
            lblQuanLyDuAn.TabIndex = 0;
            lblQuanLyDuAn.Text = "Quản lý dự án:";
            // 
            // lblPhongBanPhuTrach
            // 
            lblPhongBanPhuTrach.AutoSize = true;
            lblPhongBanPhuTrach.Location = new Point(520, 60);
            lblPhongBanPhuTrach.Name = "lblPhongBanPhuTrach";
            lblPhongBanPhuTrach.Size = new Size(117, 15);
            lblPhongBanPhuTrach.TabIndex = 0;
            lblPhongBanPhuTrach.Text = "Phòng ban phụ trách:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(520, 100);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(62, 15);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.AutoSize = true;
            lblNgayBatDau.Location = new Point(20, 220);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(79, 15);
            lblNgayBatDau.TabIndex = 0;
            lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.AutoSize = true;
            lblNgayKetThuc.Location = new Point(20, 260);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new Size(84, 15);
            lblNgayKetThuc.TabIndex = 0;
            lblNgayKetThuc.Text = "Ngày kết thúc:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1581, 405);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(200, 158, 255);
            panel4.Location = new Point(0, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 3);
            panel4.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1581, 60);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(157, 54);
            button1.TabIndex = 0;
            button1.Text = "Đang thực hiện";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(166, 3);
            button2.Name = "button2";
            button2.Size = new Size(157, 54);
            button2.TabIndex = 1;
            button2.Text = "Tất cả";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(329, 3);
            button3.Name = "button3";
            button3.Size = new Size(157, 54);
            button3.TabIndex = 2;
            button3.Text = "Đã hoàn thành";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1581, 51);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDelete);
            panel6.Controls.Add(btnImport);
            panel6.Controls.Add(btnExport);
            panel6.Controls.Add(btnAdd);
            panel6.Controls.Add(btnSearch);
            panel6.Controls.Add(txtSearch);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(341, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1240, 49);
            panel6.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(500, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(581, 12);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 4;
            btnImport.Text = "Nhập";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(662, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 3;
            btnExport.Text = "Xuất";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(743, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(419, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(3, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(410, 23);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 1;
            label1.Text = "Dự án";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(252, 250, 255);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(1581, 2);
            panel3.TabIndex = 0;
            // 
            // duangui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "duangui";
            Size = new Size(1581, 951);
            Load += duangui_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        private void duangui_Load(object sender, EventArgs e)
        {
            LoadDataToGUI();
            dataGridView1.Size = new Size(1575, 870);
            panel7.Visible = false;
            panel4.Width = button1.Width;
            panel4.Left = button1.Left;
            button1.ForeColor = Color.FromArgb(49, 17, 117);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Width = button1.Width;
            panel4.Left = button1.Left;
            button1.ForeColor = Color.FromArgb(49, 17, 117);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.FromArgb(64, 64, 64);
            // Filter projects by "Đang thực hiện" status
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Width = button2.Width;
            panel4.Left = button2.Left;
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button2.ForeColor = Color.FromArgb(49, 17, 117);
            button3.ForeColor = Color.FromArgb(64, 64, 64);
            // Show all projects
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Width = button3.Width;
            panel4.Left = button3.Left;
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button3.ForeColor = Color.FromArgb(49, 17, 117);
            // Filter projects by "Đã hoàn thành" status
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaDuAn.Text = row.Cells["Ma Du An"].Value.ToString();
                txtTenDuAn.Text = row.Cells["Ten Du An"].Value.ToString();
                txtMoTa.Text = row.Cells["Mo Ta"].Value.ToString();
                dtpNgayBatDau.Value = DateTime.Parse(row.Cells["Ngay Bat Dau"].Value.ToString());
                dtpNgayKetThuc.Value = DateTime.Parse(row.Cells["Ngay Ket Thuc"].Value.ToString());
                txtQuanLyDuAn.Text = row.Cells["Quan Ly Du An"].Value.ToString();
                txtPhongBanPhuTrach.Text = row.Cells["Phong Ban Phu Trach"].Value.ToString();
                cboTrangThai.Text = row.Cells["Trang Thai"].Value.ToString();

                panel7.Visible = true;
                dataGridView1.Size = new Size(1575, 450);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Implement search functionality
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Implement add new project functionality
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Implement export functionality
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Implement import functionality
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Implement delete functionality
        }

        private Panel panel1;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private Panel panel6;
        private Button btnDelete;
        private Button btnImport;
        private Button btnExport;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Panel panel7;
        private TextBox txtMoTa;
        private TextBox txtTenDuAn;
        private TextBox txtMaDuAn;
        private TextBox txtQuanLyDuAn;
        private TextBox txtPhongBanPhuTrach;
        private ComboBox cboTrangThai;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpNgayKetThuc;
        private Label lblMoTa;
        private Label lblTenDuAn;
        private Label lblMaDuAn;
        private Label lblQuanLyDuAn;
        private Label lblPhongBanPhuTrach;
        private Label lblTrangThai;
        private Label lblNgayBatDau;
        private Label lblNgayKetThuc;
        private Panel panel3;
    }
}