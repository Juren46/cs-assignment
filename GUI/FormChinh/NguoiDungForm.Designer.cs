﻿namespace GUI.FormChinh
{
    partial class NguoiDungForm
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
            nguoiDungDataGridView = new DataGridView();
            panel1 = new Panel();
            themButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gioiTinhComboBox = new ComboBox();
            phanQuyenComboBox = new ComboBox();
            trangThaiComboBox = new ComboBox();
            xuatExcel = new Button();
            lamMoiButton = new Button();
            timKiemButton = new Button();
            timKiemTextBox = new TextBox();
            stt = new DataGridViewTextBoxColumn();
            maNguoiDungColumn = new DataGridViewTextBoxColumn();
            phanQuyenColumn = new DataGridViewTextBoxColumn();
            tenDangNhapColumn = new DataGridViewTextBoxColumn();
            hoTenColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            chiTietButtonColumn = new DataGridViewButtonColumn();
            suaButtonColumn = new DataGridViewButtonColumn();
            xoaButtonColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)nguoiDungDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nguoiDungDataGridView
            // 
            nguoiDungDataGridView.AllowUserToAddRows = false;
            nguoiDungDataGridView.AllowUserToDeleteRows = false;
            nguoiDungDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            nguoiDungDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nguoiDungDataGridView.Columns.AddRange(new DataGridViewColumn[] { stt, maNguoiDungColumn, phanQuyenColumn, tenDangNhapColumn, hoTenColumn, trangThaiColumn, chiTietButtonColumn, suaButtonColumn, xoaButtonColumn });
            nguoiDungDataGridView.Dock = DockStyle.Fill;
            nguoiDungDataGridView.Location = new Point(0, 170);
            nguoiDungDataGridView.Margin = new Padding(0);
            nguoiDungDataGridView.Name = "nguoiDungDataGridView";
            nguoiDungDataGridView.ReadOnly = true;
            nguoiDungDataGridView.RowHeadersVisible = false;
            nguoiDungDataGridView.RowHeadersWidth = 62;
            nguoiDungDataGridView.Size = new Size(1144, 490);
            nguoiDungDataGridView.TabIndex = 3;
            nguoiDungDataGridView.CellContentClick += NguoiDungDataGridView_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 243, 252);
            panel1.Controls.Add(themButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(gioiTinhComboBox);
            panel1.Controls.Add(phanQuyenComboBox);
            panel1.Controls.Add(trangThaiComboBox);
            panel1.Controls.Add(xuatExcel);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(timKiemButton);
            panel1.Controls.Add(timKiemTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 170);
            panel1.TabIndex = 2;
            // 
            // themButton
            // 
            themButton.BackColor = Color.Teal;
            themButton.FlatAppearance.BorderSize = 0;
            themButton.FlatStyle = FlatStyle.Flat;
            themButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            themButton.ForeColor = Color.White;
            themButton.Location = new Point(861, 106);
            themButton.Margin = new Padding(0);
            themButton.Name = "themButton";
            themButton.Size = new Size(112, 34);
            themButton.TabIndex = 10;
            themButton.Text = "Thêm";
            themButton.UseVisualStyleBackColor = false;
            themButton.Click += ThemButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(445, 30);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 9;
            label3.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 30);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 8;
            label2.Text = "Phân quyền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 7;
            label1.Text = "Trạng thái";
            // 
            // gioiTinhComboBox
            // 
            gioiTinhComboBox.BackColor = Color.White;
            gioiTinhComboBox.FormattingEnabled = true;
            gioiTinhComboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioiTinhComboBox.Location = new Point(445, 58);
            gioiTinhComboBox.Margin = new Padding(0);
            gioiTinhComboBox.Name = "gioiTinhComboBox";
            gioiTinhComboBox.Size = new Size(182, 33);
            gioiTinhComboBox.TabIndex = 6;
            gioiTinhComboBox.SelectionChangeCommitted += GioiTinhComboBox_SelectionChangeCommitted;
            // 
            // phanQuyenComboBox
            // 
            phanQuyenComboBox.BackColor = Color.White;
            phanQuyenComboBox.FormattingEnabled = true;
            phanQuyenComboBox.Location = new Point(257, 58);
            phanQuyenComboBox.Margin = new Padding(0);
            phanQuyenComboBox.Name = "phanQuyenComboBox";
            phanQuyenComboBox.Size = new Size(182, 33);
            phanQuyenComboBox.TabIndex = 5;
            phanQuyenComboBox.SelectionChangeCommitted += PhanQuyenComboBox_SelectionChangeCommitted;
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.BackColor = Color.White;
            trangThaiComboBox.FormattingEnabled = true;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hoạt động", "Ngừng hoạt động" });
            trangThaiComboBox.Location = new Point(69, 58);
            trangThaiComboBox.Margin = new Padding(0);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.Size = new Size(182, 33);
            trangThaiComboBox.TabIndex = 4;
            trangThaiComboBox.SelectionChangeCommitted += TrangThaiComboBox_SelectionChangeCommitted;
            // 
            // xuatExcel
            // 
            xuatExcel.BackColor = Color.ForestGreen;
            xuatExcel.FlatAppearance.BorderSize = 0;
            xuatExcel.FlatStyle = FlatStyle.Flat;
            xuatExcel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xuatExcel.ForeColor = Color.White;
            xuatExcel.Location = new Point(983, 106);
            xuatExcel.Margin = new Padding(0);
            xuatExcel.Name = "xuatExcel";
            xuatExcel.Size = new Size(112, 34);
            xuatExcel.TabIndex = 3;
            xuatExcel.Text = "Xuất Excel";
            xuatExcel.UseVisualStyleBackColor = false;
            xuatExcel.Click += XuatExcel_Click;
            // 
            // lamMoiButton
            // 
            lamMoiButton.BackColor = Color.SkyBlue;
            lamMoiButton.FlatAppearance.BorderSize = 0;
            lamMoiButton.FlatStyle = FlatStyle.Flat;
            lamMoiButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lamMoiButton.Location = new Point(736, 106);
            lamMoiButton.Margin = new Padding(0);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(112, 34);
            lamMoiButton.TabIndex = 2;
            lamMoiButton.Text = "Làm mới";
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += LamMoiButton_Click;
            // 
            // timKiemButton
            // 
            timKiemButton.BackColor = Color.Gold;
            timKiemButton.FlatAppearance.BorderSize = 0;
            timKiemButton.FlatStyle = FlatStyle.Flat;
            timKiemButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            timKiemButton.Location = new Point(615, 106);
            timKiemButton.Margin = new Padding(0);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(112, 34);
            timKiemButton.TabIndex = 1;
            timKiemButton.Text = "Tìm kiếm";
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += TimKiemButton_Click;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.Location = new Point(69, 106);
            timKiemTextBox.Margin = new Padding(0);
            timKiemTextBox.Multiline = true;
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.Size = new Size(546, 34);
            timKiemTextBox.TabIndex = 0;
            timKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 8;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Width = 76;
            // 
            // maNguoiDungColumn
            // 
            maNguoiDungColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            maNguoiDungColumn.HeaderText = "Mã người dùng";
            maNguoiDungColumn.MinimumWidth = 8;
            maNguoiDungColumn.Name = "maNguoiDungColumn";
            maNguoiDungColumn.ReadOnly = true;
            maNguoiDungColumn.Width = 172;
            // 
            // phanQuyenColumn
            // 
            phanQuyenColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            phanQuyenColumn.HeaderText = "Phân quyền";
            phanQuyenColumn.MinimumWidth = 8;
            phanQuyenColumn.Name = "phanQuyenColumn";
            phanQuyenColumn.ReadOnly = true;
            phanQuyenColumn.Width = 141;
            // 
            // tenDangNhapColumn
            // 
            tenDangNhapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenDangNhapColumn.HeaderText = "Tên đăng nhập";
            tenDangNhapColumn.MinimumWidth = 8;
            tenDangNhapColumn.Name = "tenDangNhapColumn";
            tenDangNhapColumn.ReadOnly = true;
            // 
            // hoTenColumn
            // 
            hoTenColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hoTenColumn.HeaderText = "Họ tên";
            hoTenColumn.MinimumWidth = 8;
            hoTenColumn.Name = "hoTenColumn";
            hoTenColumn.ReadOnly = true;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 8;
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.ReadOnly = true;
            trangThaiColumn.Width = 125;
            // 
            // chiTietButtonColumn
            // 
            chiTietButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            chiTietButtonColumn.FillWeight = 30F;
            chiTietButtonColumn.HeaderText = "Chi tiết";
            chiTietButtonColumn.MinimumWidth = 8;
            chiTietButtonColumn.Name = "chiTietButtonColumn";
            chiTietButtonColumn.ReadOnly = true;
            chiTietButtonColumn.Text = "Chi tiết";
            chiTietButtonColumn.UseColumnTextForButtonValue = true;
            chiTietButtonColumn.Width = 73;
            // 
            // suaButtonColumn
            // 
            suaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            suaButtonColumn.FillWeight = 30F;
            suaButtonColumn.HeaderText = "Sửa";
            suaButtonColumn.MinimumWidth = 8;
            suaButtonColumn.Name = "suaButtonColumn";
            suaButtonColumn.ReadOnly = true;
            suaButtonColumn.Text = "Sửa";
            suaButtonColumn.UseColumnTextForButtonValue = true;
            suaButtonColumn.Width = 48;
            // 
            // xoaButtonColumn
            // 
            xoaButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            xoaButtonColumn.FillWeight = 30F;
            xoaButtonColumn.HeaderText = "Xóa";
            xoaButtonColumn.MinimumWidth = 8;
            xoaButtonColumn.Name = "xoaButtonColumn";
            xoaButtonColumn.ReadOnly = true;
            xoaButtonColumn.Text = "Xóa";
            xoaButtonColumn.UseColumnTextForButtonValue = true;
            xoaButtonColumn.Width = 49;
            // 
            // NguoiDungForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 660);
            Controls.Add(nguoiDungDataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "NguoiDungForm";
            Text = "NguoiDungForm";
            Load += NguoiDungForm_Load;
            ((System.ComponentModel.ISupportInitialize)nguoiDungDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView nguoiDungDataGridView;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox gioiTinhComboBox;
        private ComboBox phanQuyenComboBox;
        private ComboBox trangThaiComboBox;
        private Button xuatExcel;
        private Button lamMoiButton;
        private Button timKiemButton;
        private TextBox timKiemTextBox;
        private Button themButton;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maNguoiDungColumn;
        private DataGridViewTextBoxColumn phanQuyenColumn;
        private DataGridViewTextBoxColumn tenDangNhapColumn;
        private DataGridViewTextBoxColumn hoTenColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewButtonColumn chiTietButtonColumn;
        private DataGridViewButtonColumn suaButtonColumn;
        private DataGridViewButtonColumn xoaButtonColumn;
    }
}