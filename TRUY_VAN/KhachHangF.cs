using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Quan_Ly_Khach_San.TRUY_VAN;


namespace Quan_Ly_Khach_San
{
    public class KhachHangF
    {
        KetNoiData cn = new KetNoiData();
        public DataTable getAllKhachHang()
        {
            return cn.GetDataTable(@"SELECT * FROM tblKhachHang");
        }
        public int soluong()
        { 
             return (cn.ThucHienLenh(@" select count(MaKH) from tblKhachHang"));
        }
        public int Them(KhachHang et)
        {
            string a = "1995-12-12";
            return(cn.ThucHienLenh(@"insert into tblKhachHang values ('" + et.MaKH + "',N'" + et.TenKH + "','" + et.NgaySinh + "',N'" + et.GT + "','" + et.SoDT + "','" + et.CMND + "',N'" + et.DiaChi + "')"));
            //return (cn.ThucHienLenh(@"themkh  '" + et.MaKH + "',N'" + et.TenKH + "','" + et.NgaySinh + "',N'" + et.GT + "','" + et.SoDT + "','" + et.CMND + "',N'" + et.DiaChi + "'"));
        }
        public int Sua(KhachHang et)
        {
            string a = "1995-12-12";
            return (cn.ThucHienLenh(@"update tblKhachHang SET TenKH = N'" + et.TenKH + "',NgaySinh = '" + et.NgaySinh + "',GT = N'" + et.GT + "', SoDT = '" + et.SoDT + "',CMND = '" + et.CMND + "',DiaChi = N'" + et.DiaChi + "' where MaKH = '" + et.MaKH + "'"));
        }
        public void Xoa(KhachHang et)
        {
            cn.ThucHienLenh(@"DELETE FROM tblKhachHang where MaKH = '" + et.MaKH + "'");
        }
        public DataTable getGioiTinh()
        {

            return cn.GetDataTable(@"SELECT DISTINCT GT FROM tblKhachHang");
        }
    }
}
