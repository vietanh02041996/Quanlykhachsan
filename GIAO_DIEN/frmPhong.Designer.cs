﻿namespace Quan_Ly_Khach_San.GIAO_DIEN
{
	partial class frmPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPh = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripTextBox();
            this.btnSua = new System.Windows.Forms.ToolStripTextBox();
            this.btnXoa = new System.Windows.Forms.ToolStripTextBox();
            this.btnLuu = new System.Windows.Forms.ToolStripTextBox();
            this.btnLamMoi = new System.Windows.Forms.ToolStripTextBox();
            this.btnThoat = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblTimKiem = new System.Windows.Forms.ToolStripLabel();
            this.txtTimMaPhong = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimSoPhong = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimTrangThai = new System.Windows.Forms.ToolStripTextBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTrangThai);
            this.panel1.Controls.Add(this.txtSoPhong);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.lblMaPh);
            this.panel1.Controls.Add(this.lblTrangThai);
            this.panel1.Controls.Add(this.lblSoPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 114);
            this.panel1.TabIndex = 6;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(113, 74);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(237, 20);
            this.txtTrangThai.TabIndex = 5;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(113, 44);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(237, 20);
            this.txtSoPhong.TabIndex = 4;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(113, 14);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(237, 20);
            this.txtMaPhong.TabIndex = 3;
            // 
            // lblMaPh
            // 
            this.lblMaPh.AutoSize = true;
            this.lblMaPh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPh.Location = new System.Drawing.Point(16, 17);
            this.lblMaPh.Name = "lblMaPh";
            this.lblMaPh.Size = new System.Drawing.Size(75, 17);
            this.lblMaPh.TabIndex = 0;
            this.lblMaPh.Text = "Mã Phòng";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(16, 77);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(74, 17);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhong.Location = new System.Drawing.Point(16, 47);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(68, 17);
            this.lblSoPhong.TabIndex = 1;
            this.lblSoPhong.Text = "Số phòng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnLamMoi,
            this.btnThoat});

            this.menuStrip1.Location = new System.Drawing.Point(0, 114);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(556, 50);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 46);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 46);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 46);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 46);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(70, 46);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 46);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {

                //this.menuStrip1.Location = new System.Drawing.Point(0, 140)
            });
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(601, 62);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(92, 58);
			this.btnThem.Text = "Thêm";
			this.btnThem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(92, 58);
			this.btnSua.Text = "Sửa";
			this.btnSua.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(92, 58);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(92, 58);
			this.btnLuu.Text = "Lưu";
			this.btnLuu.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(92, 58);
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(92, 58);
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {

            //this.menuStrip1.Location = new System.Drawing.Point(0, 140)
            });
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(601, 62);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(92, 58);
			this.btnThem.Text = "Thêm";
			this.btnThem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(92, 58);
			this.btnSua.Text = "Sửa";
			this.btnSua.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(92, 58);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(92, 58);
			this.btnLuu.Text = "Lưu";
			this.btnLuu.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(92, 58);
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(92, 58);
			this.btnThoat.Text = "Thoát";
			this.btnThoat.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {

            this.lblTimKiem,
            this.txtTimMaPhong,
            this.txtTimSoPhong,
            this.txtTimTrangThai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 164);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 50);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(38, 47);
            this.lblTimKiem.Text = "Tìm ";
            // 
            // txtTimMaPhong
            // 
            this.txtTimMaPhong.Name = "txtTimMaPhong";
            this.txtTimMaPhong.Size = new System.Drawing.Size(99, 50);
            this.txtTimMaPhong.Text = "Mã phòng";
            // 
            // txtTimSoPhong
            // 
            this.txtTimSoPhong.Name = "txtTimSoPhong";
            this.txtTimSoPhong.Size = new System.Drawing.Size(98, 50);
            this.txtTimSoPhong.Text = "Số phòng";
            // 
            // txtTimTrangThai
            // 
            this.txtTimTrangThai.Name = "txtTimTrangThai";
            this.txtTimTrangThai.Size = new System.Drawing.Size(93, 50);
            this.txtTimTrangThai.Text = "Trạng thái";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colSoPhong,
            this.colTrangThai});

            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 214);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.Size = new System.Drawing.Size(556, 152);
            this.dgvDanhSach.TabIndex = 9;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            //this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPh";
            this.colMaPhong.HeaderText = "Mã Phòng";
            this.colMaPhong.Name = "colMaPhong";
            // 
            // colSoPhong
            // 
            this.colSoPhong.DataPropertyName = "SoPhong";
            this.colSoPhong.HeaderText = "Số phòng";
            this.colSoPhong.Name = "colSoPhong";
            // 
            // colTrangThai
            // 
            this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            // 
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 366);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhong";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

			this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDanhSach.Location = new System.Drawing.Point(0, 264);
			this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDanhSach.Name = "dgvDanhSach";
			this.dgvDanhSach.Size = new System.Drawing.Size(601, 462);
			this.dgvDanhSach.TabIndex = 9;
			//this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
			// 
			// colMaPhong
			// 
			this.colMaPhong.DataPropertyName = "MaPh";
			this.colMaPhong.HeaderText = "Mã Phòng";
			this.colMaPhong.Name = "colMaPhong";
			// 
			// colSoPhong
			// 
			this.colSoPhong.DataPropertyName = "SoPhong";
			this.colSoPhong.HeaderText = "Số phòng";
			this.colSoPhong.Name = "colSoPhong";
			// 
			// colTrangThai
			// 
			this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTrangThai.DataPropertyName = "TrangThai";
			this.colTrangThai.HeaderText = "Trạng thái";
			this.colTrangThai.Name = "colTrangThai";
			// 
			// frmPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 726);
			this.Controls.Add(this.dgvDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmPhong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPhong";
			this.Load += new System.EventHandler(this.frmPhong_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
			this.ResumeLayout(false);

			this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDanhSach.Location = new System.Drawing.Point(0, 264);
			this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDanhSach.Name = "dgvDanhSach";
			this.dgvDanhSach.Size = new System.Drawing.Size(601, 462);
			this.dgvDanhSach.TabIndex = 9;
			this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
			// 
			// colMaPhong
			// 
			this.colMaPhong.DataPropertyName = "MaPh";
			this.colMaPhong.HeaderText = "Mã Phòng";
			this.colMaPhong.Name = "colMaPhong";
			// 
			// colSoPhong
			// 
			this.colSoPhong.DataPropertyName = "SoPhong";
			this.colSoPhong.HeaderText = "Số phòng";
			this.colSoPhong.Name = "colSoPhong";
			// 
			// colTrangThai
			// 
			this.colTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTrangThai.DataPropertyName = "TrangThai";
			this.colTrangThai.HeaderText = "Trạng thái";
			this.colTrangThai.Name = "colTrangThai";
			// 
			// frmPhong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 726);
			this.Controls.Add(this.dgvDanhSach);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmPhong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPhong";
			this.Load += new System.EventHandler(this.frmPhong_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
			this.ResumeLayout(false);


		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtTrangThai;
		private System.Windows.Forms.TextBox txtSoPhong;
		private System.Windows.Forms.TextBox txtMaPhong;
		private System.Windows.Forms.Label lblMaPh;
		private System.Windows.Forms.Label lblTrangThai;
		private System.Windows.Forms.Label lblSoPhong;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripTextBox btnThem;
		private System.Windows.Forms.ToolStripTextBox btnSua;
		private System.Windows.Forms.ToolStripTextBox btnXoa;
		private System.Windows.Forms.ToolStripTextBox btnLuu;
		private System.Windows.Forms.ToolStripTextBox btnLamMoi;
		private System.Windows.Forms.ToolStripTextBox btnThoat;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel lblTimKiem;
		private System.Windows.Forms.ToolStripTextBox txtTimMaPhong;
		private System.Windows.Forms.ToolStripTextBox txtTimSoPhong;
		private System.Windows.Forms.ToolStripTextBox txtTimTrangThai;
		private System.Windows.Forms.DataGridView dgvDanhSach;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSoPhong;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
	}
}