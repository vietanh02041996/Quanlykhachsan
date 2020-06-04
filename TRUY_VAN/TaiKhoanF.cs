﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_Khach_San.DATABASE;
using System.Data;
namespace Quan_Ly_Khach_San.TRUY_VAN
{
    public class TaiKhoanF
    {
        private KetNoiData connect = new KetNoiData();
        public string LayPass(string us)
        {
            return connect.GetValue(@"select MatKhau from tblTaiKhoan where MaNV = '" + us + "'");
        }

        public string LayLoatTK(string us)
        {
            return connect.GetValue(@"select LoaiTK from tblTaiKhoan where MaNV = '" + us + "'");
        }
        public DataTable LayDanhSachTK()
        {
            return connect.GetDataTable(@"select MaNV from tblTaiKhoan");
        }
        public DataTable LayDanhSachTK(string dk)
        {
            return connect.GetDataTable(@"select MaNV from tblTaiKhoan where " + dk);
        }
        public void DoiMatKhau(TaiKhoan EC_TK)
        {
            connect.ThucHienLenh(@"update tblTaiKhoan set MatKhau = '" + EC_TK.MatKhau + "' where MaNV = '" + EC_TK.MaNV + "'");
        }
        public void DoiLoai(TaiKhoan EC_TK)
        {
            connect.ThucHienLenh(@"update tblTaiKhoan set LoaiTK = '" + EC_TK.LoaiTK + "' where MaNV = '" + EC_TK.MaNV + "'");
        }
        public void XoaTK(TaiKhoan EC_TK)
        {
            connect.ThucHienLenh(@"delete from tblNhanVien where MaNV = '" + EC_TK.MaNV + "'");
            connect.ThucHienLenh(@"delete from tblTaiKhoan where MaNV = '" + EC_TK.MaNV + "'");
        }
        public void ThemTK(TaiKhoan EC_TK)
        {
            connect.ThucHienLenh(@"insert into tblTaiKhoan(MaNV, MatKhau, LoaiTK) values(N'" + EC_TK.MaNV + "', N'" + EC_TK.MatKhau + "', '" + EC_TK.LoaiTK + "') ");
        }
    }
}
