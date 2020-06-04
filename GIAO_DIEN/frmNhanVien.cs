﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Khach_San.DATABASE;
using Quan_Ly_Khach_San.TRUY_VAN;
namespace Quan_Ly_Khach_San.GIAO_DIEN
{
    public partial class frmNhanVien : Form
    {
        private TaiKhoan EC_TK = new TaiKhoan();
        private TaiKhoanF DAL_TK = new TaiKhoanF();
        private NhanVien EC_NV = new NhanVien();
        private NhanVienF DAL_NV = new NhanVienF();
        private bool _kochon;
        private bool _them = false;
        private bool _suangs = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void load_lst()
        {
            lstDanhSachNV.Items.Add(frmMain._taikhoan);
            DataTable tbl = DAL_TK.LayDanhSachTK("MaNV != 'ADMIN' and MaNV != '" + frmMain._taikhoan + "'");
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                lstDanhSachNV.Items.Add(tbl.Rows[i]["MaNV"].ToString());
            }
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            chkAD.Hide();

            tltChuThich.SetToolTip(btnLuu, "Lưu thông tin người dùng");
            tltChuThich.SetToolTip(btnThemTK, "Thêm người dùng");
            tltChuThich.SetToolTip(btn_SuaTT, "Sửa thông tin người dùng");
            tltChuThich.SetToolTip(btnXoaTK, "Xóa người dùng");
            tltChuThich.SetToolTip(btnXoaTT, "Xóa thông tin người dùng");
            frmMain._taikhoan = frmMain._taikhoan.ToUpper();
            if (frmMain._taikhoan == "ADMIN")
            {
                chkAD.Enabled = true;
            }
            else
            {
                chkAD.Enabled = false;
            }
            string _loaiTK = DAL_TK.LayLoatTK(frmMain._taikhoan);
            if (_loaiTK == "1")
            {
                btnXoaTK.Enabled = true;
                btnThemTK.Enabled = true;
                //load danh sach tai khoan
                load_lst();
            }
            else
            {
                lstDanhSachNV.Items.Add(frmMain._taikhoan);
            }
            //lstDanhSachNV.SelectedIndex = 0;
            //DataTable a = DAL_NV.ThongTinNV(lstDanhSachNV.Text);
            //txtHoTen.Text = a.Rows[1].ToString();
        }

        private void lstDanhSachNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = lstDanhSachNV.Text;
            DataTable dt = DAL_NV.ThongTinNV(lstDanhSachNV.Text);
            txtHoTen.Text = dt.Rows[0][1].ToString();
            dtpNgaySinh.Text = dt.Rows[0][2].ToString();
            cboGioiTinh.Text = dt.Rows[0][3].ToString(); ;
            txtCMND.Text = dt.Rows[0][4].ToString();
            txtSoDT.Text = dt.Rows[0][6].ToString(); ;
            txtDiaChi.Text = dt.Rows[0][5].ToString();
            txtPass.Text = "";
            if(txtMaNV.Text != "ADMIN")
                chkAD.Checked = false;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            txtHoTen_TextChanged(null, null);
            _them = true;
            // mo text box
            txtMaNV.ReadOnly = false;
            txtPass.ReadOnly = false;
            //reset text
            txtMaNV.ResetText();
            txtPass.ResetText();
            if (frmMain._taikhoan == "ADMIN")
            {
                chkAD.Enabled = true;
                chkAD.Checked = false;
            }
            else
            {
                chkAD.Enabled = false;
            }
            txtHoTen.ResetText();
            cboGioiTinh.ResetText();
            dtpNgaySinh.ResetText();
            txtCMND.ResetText();
            txtSoDT.ResetText();
            txtDiaChi.ResetText();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã nhân viên ");
                return;
            }
            if (_them)
            {
                EC_TK.MaNV = txtMaNV.Text;
                EC_TK.MatKhau = txtPass.Text;
                if (chkAD.Checked)
                    EC_TK.LoaiTK = "1";
                else
                    EC_TK.LoaiTK = "0";
                //them tai khoan
                DAL_TK.ThemTK(EC_TK);
                lstDanhSachNV.Items.Clear();
                load_lst();
                txtMaNV.ReadOnly = true;
                txtPass.ReadOnly = true;
                EC_NV.MaNV = txtMaNV.Text;
                EC_NV.TenNV = txtHoTen.Text;
                EC_NV.GioiTinh = cboGioiTinh.Text;
                EC_NV.NgaySinh = dtpNgaySinh.Value.Year.ToString() + "-" + dtpNgaySinh.Value.Month.ToString() + "-" + dtpNgaySinh.Value.Day.ToString();
                EC_NV.DiaChi = txtDiaChi.Text;
                EC_NV.SoDT = txtSoDT.Text;
                EC_NV.CMND = txtCMND.Text;
                DAL_NV.ThemThongTin(EC_NV);
            }
            else
            {
                //txtMaNV.ReadOnly = true;
                //txtPass.ReadOnly = true;
                EC_NV.MaNV = txtMaNV.Text;
                EC_NV.TenNV = txtHoTen.Text;
                EC_NV.GioiTinh = cboGioiTinh.Text;
                EC_NV.DiaChi = txtDiaChi.Text;
                EC_NV.SoDT = txtSoDT.Text;
                EC_NV.CMND = txtCMND.Text;
                //if (_suangs)
                EC_NV.NgaySinh = dtpNgaySinh.Value.Year.ToString() + "-" + dtpNgaySinh.Value.Month.ToString() + "-" + dtpNgaySinh.Value.Day.ToString();
                //else EC_NV.NgaySinh = "";
                DAL_NV.SuaThongTin(EC_NV);
                ////update tt tai khoan
                //EC_TK.MaNV = txtMaNV.Text;
                //if (chkAD.Checked) EC_TK.LoaiTK = "1";
                //else EC_TK.LoaiTK = "0";
                //DAL_TK.DoiLoai(EC_TK);
            }
            btnLuu.Enabled = false;
            _them = false;
            _suangs = false;
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            //xoa tai khoan dc chon
            if (txtMaNV.Text != "ADMIN")
            {
                //xoa
                EC_TK.MaNV = txtMaNV.Text;
                DAL_TK.XoaTK(EC_TK);
                lstDanhSachNV.Items.Clear();
                load_lst();
            }
            else
            {
                MessageBox.Show("Không thể xóa tài khoản ADMIN");
            }

        }

        private void btn_SuaTT_Click(object sender, EventArgs e)
        {
            _them = false;
            btnLuu.Enabled = true;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            _kochon = false;
            EC_TK.MaNV = txtMaNV.Text;
            DAL_TK.XoaTK(EC_TK);
            txtHoTen.ResetText();
            cboGioiTinh.ResetText();
            dtpNgaySinh.ResetText();
            txtCMND.ResetText();
            txtSoDT.ResetText();
            txtDiaChi.ResetText();
            //xoa thong tin NV
            _kochon = true;
            lstDanhSachNV.Items.Clear();
            load_lst();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (btnDoiMK.Text != "OK")
            {
                btnDoiMK.Text = "OK";
                txtPass.ReadOnly = false;
            }
            else
            {
                btnDoiMK.Text = "Đổi mật khẩu";
                txtPass.ReadOnly = true;
                EC_TK.MaNV = txtMaNV.Text;
                EC_TK.MatKhau = txtPass.Text;
                DAL_TK.DoiMatKhau(EC_TK);
                MessageBox.Show("Đổi mật khẩu thành công");
            }
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tltChuThich_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}