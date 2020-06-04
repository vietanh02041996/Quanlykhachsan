using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Khach_San.DATABASE
{
    public class ThietBi_
    {
        private string _MaPh;

        public string MaPh
        {
            get { return _MaPh; }
            set { _MaPh = value; }
        }
        private string _ThietBi;

        public string ThietBi
        {
            get { return _ThietBi; }
            set { _ThietBi = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private string _NhaSanXuat;

        public string NhaSanXuat
        {
            get { return _NhaSanXuat; }
            set { _NhaSanXuat = value; }
        }
    }
}

