﻿namespace WinFormsApp1
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panNav = new Panel();
            chamcong = new Button();
            nhanvien = new Button();
            bangluong = new Button();
            baohiem = new Button();
            button10 = new Button();
            thongbao = new Button();
            tuyendung = new Button();
            duan = new Button();
            phongban = new Button();
            home = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            fontDialog1 = new FontDialog();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(panNav);
            panel1.Controls.Add(chamcong);
            panel1.Controls.Add(nhanvien);
            panel1.Controls.Add(bangluong);
            panel1.Controls.Add(baohiem);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(thongbao);
            panel1.Controls.Add(tuyendung);
            panel1.Controls.Add(duan);
            panel1.Controls.Add(phongban);
            panel1.Controls.Add(home);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 1053);
            panel1.TabIndex = 0;
            // 
            // panNav
            // 
            panNav.BackColor = Color.FromArgb(0, 126, 249);
            panNav.Location = new Point(0, 193);
            panNav.Name = "panNav";
            panNav.Size = new Size(7, 100);
            panNav.TabIndex = 3;
            // 
            // chamcong
            // 
            chamcong.Dock = DockStyle.Top;
            chamcong.FlatAppearance.BorderSize = 0;
            chamcong.FlatStyle = FlatStyle.Flat;
            chamcong.ForeColor = Color.FromArgb(192, 192, 255);
            chamcong.Image = Properties.Resources.home;
            chamcong.ImageAlign = ContentAlignment.MiddleLeft;
            chamcong.Location = new Point(0, 584);
            chamcong.Name = "chamcong";
            chamcong.Size = new Size(186, 55);
            chamcong.TabIndex = 2;
            chamcong.Text = "Chấm công";
            chamcong.TextAlign = ContentAlignment.MiddleRight;
            chamcong.TextImageRelation = TextImageRelation.TextBeforeImage;
            chamcong.UseVisualStyleBackColor = true;
            chamcong.Click += chamcong_Click;
            chamcong.Leave += chamcong_Leave;
            // 
            // nhanvien
            // 
            nhanvien.Dock = DockStyle.Top;
            nhanvien.FlatAppearance.BorderSize = 0;
            nhanvien.FlatStyle = FlatStyle.Flat;
            nhanvien.ForeColor = Color.FromArgb(192, 192, 255);
            nhanvien.Image = Properties.Resources.home;
            nhanvien.ImageAlign = ContentAlignment.MiddleLeft;
            nhanvien.Location = new Point(0, 529);
            nhanvien.Name = "nhanvien";
            nhanvien.Size = new Size(186, 55);
            nhanvien.TabIndex = 2;
            nhanvien.Text = "Nhân viên";
            nhanvien.TextAlign = ContentAlignment.MiddleRight;
            nhanvien.TextImageRelation = TextImageRelation.TextBeforeImage;
            nhanvien.UseVisualStyleBackColor = true;
            nhanvien.Click += nhanvien_Click;
            nhanvien.Leave += nhanvien_Leave;
            // 
            // bangluong
            // 
            bangluong.Dock = DockStyle.Top;
            bangluong.FlatAppearance.BorderSize = 0;
            bangluong.FlatStyle = FlatStyle.Flat;
            bangluong.ForeColor = Color.FromArgb(192, 192, 255);
            bangluong.Image = Properties.Resources.home;
            bangluong.ImageAlign = ContentAlignment.MiddleLeft;
            bangluong.Location = new Point(0, 474);
            bangluong.Name = "bangluong";
            bangluong.Size = new Size(186, 55);
            bangluong.TabIndex = 2;
            bangluong.Text = "Bảng lương";
            bangluong.TextAlign = ContentAlignment.MiddleRight;
            bangluong.TextImageRelation = TextImageRelation.TextBeforeImage;
            bangluong.UseVisualStyleBackColor = true;
            bangluong.Click += bangluong_Click;
            bangluong.Leave += bangluong_Leave;
            // 
            // baohiem
            // 
            baohiem.Dock = DockStyle.Top;
            baohiem.FlatAppearance.BorderSize = 0;
            baohiem.FlatStyle = FlatStyle.Flat;
            baohiem.ForeColor = Color.FromArgb(192, 192, 255);
            baohiem.Image = Properties.Resources.home;
            baohiem.ImageAlign = ContentAlignment.MiddleLeft;
            baohiem.Location = new Point(0, 419);
            baohiem.Name = "baohiem";
            baohiem.Size = new Size(186, 55);
            baohiem.TabIndex = 2;
            baohiem.Text = "Bảo hiểm";
            baohiem.TextAlign = ContentAlignment.MiddleRight;
            baohiem.TextImageRelation = TextImageRelation.TextBeforeImage;
            baohiem.UseVisualStyleBackColor = true;
            baohiem.Click += baohiem_Click;
            baohiem.Leave += baohiem_Leave;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Bottom;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.FromArgb(192, 192, 255);
            button10.Image = Properties.Resources.home;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(0, 998);
            button10.Name = "button10";
            button10.Size = new Size(186, 55);
            button10.TabIndex = 2;
            button10.Text = "Dashboard  ";
            button10.TextAlign = ContentAlignment.MiddleRight;
            button10.TextImageRelation = TextImageRelation.TextBeforeImage;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // thongbao
            // 
            thongbao.Dock = DockStyle.Top;
            thongbao.FlatAppearance.BorderSize = 0;
            thongbao.FlatStyle = FlatStyle.Flat;
            thongbao.ForeColor = Color.FromArgb(192, 192, 255);
            thongbao.Image = Properties.Resources.home;
            thongbao.ImageAlign = ContentAlignment.MiddleLeft;
            thongbao.Location = new Point(0, 364);
            thongbao.Name = "thongbao";
            thongbao.Size = new Size(186, 55);
            thongbao.TabIndex = 2;
            thongbao.Text = "Thông báo";
            thongbao.TextAlign = ContentAlignment.MiddleRight;
            thongbao.TextImageRelation = TextImageRelation.TextBeforeImage;
            thongbao.UseVisualStyleBackColor = true;
            thongbao.Click += thongbao_Click;
            thongbao.Leave += thongbao_Leave;
            // 
            // tuyendung
            // 
            tuyendung.Dock = DockStyle.Top;
            tuyendung.FlatAppearance.BorderSize = 0;
            tuyendung.FlatStyle = FlatStyle.Flat;
            tuyendung.ForeColor = Color.FromArgb(192, 192, 255);
            tuyendung.Image = Properties.Resources.home;
            tuyendung.ImageAlign = ContentAlignment.MiddleLeft;
            tuyendung.Location = new Point(0, 309);
            tuyendung.Name = "tuyendung";
            tuyendung.Size = new Size(186, 55);
            tuyendung.TabIndex = 2;
            tuyendung.Text = "Tuyển dụng";
            tuyendung.TextAlign = ContentAlignment.MiddleRight;
            tuyendung.TextImageRelation = TextImageRelation.TextBeforeImage;
            tuyendung.UseVisualStyleBackColor = true;
            tuyendung.Click += tuyendung_Click;
            tuyendung.Leave += tuyendung_Leave;
            // 
            // duan
            // 
            duan.Dock = DockStyle.Top;
            duan.FlatAppearance.BorderSize = 0;
            duan.FlatStyle = FlatStyle.Flat;
            duan.ForeColor = Color.FromArgb(192, 192, 255);
            duan.Image = Properties.Resources.home;
            duan.ImageAlign = ContentAlignment.MiddleLeft;
            duan.Location = new Point(0, 254);
            duan.Name = "duan";
            duan.Size = new Size(186, 55);
            duan.TabIndex = 2;
            duan.Text = "Dự án";
            duan.TextAlign = ContentAlignment.MiddleRight;
            duan.TextImageRelation = TextImageRelation.TextBeforeImage;
            duan.UseVisualStyleBackColor = true;
            duan.Click += duan_Click;
            duan.Leave += duan_Leave;
            // 
            // phongban
            // 
            phongban.Dock = DockStyle.Top;
            phongban.FlatAppearance.BorderSize = 0;
            phongban.FlatStyle = FlatStyle.Flat;
            phongban.ForeColor = Color.FromArgb(192, 192, 255);
            phongban.Image = Properties.Resources.home;
            phongban.ImageAlign = ContentAlignment.MiddleLeft;
            phongban.Location = new Point(0, 199);
            phongban.Name = "phongban";
            phongban.Size = new Size(186, 55);
            phongban.TabIndex = 2;
            phongban.Text = "Phòng ban";
            phongban.TextAlign = ContentAlignment.MiddleRight;
            phongban.TextImageRelation = TextImageRelation.TextBeforeImage;
            phongban.UseVisualStyleBackColor = true;
            phongban.Click += phongban_Click;
            phongban.Leave += phongban_Leave;
            // 
            // home
            // 
            home.BackColor = Color.FromArgb(24, 30, 54);
            home.Dock = DockStyle.Top;
            home.FlatAppearance.BorderSize = 0;
            home.FlatStyle = FlatStyle.Flat;
            home.ForeColor = Color.FromArgb(192, 192, 255);
            home.Image = Properties.Resources.home;
            home.ImageAlign = ContentAlignment.MiddleLeft;
            home.Location = new Point(0, 144);
            home.Name = "home";
            home.Size = new Size(186, 55);
            home.TabIndex = 2;
            home.Text = "Dashboard  ";
            home.TextAlign = ContentAlignment.MiddleRight;
            home.TextImageRelation = TextImageRelation.TextBeforeImage;
            home.UseVisualStyleBackColor = false;
            home.Click += home_Click;
            home.Leave += home_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(158, 161, 178);
            label2.Location = new Point(25, 106);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 2;
            label2.Text = "User text here";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 156, 149);
            label1.Location = new Point(48, 86);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "User name";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.hr;
            pictureBox1.Location = new Point(48, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.Navy;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(186, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1698, 0);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1884, 1053);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "index";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private FontDialog fontDialog1;
        private Button home;
        private Button tuyendung;
        private Button duan;
        private Button phongban;
        private Button chamcong;
        private Button nhanvien;
        private Button bangluong;
        private Button thongbao;
        private Panel panNav;
        private Button baohiem;
        private Button button10;
        private Panel panel3;
    }
}
