using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_Khach_San.DATABASE;
using System.Data;
namespace Quan_Ly_Khach_San.TRUY_VAN
{
    public class ThietBi_F
    {
        private KetNoiData connect = new KetNoiData();

        public int ThemThongTin(ThietBi_ EC_ThietBi)
        {
            return connect.ThucHienLenh("insert into tblThietBi(MaPh, ThietBi, SoLuong, NhaSanXuat) values(N'" + EC_ThietBi.MaPh + "', N'" + EC_ThietBi.ThietBi + "', '" + EC_ThietBi.SoLuong + "', N'" + EC_ThietBi.NhaSanXuat + "') ");
        }

        public int SuaThongTin(ThietBi_ EC_ThietBi)
        {
            return connect.ThucHienLenh("update tblThietBi set SoLuong='" + EC_ThietBi.SoLuong + "',NhaSanXuat=N'" + EC_ThietBi.NhaSanXuat + "' where MaPh=N'" + EC_ThietBi.MaPh + "' and ThietBi=N'" + EC_ThietBi.ThietBi + "'");
        }

        public int XoaTTThietBi(ThietBi_ EC_ThietBi)
        {
            return connect.ThucHienLenh("delete from tblThietBi where MaPh=N'" + EC_ThietBi.MaPh + "' and ThietBi=N'" + EC_ThietBi.ThietBi + "'");

        }
        public DataTable TaoBang(string DieuKien)
        {
            return connect.GetDataTable(@"SELECT * FROM tblThietBi " + DieuKien);
        }
        public DataTable TruyVanRaMaPh(string DieuKien)
        {
            return connect.GetDataTable(@"SELECT MaPh from tblPhong " + DieuKien);
        }
    }
}
