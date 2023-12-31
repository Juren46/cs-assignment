﻿namespace GUI.FormChinh
{
    partial class BanHangForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sanPhamFlowLayoutPanel = new FlowLayoutPanel();
            maKhachHangLabel = new Label();
            lamMoiKhachHangButton = new Button();
            label5 = new Label();
            label4 = new Label();
            chonKhachHangButton = new Button();
            label3 = new Label();
            loaiSanPhamComboBox = new ComboBox();
            chiTietFlowLayoutPanel = new FlowLayoutPanel();
            lamMoiSanPhamButton = new Button();
            timKiemSanPhamTextBox = new TextBox();
            tongTienLabel = new Label();
            label1 = new Label();
            hoanTatButton = new Button();
            panel5 = new Panel();
            lamMoiKhuyenMaiButton = new Button();
            tenKhuyenMaiLabel = new Label();
            label2 = new Label();
            giamGiaLabel = new Label();
            tienThuaLabel = new Label();
            label10 = new Label();
            tienNhanTextBox = new TextBox();
            label9 = new Label();
            thanhTienLabel = new Label();
            label7 = new Label();
            chonKhuyenMaiButton = new Button();
            panel4 = new Panel();
            khuyenMaiThanhVienCheckBox = new CheckBox();
            soDienThoaiLabel = new Label();
            panel3 = new Panel();
            timKiemSanPhamButton = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sanPhamFlowLayoutPanel
            // 
            sanPhamFlowLayoutPanel.AutoScroll = true;
            sanPhamFlowLayoutPanel.BackColor = Color.PowderBlue;
            sanPhamFlowLayoutPanel.Dock = DockStyle.Fill;
            sanPhamFlowLayoutPanel.Location = new Point(0, 120);
            sanPhamFlowLayoutPanel.Margin = new Padding(0);
            sanPhamFlowLayoutPanel.Name = "sanPhamFlowLayoutPanel";
            sanPhamFlowLayoutPanel.Size = new Size(572, 540);
            sanPhamFlowLayoutPanel.TabIndex = 1;
            // 
            // maKhachHangLabel
            // 
            maKhachHangLabel.AutoSize = true;
            maKhachHangLabel.BorderStyle = BorderStyle.FixedSingle;
            maKhachHangLabel.Location = new Point(339, 9);
            maKhachHangLabel.Margin = new Padding(0);
            maKhachHangLabel.Name = "maKhachHangLabel";
            maKhachHangLabel.Size = new Size(195, 27);
            maKhachHangLabel.TabIndex = 5;
            maKhachHangLabel.Text = "Chưa chọn khách hàng";
            // 
            // lamMoiKhachHangButton
            // 
            lamMoiKhachHangButton.BackColor = Color.SkyBlue;
            lamMoiKhachHangButton.FlatAppearance.BorderSize = 0;
            lamMoiKhachHangButton.FlatStyle = FlatStyle.Flat;
            lamMoiKhachHangButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lamMoiKhachHangButton.Location = new Point(16, 48);
            lamMoiKhachHangButton.Margin = new Padding(0);
            lamMoiKhachHangButton.Name = "lamMoiKhachHangButton";
            lamMoiKhachHangButton.Size = new Size(112, 34);
            lamMoiKhachHangButton.TabIndex = 4;
            lamMoiKhachHangButton.Text = "Làm mới";
            lamMoiKhachHangButton.UseVisualStyleBackColor = false;
            lamMoiKhachHangButton.Click += LamMoiKhachHangButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(219, 45);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 2;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(220, 6);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(38, 25);
            label4.TabIndex = 1;
            label4.Text = "Mã";
            // 
            // chonKhachHangButton
            // 
            chonKhachHangButton.AutoSize = true;
            chonKhachHangButton.BackColor = Color.FromArgb(0, 192, 192);
            chonKhachHangButton.FlatAppearance.BorderSize = 0;
            chonKhachHangButton.FlatStyle = FlatStyle.Flat;
            chonKhachHangButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chonKhachHangButton.Location = new Point(16, 9);
            chonKhachHangButton.Margin = new Padding(0);
            chonKhachHangButton.Name = "chonKhachHangButton";
            chonKhachHangButton.Size = new Size(175, 37);
            chonKhachHangButton.TabIndex = 0;
            chonKhachHangButton.Text = "Chọn khách hàng";
            chonKhachHangButton.UseVisualStyleBackColor = false;
            chonKhachHangButton.Click += ChonKhachHangButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(30, 28);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 4;
            label3.Text = "Loại sản phẩm";
            // 
            // loaiSanPhamComboBox
            // 
            loaiSanPhamComboBox.FormattingEnabled = true;
            loaiSanPhamComboBox.Location = new Point(160, 25);
            loaiSanPhamComboBox.Margin = new Padding(0);
            loaiSanPhamComboBox.Name = "loaiSanPhamComboBox";
            loaiSanPhamComboBox.Size = new Size(216, 33);
            loaiSanPhamComboBox.TabIndex = 3;
            loaiSanPhamComboBox.SelectionChangeCommitted += LoaiSanPhamComboBox_SelectionChangeCommitted;
            // 
            // chiTietFlowLayoutPanel
            // 
            chiTietFlowLayoutPanel.AutoScroll = true;
            chiTietFlowLayoutPanel.BackColor = Color.PowderBlue;
            chiTietFlowLayoutPanel.Dock = DockStyle.Fill;
            chiTietFlowLayoutPanel.Location = new Point(0, 120);
            chiTietFlowLayoutPanel.Margin = new Padding(0);
            chiTietFlowLayoutPanel.Name = "chiTietFlowLayoutPanel";
            chiTietFlowLayoutPanel.Size = new Size(572, 353);
            chiTietFlowLayoutPanel.TabIndex = 2;
            // 
            // lamMoiSanPhamButton
            // 
            lamMoiSanPhamButton.BackColor = Color.SkyBlue;
            lamMoiSanPhamButton.FlatAppearance.BorderSize = 0;
            lamMoiSanPhamButton.FlatStyle = FlatStyle.Flat;
            lamMoiSanPhamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lamMoiSanPhamButton.Location = new Point(431, 62);
            lamMoiSanPhamButton.Margin = new Padding(0);
            lamMoiSanPhamButton.Name = "lamMoiSanPhamButton";
            lamMoiSanPhamButton.Size = new Size(112, 34);
            lamMoiSanPhamButton.TabIndex = 2;
            lamMoiSanPhamButton.Text = "Làm mới";
            lamMoiSanPhamButton.UseVisualStyleBackColor = false;
            lamMoiSanPhamButton.Click += LamMoiSanPhamButton_Click;
            // 
            // timKiemSanPhamTextBox
            // 
            timKiemSanPhamTextBox.Location = new Point(30, 64);
            timKiemSanPhamTextBox.Margin = new Padding(0);
            timKiemSanPhamTextBox.Name = "timKiemSanPhamTextBox";
            timKiemSanPhamTextBox.PlaceholderText = "Tìm kiếm";
            timKiemSanPhamTextBox.Size = new Size(277, 31);
            timKiemSanPhamTextBox.TabIndex = 0;
            timKiemSanPhamTextBox.TextChanged += TimKiemSanPhamTextBox_TextChanged;
            // 
            // tongTienLabel
            // 
            tongTienLabel.AutoSize = true;
            tongTienLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tongTienLabel.Location = new Point(130, 133);
            tongTienLabel.Margin = new Padding(0);
            tongTienLabel.Name = "tongTienLabel";
            tongTienLabel.Size = new Size(58, 38);
            tongTienLabel.TabIndex = 2;
            tongTienLabel.Text = "0 đ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 138);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 1;
            label1.Text = "Tổng tiền";
            // 
            // hoanTatButton
            // 
            hoanTatButton.AutoSize = true;
            hoanTatButton.BackColor = Color.Teal;
            hoanTatButton.FlatAppearance.BorderSize = 0;
            hoanTatButton.FlatStyle = FlatStyle.Flat;
            hoanTatButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hoanTatButton.ForeColor = Color.White;
            hoanTatButton.Location = new Point(421, 128);
            hoanTatButton.Margin = new Padding(0);
            hoanTatButton.Name = "hoanTatButton";
            hoanTatButton.Size = new Size(141, 50);
            hoanTatButton.TabIndex = 0;
            hoanTatButton.Text = "Hoàn tất";
            hoanTatButton.UseVisualStyleBackColor = false;
            hoanTatButton.Click += HoanTatButton_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(223, 243, 252);
            panel5.Controls.Add(lamMoiKhuyenMaiButton);
            panel5.Controls.Add(tenKhuyenMaiLabel);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(giamGiaLabel);
            panel5.Controls.Add(tienThuaLabel);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(tienNhanTextBox);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(thanhTienLabel);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(chonKhuyenMaiButton);
            panel5.Controls.Add(tongTienLabel);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(hoanTatButton);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 473);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(572, 187);
            panel5.TabIndex = 1;
            // 
            // lamMoiKhuyenMaiButton
            // 
            lamMoiKhuyenMaiButton.BackColor = Color.SkyBlue;
            lamMoiKhuyenMaiButton.FlatAppearance.BorderSize = 0;
            lamMoiKhuyenMaiButton.FlatStyle = FlatStyle.Flat;
            lamMoiKhuyenMaiButton.Location = new Point(447, 36);
            lamMoiKhuyenMaiButton.Name = "lamMoiKhuyenMaiButton";
            lamMoiKhuyenMaiButton.Size = new Size(112, 34);
            lamMoiKhuyenMaiButton.TabIndex = 13;
            lamMoiKhuyenMaiButton.Text = "Làm mới";
            lamMoiKhuyenMaiButton.UseVisualStyleBackColor = false;
            lamMoiKhuyenMaiButton.Click += LamMoiKhuyenMaiButton_Click;
            // 
            // tenKhuyenMaiLabel
            // 
            tenKhuyenMaiLabel.BorderStyle = BorderStyle.FixedSingle;
            tenKhuyenMaiLabel.Location = new Point(282, 71);
            tenKhuyenMaiLabel.Name = "tenKhuyenMaiLabel";
            tenKhuyenMaiLabel.Size = new Size(278, 54);
            tenKhuyenMaiLabel.TabIndex = 12;
            tenKhuyenMaiLabel.Text = "Chưa chọn khuyến mãi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 11);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 4;
            label2.Text = "Giảm giá";
            // 
            // giamGiaLabel
            // 
            giamGiaLabel.AutoSize = true;
            giamGiaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            giamGiaLabel.Location = new Point(106, 11);
            giamGiaLabel.Margin = new Padding(0);
            giamGiaLabel.Name = "giamGiaLabel";
            giamGiaLabel.Size = new Size(38, 25);
            giamGiaLabel.TabIndex = 5;
            giamGiaLabel.Text = "0 đ";
            giamGiaLabel.TextChanged += GiamGiaLabel_TextChanged;
            // 
            // tienThuaLabel
            // 
            tienThuaLabel.AutoSize = true;
            tienThuaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tienThuaLabel.Location = new Point(106, 72);
            tienThuaLabel.Margin = new Padding(0);
            tienThuaLabel.Name = "tienThuaLabel";
            tienThuaLabel.Size = new Size(38, 25);
            tienThuaLabel.TabIndex = 11;
            tienThuaLabel.Text = "0 đ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 72);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(90, 25);
            label10.TabIndex = 10;
            label10.Text = "Tiền thừa";
            // 
            // tienNhanTextBox
            // 
            tienNhanTextBox.Location = new Point(106, 39);
            tienNhanTextBox.Margin = new Padding(0);
            tienNhanTextBox.Name = "tienNhanTextBox";
            tienNhanTextBox.Size = new Size(150, 31);
            tienNhanTextBox.TabIndex = 9;
            tienNhanTextBox.Text = "0";
            tienNhanTextBox.TextChanged += TienNhanTextBox_TextChanged;
            tienNhanTextBox.KeyPress += TienNhanTextBox_KeyPress;
            tienNhanTextBox.MouseLeave += TienNhanTextBox_MouseLeave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 41);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 8;
            label9.Text = "Tiền nhận";
            // 
            // thanhTienLabel
            // 
            thanhTienLabel.AutoSize = true;
            thanhTienLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thanhTienLabel.Location = new Point(382, 11);
            thanhTienLabel.Margin = new Padding(0);
            thanhTienLabel.Name = "thanhTienLabel";
            thanhTienLabel.Size = new Size(38, 25);
            thanhTienLabel.TabIndex = 7;
            thanhTienLabel.Text = "0 đ";
            thanhTienLabel.TextChanged += ThanhTienLabel_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(282, 11);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(100, 25);
            label7.TabIndex = 6;
            label7.Text = "Thành tiền";
            // 
            // chonKhuyenMaiButton
            // 
            chonKhuyenMaiButton.AutoSize = true;
            chonKhuyenMaiButton.BackColor = Color.FromArgb(0, 192, 192);
            chonKhuyenMaiButton.FlatAppearance.BorderSize = 0;
            chonKhuyenMaiButton.FlatStyle = FlatStyle.Flat;
            chonKhuyenMaiButton.Location = new Point(282, 36);
            chonKhuyenMaiButton.Margin = new Padding(0);
            chonKhuyenMaiButton.Name = "chonKhuyenMaiButton";
            chonKhuyenMaiButton.Size = new Size(162, 35);
            chonKhuyenMaiButton.TabIndex = 3;
            chonKhuyenMaiButton.Text = "Chọn khuyến mãi";
            chonKhuyenMaiButton.UseVisualStyleBackColor = false;
            chonKhuyenMaiButton.Click += ChonKhuyenMaiButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(223, 243, 252);
            panel4.Controls.Add(khuyenMaiThanhVienCheckBox);
            panel4.Controls.Add(soDienThoaiLabel);
            panel4.Controls.Add(maKhachHangLabel);
            panel4.Controls.Add(lamMoiKhachHangButton);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(chonKhachHangButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(572, 120);
            panel4.TabIndex = 0;
            // 
            // khuyenMaiThanhVienCheckBox
            // 
            khuyenMaiThanhVienCheckBox.AutoSize = true;
            khuyenMaiThanhVienCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            khuyenMaiThanhVienCheckBox.Location = new Point(16, 82);
            khuyenMaiThanhVienCheckBox.Margin = new Padding(0);
            khuyenMaiThanhVienCheckBox.Name = "khuyenMaiThanhVienCheckBox";
            khuyenMaiThanhVienCheckBox.Size = new Size(302, 29);
            khuyenMaiThanhVienCheckBox.TabIndex = 7;
            khuyenMaiThanhVienCheckBox.Text = "Áp dụng khuyến mãi thành viên";
            khuyenMaiThanhVienCheckBox.UseVisualStyleBackColor = true;
            khuyenMaiThanhVienCheckBox.CheckedChanged += KhuyenMaiThanhVienCheckBox_CheckedChanged;
            // 
            // soDienThoaiLabel
            // 
            soDienThoaiLabel.AutoSize = true;
            soDienThoaiLabel.BorderStyle = BorderStyle.FixedSingle;
            soDienThoaiLabel.Location = new Point(339, 45);
            soDienThoaiLabel.Margin = new Padding(0);
            soDienThoaiLabel.Name = "soDienThoaiLabel";
            soDienThoaiLabel.Size = new Size(195, 27);
            soDienThoaiLabel.TabIndex = 6;
            soDienThoaiLabel.Text = "Chưa chọn khách hàng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(223, 243, 252);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(loaiSanPhamComboBox);
            panel3.Controls.Add(lamMoiSanPhamButton);
            panel3.Controls.Add(timKiemSanPhamButton);
            panel3.Controls.Add(timKiemSanPhamTextBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(572, 120);
            panel3.TabIndex = 0;
            // 
            // timKiemSanPhamButton
            // 
            timKiemSanPhamButton.BackColor = Color.Gold;
            timKiemSanPhamButton.FlatAppearance.BorderSize = 0;
            timKiemSanPhamButton.FlatStyle = FlatStyle.Flat;
            timKiemSanPhamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            timKiemSanPhamButton.Location = new Point(307, 62);
            timKiemSanPhamButton.Margin = new Padding(0);
            timKiemSanPhamButton.Name = "timKiemSanPhamButton";
            timKiemSanPhamButton.Size = new Size(112, 34);
            timKiemSanPhamButton.TabIndex = 1;
            timKiemSanPhamButton.Text = "Tìm kiếm";
            timKiemSanPhamButton.UseVisualStyleBackColor = false;
            timKiemSanPhamButton.Click += TimKiemSanPhamButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(chiTietFlowLayoutPanel);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(572, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 660);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(sanPhamFlowLayoutPanel);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 660);
            panel1.TabIndex = 2;
            // 
            // BanHangForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BanHangForm";
            Text = "BanHangForm";
            Load += BanHangForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sanPhamFlowLayoutPanel;
        private Button lamMoiKhachHangButton;
        private Label label5;
        private Label label4;
        private Button chonKhachHangButton;
        private Label label3;
        private ComboBox loaiSanPhamComboBox;
        private Button lamMoiSanPhamButton;
        private TextBox timKiemSanPhamTextBox;
        private Label tongTienLabel;
        private Label label1;
        private Button hoanTatButton;
        private Panel panel5;
        private Button chonKhuyenMaiButton;
        private Panel panel4;
        private Panel panel3;
        private Button timKiemSanPhamButton;
        private Panel panel2;
        private Panel panel1;
        private Label tienThuaLabel;
        private Label label10;
        private TextBox tienNhanTextBox;
        private Label label9;
        private Label label7;
        private Label label2;
        private Button lamMoiKhuyenMaiButton;
        internal FlowLayoutPanel chiTietFlowLayoutPanel;
        internal Label thanhTienLabel;
        internal Label giamGiaLabel;
        internal Label tenKhuyenMaiLabel;
        internal Label maKhachHangLabel;
        internal Label soDienThoaiLabel;
        internal CheckBox khuyenMaiThanhVienCheckBox;
    }
}