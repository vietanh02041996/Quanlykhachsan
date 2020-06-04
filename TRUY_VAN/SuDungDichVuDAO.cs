using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Khach_San.TRUY_VAN;

namespace Quan_Ly_Khach_San
{
    public class SuDungDichVuDAO
    {
        private KetNoiData connect = new KetNoiData();


        public DataTable getDanhSach()
        {
            return connect.GetDataTable(@"select SoPhong, TenDV,ThoiGian, tblSuDungDV.Gia,tblHoaDon.MaHD from tblPhong,tblPhieuThue,tblHoaDon,tblSuDungDV,tblDichVu where tblPhong.MaPh = tblPhieuThue.MaPh and tblPhieuThue.MaPhieu = tblHoaDon.MaPhieuThue and tblHoaDon.MaHD = tblSuDungDV.MaHD and tblSuDungDV.MaDV = tblDichVu.MaDV order by SoPhong,ThoiGian");
        }
        public DataTable getDanhSach(string dk)
        {
            return connect.GetDataTable(@"select SoPhong, TenDV, ThoiGian,tblHoaDon.MaHD from tblPhong,tblPhieuThue,tblHoaDon,tblSuDungDV,tblDichVu where tblPhong.MaPh = tblPhieuThue.MaPh and tblPhieuThue.MaPhieu = tblHoaDon.MaPhieuThue and tblHoaDon.MaHD = tblSuDungDV.MaHD and tblSuDungDV.MaDV = tblDichVu.MaDV order by SoPhong");
        }

        public void addSuDung(SuDungDichVu SuDung)
        {
            connect.ThucHienLenh(@"insert into tblSuDungDV(MaHD,MaDV,ThoiGian,Gia) values('" + SuDung.MaHD + "','" + SuDung.MaDV + "','" + SuDung.ThoiGian + "', '" + SuDung.Gia + "')");
        }

        public void delSuDung(SuDungDichVu SuDung)
        {
            connect.ThucHienLenh(@"delete from tblSuDungDV where MaHD = '" + SuDung.MaHD + "' and MaDV = '" + SuDung.MaDV + "' and ThoiGian = '" + SuDung.ThoiGian + "'");
        }

        public DataTable getPhong()
        {
            return connect.GetDataTable(@"select * from tblPhong where TrangThai = N'Đã thuê'");
        }

        public DataTable getDV()
        {
            return connect.GetDataTable(@"select * from tblDichVu");
        }

        public string getMaHD(string MaPhong)
        {
            return connect.GetValue(@"select MaHD from tblHoaDon, tblPhieuThue, tblPhong where tblPhieuThue.MaPhieu = tblHoaDon.MaPhieuThue and tblPhieuThue.MaPh = tblPhong.MaPh and SoPhong = '" + MaPhong + "'" );
        }
    }
}
