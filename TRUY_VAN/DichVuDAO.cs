using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quan_Ly_Khach_San.TRUY_VAN;

namespace Quan_Ly_Khach_San
{
    public class DichVuDAO
    {
        private KetNoiData connect = new KetNoiData();

        public DataTable ThongTinDichVu(string MaDV)
        {
            DataTable tb = connect.GetDataTable("select * from tblDichVu where MaDV = '" + MaDV + "'");
            return tb;
        }

        public void ThemThongTin(DichVu DV)
        {
            connect.ThucHienLenh("insert into tblDichVu(MaDV,TenDV,Gia) values(N'" + DV.MaDV + "', N'" + DV.TenDV + "', '" + DV.Gia + "')");
        }

        public void SuaThongTin(DichVu DV)
        {
            connect.ThucHienLenh("update tblDichVu set TenDV = N'" + DV.TenDV + "', Gia = N'" + DV.Gia + "'  where MaDV = '" + DV.MaDV + "'");
        }

        public int XoaTTDichVu(DichVu DV)
        {
            return connect.ThucHienLenh("delete from tblDichVu where MaDV = '" + DV.MaDV + "'");
        }

        public DataTable GetAll()
        {
            return connect.GetDataTable(@"select * from tblDichVu");
        }

        public DataTable GetAll(string dk)
        {
            return connect.GetDataTable(@"select * from tblDichVu where " + dk);
        }

        public string GetGia(string MaDV)
        {
            return connect.GetValue("Select Gia from tblDichVu where MaDV = '" + MaDV +"'");
        }
    }
}
